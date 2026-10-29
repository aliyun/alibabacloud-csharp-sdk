// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SourceRabbitMQMetaParameters : TeaModel {
        /// <summary>
        /// <para>The access endpoint of the RabbitMQ cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rabbitmq-cn-a1b2c3d4e5f-cn-hangzhou-vpc.amqp.aliyuncs.com</para>
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>The added suffix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rabbitmq-cn-a1b2c3d4e5f_example_123e4567-e89b-42d3-a456-426614174000</para>
        /// </summary>
        [NameInMap("InnerNameSuffix")]
        [Validation(Required=false)]
        public string InnerNameSuffix { get; set; }

        /// <summary>
        /// <para>The ID of the ApsaraMQ for RabbitMQ (MSMQ message queue) instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rabbitmq-cn-a1b2c3d4e5f</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of the source RabbitMQ instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cloud</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The maximum number of hops allowed for message forwarding in a federation task. Messages that exceed this limit are dropped.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxHops")]
        [Validation(Required=false)]
        public string MaxHops { get; set; }

        /// <summary>
        /// <para>The network type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrivateNetwork</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>Specifies whether to consume messages in order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OrderConsume")]
        [Validation(Required=false)]
        public string OrderConsume { get; set; }

        /// <summary>
        /// <para>The password used to connect to the RabbitMQ cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourPassword</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The regular expression used to filter exchanges.</para>
        /// 
        /// <b>Example:</b>
        /// <para>^example_.*</para>
        /// </summary>
        [NameInMap("Regex")]
        [Validation(Required=false)]
        public string Regex { get; set; }

        /// <summary>
        /// <para>The ID of the security group to which the machines of the RabbitMQ cluster belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp1****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The type of synchronized metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>queue</para>
        /// </summary>
        [NameInMap("SyncMetaType")]
        [Validation(Required=false)]
        public string SyncMetaType { get; set; }

        /// <summary>
        /// <para>The username used to connect to the RabbitMQ cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch in the VPC where the RabbitMQ cluster resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1****</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public string VSwitchIds { get; set; }

        /// <summary>
        /// <para>The name of the virtual host (vhost) in the RabbitMQ cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-001</para>
        /// </summary>
        [NameInMap("VirtualHostName")]
        [Validation(Required=false)]
        public string VirtualHostName { get; set; }

        /// <summary>
        /// <para>The ID of the VPC where the RabbitMQ cluster resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-8vb****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
