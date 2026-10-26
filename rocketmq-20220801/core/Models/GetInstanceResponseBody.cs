// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class GetInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MissingInstanceId</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response result.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyData Data { get; set; }
        public class GetInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The account information.</para>
            /// </summary>
            [NameInMap("accountInfo")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyDataAccountInfo AccountInfo { get; set; }
            public class GetInstanceResponseBodyDataAccountInfo : TeaModel {
                /// <summary>
                /// <para>The username of the instance. When you use public network access, you must configure the username and password of the instance in the SDK code for identity verification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6W0xz2uPfiwp****</para>
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <para>The access control information.</para>
            /// </summary>
            [NameInMap("aclInfo")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyDataAclInfo AclInfo { get; set; }
            public class GetInstanceResponseBodyDataAclInfo : TeaModel {
                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>The authentication type of the instance. This parameter is deprecated. Use the aclTypes parameter instead.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("aclType")]
                [Validation(Required=false)]
                [Obsolete]
                public string AclType { get; set; }

                /// <summary>
                /// <para>The authentication types of the instance.</para>
                /// </summary>
                [NameInMap("aclTypes")]
                [Validation(Required=false)]
                public List<string> AclTypes { get; set; }

                /// <summary>
                /// <para>Indicates whether the authentication-free in VPC feature is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("defaultVpcAuthFree")]
                [Validation(Required=false)]
                public bool? DefaultVpcAuthFree { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether auto-renewal is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("autoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>Indicates whether auto-renewal is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("autoRenewPeriod")]
            [Validation(Required=false)]
            public int? AutoRenewPeriod { get; set; }

            /// <summary>
            /// <para>The BID of the sales channel for the commodity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26842</para>
            /// </summary>
            [NameInMap("bid")]
            [Validation(Required=false)]
            public string Bid { get; set; }

            /// <summary>
            /// <para>The commodity code of an MSMQ for RocketMQ 5.x series instance, such as ons_rmqsub_public_cn.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ons_rmqsub_public_cn</para>
            /// </summary>
            [NameInMap("commodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The time when the instance was created. The value is in the YYYY-MM-DD HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-01 00:00:00</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the instance expires. The format is YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-01 00:00:00</para>
            /// </summary>
            [NameInMap("expireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para><b>[Deprecated]</b> The extended configuration. This field is no longer recommended. Use the productInfo, internetInfo, and aclInfo fields instead.</para>
            /// </summary>
            [NameInMap("extConfig")]
            [Validation(Required=false)]
            [Obsolete]
            public GetInstanceResponseBodyDataExtConfig ExtConfig { get; set; }
            public class GetInstanceResponseBodyDataExtConfig : TeaModel {
                /// <summary>
                /// <para>The authentication type of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("aclType")]
                [Validation(Required=false)]
                public string AclType { get; set; }

                /// <summary>
                /// <para>Indicates whether burstable elastic capacity beyond the base specification is enabled.</para>
                /// <para>This parameter takes effect only when the value of supportAutoScaling is enable, which means the instance supports enabling elastic capacity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("autoScaling")]
                [Validation(Required=false)]
                public bool? AutoScaling { get; set; }

                /// <summary>
                /// <para>The Internet bandwidth specification. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("flowOutBandwidth")]
                [Validation(Required=false)]
                public int? FlowOutBandwidth { get; set; }

                /// <summary>
                /// <para>The billing type for public network usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>payByBandwidth</para>
                /// </summary>
                [NameInMap("flowOutType")]
                [Validation(Required=false)]
                public string FlowOutType { get; set; }

                /// <summary>
                /// <para>Indicates whether public network access is enabled.</para>
                /// <para>The instance supports VPC access by default. If public network access is enabled, ApsaraMQ for RocketMQ charges fees for public downstream bandwidth. For more information about billing, see <a href="https://help.aliyun.com/document_detail/427240.html">Public network access fees</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>enable</para>
                /// </summary>
                [NameInMap("internetSpec")]
                [Validation(Required=false)]
                public string InternetSpec { get; set; }

                /// <summary>
                /// <para>The message retention period. Unit: hours.</para>
                /// <para>For the value range, see <a href="https://help.aliyun.com/document_detail/440347.html">Limits</a> &gt; Resource Quotas &gt; Message retention period.</para>
                /// <para>The message storage of ApsaraMQ for RocketMQ is fully serverless and elastic. You are charged based on the actual storage space used. You can control the storage capacity by adjusting the message retention period. For more information, see <a href="https://help.aliyun.com/document_detail/427238.html">Storage fees</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>72</para>
                /// </summary>
                [NameInMap("messageRetentionTime")]
                [Validation(Required=false)]
                public int? MessageRetentionTime { get; set; }

                /// <summary>
                /// <para>The message processing specification. For the TPS upper limit of message sending and receiving, see <a href="https://help.aliyun.com/document_detail/444715.html">Instance specifications</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rmq.s2.2xlarge</para>
                /// </summary>
                [NameInMap("msgProcessSpec")]
                [Validation(Required=false)]
                public string MsgProcessSpec { get; set; }

                /// <summary>
                /// <para>The ratio of message sending to message receiving.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("sendReceiveRatio")]
                [Validation(Required=false)]
                public float? SendReceiveRatio { get; set; }

                /// <summary>
                /// <para>Indicates whether the instance supports enabling burstable elastic capacity beyond the base specification.</para>
                /// <para>After burstable elastic capacity is enabled, ApsaraMQ for RocketMQ allows the instance to exceed the TPS limit of the base specification within a certain range. Additional elastic specification fees are charged for the portion that exceeds the base specification. For more information about billing, see <a href="https://help.aliyun.com/document_detail/427237.html">Computing fees</a>.</para>
                /// <remarks>
                /// <para>Only instances of specific specifications support burstable elastic capacity. For more information about supported instances, see <a href="https://help.aliyun.com/document_detail/444715.html">Instance specifications</a>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("supportAutoScaling")]
                [Validation(Required=false)]
                public bool? SupportAutoScaling { get; set; }

            }

            /// <summary>
            /// <para>The number of consumer groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("groupCount")]
            [Validation(Required=false)]
            public long? GroupCount { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rmq-cn-7e22ody****</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test instance</para>
            /// </summary>
            [NameInMap("instanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The capacity information.</para>
            /// </summary>
            [NameInMap("instanceQuotas")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyDataInstanceQuotas> InstanceQuotas { get; set; }
            public class GetInstanceResponseBodyDataInstanceQuotas : TeaModel {
                /// <summary>
                /// <para>The free quota. Unit: count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("freeCount")]
                [Validation(Required=false)]
                public double? FreeCount { get; set; }

                /// <summary>
                /// <para>The quota name of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TOPIC_COUNT</para>
                /// </summary>
                [NameInMap("quotaName")]
                [Validation(Required=false)]
                public string QuotaName { get; set; }

                /// <summary>
                /// <para>The total quota. Unit: count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("totalCount")]
                [Validation(Required=false)]
                public double? TotalCount { get; set; }

                /// <summary>
                /// <para>The used quota. Unit: count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("usedCount")]
                [Validation(Required=false)]
                public double? UsedCount { get; set; }

            }

            /// <summary>
            /// <para>The network information.</para>
            /// </summary>
            [NameInMap("networkInfo")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyDataNetworkInfo NetworkInfo { get; set; }
            public class GetInstanceResponseBodyDataNetworkInfo : TeaModel {
                /// <summary>
                /// <para>The endpoint information.</para>
                /// </summary>
                [NameInMap("endpoints")]
                [Validation(Required=false)]
                public List<GetInstanceResponseBodyDataNetworkInfoEndpoints> Endpoints { get; set; }
                public class GetInstanceResponseBodyDataNetworkInfoEndpoints : TeaModel {
                    /// <summary>
                    /// <para>The associated PrivateLink endpoint instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ep-bpxxx</para>
                    /// </summary>
                    [NameInMap("endpointId")]
                    [Validation(Required=false)]
                    public string EndpointId { get; set; }

                    /// <summary>
                    /// <para>The endpoint type of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TCP_INTERNET</para>
                    /// </summary>
                    [NameInMap("endpointType")]
                    [Validation(Required=false)]
                    public string EndpointType { get; set; }

                    /// <summary>
                    /// <para>The endpoint of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rmq-cn-c4d2tbk****-vpc.cn-hangzhou.rmq.aliyuncs.com:8080</para>
                    /// </summary>
                    [NameInMap("endpointUrl")]
                    [Validation(Required=false)]
                    public string EndpointUrl { get; set; }

                    /// <summary>
                    /// <para>The IP whitelist for public network access. IP whitelists are supported only for Internet endpoints and are not supported for VPC endpoints.</para>
                    /// <list type="bullet">
                    /// <item><description>If no IP whitelist is configured, all IP address ranges are allowed to access the MSMQ for RocketMQ queue broker over the Internet by default.</description></item>
                    /// <item><description>If an IP whitelist is configured, only IP addresses in the whitelist are allowed to access the MSMQ for RocketMQ queue broker over the Internet.</description></item>
                    /// </list>
                    /// <para>This field is no longer recommended. Use the internetInfo.ipWhitelist field instead.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.168.x.x/24</para>
                    /// </summary>
                    [NameInMap("ipWhitelist")]
                    [Validation(Required=false)]
                    public List<string> IpWhitelist { get; set; }

                }

                /// <summary>
                /// <para>The public network information of the instance.</para>
                /// </summary>
                [NameInMap("internetInfo")]
                [Validation(Required=false)]
                public GetInstanceResponseBodyDataNetworkInfoInternetInfo InternetInfo { get; set; }
                public class GetInstanceResponseBodyDataNetworkInfoInternetInfo : TeaModel {
                    /// <summary>
                    /// <para>The Internet bandwidth specification. Unit: Mbit/s.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("flowOutBandwidth")]
                    [Validation(Required=false)]
                    public int? FlowOutBandwidth { get; set; }

                    /// <summary>
                    /// <para>The billing type for public network usage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>payByBandwidth</para>
                    /// </summary>
                    [NameInMap("flowOutType")]
                    [Validation(Required=false)]
                    public string FlowOutType { get; set; }

                    /// <summary>
                    /// <para>Indicates whether public network access is enabled.</para>
                    /// <para>The instance supports VPC access by default. If public network access is enabled, ApsaraMQ for RocketMQ charges fees for public downstream bandwidth. For more information about billing, see <a href="https://help.aliyun.com/document_detail/427240.html">Public network access fees</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>enable</para>
                    /// </summary>
                    [NameInMap("internetSpec")]
                    [Validation(Required=false)]
                    public string InternetSpec { get; set; }

                    /// <summary>
                    /// <para>The IP whitelist for public network access.</para>
                    /// <list type="bullet">
                    /// <item><description>If the IP whitelist is not configured, all IP address ranges are allowed to access the ApsaraMQ for RocketMQ broker over the public network by default.</description></item>
                    /// <item><description>If the IP whitelist is configured, only the IP addresses in the whitelist are allowed to access the ApsaraMQ for RocketMQ broker over the public network.</description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("ipWhitelist")]
                    [Validation(Required=false)]
                    public List<string> IpWhitelist { get; set; }

                }

                /// <summary>
                /// <para>The VPC information.</para>
                /// </summary>
                [NameInMap("vpcInfo")]
                [Validation(Required=false)]
                public GetInstanceResponseBodyDataNetworkInfoVpcInfo VpcInfo { get; set; }
                public class GetInstanceResponseBodyDataNetworkInfoVpcInfo : TeaModel {
                    /// <summary>
                    /// <para>The security group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sg-hp35r2hc3a3sv8q2sb16</para>
                    /// </summary>
                    [NameInMap("securityGroupIds")]
                    [Validation(Required=false)]
                    public string SecurityGroupIds { get; set; }

                    /// <term><b>Obsolete</b></term>
                    /// 
                    /// <summary>
                    /// <para>The ID of the vSwitch associated with the instance.</para>
                    /// <para><notice>This field is not recommended. Use the vSwitches field instead. For compatibility, this field currently returns only one vSwitch.</notice></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-uf6gwtbn6etadpvz7****</para>
                    /// </summary>
                    [NameInMap("vSwitchId")]
                    [Validation(Required=false)]
                    [Obsolete]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// <para>The list of vSwitches.</para>
                    /// </summary>
                    [NameInMap("vSwitches")]
                    [Validation(Required=false)]
                    public List<GetInstanceResponseBodyDataNetworkInfoVpcInfoVSwitches> VSwitches { get; set; }
                    public class GetInstanceResponseBodyDataNetworkInfoVpcInfoVSwitches : TeaModel {
                        /// <summary>
                        /// <para>The vSwitch ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vsw-uf6gwtbn6etadpvz7****</para>
                        /// </summary>
                        [NameInMap("vSwitchId")]
                        [Validation(Required=false)]
                        public string VSwitchId { get; set; }

                        /// <summary>
                        /// <para>The zone ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou</para>
                        /// </summary>
                        [NameInMap("zoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                    /// <summary>
                    /// <para>The ID of the VPC associated with the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-uf6of9452b2pba82c****</para>
                    /// </summary>
                    [NameInMap("vpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

            }

            /// <summary>
            /// <para>The payment type of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Subscription</para>
            /// </summary>
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// <para>The extended configuration of the instance.</para>
            /// </summary>
            [NameInMap("productInfo")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyDataProductInfo ProductInfo { get; set; }
            public class GetInstanceResponseBodyDataProductInfo : TeaModel {
                /// <summary>
                /// <para>The adaptive elasticity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("adaptiveElasticity")]
                [Validation(Required=false)]
                public bool? AdaptiveElasticity { get; set; }

                /// <summary>
                /// <para>Indicates whether burstable elastic capacity beyond the base specification is enabled for seamless scaling.</para>
                /// <para>This parameter takes effect only when the value of supportAutoScaling is enable, which means the instance supports enabling elastic capacity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("autoScaling")]
                [Validation(Required=false)]
                public bool? AutoScaling { get; set; }

                /// <summary>
                /// <para>The capacity mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>provisioned</para>
                /// </summary>
                [NameInMap("capacityType")]
                [Validation(Required=false)]
                public string CapacityType { get; set; }

                /// <summary>
                /// <para>The cross-region replication mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>async_cross_az</para>
                /// </summary>
                [NameInMap("drReplicationMode")]
                [Validation(Required=false)]
                public string DrReplicationMode { get; set; }

                /// <summary>
                /// <para>The maximum interval for scheduled messages. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3456000</para>
                /// </summary>
                [NameInMap("maxDelayTime")]
                [Validation(Required=false)]
                public int? MaxDelayTime { get; set; }

                /// <summary>
                /// <para>The message retention period. Unit: hours.</para>
                /// <para>For the value range, see <a href="https://help.aliyun.com/document_detail/440347.html">Limits</a> &gt; Resource Quotas &gt; Message retention period.</para>
                /// <para>The message storage of ApsaraMQ for RocketMQ is fully serverless and elastic. You are charged based on the actual storage space used. You can control the storage capacity by adjusting the message retention period. For more information, see <a href="https://help.aliyun.com/document_detail/427238.html">Storage fees</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>72</para>
                /// </summary>
                [NameInMap("messageRetentionTime")]
                [Validation(Required=false)]
                public int? MessageRetentionTime { get; set; }

                /// <summary>
                /// <para>The message processing specification. For the TPS upper limit of message sending and receiving, see <a href="https://help.aliyun.com/document_detail/444715.html">Instance specifications</a>.</para>
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
                /// <para>3000</para>
                /// </summary>
                [NameInMap("provisionedCapacity")]
                [Validation(Required=false)]
                public long? ProvisionedCapacity { get; set; }

                /// <summary>
                /// <para>The ratio of message sending to message receiving.</para>
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
                /// <para>The storage encryption key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxxx</para>
                /// </summary>
                [NameInMap("storageSecretKey")]
                [Validation(Required=false)]
                public string StorageSecretKey { get; set; }

                /// <summary>
                /// <para>Indicates whether the burstable elastic capability beyond the base specification is enabled.</para>
                /// <para>After the burstable elastic capability is enabled, ApsaraMQ for RocketMQ allows the instance to exceed the TPS limit of the base specification within a certain range. Additional elastic specification fees are charged for the portion that exceeds the base specification. For more information about billing, see <a href="https://help.aliyun.com/document_detail/427237.html">Computing capability fees</a>.</para>
                /// <remarks>
                /// <para>Only instances of specific specifications support the burstable elastic capability. For more information about supported instances, see <a href="https://help.aliyun.com/document_detail/444715.html">Instance specifications</a>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("supportAutoScaling")]
                [Validation(Required=false)]
                public bool? SupportAutoScaling { get; set; }

                /// <summary>
                /// <para>Indicates whether the message trace feature is enabled.</para>
                /// <list type="bullet">
                /// <item><description>true: The message trace feature is enabled.</description></item>
                /// <item><description>false: The message trace feature is disabled.</description></item>
                /// </list>
                /// <para>&lt;props=&quot;intl&quot;&gt;This parameter does not take effect. Instances support the message trace feature by default regardless of whether this parameter is enabled.
                /// &lt;props=&quot;china&quot;&gt;This parameter takes effect only for Serverless instances. If the message trace feature is enabled, message trace fees are incurred. For more information about billing, see <a href="https://help.aliyun.com/document_detail/2586280.html">Serverless billing</a>.</para>
                /// <para>&lt;props=&quot;china&quot;&gt;For pay-as-you-go and subscription instances, this parameter does not take effect. The message trace feature is supported by default regardless of whether this parameter is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("traceOn")]
                [Validation(Required=false)]
                public bool? TraceOn { get; set; }

            }

            /// <summary>
            /// <para>The ID of the region where the instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The time when the instance was released. The format is YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-07 00:00:00</para>
            /// </summary>
            [NameInMap("releaseTime")]
            [Validation(Required=false)]
            public string ReleaseTime { get; set; }

            /// <summary>
            /// <para>The remarks for the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is remark for instance.</para>
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfm3tmjruyribi</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The primary series code of the instance. For differences between primary series, see <a href="https://help.aliyun.com/document_detail/444722.html">Product selection</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("seriesCode")]
            [Validation(Required=false)]
            public string SeriesCode { get; set; }

            /// <summary>
            /// <para>The service code of the instance. The service code for MSMQ for RocketMQ is rmq.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rmq</para>
            /// </summary>
            [NameInMap("serviceCode")]
            [Validation(Required=false)]
            public string ServiceCode { get; set; }

            /// <summary>
            /// <para>The instance software information.</para>
            /// </summary>
            [NameInMap("software")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyDataSoftware Software { get; set; }
            public class GetInstanceResponseBodyDataSoftware : TeaModel {
                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>The upgrade time window, in the format of HH:mm-HH:mm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>02:00-06:00</para>
                /// </summary>
                [NameInMap("maintainTime")]
                [Validation(Required=false)]
                [Obsolete]
                public string MaintainTime { get; set; }

                /// <summary>
                /// <para>The software version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.0-rmq-20230619-1</para>
                /// </summary>
                [NameInMap("softwareVersion")]
                [Validation(Required=false)]
                public string SoftwareVersion { get; set; }

                /// <summary>
                /// <para>The upgrade method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>auto</para>
                /// </summary>
                [NameInMap("upgradeMethod")]
                [Validation(Required=false)]
                public string UpgradeMethod { get; set; }

            }

            /// <summary>
            /// <para>The time when the instance was started. The format is YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-01 00:00:00</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The instance status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The sub-series code of the instance. For differences between sub-series, see <a href="https://help.aliyun.com/document_detail/444722.html">Product selection</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster_ha</para>
            /// </summary>
            [NameInMap("subSeriesCode")]
            [Validation(Required=false)]
            public string SubSeriesCode { get; set; }

            /// <summary>
            /// <para>The resource tags.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyDataTags> Tags { get; set; }
            public class GetInstanceResponseBodyDataTags : TeaModel {
                /// <summary>
                /// <para>The key of the resource tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the resource tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The number of topics.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("topicCount")]
            [Validation(Required=false)]
            public long? TopicCount { get; set; }

            /// <summary>
            /// <para>The time when the instance was last modified. The value is in the YYYY-MM-DD HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-02 00:00:00</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The ID of the user to whom the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111111111111111</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InstanceId</para>
        /// </summary>
        [NameInMap("dynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instanceId</para>
        /// </summary>
        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Parameter instanceId is mandatory for this action .</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. Each request has a unique ID, which you can use to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05AB7FBD-F1D3-5D87-BF78-BD782249****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
