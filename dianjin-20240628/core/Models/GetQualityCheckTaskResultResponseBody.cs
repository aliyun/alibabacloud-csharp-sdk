// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetQualityCheckTaskResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetQualityCheckTaskResultResponseBodyData Data { get; set; }
        public class GetQualityCheckTaskResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The original conversation content.</para>
            /// </summary>
            [NameInMap("conversationList")]
            [Validation(Required=false)]
            public GetQualityCheckTaskResultResponseBodyDataConversationList ConversationList { get; set; }
            public class GetQualityCheckTaskResultResponseBodyDataConversationList : TeaModel {
                /// <summary>
                /// <para>The call type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("callType")]
                [Validation(Required=false)]
                public string CallType { get; set; }

                /// <summary>
                /// <para>The customer ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>234234</para>
                /// </summary>
                [NameInMap("customerId")]
                [Validation(Required=false)]
                public string CustomerId { get; set; }

                /// <summary>
                /// <para>The customer name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhang San</para>
                /// </summary>
                [NameInMap("customerName")]
                [Validation(Required=false)]
                public string CustomerName { get; set; }

                /// <summary>
                /// <para>The customer service ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23984763826</para>
                /// </summary>
                [NameInMap("customerServiceId")]
                [Validation(Required=false)]
                public string CustomerServiceId { get; set; }

                /// <summary>
                /// <para>The customer service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Li Si</para>
                /// </summary>
                [NameInMap("customerServiceName")]
                [Validation(Required=false)]
                public string CustomerServiceName { get; set; }

                /// <summary>
                /// <para>The list of dialogue details.</para>
                /// </summary>
                [NameInMap("dialogueList")]
                [Validation(Required=false)]
                public List<GetQualityCheckTaskResultResponseBodyDataConversationListDialogueList> DialogueList { get; set; }
                public class GetQualityCheckTaskResultResponseBodyDataConversationListDialogueList : TeaModel {
                    /// <summary>
                    /// <para>The start time of the utterance, as an offset in milliseconds from the start of the conversation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("begin")]
                    [Validation(Required=false)]
                    public int? Begin { get; set; }

                    /// <summary>
                    /// <para>The start time of the utterance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-09-27 11:23:20</para>
                    /// </summary>
                    [NameInMap("beginTime")]
                    [Validation(Required=false)]
                    public string BeginTime { get; set; }

                    /// <summary>
                    /// <para>The specific content of the dialogue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Hello, this is 2001. How may I help you?</para>
                    /// </summary>
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The unique identifier of the dialogue role.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("customerId")]
                    [Validation(Required=false)]
                    public string CustomerId { get; set; }

                    /// <summary>
                    /// <para>The customer service ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Li Si</para>
                    /// </summary>
                    [NameInMap("customerServiceId")]
                    [Validation(Required=false)]
                    public string CustomerServiceId { get; set; }

                    /// <summary>
                    /// <para>The agent type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("customerServiceType")]
                    [Validation(Required=false)]
                    public string CustomerServiceType { get; set; }

                    /// <summary>
                    /// <para>The end time of the utterance, as an offset in milliseconds from the start of the conversation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("end")]
                    [Validation(Required=false)]
                    public int? End { get; set; }

                    /// <summary>
                    /// <para>The unique identifier of the utterance. This value is assigned internally.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public int? Id { get; set; }

                    /// <summary>
                    /// <para>The role.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                    /// <summary>
                    /// <para>The type of the dialogue content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TEXT</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The conversation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-09-27 11:23:20</para>
                /// </summary>
                [NameInMap("gmtService")]
                [Validation(Required=false)]
                public string GmtService { get; set; }

            }

            /// <summary>
            /// <para>The time when the task was created and submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-09-27 11:23:20</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the system finished execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-09-27 11:23:20</para>
            /// </summary>
            [NameInMap("gmtEnd")]
            [Validation(Required=false)]
            public string GmtEnd { get; set; }

            /// <summary>
            /// <para>The time when the system started execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-09-27 11:23:20</para>
            /// </summary>
            [NameInMap("gmtStart")]
            [Validation(Required=false)]
            public string GmtStart { get; set; }

            /// <summary>
            /// <para>The quality check results.</para>
            /// </summary>
            [NameInMap("qualityCheckList")]
            [Validation(Required=false)]
            public List<GetQualityCheckTaskResultResponseBodyDataQualityCheckList> QualityCheckList { get; set; }
            public class GetQualityCheckTaskResultResponseBodyDataQualityCheckList : TeaModel {
                /// <summary>
                /// <para>The business type of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>No</para>
                /// </summary>
                [NameInMap("bizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// <para>The explanation for why the check passed or failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("checkExplanation")]
                [Validation(Required=false)]
                public string CheckExplanation { get; set; }

                /// <summary>
                /// <para>Indicates whether the quality check passed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PASSED</para>
                /// </summary>
                [NameInMap("checkPassed")]
                [Validation(Required=false)]
                public string CheckPassed { get; set; }

                /// <summary>
                /// <para>The description of the quality check process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("checkProcess")]
                [Validation(Required=false)]
                public string CheckProcess { get; set; }

                /// <summary>
                /// <para>Indicates whether the rule was hit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HIT</para>
                /// </summary>
                [NameInMap("checked")]
                [Validation(Required=false)]
                public string Checked { get; set; }

                /// <summary>
                /// <para>The quality check completion time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-05-23 14:57:50</para>
                /// </summary>
                [NameInMap("gmtEnd")]
                [Validation(Required=false)]
                public string GmtEnd { get; set; }

                /// <summary>
                /// <para>The quality check start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-05-23 14:57:50</para>
                /// </summary>
                [NameInMap("gmtStart")]
                [Validation(Required=false)]
                public string GmtStart { get; set; }

                /// <summary>
                /// <para>The internal quality check mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The original dialogue list.</para>
                /// </summary>
                [NameInMap("originDialogue")]
                [Validation(Required=false)]
                public List<GetQualityCheckTaskResultResponseBodyDataQualityCheckListOriginDialogue> OriginDialogue { get; set; }
                public class GetQualityCheckTaskResultResponseBodyDataQualityCheckListOriginDialogue : TeaModel {
                    /// <summary>
                    /// <para>The start time of the utterance, as an offset in milliseconds from the start of the conversation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("begin")]
                    [Validation(Required=false)]
                    public int? Begin { get; set; }

                    /// <summary>
                    /// <para>The start time of the utterance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-05-23 14:57:50</para>
                    /// </summary>
                    [NameInMap("beginTime")]
                    [Validation(Required=false)]
                    public string BeginTime { get; set; }

                    /// <summary>
                    /// <para>The specific content of the dialogue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Hello, this is 2001. How may I help you?</para>
                    /// </summary>
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The unique identifier of the dialogue role.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("customerId")]
                    [Validation(Required=false)]
                    public string CustomerId { get; set; }

                    /// <summary>
                    /// <para>The customer service ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>23876432</para>
                    /// </summary>
                    [NameInMap("customerServiceId")]
                    [Validation(Required=false)]
                    public string CustomerServiceId { get; set; }

                    /// <summary>
                    /// <para>The agent type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("customerServiceType")]
                    [Validation(Required=false)]
                    public string CustomerServiceType { get; set; }

                    /// <summary>
                    /// <para>The end time of the utterance, as an offset in milliseconds from the start of the conversation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("end")]
                    [Validation(Required=false)]
                    public int? End { get; set; }

                    /// <summary>
                    /// <para>The unique identifier of the sentence, which is assigned internally.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public int? Id { get; set; }

                    /// <summary>
                    /// <para>The role.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                    /// <summary>
                    /// <para>The type of the dialogue content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TEXT</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The quality check group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>warning_customers</para>
                /// </summary>
                [NameInMap("qualityGroupId")]
                [Validation(Required=false)]
                public string QualityGroupId { get; set; }

                /// <summary>
                /// <para>The quality check item description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enter the early-warning customer detection process</para>
                /// </summary>
                [NameInMap("ruleDescription")]
                [Validation(Required=false)]
                public string RuleDescription { get; set; }

                /// <summary>
                /// <para>The quality check item ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>wcm_start</para>
                /// </summary>
                [NameInMap("ruleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>The polarity type of the rule. Valid values: 0: negative. 1: positive.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ruleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

                /// <summary>
                /// <para>The child node.</para>
                /// </summary>
                [NameInMap("subNodeCol")]
                [Validation(Required=false)]
                public List<object> SubNodeCol { get; set; }

            }

            /// <summary>
            /// <para>The task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INIT</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1703557101831</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The data type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67C7021A-D268-553D-8C15-A087B9604028</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
