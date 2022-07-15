using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Operations;



namespace Clal_HW
{
    public class Actor
    {
        Operations.Functions operations = new Operations.Functions();
        WorkFlow workFlow = new WorkFlow();

        public bool Init()
        {
            try
            {
                string json = ReadJsonfile(@"C:\Users\חגית\source\repos\Clal_HW\workflow.txt");
                workFlow = GetWorkFlowFromJson(json);
                operations.Init();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public int StartFlow(int input)
        {
            bool activeFlow = true;
            Step nextStop = workFlow.Steps.FirstOrDefault();

            int output = EcxcuteOperation(nextStop.OperationName, input);

            while (activeFlow)
            {
                if (output < 10)
                {
                    if (nextStop.Id != nextStop.NextIdIfOutputIsLessThan)
                    {
                        nextStop = workFlow.Steps.Where(x => x.Id == nextStop.NextIdIfOutputIsLessThan).FirstOrDefault();
                    }

                    output = EcxcuteOperation(nextStop.OperationName, output);
                }
                else if (output >= 10)
                {
                    if (nextStop.Id != nextStop.NextIdIfOutputIsGreaterThan)
                    {
                        nextStop = workFlow.Steps.Where(x => x.Id == nextStop.NextIdIfOutputIsGreaterThan).FirstOrDefault();
                    }
                    output = EcxcuteOperation(nextStop.OperationName, output);
                }
                else if (output == 10)
                {
                    activeFlow = false;
                }
            }

            return 0;
        }
        private string ReadJsonfile(string path)
        {
            string json = string.Empty;
            try
            {
                using (StreamReader streamReader = new StreamReader(path, Encoding.UTF8))
                {
                    json = streamReader.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Logger.WriteInfo("Err", "ReadJsonfile", e.Message);
            }
            return json;
        }
        private WorkFlow GetWorkFlowFromJson(string json)
        {
            WorkFlow steps = new WorkFlow();
            try
            {
                JavaScriptSerializer oJS = new JavaScriptSerializer();
                steps = oJS.Deserialize<WorkFlow>(json);
            }
            catch (Exception e)
            {
                Logger.WriteInfo("Err", "GetStepsFromJson", e.Message);
            }

            return steps;
        }

        private int EcxcuteOperation(string ope, int input)
        {
            int output = 0;
            try
            {
                switch (ope)
                {
                    case "operation 1":
                        output = operations.PlusThree(input);
                        break;

                    case "operation 2":
                        output = operations.MultiplyByFive(input);
                        break;

                    case "operation 3":
                        output = operations.DivideByTwo(input);
                        break;

                    case "operation 4":

                        output = operations.InCaseofSevenInput(input);
                        break;


                    default:
                        break;

                }
            }
            catch (Exception e)
            {

                throw;
            }

            Logger.Write(input + "->" + output);
            return output;
        }

    }
}
