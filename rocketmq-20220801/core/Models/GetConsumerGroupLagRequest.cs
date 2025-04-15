// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class GetConsumerGroupLagRequest : TeaModel {
        /// <summary>
        /// <para>The topic name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal-topic-1</para>
        /// </summary>
        [NameInMap("topicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}
