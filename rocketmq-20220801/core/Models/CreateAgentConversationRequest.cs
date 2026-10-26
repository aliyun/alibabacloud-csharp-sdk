// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class CreateAgentConversationRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>conversation-request-001</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("initialMessage")]
        [Validation(Required=false)]
        public CreateAgentConversationRequestInitialMessage InitialMessage { get; set; }
        public class CreateAgentConversationRequestInitialMessage : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>告警发生于 10:00</para>
            /// </summary>
            [NameInMap("clientContext")]
            [Validation(Required=false)]
            public string ClientContext { get; set; }

            [NameInMap("images")]
            [Validation(Required=false)]
            public List<CreateAgentConversationRequestInitialMessageImages> Images { get; set; }
            public class CreateAgentConversationRequestInitialMessageImages : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAAC0lEQVR4nGNgAAIAAAUAAXpeqz8AAAAASUVORK5CYII=</para>
                /// </summary>
                [NameInMap("dataBase64")]
                [Validation(Required=false)]
                public string DataBase64 { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>image/png</para>
                /// </summary>
                [NameInMap("mediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>请排查实例消息堆积原因</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ticket_request</para>
            /// </summary>
            [NameInMap("messageType")]
            [Validation(Required=false)]
            public string MessageType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ticket-request-example-001</para>
            /// </summary>
            [NameInMap("ticketRequestId")]
            [Validation(Required=false)]
            public string TicketRequestId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>消息堆积排查</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
