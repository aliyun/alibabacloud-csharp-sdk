// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListWaitingChatsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListWaitingChatsResponseBodyData> Data { get; set; }
        public class ListWaitingChatsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>843073c2-*****-49fb-a616-738ddddfebdc</para>
            /// </summary>
            [NameInMap("AccessChannelId")]
            [Validation(Required=false)]
            public string AccessChannelId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Web</para>
            /// </summary>
            [NameInMap("AccessChannelType")]
            [Validation(Required=false)]
            public string AccessChannelType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("BeingAssigned")]
            [Validation(Required=false)]
            public bool? BeingAssigned { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>$23086709$EAUNIT</para>
            /// </summary>
            [NameInMap("ChatConversationId")]
            [Validation(Required=false)]
            public string ChatConversationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1718868572094</para>
            /// </summary>
            [NameInMap("EnqueueTime")]
            [Validation(Required=false)]
            public long? EnqueueTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>chat-434537064047960064</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("Messages")]
            [Validation(Required=false)]
            public List<ListWaitingChatsResponseBodyDataMessages> Messages { get; set; }
            public class ListWaitingChatsResponseBodyDataMessages : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>c361765f-******-4e07-b81c-4b5d9183fac6</para>
                /// </summary>
                [NameInMap("SenderId")]
                [Validation(Required=false)]
                public string SenderId { get; set; }

                [NameInMap("SenderType")]
                [Validation(Required=false)]
                public string SenderType { get; set; }

            }

            [NameInMap("SkillGroupId")]
            [Validation(Required=false)]
            public string SkillGroupId { get; set; }

            [NameInMap("UserList")]
            [Validation(Required=false)]
            public List<ListWaitingChatsResponseBodyDataUserList> UserList { get; set; }
            public class ListWaitingChatsResponseBodyDataUserList : TeaModel {
                [NameInMap("AvatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>c361765f-******-4e07-b81c-4b5d9183fac6</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CUSTOMER</para>
                /// </summary>
                [NameInMap("UserType")]
                [Validation(Required=false)]
                public string UserType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>03C67DAD-EB26-41D8-949D-9B0C470FB716</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
