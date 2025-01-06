// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class CreateDiagnosticTaskRequest : TeaModel {
        /// <summary>
        /// <para>Log information</para>
        /// </summary>
        [NameInMap("AiJobLogInfo")]
        [Validation(Required=false)]
        public CreateDiagnosticTaskRequestAiJobLogInfo AiJobLogInfo { get; set; }
        public class CreateDiagnosticTaskRequestAiJobLogInfo : TeaModel {
            /// <summary>
            /// <para>Task logs</para>
            /// </summary>
            [NameInMap("AiJobLogs")]
            [Validation(Required=false)]
            public List<CreateDiagnosticTaskRequestAiJobLogInfoAiJobLogs> AiJobLogs { get; set; }
            public class CreateDiagnosticTaskRequestAiJobLogInfoAiJobLogs : TeaModel {
                /// <summary>
                /// <para>Instance ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("AiInstance")]
                [Validation(Required=false)]
                public string AiInstance { get; set; }

                /// <summary>
                /// <para>Log object</para>
                /// </summary>
                [NameInMap("Logs")]
                [Validation(Required=false)]
                public List<CreateDiagnosticTaskRequestAiJobLogInfoAiJobLogsLogs> Logs { get; set; }
                public class CreateDiagnosticTaskRequestAiJobLogInfoAiJobLogsLogs : TeaModel {
                    /// <summary>
                    /// <para>Sent date, in the format yyyymmdd.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-08-05T10:10:01</para>
                    /// </summary>
                    [NameInMap("Datetime")]
                    [Validation(Required=false)]
                    public string Datetime { get; set; }

                    /// <summary>
                    /// <para>Log content</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>success</para>
                    /// </summary>
                    [NameInMap("LogContent")]
                    [Validation(Required=false)]
                    public string LogContent { get; set; }

                }

                /// <summary>
                /// <para>Node ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>e01-tw-p2p2al5u1hn</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

            }

            /// <summary>
            /// <para>End time. In timestamp format, unit: seconds.</para>
            /// <remarks>
            /// <para>Must be on the hour or half-hour mark.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2024-08-05T10:10:01</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>Start time. In timestamp format, unit: seconds.</para>
            /// <remarks>
            /// <para>Must be on the hour or half-hour mark.</para>
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
        /// <para>Cluster ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>i118913031696573280136</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Diagnostic type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CheckByAiJobLogs</para>
        /// </summary>
        [NameInMap("DiagnosticType")]
        [Validation(Required=false)]
        public string DiagnosticType { get; set; }

        /// <summary>
        /// <para>List of node IDs</para>
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public List<string> NodeIds { get; set; }

    }

}
