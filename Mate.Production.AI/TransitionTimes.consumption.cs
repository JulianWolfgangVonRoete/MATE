﻿// This file was auto-generated by ML.NET Model Builder. 
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace Mate_Production_AI
{
    public partial class TransitionTimes
    {
        /// <summary>
        /// model input class for TransitionTimes.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [ColumnName(@"ThroughputTime")]
            public float ThroughputTime { get; set; }

            [ColumnName(@"TotalProcessingDuration")]
            public float TotalProcessingDuration { get; set; }

            [ColumnName(@"LongestPathProcessingDuration")]
            public float LongestPathProcessingDuration { get; set; }

            [ColumnName(@"TimeToRelease")]
            public float TimeToRelease { get; set; }

            [ColumnName(@"TimeBeforeFinish")]
            public float TimeBeforeFinish { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for TransitionTimes.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            public float Score { get; set; }
        }
        #endregion

        private static string MLNetModelPath = Path.GetFullPath("TransitionTimes.zip");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }
    }
}
