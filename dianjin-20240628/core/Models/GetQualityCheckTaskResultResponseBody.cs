// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetQualityCheckTaskResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetQualityCheckTaskResultResponseBodyData Data { get; set; }
        public class GetQualityCheckTaskResultResponseBodyData : TeaModel {
            [NameInMap("conversationList")]
            [Validation(Required=false)]
            public GetQualityCheckTaskResultResponseBodyDataConversationList ConversationList { get; set; }
            public class GetQualityCheckTaskResultResponseBodyDataConversationList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("callType")]
                [Validation(Required=false)]
                public string CallType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>234234</para>
                /// </summary>
                [NameInMap("customerId")]
                [Validation(Required=false)]
                public string CustomerId { get; set; }

                [NameInMap("customerName")]
                [Validation(Required=false)]
                public string CustomerName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23984763826</para>
                /// </summary>
                [NameInMap("customerServiceId")]
                [Validation(Required=false)]
                public string CustomerServiceId { get; set; }

                [NameInMap("customerServiceName")]
                [Validation(Required=false)]
                public string CustomerServiceName { get; set; }

                [NameInMap("dialogueList")]
                [Validation(Required=false)]
                public List<GetQualityCheckTaskResultResponseBodyDataConversationListDialogueList> DialogueList { get; set; }
                public class GetQualityCheckTaskResultResponseBodyDataConversationListDialogueList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("begin")]
                    [Validation(Required=false)]
                    public int? Begin { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-09-27 11:23:20</para>
                    /// </summary>
                    [NameInMap("beginTime")]
                    [Validation(Required=false)]
                    public string BeginTime { get; set; }

                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("customerId")]
                    [Validation(Required=false)]
                    public string CustomerId { get; set; }

                    [NameInMap("customerServiceId")]
                    [Validation(Required=false)]
                    public string CustomerServiceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("customerServiceType")]
                    [Validation(Required=false)]
                    public string CustomerServiceType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("end")]
                    [Validation(Required=false)]
                    public int? End { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public int? Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>TEXT</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-09-27 11:23:20</para>
                /// </summary>
                [NameInMap("gmtService")]
                [Validation(Required=false)]
                public string GmtService { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-09-27 11:23:20</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-09-27 11:23:20</para>
            /// </summary>
            [NameInMap("gmtEnd")]
            [Validation(Required=false)]
            public string GmtEnd { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-09-27 11:23:20</para>
            /// </summary>
            [NameInMap("gmtStart")]
            [Validation(Required=false)]
            public string GmtStart { get; set; }

            [NameInMap("qualityCheckList")]
            [Validation(Required=false)]
            public List<GetQualityCheckTaskResultResponseBodyDataQualityCheckList> QualityCheckList { get; set; }
            public class GetQualityCheckTaskResultResponseBodyDataQualityCheckList : TeaModel {
                [NameInMap("bizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                [NameInMap("checkExplanation")]
                [Validation(Required=false)]
                public string CheckExplanation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PASSED</para>
                /// </summary>
                [NameInMap("checkPassed")]
                [Validation(Required=false)]
                public string CheckPassed { get; set; }

                [NameInMap("checkProcess")]
                [Validation(Required=false)]
                public string CheckProcess { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HIT</para>
                /// </summary>
                [NameInMap("checked")]
                [Validation(Required=false)]
                public string Checked { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-05-23 14:57:50</para>
                /// </summary>
                [NameInMap("gmtEnd")]
                [Validation(Required=false)]
                public string GmtEnd { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-05-23 14:57:50</para>
                /// </summary>
                [NameInMap("gmtStart")]
                [Validation(Required=false)]
                public string GmtStart { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                [NameInMap("originDialogue")]
                [Validation(Required=false)]
                public List<GetQualityCheckTaskResultResponseBodyDataQualityCheckListOriginDialogue> OriginDialogue { get; set; }
                public class GetQualityCheckTaskResultResponseBodyDataQualityCheckListOriginDialogue : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("begin")]
                    [Validation(Required=false)]
                    public int? Begin { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-05-23 14:57:50</para>
                    /// </summary>
                    [NameInMap("beginTime")]
                    [Validation(Required=false)]
                    public string BeginTime { get; set; }

                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("customerId")]
                    [Validation(Required=false)]
                    public string CustomerId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>23876432</para>
                    /// </summary>
                    [NameInMap("customerServiceId")]
                    [Validation(Required=false)]
                    public string CustomerServiceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("customerServiceType")]
                    [Validation(Required=false)]
                    public string CustomerServiceType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("end")]
                    [Validation(Required=false)]
                    public int? End { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public int? Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>TEXT</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>warning_customers</para>
                /// </summary>
                [NameInMap("qualityGroupId")]
                [Validation(Required=false)]
                public string QualityGroupId { get; set; }

                [NameInMap("ruleDescription")]
                [Validation(Required=false)]
                public string RuleDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>wcm_start</para>
                /// </summary>
                [NameInMap("ruleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                [NameInMap("ruleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>INIT</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1703557101831</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>67C7021A-D268-553D-8C15-A087B9604028</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
