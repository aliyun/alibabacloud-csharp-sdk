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
            /// <para>The instances.</para>
            /// </summary>
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyDataInstances> Instances { get; set; }
            public class ListInstancesResponseBodyDataInstances : TeaModel {
                /// <summary>
                /// <para>Indicates whether the instance is automatically renewed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AutoRenewInstance")]
                [Validation(Required=false)]
                public bool? AutoRenewInstance { get; set; }

                /// <summary>
                /// <para>The endpoint that is used to access the instance over the classic network. This parameter is no longer available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>amqp-cn-st21x7kv****.not-support</para>
                /// </summary>
                [NameInMap("ClassicEndpoint")]
                [Validation(Required=false)]
                public string ClassicEndpoint { get; set; }

                [NameInMap("EncryptedInstance")]
                [Validation(Required=false)]
                public bool? EncryptedInstance { get; set; }

                /// <summary>
                /// <para>The timestamp that indicates when the instance expires. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1651507200000</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                /// <summary>
                /// <para>The instance ID</para>
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
                /// <para>The instance type.</para>
                /// <list type="bullet">
                /// <item><description>PROFESSIONAL: Professional Edition</description></item>
                /// <item><description>ENTERPRISE: Enterprise Edition</description></item>
                /// <item><description>VIP: Enterprise Platinum Edition</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>professional</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("KmsKeyId")]
                [Validation(Required=false)]
                public string KmsKeyId { get; set; }

                /// <summary>
                /// <para>The maximum number of Internet-based transactions per second (TPS) for the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>24832</para>
                /// </summary>
                [NameInMap("MaxEipTps")]
                [Validation(Required=false)]
                public int? MaxEipTps { get; set; }

                /// <summary>
                /// <para>The maximum number of queues on the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("MaxQueue")]
                [Validation(Required=false)]
                public int? MaxQueue { get; set; }

                /// <summary>
                /// <para>The maximum number of VPC-based TPS for the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5000</para>
                /// </summary>
                [NameInMap("MaxTps")]
                [Validation(Required=false)]
                public int? MaxTps { get; set; }

                /// <summary>
                /// <para>The maximum number of vhosts on the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("MaxVhost")]
                [Validation(Required=false)]
                public int? MaxVhost { get; set; }

                /// <summary>
                /// <para>The timestamp that indicates when the order was created. Unit: milliseconds.</para>
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
                /// <item><description>PrePaid: the subscription billing method.</description></item>
                /// <item><description>POST_PAID: the pay-as-you-go billing method.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PRE_PAID</para>
                /// </summary>
                [NameInMap("OrderType")]
                [Validation(Required=false)]
                public string OrderType { get; set; }

                /// <summary>
                /// <para>The virtual private cloud (VPC) endpoint of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>amqp-cn-st21x7kv****.mq-amqp.cn-hangzhou-a.aliyuncs.com</para>
                /// </summary>
                [NameInMap("PrivateEndpoint")]
                [Validation(Required=false)]
                public string PrivateEndpoint { get; set; }

                /// <summary>
                /// <para>The public endpoint of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>amqp-cn-st21x7kv****.mq-amqp.cn-hangzhou-a.aliyuncs.com</para>
                /// </summary>
                [NameInMap("PublicEndpoint")]
                [Validation(Required=false)]
                public string PublicEndpoint { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The instance status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DEPLOYING: The instance is being deployed.</description></item>
                /// <item><description>EXPIRED: The instance is expired.</description></item>
                /// <item><description>SERVING: The instance is running.</description></item>
                /// <item><description>RELEASED: The instance is released.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SERVING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The disk size. Unit: GB.</para>
                /// <remarks>
                /// <para> For Professional Edition instances and Enterprise Edition instances, this parameter is unavailable and \<em>\</em>-1\<em>\</em> is returned.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("StorageSize")]
                [Validation(Required=false)]
                public int? StorageSize { get; set; }

                /// <summary>
                /// <para>Indicates whether the instance supports elastic IP addresses (EIPs).</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SupportEIP")]
                [Validation(Required=false)]
                public bool? SupportEIP { get; set; }

                /// <summary>
                /// <para>标签列表。</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListInstancesResponseBodyDataInstancesTags> Tags { get; set; }
                public class ListInstancesResponseBodyDataInstancesTags : TeaModel {
                    /// <summary>
                    /// <para>标签键。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>region</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>标签值。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hangzhou</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The maximum number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token that marks the end of the current returned page. If this parameter is empty, all data is retrieved.</para>
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
