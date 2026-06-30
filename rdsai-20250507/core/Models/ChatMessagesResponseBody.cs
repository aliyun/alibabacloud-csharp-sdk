// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ChatMessagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The content of the generated answer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>您询问的实例rm-bp14as9914vd3**** 磁盘使用率为23%，暂时不需要进行扩容。如果您需要进一步查看某个实例的详细配置、性能监控或进行其他操作，请告诉我你的具体需求！</para>
        /// </summary>
        [NameInMap("Answer")]
        [Validation(Required=false)]
        public string Answer { get; set; }

        /// <summary>
        /// <para>The ID of the conversation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9cbbe885-b240-4803-9d15-6781a3fd****</para>
        /// </summary>
        [NameInMap("ConversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <para>The time when the message was created. This value is a UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1763986004</para>
        /// </summary>
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>The event associated with the message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MysqlIOException</para>
        /// </summary>
        [NameInMap("Event")]
        [Validation(Required=false)]
        public string Event { get; set; }

        /// <summary>
        /// <para>The ID of the message, which is distinct from <c>MessageId</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60b335ca-124d-4ee1-864b-de554987****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The unique ID of the message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oas8pwy2-slxw-sf98-bx83-cb2hkktl****</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>The query mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>以后会下线，不用关注。</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the asynchronous task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01c3d43d-9466-4bd5-8196-4cbbce08****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
