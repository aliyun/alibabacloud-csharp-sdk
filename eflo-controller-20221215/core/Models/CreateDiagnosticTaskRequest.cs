// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class CreateDiagnosticTaskRequest : TeaModel {
        /// <summary>
        /// <para>The log information.</para>
        /// </summary>
        [NameInMap("AiJobLogInfo")]
        [Validation(Required=false)]
        public CreateDiagnosticTaskRequestAiJobLogInfo AiJobLogInfo { get; set; }
        public class CreateDiagnosticTaskRequestAiJobLogInfo : TeaModel {
            /// <summary>
            /// <para>The task logs.</para>
            /// </summary>
            [NameInMap("AiJobLogs")]
            [Validation(Required=false)]
            public List<CreateDiagnosticTaskRequestAiJobLogInfoAiJobLogs> AiJobLogs { get; set; }
            public class CreateDiagnosticTaskRequestAiJobLogInfoAiJobLogs : TeaModel {
                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("AiInstance")]
                [Validation(Required=false)]
                public string AiInstance { get; set; }

                /// <summary>
                /// <para>The logs.</para>
                /// </summary>
                [NameInMap("Logs")]
                [Validation(Required=false)]
                public List<CreateDiagnosticTaskRequestAiJobLogInfoAiJobLogsLogs> Logs { get; set; }
                public class CreateDiagnosticTaskRequestAiJobLogInfoAiJobLogsLogs : TeaModel {
                    /// <summary>
                    /// <para>The sending date in the yyyymmdd format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-08-05T10:10:01</para>
                    /// </summary>
                    [NameInMap("Datetime")]
                    [Validation(Required=false)]
                    public string Datetime { get; set; }

                    /// <summary>
                    /// <para>The log content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>success</para>
                    /// </summary>
                    [NameInMap("LogContent")]
                    [Validation(Required=false)]
                    public string LogContent { get; set; }

                }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e01-tw-p2p2al5u1hn</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

            }

            /// <summary>
            /// <para>The end time. The value is in the timestamp format. Unit: seconds.</para>
            /// <remarks>
            /// <para> This timestamp must indicate a point in time that is accurate to the minute.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2024-08-05T10:10:01</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The start time. The value is in the timestamp format. Unit: seconds.</para>
            /// <remarks>
            /// <para> This timestamp must indicate a point in time that is accurate to the minute.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-11T00:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i118913031696573280136</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The diagnostics type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CheckByAiJobLogs</para>
        /// </summary>
        [NameInMap("DiagnosticType")]
        [Validation(Required=false)]
        public string DiagnosticType { get; set; }

        /// <summary>
        /// <para>The IDs of the nodes.</para>
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public List<string> NodeIds { get; set; }

    }

}
