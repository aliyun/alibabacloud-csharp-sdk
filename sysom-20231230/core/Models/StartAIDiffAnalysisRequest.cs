// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class StartAIDiffAnalysisRequest : TeaModel {
        /// <summary>
        /// <para>The task1 parameters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task1参数</para>
        /// </summary>
        [NameInMap("task1")]
        [Validation(Required=false)]
        public StartAIDiffAnalysisRequestTask1 Task1 { get; set; }
        public class StartAIDiffAnalysisRequestTask1 : TeaModel {
            /// <summary>
            /// <para>The AI analysis ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16896fa8-37f6-4c70-bb32-67fa9817d426</para>
            /// </summary>
            [NameInMap("analysisId")]
            [Validation(Required=false)]
            public string AnalysisId { get; set; }

            /// <summary>
            /// <para>The pids of AI job processes. Batch input is supported. Separate multiple pids with commas.</para>
            /// </summary>
            [NameInMap("pids")]
            [Validation(Required=false)]
            public List<string> Pids { get; set; }

            /// <summary>
            /// <para>The step end time, calculated based on the selected step number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4660551334179.955</para>
            /// </summary>
            [NameInMap("step_end")]
            [Validation(Required=false)]
            public float? StepEnd { get; set; }

            /// <summary>
            /// <para>The step start time, calculated based on the selected step number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4660550379415.497</para>
            /// </summary>
            [NameInMap("step_start")]
            [Validation(Required=false)]
            public float? StepStart { get; set; }

        }

        /// <summary>
        /// <para>The task2 parameters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task2参数，目前只支持相同analysisId和pid的对比</para>
        /// </summary>
        [NameInMap("task2")]
        [Validation(Required=false)]
        public StartAIDiffAnalysisRequestTask2 Task2 { get; set; }
        public class StartAIDiffAnalysisRequestTask2 : TeaModel {
            /// <summary>
            /// <para>The AI analysis ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16896fa8-37f6-4c70-bb32-67fa9817d426</para>
            /// </summary>
            [NameInMap("analysisId")]
            [Validation(Required=false)]
            public string AnalysisId { get; set; }

            /// <summary>
            /// <para>The pids of AI job processes. Batch input is supported. Separate multiple pids with commas.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>452651:python3 ./test.py</para>
            /// </summary>
            [NameInMap("pids")]
            [Validation(Required=false)]
            public List<string> Pids { get; set; }

            /// <summary>
            /// <para>The step end time, calculated based on the selected step number.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4660551334179.955</para>
            /// </summary>
            [NameInMap("step_end")]
            [Validation(Required=false)]
            public float? StepEnd { get; set; }

            /// <summary>
            /// <para>The step start time, calculated based on the selected step number.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4660550379415.497</para>
            /// </summary>
            [NameInMap("step_start")]
            [Validation(Required=false)]
            public float? StepStart { get; set; }

        }

    }

}
