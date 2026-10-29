// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SinkRabbitMQMetaParameters : TeaModel {
        /// <summary>
        /// <para>The endpoint of the ApsaraMQ for RabbitMQ cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rabbitmq-cn-a1b2c3d4e5f-cn-hangzhou-vpc.amqp.aliyuncs.com</para>
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>The ID of the ApsaraMQ for RabbitMQ instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rabbitmq-cn-a1b2c3d4e5f</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of the ApsaraMQ for RabbitMQ instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cloud</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The network type used to connect to the ApsaraMQ for RabbitMQ instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrivateNetwork</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The password used to connect to the ApsaraMQ for RabbitMQ cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourPassword</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The ID of the security group to which the servers of the ApsaraMQ for RabbitMQ cluster belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-a1b2c3d4e5f6g7h8i9j0</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The username used to connect to the ApsaraMQ for RabbitMQ cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>The IDs of the vSwitches in the VPC where the ApsaraMQ for RabbitMQ cluster is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-a1b2c3d4e5f6g7h8i9j0k</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public string VSwitchIds { get; set; }

        /// <summary>
        /// <para>The name of the virtual host (vhost) in the ApsaraMQ for RabbitMQ cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-001</para>
        /// </summary>
        [NameInMap("VirtualHostName")]
        [Validation(Required=false)]
        public string VirtualHostName { get; set; }

        /// <summary>
        /// <para>The ID of the VPC where the ApsaraMQ for RabbitMQ cluster is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-a1b2c3d4e5f6g7h8i9j0k</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
