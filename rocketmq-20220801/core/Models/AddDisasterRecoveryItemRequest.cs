// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class AddDisasterRecoveryItemRequest : TeaModel {
        [NameInMap("topics")]
        [Validation(Required=false)]
        public List<AddDisasterRecoveryItemRequestTopics> Topics { get; set; }
        public class AddDisasterRecoveryItemRequestTopics : TeaModel {
            [NameInMap("consumerGroupId")]
            [Validation(Required=false)]
            public string ConsumerGroupId { get; set; }

            [NameInMap("deliveryOrderType")]
            [Validation(Required=false)]
            public string DeliveryOrderType { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ALIYUN_ROCKETMQ</para>
            /// </summary>
            [NameInMap("instanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>regionId</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("topicName")]
            [Validation(Required=false)]
            public string TopicName { get; set; }

        }

    }

}
