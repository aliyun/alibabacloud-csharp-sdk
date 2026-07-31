// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class RunSemanticJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The run information for this submission. A successful submission does not mean that the semantic model output has been generated. Use the detail operation to confirm the status before downloading results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RunSemanticJobResponseBodyData Data { get; set; }
        public class RunSemanticJobResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The current SQL fragment index returned by the executor in the submission response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CurrentSqlIndex")]
            [Validation(Required=false)]
            public int? CurrentSqlIndex { get; set; }

            /// <summary>
            /// <para>The runtime environment identifier returned by the executor in the submission response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROD</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>The list of execution type codes returned by the executor in the submission response.</para>
            /// </summary>
            [NameInMap("ExecTypes")]
            [Validation(Required=false)]
            public List<int?> ExecTypes { get; set; }

            /// <summary>
            /// <para>The executor job identifier. Pass this value to the ExecutorJobId parameter of GetSemanticJobDetail, GetSemanticJobLog, or KillSemanticJob.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exec-job-demo</para>
            /// </summary>
            [NameInMap("ExecutorJobId")]
            [Validation(Required=false)]
            public string ExecutorJobId { get; set; }

            /// <summary>
            /// <para>The unique identifier of this run. Pass this value to the JobRunId parameter of DownloadSemanticResults to obtain the output of this run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>01H00000000000000000000000</para>
            /// </summary>
            [NameInMap("JobRunId")]
            [Validation(Required=false)]
            public string JobRunId { get; set; }

            /// <summary>
            /// <para>The list of status codes returned by the executor in the submission response. The status at the submission stage does not indicate that the results are complete.</para>
            /// </summary>
            [NameInMap("Statuses")]
            [Validation(Required=false)]
            public List<int?> Statuses { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Used for locating logs and troubleshooting issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>676271D6-53B4-57BE-89FA-72F7AE1418DF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
