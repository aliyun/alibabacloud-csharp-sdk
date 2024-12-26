// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class CreateTopicRequest : TeaModel {
        [NameInMap("maxSendTps")]
        [Validation(Required=false)]
        public long? MaxSendTps { get; set; }

        /// <summary>
        /// <para>The type of messages in the topic that you want to create.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TRANSACTION: transactional messages</description></item>
        /// <item><description>FIFO: ordered messages</description></item>
        /// <item><description>DELAY: scheduled messages or delayed Message</description></item>
        /// <item><description>NORMAL: normal messages</description></item>
        /// </list>
        /// <remarks>
        /// <para>The type of messages in the topic must be the same as the type of messages that you want to send. For example, if you create a topic whose message type is ordered messages, the topic can be used to send and receive only ordered messages.</para>
        /// </remarks>
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
