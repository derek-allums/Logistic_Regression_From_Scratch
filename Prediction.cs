using System;

namespace Logistic_Regression_From_Scratch
{
    public class Prediction
    {
        // TODO: build out. Idea is make single prediction from row and model (another row)
        public Prediction() {}

        public static  decimal makePrediction()
        {
            return 0m;
        }

        public static double logLoss(double prediction, double actual)
        {
            double firstSummand = -(actual * Math.Log(prediction));
            double secondSummand = (1 - actual) * (Math.Log(1 - prediction));
            double logLossValue = firstSummand + secondSummand;
            return logLossValue;
        }
    }
}