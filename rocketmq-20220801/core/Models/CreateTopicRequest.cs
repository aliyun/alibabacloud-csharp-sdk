// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class CreateTopicRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("liteTopicExpiration")]
        [Validation(Required=false)]
        public long? LiteTopicExpiration { get; set; }

        /// <summary>
        /// <para>The maximum TPS for message sending.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1500</para>
        /// </summary>
        [NameInMap("maxSendTps")]
        [Validation(Required=false)]
        public long? MaxSendTps { get; set; }

        /// <summary>
        /// <para>The type of messages in the topic that you want to create.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TRANSACTION: transactional messages</description></item>
        /// <item><description>FIFO: ordered messages</description></item>
        /// <item><description>DELAY: scheduled or delayed messages</description></item>
        /// <item><description>NORMAL: normal messages</description></item>
        /// </list>
        /// <remarks>
        /// <para> The type of messages in the topic must be the same as the type of messages that you want to send. For example, if you create a topic whose message type is ordered messages, you can use the topic to send and receive only ordered messages.</para>
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
        /// <para>The description of the topic that you want to create.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is the remark for test.</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
