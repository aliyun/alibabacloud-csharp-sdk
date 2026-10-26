// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class CreateTopicRequest : TeaModel {
        /// <summary>
        /// <para>The expiration time of the lite topic, in minutes.
        /// Valid values: 30 to 720.
        /// Default value: -1, which indicates the topic never expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("liteTopicExpiration")]
        [Validation(Required=false)]
        public long? LiteTopicExpiration { get; set; }

        /// <summary>
        /// <para>The maximum transactions per second (TPS) for sending messages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1500</para>
        /// </summary>
        [NameInMap("maxSendTps")]
        [Validation(Required=false)]
        public long? MaxSendTps { get; set; }

        /// <summary>
        /// <para>The message type of the topic to be created.</para>
        /// <remarks>
        /// <para>Notice: The type of the topic must be the same as the type of messages sent to the topic. For example, if you create a topic of the ordered message type, the topic can be used only to send and receive ordered messages, not other types of messages.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("messageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

        /// <summary>
        /// <para>The remarks of the topic to be created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is the remark for test.</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
