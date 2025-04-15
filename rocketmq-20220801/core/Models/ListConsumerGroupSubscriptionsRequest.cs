// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListConsumerGroupSubscriptionsRequest : TeaModel {
        /// <summary>
        /// <para>The topic name. If you do not specify this parameter, all subscriptions of the consumer group are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>topic_test</para>
        /// </summary>
        [NameInMap("topicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}
