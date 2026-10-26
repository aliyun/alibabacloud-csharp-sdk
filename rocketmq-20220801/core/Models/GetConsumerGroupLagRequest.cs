// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class GetConsumerGroupLagRequest : TeaModel {
        /// <summary>
        /// <para>The name of the lite topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("liteTopicName")]
        [Validation(Required=false)]
        public string LiteTopicName { get; set; }

        /// <summary>
        /// <para>The name of the topic to which the consumer group subscribes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal-topic-1</para>
        /// </summary>
        [NameInMap("topicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}
