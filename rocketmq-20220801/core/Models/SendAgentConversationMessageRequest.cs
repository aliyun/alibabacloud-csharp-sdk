// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class SendAgentConversationMessageRequest : TeaModel {
        [NameInMap("attachments")]
        [Validation(Required=false)]
        public List<SendAgentConversationMessageRequestAttachments> Attachments { get; set; }
        public class SendAgentConversationMessageRequestAttachments : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>client.log</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("keptLines")]
            [Validation(Required=false)]
            public long? KeptLines { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>client_log</para>
            /// </summary>
            [NameInMap("kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>client-logs/0198c8a91f4d7f01a3c21e99/client.log</para>
            /// </summary>
            [NameInMap("sandboxPath")]
            [Validation(Required=false)]
            public string SandboxPath { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>114</para>
            /// </summary>
            [NameInMap("sizeBytes")]
            [Validation(Required=false)]
            public long? SizeBytes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-09-12T11:00:00+08:00</para>
            /// </summary>
            [NameInMap("timeRangeEnd")]
            [Validation(Required=false)]
            public string TimeRangeEnd { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-09-12T10:00:00+08:00</para>
            /// </summary>
            [NameInMap("timeRangeStart")]
            [Validation(Required=false)]
            public string TimeRangeStart { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("totalLines")]
            [Validation(Required=false)]
            public long? TotalLines { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>告警时间为 2026-08-19 19:30:00</para>
        /// </summary>
        [NameInMap("clientContext")]
        [Validation(Required=false)]
        public string ClientContext { get; set; }

        [NameInMap("images")]
        [Validation(Required=false)]
        public List<SendAgentConversationMessageRequestImages> Images { get; set; }
        public class SendAgentConversationMessageRequestImages : TeaModel {
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
        /// <para>实例 rmq-cn-example 的消息为什么持续堆积？</para>
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

}
