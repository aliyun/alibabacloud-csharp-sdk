// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class SourceKafkaParameters : TeaModel {
        /// <summary>
        /// <para>The group ID of the consumer that subscribes to the topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT_GROUP</para>
        /// </summary>
        [NameInMap("ConsumerGroup")]
        [Validation(Required=false)]
        public string ConsumerGroup { get; set; }

        /// <summary>
        /// <para>The ID of the EventBridge instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-8vb64581862c****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The network type. Default value: Default. The value PublicNetwork specifies a virtual private cloud (VPC) network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public string Network { get; set; }

        /// <summary>
        /// <para>The offset. earliest: consumes messages from the earliest offset. latest: consumes messages from the latest offset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>latest</para>
        /// </summary>
        [NameInMap("OffsetReset")]
        [Validation(Required=false)]
        public string OffsetReset { get; set; }

        /// <summary>
        /// <para>The region in which the ApsaraMQ for Kafka instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp1iv19sp1msc7zot4****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The name of the topic in the ApsaraMQ for Kafka instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>popvip_center_robot_order</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp179l3llg3jjxwrq72****</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public string VSwitchIds { get; set; }

        /// <summary>
        /// <para>The ID of the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-8vblalsi0vbhizr77****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
