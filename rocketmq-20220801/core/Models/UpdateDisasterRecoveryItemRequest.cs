// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class UpdateDisasterRecoveryItemRequest : TeaModel {
        /// <summary>
        /// <para>The topics involved in the topic mapping.</para>
        /// </summary>
        [NameInMap("topics")]
        [Validation(Required=false)]
        public List<UpdateDisasterRecoveryItemRequestTopics> Topics { get; set; }
        public class UpdateDisasterRecoveryItemRequestTopics : TeaModel {
            /// <summary>
            /// <para>The ID of the consumer group. If you use the two-way backup mode, you must specify this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GID_xxx</para>
            /// </summary>
            [NameInMap("consumerGroupId")]
            [Validation(Required=false)]
            public string ConsumerGroupId { get; set; }

            /// <summary>
            /// <para>The method used to deliver messages to the destination instance.</para>
            /// <para>Valid values:</para>
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
            /// <para>The instance ID. If you set instanceType to EXTERNAL_ROCKETMQ, the system automatically generates an ID for the instance. You can obtain the ID by querying the global message backup plan.</para>
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
            /// <item><description>ALIYUN_ROCKETMQ: ApsaraMQ for RocketMQ instance</description></item>
            /// <item><description>EXTERNAL_ROCKETMQ: open source RocketMQ cluster</description></item>
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
            /// <para>The topic name. You must specify this parameter.</para>
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
