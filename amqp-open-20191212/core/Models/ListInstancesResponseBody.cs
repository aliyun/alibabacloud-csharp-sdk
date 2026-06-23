// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListInstancesResponseBodyData Data { get; set; }
        public class ListInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A list of instances.</para>
            /// </summary>
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyDataInstances> Instances { get; set; }
            public class ListInstancesResponseBodyDataInstances : TeaModel {
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
                /// <para>The deployment architecture, which is applicable only to Serverless Edition instances. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>shared: A shared architecture, used for reserved, elastic (shared), and pay-as-you-go instances.</para>
                /// </description></item>
                /// <item><description><para>dedicated: A dedicated architecture, used for reserved and elastic (dedicated) instances.</para>
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
                /// <para>Indicates whether storage encryption is enabled for the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EncryptedInstance")]
                [Validation(Required=false)]
                public bool? EncryptedInstance { get; set; }

                /// <summary>
                /// <para>The expiration timestamp of the instance, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1651507200000</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>amqp-cn-st21x7kv****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>amqp-cn-st21x7kv****</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The instance type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>professional: Professional Edition</para>
                /// </description></item>
                /// <item><description><para>enterprise: Enterprise Edition</para>
                /// </description></item>
                /// <item><description><para>vip: Platinum Edition</para>
                /// </description></item>
                /// </list>
                /// <para>&lt;props=&quot;china&quot;&gt;</para>
                /// <list type="bullet">
                /// <item><description>serverless: Serverless Edition</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>professional</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The ID of the KMS key used for data disk encryption.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key-bjj66c2a893vmhawtq5fd</para>
                /// </summary>
                [NameInMap("KmsKeyId")]
                [Validation(Required=false)]
                public string KmsKeyId { get; set; }

                /// <summary>
                /// <para>The port listener mode of the instance. <c>tcp_and_ssl</c> enables both port <c>5672</c> and port <c>5671</c>, while <c>ssl_only</c> enables only port <c>5671</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tcp_and_ssl</para>
                /// </summary>
                [NameInMap("ListenerMode")]
                [Validation(Required=false)]
                public string ListenerMode { get; set; }

                /// <summary>
                /// <para>The peak transactions per second (TPS) of the instance over the public network.</para>
                /// 
                /// <b>Example:</b>
                /// <para>24832</para>
                /// </summary>
                [NameInMap("MaxEipTps")]
                [Validation(Required=false)]
                public int? MaxEipTps { get; set; }

                /// <summary>
                /// <para>The maximum number of queues for the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("MaxQueue")]
                [Validation(Required=false)]
                public int? MaxQueue { get; set; }

                /// <summary>
                /// <para>The peak transactions per second (TPS) of the instance over the private network.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5000</para>
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
                /// <para>The creation timestamp of the order, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1572441939000</para>
                /// </summary>
                [NameInMap("OrderCreateTime")]
                [Validation(Required=false)]
                public long? OrderCreateTime { get; set; }

                /// <summary>
                /// <para>The billing method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>PRE_PAID: The instance uses the subscription billing method.</para>
                /// </description></item>
                /// <item><description><para>POST_PAID: The instance uses the pay-as-you-go billing method.</para>
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
                /// <para>amqp-cn-st21x7kv****.mq-amqp.cn-hangzhou-a.aliyuncs.com</para>
                /// </summary>
                [NameInMap("PublicEndpoint")]
                [Validation(Required=false)]
                public string PublicEndpoint { get; set; }

                /// <summary>
                /// <para>The resource group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aek3axfj2w4czrq</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The ID of the security group to which the instance belongs. This security group is used for PrivateLink endpoint creation.</para>
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
                /// <item><description><para>SERVING: The instance is running.</para>
                /// </description></item>
                /// <item><description><para>RELEASED: The instance is released.</para>
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
                /// <para>The storage capacity of the disk. Unit: GB.</para>
                /// <remarks>
                /// <para>This parameter returns a value of <b>-1</b> for Professional Edition and Enterprise Edition instances, to which it does not apply.</para>
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
                /// <para>The tags attached to the instance.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListInstancesResponseBodyDataInstancesTags> Tags { get; set; }
                public class ListInstancesResponseBodyDataInstancesTags : TeaModel {
                    /// <summary>
                    /// <para>The tag key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>region</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The tag value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hangzhou</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The ID of the VPC in which the instance resides. This VPC is used for PrivateLink endpoint creation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-xxx</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The IDs of the VSwitches to which the instance is connected. These VSwitches are used for PrivateLink endpoint creation.</para>
                /// </summary>
                [NameInMap("VswitchIds")]
                [Validation(Required=false)]
                public List<string> VswitchIds { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token for the next page of results. If this field is empty, it means all results have been returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>caebacccb2be03f84eb48b699f0a****</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CCBB1225-C392-480E-8C7F-D09AB2CD2***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
