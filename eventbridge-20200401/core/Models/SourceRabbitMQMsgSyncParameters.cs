// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SourceRabbitMQMsgSyncParameters : TeaModel {
        /// <summary>
        /// <para>The data type of the message body.</para>
        /// 
        /// <b>Example:</b>
        /// <para>json</para>
        /// </summary>
        [NameInMap("BodyDataType")]
        [Validation(Required=false)]
        public string BodyDataType { get; set; }

        /// <summary>
        /// <para>The ID of the RabbitMQ cloud migration task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-42d3-a456-426614174000</para>
        /// </summary>
        [NameInMap("CloudMigrationTaskId")]
        [Validation(Required=false)]
        public string CloudMigrationTaskId { get; set; }

        /// <summary>
        /// <para>The address of the destination cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rabbitmq-cn-hangzhou-2x***.com</para>
        /// </summary>
        [NameInMap("DstClusterHost")]
        [Validation(Required=false)]
        public string DstClusterHost { get; set; }

        /// <summary>
        /// <para>The type of the destination RabbitMQ cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cloud</para>
        /// </summary>
        [NameInMap("DstClusterType")]
        [Validation(Required=false)]
        public string DstClusterType { get; set; }

        /// <summary>
        /// <para>The endpoint of the RabbitMQ cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.2.10</para>
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
        /// <para>The type of the source RabbitMQ instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SelfBuilt</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The network type used to connect to the source RabbitMQ instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrivateNetwork</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>Specifies whether SAC is enabled. Do not specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Leave empty</para>
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
        /// <para>The prefetch count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PrefetchCount")]
        [Validation(Required=false)]
        public string PrefetchCount { get; set; }

        /// <summary>
        /// <para>The regular expression for matching. Do not specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Leave empty</para>
        /// </summary>
        [NameInMap("Regex")]
        [Validation(Required=false)]
        public string Regex { get; set; }

        /// <summary>
        /// <para>The ID of the security group to which the machines of the RabbitMQ cluster belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-a1b2c3d4e5f6g7h8i9j0</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The address of the source cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rabbitmq-cn-hangzhou-2x***.com</para>
        /// </summary>
        [NameInMap("SrcClusterHost")]
        [Validation(Required=false)]
        public string SrcClusterHost { get; set; }

        /// <summary>
        /// <para>The type of the source RabbitMQ cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SelfBuilt</para>
        /// </summary>
        [NameInMap("SrcClusterType")]
        [Validation(Required=false)]
        public string SrcClusterType { get; set; }

        /// <summary>
        /// <para>The type of metadata to synchronize. Do not specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
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
        /// <para>The IDs of the vSwitches in the VPC where the RabbitMQ cluster is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-a1b2c3d4e5f6g7h8i9j0k</para>
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
        /// <para>The ID of the VPC where the RabbitMQ cluster is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-a1b2c3d4e5f6g7h8i9j0k</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
