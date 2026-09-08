// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListWaitingChatsResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListWaitingChatsResponseBodyData> Data { get; set; }
        public class ListWaitingChatsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Access channel ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>843073c2-*****-49fb-a616-738ddddfebdc</para>
            /// </summary>
            [NameInMap("AccessChannelId")]
            [Validation(Required=false)]
            public string AccessChannelId { get; set; }

            /// <summary>
            /// <para>Access channel type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Web</para>
            /// </summary>
            [NameInMap("AccessChannelType")]
            [Validation(Required=false)]
            public string AccessChannelType { get; set; }

            /// <summary>
            /// <para>Indicates whether the session has been assigned to an agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("BeingAssigned")]
            [Validation(Required=false)]
            public bool? BeingAssigned { get; set; }

            /// <summary>
            /// <para>Chat session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>$23086709$EAUNIT</para>
            /// </summary>
            [NameInMap("ChatConversationId")]
            [Validation(Required=false)]
            public string ChatConversationId { get; set; }

            /// <summary>
            /// <para>Enqueue time, in Unix timestamp format, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1718868572094</para>
            /// </summary>
            [NameInMap("EnqueueTime")]
            [Validation(Required=false)]
            public long? EnqueueTime { get; set; }

            /// <summary>
            /// <para>Job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chat-434537064047960064</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>Message list.</para>
            /// </summary>
            [NameInMap("Messages")]
            [Validation(Required=false)]
            public List<ListWaitingChatsResponseBodyDataMessages> Messages { get; set; }
            public class ListWaitingChatsResponseBodyDataMessages : TeaModel {
                /// <summary>
                /// <para>Message content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试消息</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>Message sender ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c361765f-******-4e07-b81c-4b5d9183fac6</para>
                /// </summary>
                [NameInMap("SenderId")]
                [Validation(Required=false)]
                public string SenderId { get; set; }

                /// <summary>
                /// <para>Sender type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>CUSTOMER</b>: visitor</para>
                /// </description></item>
                /// <item><description><para><b>AGENT</b>: agent</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;variables&quot;:{},&quot;text&quot;:&quot;<para>这种的名片选单面还是双面</para>&quot;}</para>
                /// </summary>
                [NameInMap("SenderType")]
                [Validation(Required=false)]
                public string SenderType { get; set; }

            }

            /// <summary>
            /// <para>The skill group information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>skill@ccc-test</para>
            /// </summary>
            [NameInMap("SkillGroupId")]
            [Validation(Required=false)]
            public string SkillGroupId { get; set; }

            /// <summary>
            /// <para>User list.</para>
            /// </summary>
            [NameInMap("UserList")]
            [Validation(Required=false)]
            public List<ListWaitingChatsResponseBodyDataUserList> UserList { get; set; }
            public class ListWaitingChatsResponseBodyDataUserList : TeaModel {
                /// <summary>
                /// <para>Profile picture URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("AvatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                /// <summary>
                /// <para>User ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c361765f-******-4e07-b81c-4b5d9183fac6</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>User name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>访客-1c***</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                /// <summary>
                /// <para>User type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CUSTOMER</para>
                /// </summary>
                [NameInMap("UserType")]
                [Validation(Required=false)]
                public string UserType { get; set; }

            }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>03C67DAD-EB26-41D8-949D-9B0C470FB716</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
