// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class AddDisasterRecoveryItemRequest : TeaModel {
        /// <summary>
        /// <para>Topics included in the backup mapping. Required.</para>
        /// </summary>
        [NameInMap("topics")]
        [Validation(Required=false)]
        public List<AddDisasterRecoveryItemRequestTopics> Topics { get; set; }
        public class AddDisasterRecoveryItemRequestTopics : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>Consumer group ID, required for ACTIVE_ACTIVE bidirectional backup</para>
            /// 
            /// <b>Example:</b>
            /// <para>GID_xxx</para>
            /// </summary>
            [NameInMap("consumerGroupId")]
            [Validation(Required=false)]
            [Obsolete]
            public string ConsumerGroupId { get; set; }

            /// <summary>
            /// <para>The order in which messages are delivered to the target instance. The parameter values ​​are as follows:</para>
            /// <list type="bullet">
            /// <item><description>Concurrently: concurrent delivery</description></item>
            /// <item><description>Orderly: sequential delivery</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Concurrently</para>
            /// </summary>
            [NameInMap("deliveryOrderType")]
            [Validation(Required=false)]
            public string DeliveryOrderType { get; set; }

            /// <summary>
            /// <para>Instance ID, an instance ID will be automatically generated when <c>instanceType</c> is <c>EXTERNAL_ROCKETMQ</c>, and it can be obtained by querying the backup plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rmq-cn-em93y94xxx</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Instance type</para>
            /// <list type="bullet">
            /// <item><description>ALIYUN_ROCKETMQ: Alibaba Cloud instance</description></item>
            /// <item><description>EXTERNAL_ROCKETMQ: External instance, open-source instance, open-source cluster</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN_ROCKETMQ</para>
            /// </summary>
            [NameInMap("instanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>Region ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Disaster recovery topic name, required</para>
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
