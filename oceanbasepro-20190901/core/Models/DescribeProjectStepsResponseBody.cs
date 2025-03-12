// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeProjectStepsResponseBody : TeaModel {
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
        public List<DescribeProjectStepsResponseBodyData> Data { get; set; }
        public class DescribeProjectStepsResponseBodyData : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public DescribeProjectStepsResponseBodyDataExtraInfo ExtraInfo { get; set; }
            public class DescribeProjectStepsResponseBodyDataExtraInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>INNER_ERROR</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("ErrorDetails")]
                [Validation(Required=false)]
                public List<DescribeProjectStepsResponseBodyDataExtraInfoErrorDetails> ErrorDetails { get; set; }
                public class DescribeProjectStepsResponseBodyDataExtraInfoErrorDetails : TeaModel {
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
                /// <para>The ResourceDirectoryId is invalid.</para>
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                [NameInMap("ErrorParam")]
                [Validation(Required=false)]
                public Dictionary<string, string> ErrorParam { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("FailedTime")]
                [Validation(Required=false)]
                public string FailedTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-05-22T17:04:18</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PRE_CHECK</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-05-22T17:04:18</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("StepInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> StepInfo { get; set; }

        }

        [NameInMap("ErrorDetail")]
        [Validation(Required=false)]
        public DescribeProjectStepsResponseBodyErrorDetail ErrorDetail { get; set; }
        public class DescribeProjectStepsResponseBodyErrorDetail : TeaModel {
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
            /// <para>Contact the administrator.</para>
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
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
