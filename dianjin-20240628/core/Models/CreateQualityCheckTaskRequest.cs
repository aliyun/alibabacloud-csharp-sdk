// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class CreateQualityCheckTaskRequest : TeaModel {
        /// <summary>
        /// <para>The conversation content. If associated with a quality check scenario, pass multiple conversations. Otherwise, pass only one.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("conversationList")]
        [Validation(Required=false)]
        public CreateQualityCheckTaskRequestConversationList ConversationList { get; set; }
        public class CreateQualityCheckTaskRequestConversationList : TeaModel {
            /// <summary>
            /// <para>Call type:</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("callType")]
            [Validation(Required=false)]
            public string CallType { get; set; }

            /// <summary>
            /// <para>The Customer ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("customerId")]
            [Validation(Required=false)]
            public string CustomerId { get; set; }

            /// <summary>
            /// <para>The customer name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("customerName")]
            [Validation(Required=false)]
            public string CustomerName { get; set; }

            /// <summary>
            /// <para>The customer service ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("customerServiceId")]
            [Validation(Required=false)]
            public string CustomerServiceId { get; set; }

            /// <summary>
            /// <para>The customer service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>李四</para>
            /// </summary>
            [NameInMap("customerServiceName")]
            [Validation(Required=false)]
            public string CustomerServiceName { get; set; }

            /// <summary>
            /// <para>The list of dialogue details.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("dialogueList")]
            [Validation(Required=false)]
            public List<CreateQualityCheckTaskRequestConversationListDialogueList> DialogueList { get; set; }
            public class CreateQualityCheckTaskRequestConversationListDialogueList : TeaModel {
                /// <summary>
                /// <para>The start time of this sentence. This is the offset time in milliseconds from the start of the conversation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("begin")]
                [Validation(Required=false)]
                public int? Begin { get; set; }

                /// <summary>
                /// <para>The start time of this sentence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-05-23 14:57:50</para>
                /// </summary>
                [NameInMap("beginTime")]
                [Validation(Required=false)]
                public string BeginTime { get; set; }

                /// <summary>
                /// <para>The specific content of the dialogue.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>您好，我是2001，很高兴为您服务！</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The unique identifier of the dialogue role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2348234</para>
                /// </summary>
                [NameInMap("customerId")]
                [Validation(Required=false)]
                public string CustomerId { get; set; }

                /// <summary>
                /// <para>The customer service ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23874627346</para>
                /// </summary>
                [NameInMap("customerServiceId")]
                [Validation(Required=false)]
                public string CustomerServiceId { get; set; }

                /// <summary>
                /// <para>Agent type:</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("customerServiceType")]
                [Validation(Required=false)]
                public string CustomerServiceType { get; set; }

                /// <summary>
                /// <para>The end time of this sentence. This is the offset time in milliseconds from the start of the conversation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("end")]
                [Validation(Required=false)]
                public int? End { get; set; }

                /// <summary>
                /// <para>Role:</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>Dialogue content type:</para>
                /// <para>This parameter is required.</para>
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
        /// <para>The business occurrence time. The system uses this to record submission time, make task scheduling priority decisions, and so on.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-09-27 11:23:20</para>
        /// </summary>
        [NameInMap("gmtService")]
        [Validation(Required=false)]
        public string GmtService { get; set; }

        /// <summary>
        /// <para>The metadata. These are properties related to business that rules consume during execution. The business system passes these in real-time when initiating a quality check.</para>
        /// </summary>
        [NameInMap("metaData")]
        [Validation(Required=false)]
        public Dictionary<string, string> MetaData { get; set; }

        /// <summary>
        /// <para>The quality check rule group.</para>
        /// </summary>
        [NameInMap("qualityGroup")]
        [Validation(Required=false)]
        public List<string> QualityGroup { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FC6636E-380A-5369-AE01-D1C15BB9B254</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The scenario code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>o9c8u8</para>
        /// </summary>
        [NameInMap("sceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// <para>Quality check type:</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
