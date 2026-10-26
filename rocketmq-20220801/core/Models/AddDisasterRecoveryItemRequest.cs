// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class AddDisasterRecoveryItemRequest : TeaModel {
        /// <summary>
        /// <para>The topics included in the backup mapping. Required.</para>
        /// </summary>
        [NameInMap("topics")]
        [Validation(Required=false)]
        public List<AddDisasterRecoveryItemRequestTopics> Topics { get; set; }
        public class AddDisasterRecoveryItemRequestTopics : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The ID of the consumer group. Required for ACTIVE_ACTIVE bidirectional backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GID_xxx</para>
            /// </summary>
            [NameInMap("consumerGroupId")]
            [Validation(Required=false)]
            [Obsolete]
            public string ConsumerGroupId { get; set; }

            /// <summary>
            /// <para>The delivery order of messages to the target instance. Valid values for the parameter:</para>
            /// <list type="bullet">
            /// <item><description>Concurrently: concurrent delivery</description></item>
            /// <item><description>Orderly: ordered delivery</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Concurrently</para>
            /// </summary>
            [NameInMap("deliveryOrderType")]
            [Validation(Required=false)]
            public string DeliveryOrderType { get; set; }

            /// <summary>
            /// <para>The instance ID. If instanceType is set to EXTERNAL_ROCKETMQ, an instance ID is automatically generated. You can obtain this ID by querying the backup plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rmq-cn-em93y94xxx</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ALIYUN_ROCKETMQ: Alibaba Cloud instance</description></item>
            /// <item><description>EXTERNAL_ROCKETMQ: external instance, open-source instance, or open-source cluster</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN_ROCKETMQ</para>
            /// </summary>
            [NameInMap("instanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The name of the disaster recovery topic. Required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Topic_xxx</para>
            /// </summary>
            [NameInMap("topicName")]
            [Validation(Required=false)]
            public string TopicName { get; set; }

        }

    }

}
