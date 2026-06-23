// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class GetInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyData Data { get; set; }
        public class GetInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether auto-renewal is enabled for the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoRenewInstance")]
            [Validation(Required=false)]
            public bool? AutoRenewInstance { get; set; }

            /// <summary>
            /// <para>The classic network endpoint. This parameter is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amqp-cn-st21x7kv****.not-support</para>
            /// </summary>
            [NameInMap("ClassicEndpoint")]
            [Validation(Required=false)]
            public string ClassicEndpoint { get; set; }

            /// <summary>
            /// <para>The deployment architecture. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>shared: shared architecture, which is suitable for reserved and elastic (shared) instances and pay-as-you-go instances.</para>
            /// </description></item>
            /// <item><description><para>dedicated: dedicated architecture, which is suitable for reserved and elastic (dedicated) instances.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>shared</para>
            /// </summary>
            [NameInMap("Edition")]
            [Validation(Required=false)]
            public string Edition { get; set; }

            /// <summary>
            /// <para>Indicates whether storage encryption is enabled for the instance data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EncryptedInstance")]
            [Validation(Required=false)]
            public bool? EncryptedInstance { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates when the instance expires, in milliseconds.</para>
            /// <remarks>
            /// <para>The value is a long integer. Handle it with care in certain programming languages to prevent precision loss.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1651507200000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amqp-cn-*********</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the instance. A length of 64 characters or less is recommended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yunQi-instance</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The instance type.</para>
            /// <list type="bullet">
            /// <item><description><para>PROFESSIONAL: Professional Edition</para>
            /// </description></item>
            /// <item><description><para>ENTERPRISE: Enterprise Edition</para>
            /// </description></item>
            /// <item><description><para>VIP: Platinum Edition</para>
            /// </description></item>
            /// <item><description><para>SERVERLESS: Serverless Edition</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enterprise</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The KMS key ID of the cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key-hzz6566e86byam3lg5rw4</para>
            /// </summary>
            [NameInMap("KmsKeyId")]
            [Validation(Required=false)]
            public string KmsKeyId { get; set; }

            /// <summary>
            /// <para>The listener mode. A value of tcp_and_ssl enables both port 5672 and 5671, while ssl_only enables only port 5671.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tcp_and_ssl</para>
            /// </summary>
            [NameInMap("ListenerMode")]
            [Validation(Required=false)]
            public string ListenerMode { get; set; }

            /// <summary>
            /// <para>The maximum number of connections.</para>
            /// <para>For valid values, see the <a href="https://common-buy.aliyun.com/?commodityCode=ons_onsproxy_pre">ApsaraMQ for RabbitMQ purchase page</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1500</para>
            /// </summary>
            [NameInMap("MaxConnections")]
            [Validation(Required=false)]
            public int? MaxConnections { get; set; }

            /// <summary>
            /// <para>The peak public TPS.</para>
            /// <para>For valid values, see the <a href="https://common-buy.aliyun.com/?commodityCode=ons_onsproxy_pre">ApsaraMQ for RabbitMQ purchase page</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("MaxEipTps")]
            [Validation(Required=false)]
            public int? MaxEipTps { get; set; }

            /// <summary>
            /// <para>The maximum number of queues for the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("MaxQueue")]
            [Validation(Required=false)]
            public int? MaxQueue { get; set; }

            /// <summary>
            /// <para>The peak private TPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("MaxTps")]
            [Validation(Required=false)]
            public int? MaxTps { get; set; }

            /// <summary>
            /// <para>The maximum number of vhosts for the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("MaxVhost")]
            [Validation(Required=false)]
            public int? MaxVhost { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates when the order was created, in milliseconds.</para>
            /// <remarks>
            /// <para>The value is a long integer. Handle it with care in certain programming languages to prevent precision loss.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1651507200000</para>
            /// </summary>
            [NameInMap("OrderCreateTime")]
            [Validation(Required=false)]
            public long? OrderCreateTime { get; set; }

            /// <summary>
            /// <para>The billing method.</para>
            /// <list type="bullet">
            /// <item><description><para>PRE_PAID: subscription</para>
            /// </description></item>
            /// <item><description><para>POST_PAID: pay-as-you-go</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PRE_PAID</para>
            /// </summary>
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            /// <summary>
            /// <para>The VPC endpoint of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amqp-cn-st21x7kv****.mq-amqp.cn-hangzhou-a.aliyuncs.com</para>
            /// </summary>
            [NameInMap("PrivateEndpoint")]
            [Validation(Required=false)]
            public string PrivateEndpoint { get; set; }

            /// <summary>
            /// <para>The reserved TPS capacity for reserved and elastic instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("ProvisionedCapacity")]
            [Validation(Required=false)]
            public int? ProvisionedCapacity { get; set; }

            /// <summary>
            /// <para>The public endpoint of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx.cn-hangzhou.xxx.net.mq.amqp.aliyuncs.com</para>
            /// </summary>
            [NameInMap("PublicEndpoint")]
            [Validation(Required=false)]
            public string PublicEndpoint { get; set; }

            /// <summary>
            /// <para>The ID of the resource group for the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfm2vn6jkayvfy</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The security group ID used to create a PrivateLink endpoint for the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-xxx</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            [NameInMap("ServerlessSwitch")]
            [Validation(Required=false)]
            public bool? ServerlessSwitch { get; set; }

            /// <summary>
            /// <para>The instance status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>DEPLOYING: The instance is being deployed.</para>
            /// </description></item>
            /// <item><description><para>EXPIRED: The instance has expired.</para>
            /// </description></item>
            /// <item><description><para>SERVING: The instance is in service.</para>
            /// </description></item>
            /// <item><description><para>RELEASED: The instance has been released.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SERVING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The disk capacity. Unit: GB.</para>
            /// <remarks>
            /// <para>For Professional and Enterprise Edition instances, this parameter returns <b>-1</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("StorageSize")]
            [Validation(Required=false)]
            public int? StorageSize { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance supports EIPs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportEIP")]
            [Validation(Required=false)]
            public bool? SupportEIP { get; set; }

            /// <summary>
            /// <para>Indicates whether the message trace feature is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("SupportTracing")]
            [Validation(Required=false)]
            public bool? SupportTracing { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyDataTags> Tags { get; set; }
            public class GetInstanceResponseBodyDataTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Tag key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Tag value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The retention period of message traces. Unit: days. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>3: 3 days</para>
            /// </description></item>
            /// <item><description><para>7: 7 days</para>
            /// </description></item>
            /// <item><description><para>15: 15 days</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter applies only when <c>SupportTracing</c> is set to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("TracingStorageTime")]
            [Validation(Required=false)]
            public int? TracingStorageTime { get; set; }

            /// <summary>
            /// <para>The VPC ID used to create a PrivateLink endpoint for the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-xxx</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The VSwitch IDs used to create a PrivateLink endpoint for the instance.</para>
            /// </summary>
            [NameInMap("VswitchIds")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

        }

        /// <summary>
        /// <para>The unique ID generated for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>92385FD2-624A-48C9-8FB5-753F2AFA***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
