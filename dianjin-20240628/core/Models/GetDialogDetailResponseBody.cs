// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetDialogDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Processing time in milliseconds</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        /// <summary>
        /// <para>Response data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDialogDetailResponseBodyData Data { get; set; }
        public class GetDialogDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>List of dialogue details</para>
            /// </summary>
            [NameInMap("dialogueList")]
            [Validation(Required=false)]
            public List<GetDialogDetailResponseBodyDataDialogueList> DialogueList { get; set; }
            public class GetDialogDetailResponseBodyDataDialogueList : TeaModel {
                /// <summary>
                /// <para>Dialogue content</para>
                /// 
                /// <b>Example:</b>
                /// <para>请问具体怎么操作呢？</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>Customer ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>123761283</para>
                /// </summary>
                [NameInMap("customerId")]
                [Validation(Required=false)]
                public string CustomerId { get; set; }

                /// <summary>
                /// <para>Agent ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>BOT</para>
                /// </summary>
                [NameInMap("customerServiceId")]
                [Validation(Required=false)]
                public string CustomerServiceId { get; set; }

                /// <summary>
                /// <para>Agent type:</para>
                /// <list type="bullet">
                /// <item><description><para>0: Bot</para>
                /// </description></item>
                /// <item><description><para>1: Human</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("customerServiceType")]
                [Validation(Required=false)]
                public string CustomerServiceType { get; set; }

                /// <summary>
                /// <para>Indicates whether the session ended with this message</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("hangUpDialog")]
                [Validation(Required=false)]
                public bool? HangUpDialog { get; set; }

                /// <summary>
                /// <para>Unique identifier for this message. Assigned internally. May be empty. Use recordId instead.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1742869659849</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Intent code</para>
                /// 
                /// <b>Example:</b>
                /// <para>193874634xxx</para>
                /// </summary>
                [NameInMap("intentCode")]
                [Validation(Required=false)]
                public string IntentCode { get; set; }

                /// <summary>
                /// <para>Intent name</para>
                /// 
                /// <b>Example:</b>
                /// <para>客户询问如何操作</para>
                /// </summary>
                [NameInMap("intentName")]
                [Validation(Required=false)]
                public string IntentName { get; set; }

                /// <summary>
                /// <para>Unique identifier for this message. Assigned internally. String type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>19387872364736xdhcb</para>
                /// </summary>
                [NameInMap("recordId")]
                [Validation(Required=false)]
                public string RecordId { get; set; }

                /// <summary>
                /// <para>Role:</para>
                /// <list type="bullet">
                /// <item><description><para>0: Customer</para>
                /// </description></item>
                /// <item><description><para>1: Agent</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>Content type: text, audio, or image. Only text is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Session time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-09-27 11:23:20</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>Session status</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Total conversation rounds. Each round counts one exchange between AI and the customer. Multiple consecutive messages from either side count as one round. If the last message is from the AI and is not a hang-up, subtract one from the total round count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("totalDialogTurns")]
            [Validation(Required=false)]
            public int? TotalDialogTurns { get; set; }

            /// <summary>
            /// <para>Valid conversation rounds. Each valid round counts one question-and-answer pair between AI and the customer. This differs from the total round count method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("validDialogTurns")]
            [Validation(Required=false)]
            public int? ValidDialogTurns { get; set; }

        }

        /// <summary>
        /// <para>Data type</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>Error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>Error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>5E3FBAF1-17AF-53B7-AF0A-CDCEEB6DE658</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation succeeded</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Timestamp</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-04-24 11:54:34</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
