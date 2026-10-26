// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The access control information.</para>
        /// </summary>
        [NameInMap("aclInfo")]
        [Validation(Required=false)]
        public CreateInstanceRequestAclInfo AclInfo { get; set; }
        public class CreateInstanceRequestAclInfo : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable authentication-free access for VPC endpoints when the intelligent identity recognition type is used. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enable authentication-free access.</description></item>
            /// <item><description>false: Disable authentication-free access.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("defaultVpcAuthFree")]
            [Validation(Required=false)]
            public bool? DefaultVpcAuthFree { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. This parameter takes effect only when the billing method of the instance is set to Subscription.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The Unified Auto Renewal Cycle. This parameter takes effect only when auto-renewal is enabled. Unit: months.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Monthly renewal: 1, 2, 3, 6, 12</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("autoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The commodity code.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;- ons_rmqsub_public_cn: subscription instance.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;- ons_rmqpost_public_cn: pay-as-you-go instance.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;- ons_rmqsrvlesspost_public_cn: serverless instance.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;- ons_rmqpost_public_intl: pay-as-you-go.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;- ons_rmqsub_public_intl: subscription.
        /// &lt;props=&quot;intl&quot;&gt;- ons_rmqsrvlesspost_public_intl: serverless instance.
        /// This parameter is required for serverless instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ons_ rmqpost_public_cn</para>
        /// </summary>
        [NameInMap("commodityCode")]
        [Validation(Required=false)]
        [Obsolete]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>The name of the instance to be created.</para>
        /// <para>If you do not specify this parameter, the instance ID is used as the instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rmq-cn-72u3048uxxx</para>
        /// </summary>
        [NameInMap("instanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The network configuration information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("networkInfo")]
        [Validation(Required=false)]
        public CreateInstanceRequestNetworkInfo NetworkInfo { get; set; }
        public class CreateInstanceRequestNetworkInfo : TeaModel {
            /// <summary>
            /// <para>The Internet configuration information.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("internetInfo")]
            [Validation(Required=false)]
            public CreateInstanceRequestNetworkInfoInternetInfo InternetInfo { get; set; }
            public class CreateInstanceRequestNetworkInfoInternetInfo : TeaModel {
                /// <summary>
                /// <para>The Internet bandwidth specification. Unit: Mb/s.</para>
                /// <para>This parameter is required only when the Internet billing type is set to fixed bandwidth billing.</para>
                /// <para>Valid values: 1 to 1000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("flowOutBandwidth")]
                [Validation(Required=false)]
                public int? FlowOutBandwidth { get; set; }

                /// <summary>
                /// <para>The Internet billing type.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>uninvolved</para>
                /// </summary>
                [NameInMap("flowOutType")]
                [Validation(Required=false)]
                public string FlowOutType { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable public network access.</para>
                /// <para>By default, instances support VPC access. If you enable public network access, ApsaraMQ for RocketMQ charges fees for public network downstream bandwidth. For more information about billing, see <a href="https://help.aliyun.com/document_detail/427240.html">Public network access fees</a>.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>disable</para>
                /// </summary>
                [NameInMap("internetSpec")]
                [Validation(Required=false)]
                public string InternetSpec { get; set; }

                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>The public network access IP whitelist. Only public endpoints support IP whitelist configuration. VPC endpoints do not support this feature.</para>
                /// <list type="bullet">
                /// <item><description>If no IP whitelist is configured, all IP address ranges are allowed to access the ApsaraMQ for RocketMQ server over the Internet by default.</description></item>
                /// <item><description>If an IP whitelist is configured, only the IP addresses in the whitelist are allowed to access the ApsaraMQ for RocketMQ server over the Internet.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("ipWhitelist")]
                [Validation(Required=false)]
                [Obsolete]
                public List<string> IpWhitelist { get; set; }

            }

            /// <summary>
            /// <para>The VPC configuration information.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("vpcInfo")]
            [Validation(Required=false)]
            public CreateInstanceRequestNetworkInfoVpcInfo VpcInfo { get; set; }
            public class CreateInstanceRequestNetworkInfoVpcInfo : TeaModel {
                /// <summary>
                /// <para>The security group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-bp17hpmgz96tvnsdy6so</para>
                /// </summary>
                [NameInMap("securityGroupIds")]
                [Validation(Required=false)]
                public string SecurityGroupIds { get; set; }

                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>The ID of the vSwitch associated with the instance. If multiple vSwitches exist, separate them with vertical bars (|).</para>
                /// <remarks>
                /// <para>After an ApsaraMQ for RocketMQ instance is created, the selected vSwitch cannot be changed. To modify the associated vSwitch, release the existing ApsaraMQ for RocketMQ instance and purchase a new one.</para>
                /// </remarks>
                /// <para><notice>This field is not recommended. Use the vSwitches field instead.</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-uf6gwtbn6etadpv*******</para>
                /// </summary>
                [NameInMap("vSwitchId")]
                [Validation(Required=false)]
                [Obsolete]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The list of vSwitches.</para>
                /// <remarks>
                /// <para>After an ApsaraMQ for RocketMQ instance is created, the selected vSwitch cannot be changed. To modify the associated vSwitch, release the existing ApsaraMQ for RocketMQ instance and purchase a new one.</para>
                /// </remarks>
                /// <para><notice>This is a required field. Because the vSwitchId field is no longer recommended, use this field to configure vSwitches.</notice></para>
                /// </summary>
                [NameInMap("vSwitches")]
                [Validation(Required=false)]
                public List<CreateInstanceRequestNetworkInfoVpcInfoVSwitches> VSwitches { get; set; }
                public class CreateInstanceRequestNetworkInfoVpcInfoVSwitches : TeaModel {
                    /// <summary>
                    /// <para>The ID of the vSwitch associated with the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-uf6gwtbn6etadpv*******</para>
                    /// </summary>
                    [NameInMap("vSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                }

                /// <summary>
                /// <para>The ID of the VPC to associate with the instance.</para>
                /// <remarks>
                /// <para>After an ApsaraMQ for RocketMQ instance is created, the selected VPC cannot be changed. To modify the associated VPC, release the existing ApsaraMQ for RocketMQ instance and purchase a new one.</para>
                /// </remarks>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-wz9qt50xhtj9krb******</para>
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// <para>The billing method of the instance. ApsaraMQ for RocketMQ supports subscription and pay-as-you-go billing methods.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/427234.html">Billable methods</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Subscription</para>
        /// </summary>
        [NameInMap("paymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The subscription duration. This parameter takes effect only when the billing method of the instance is set to Subscription.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Monthly subscription: 1, 2, 3, 4, 5, 6</para>
        /// </description></item>
        /// <item><description><para>Yearly subscription: 1, 2, 3</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The minimum epoch unit of the subscription duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("periodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The instance specification information.</para>
        /// </summary>
        [NameInMap("productInfo")]
        [Validation(Required=false)]
        public CreateInstanceRequestProductInfo ProductInfo { get; set; }
        public class CreateInstanceRequestProductInfo : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable adaptive elasticity. A value of true indicates that adaptive elasticity is enabled. A value of false indicates that adaptive elasticity is shutdown.</para>
            /// </summary>
            [NameInMap("adaptiveElasticity")]
            [Validation(Required=false)]
            public bool? AdaptiveElasticity { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable burstable elastic capacity beyond the specification.</para>
            /// <para>After burstable elastic capacity is enabled, MSMQ for RocketMQ allows the instance to exceed the TPS limit of the base specification within a certain range. The portion that exceeds the base specification incurs additional elastic specification fees. For more information about billing, see <a href="https://help.aliyun.com/document_detail/427237.html">Computing fees</a>.</para>
            /// <remarks>
            /// <para>Only instances of certain specifications support burstable elastic capacity. For more information about supported instances, see <a href="https://help.aliyun.com/document_detail/444715.html">Instance specifications</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("autoScaling")]
            [Validation(Required=false)]
            public bool? AutoScaling { get; set; }

            /// <summary>
            /// <para>The capacity pattern.</para>
            /// 
            /// <b>Example:</b>
            /// <para>provisioned</para>
            /// </summary>
            [NameInMap("capacityType")]
            [Validation(Required=false)]
            public string CapacityType { get; set; }

            /// <summary>
            /// <para>The cross-region replication pattern.</para>
            /// 
            /// <b>Example:</b>
            /// <para>async_cross_az</para>
            /// </summary>
            [NameInMap("drReplicationMode")]
            [Validation(Required=false)]
            public string DrReplicationMode { get; set; }

            /// <summary>
            /// <para>The message retention period. Unit: hours.</para>
            /// <para>For the valid value range, see <a href="https://help.aliyun.com/document_detail/440347.html">Limits</a> &gt; Resource Quotas &gt; Message Retention Period.</para>
            /// <para>The log broker in MSMQ for RocketMQ is fully serverless and elastic. Fees are charged based on the actual storage space used. You can control the storage capacity by adjusting the message retention period. For more information, see <a href="https://help.aliyun.com/document_detail/427238.html">Storage fees</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>72</para>
            /// </summary>
            [NameInMap("messageRetentionTime")]
            [Validation(Required=false)]
            public int? MessageRetentionTime { get; set; }

            /// <summary>
            /// <para>The message sending and receiving computing specification. For more information about the TPS upper limit for message sending and receiving, see <a href="https://help.aliyun.com/document_detail/444715.html">Instance specifications</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rmq.s2.2xlarge</para>
            /// </summary>
            [NameInMap("msgProcessSpec")]
            [Validation(Required=false)]
            public string MsgProcessSpec { get; set; }

            /// <summary>
            /// <para>The provisioned capacity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5000</para>
            /// </summary>
            [NameInMap("provisionedCapacity")]
            [Validation(Required=false)]
            public long? ProvisionedCapacity { get; set; }

            /// <summary>
            /// <para>The ratio of message sending TPS to the total message sending and accepting TPS of the instance.</para>
            /// <para>For example, if the TPS upper limit for message sending and accepting of the instance is 1000 per second and the message sending ratio is 0.8, the TPS upper limit for message sending is 800 per second and the TPS upper limit for message accepting is 200 per second.</para>
            /// <para>Valid values: [0.05, 0.95]. Default value: 0.5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("sendReceiveRatio")]
            [Validation(Required=false)]
            public float? SendReceiveRatio { get; set; }

            /// <summary>
            /// <para>Indicates whether storage encryption is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("storageEncryption")]
            [Validation(Required=false)]
            public bool? StorageEncryption { get; set; }

            /// <summary>
            /// <para>The key for storage encryption.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxx</para>
            /// </summary>
            [NameInMap("storageSecretKey")]
            [Validation(Required=false)]
            public string StorageSecretKey { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the message trace feature.</para>
            /// <para>true: Enable the message trace feature.
            /// false: Shutdown the message trace feature.
            /// This parameter takes effect only for Serverless instances. If the message trace feature is enabled, message trace fees are incurred. For more information about billing, see the Serverless billing description. For pay-as-you-go and subscription instances, this parameter does not take effect. The message trace feature is supported by default regardless of whether this parameter is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("traceOn")]
            [Validation(Required=false)]
            public bool? TraceOn { get; set; }

        }

        /// <summary>
        /// <para>The remarks of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is the remark for test.</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzy6pist7uuna</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The primary series encoding of the instance. For more information about the differences between primary series, see <a href="https://help.aliyun.com/document_detail/444722.html">Product selection</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("seriesCode")]
        [Validation(Required=false)]
        public string SeriesCode { get; set; }

        /// <summary>
        /// <para>The service encoding of the instance. The service encoding for MSMQ for RocketMQ is rmq.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rmq</para>
        /// </summary>
        [NameInMap("serviceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// <para>The sub-series encoding of the instance. For more information about the differences between sub-series, see <a href="https://help.aliyun.com/document_detail/444722.html">Product selection</a>.</para>
        /// <para>If the primary series is set to ultimate (Platinum Edition), the sub-series can only be set to cluster_ha (Cluster High Availability Edition).</para>
        /// <remarks>
        /// <para>Notice: After the instance is created, the sub-series cannot be changed.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster_ha</para>
        /// </summary>
        [NameInMap("subSeriesCode")]
        [Validation(Required=false)]
        public string SubSeriesCode { get; set; }

        /// <summary>
        /// <para>The list of resource tags.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestTags> Tags { get; set; }
        public class CreateInstanceRequestTags : TeaModel {
            /// <summary>
            /// <para>The key of the resource tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxKey</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the resource tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxValue</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. The client generates the value of this parameter, which must be unique among different requests. The token can be up to 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c2c5d1274a8d4317a13bc5b0d4******</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
