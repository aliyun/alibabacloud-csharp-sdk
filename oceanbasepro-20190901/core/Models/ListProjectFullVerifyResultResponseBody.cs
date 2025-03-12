// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ListProjectFullVerifyResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Contact the administrator.</para>
        /// </summary>
        [NameInMap("Advice")]
        [Validation(Required=false)]
        public string Advice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>INNER_ERROR</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Cost")]
        [Validation(Required=false)]
        public string Cost { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListProjectFullVerifyResultResponseBodyData Data { get; set; }
        public class ListProjectFullVerifyResultResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("DifferentNumber")]
            [Validation(Required=false)]
            public long? DifferentNumber { get; set; }

            [NameInMap("FullVerifyTableStatistics")]
            [Validation(Required=false)]
            public List<ListProjectFullVerifyResultResponseBodyDataFullVerifyTableStatistics> FullVerifyTableStatistics { get; set; }
            public class ListProjectFullVerifyResultResponseBodyDataFullVerifyTableStatistics : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("ConsistentCount")]
                [Validation(Required=false)]
                public long? ConsistentCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DestOnlyCount")]
                [Validation(Required=false)]
                public long? DestOnlyCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dest_db</para>
                /// </summary>
                [NameInMap("DestSchemaName")]
                [Validation(Required=false)]
                public string DestSchemaName { get; set; }

                [NameInMap("ErrorDetails")]
                [Validation(Required=false)]
                public List<ListProjectFullVerifyResultResponseBodyDataFullVerifyTableStatisticsErrorDetails> ErrorDetails { get; set; }
                public class ListProjectFullVerifyResultResponseBodyDataFullVerifyTableStatisticsErrorDetails : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CM-RESOAT1111</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("ExtraContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> ExtraContext { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ERROR</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    [NameInMap("MessageMcmsContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> MessageMcmsContext { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("MessageMcmsKey")]
                    [Validation(Required=false)]
                    public string MessageMcmsKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("Proposal")]
                    [Validation(Required=false)]
                    public string Proposal { get; set; }

                    [NameInMap("ProposalMcmsContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> ProposalMcmsContext { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("ProposalMcmsKey")]
                    [Validation(Required=false)]
                    public string ProposalMcmsKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    [NameInMap("ReasonMcmsContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> ReasonMcmsContext { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("ReasonMcmsKey")]
                    [Validation(Required=false)]
                    public string ReasonMcmsKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("UpstreamErrorDetail")]
                    [Validation(Required=false)]
                    public object UpstreamErrorDetail { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MismatchedCount")]
                [Validation(Required=false)]
                public long? MismatchedCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>desc</para>
                /// </summary>
                [NameInMap("ResultDesc")]
                [Validation(Required=false)]
                public string ResultDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("ResultType")]
                [Validation(Required=false)]
                public string ResultType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SourceOnlyCount")]
                [Validation(Required=false)]
                public long? SourceOnlyCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>source_db</para>
                /// </summary>
                [NameInMap("SourceSchemaName")]
                [Validation(Required=false)]
                public string SourceSchemaName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>source_table</para>
                /// </summary>
                [NameInMap("SourceTableName")]
                [Validation(Required=false)]
                public string SourceTableName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("ErrorDetail")]
        [Validation(Required=false)]
        public ListProjectFullVerifyResultResponseBodyErrorDetail ErrorDetail { get; set; }
        public class ListProjectFullVerifyResultResponseBodyErrorDetail : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>CM-RESOAT1111</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("ExtraContext")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtraContext { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ERROR</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>A system error occurred.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("MessageMcmsContext")]
            [Validation(Required=false)]
            public Dictionary<string, string> MessageMcmsContext { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("MessageMcmsKey")]
            [Validation(Required=false)]
            public string MessageMcmsKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Proposal")]
            [Validation(Required=false)]
            public string Proposal { get; set; }

            [NameInMap("ProposalMcmsContext")]
            [Validation(Required=false)]
            public Dictionary<string, string> ProposalMcmsContext { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ProposalMcmsKey")]
            [Validation(Required=false)]
            public string ProposalMcmsKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("ReasonMcmsContext")]
            [Validation(Required=false)]
            public Dictionary<string, string> ReasonMcmsContext { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ReasonMcmsKey")]
            [Validation(Required=false)]
            public string ReasonMcmsKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("UpstreamErrorDetail")]
            [Validation(Required=false)]
            public object UpstreamErrorDetail { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A system error occurred.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
