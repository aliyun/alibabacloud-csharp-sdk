// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class GetInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MissingInstanceId</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
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
                /// <para>The username of the instance. If you access a ApsaraMQ for RocketMQ instance over the Internet, you must configure the username and password of the instance in the SDK code for authentication.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6W0xz2uPfiwp****</para>
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <para>The information about access control.</para>
            /// </summary>
            [NameInMap("aclInfo")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyDataAclInfo AclInfo { get; set; }
            public class GetInstanceResponseBodyDataAclInfo : TeaModel {
                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>The authentication type of the instance. This parameter is no longer in use. We recommend that you configure aclTypes.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>default: intelligent identity authentication</para>
                /// </description></item>
                /// <item><description><para>apache_acl:access control list (ACL) identity authentication**</para>
                /// </description></item>
                /// </list>
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
                /// <para>Indicates whether the authentication-free in VPCs feature is enabled.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- -->
                /// </description></item>
                /// <item><description><para>false</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- --></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("defaultVpcAuthFree")]
                [Validation(Required=false)]
                public bool? DefaultVpcAuthFree { get; set; }

            }

            /// <summary>
            /// <para>The business ID (BID) of the commodity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26842</para>
            /// </summary>
            [NameInMap("bid")]
            [Validation(Required=false)]
            public string Bid { get; set; }

            /// <summary>
            /// <para>The commodity code of the instance. The commodity code of a ApsaraMQ for RocketMQ 5.0 instance has a similar format as ons_rmqsub_public_cn.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ons_rmqsub_public_cn</para>
            /// </summary>
            [NameInMap("commodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-01 00:00:00</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the instance expires.</para>
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
            /// <para>The extended configurations. We recommend you configure productInfo, internetInfo, or aclInfo instead of this parameter.</para>
            /// </summary>
            [NameInMap("extConfig")]
            [Validation(Required=false)]
            [Obsolete]
            public GetInstanceResponseBodyDataExtConfig ExtConfig { get; set; }
            public class GetInstanceResponseBodyDataExtConfig : TeaModel {
                /// <summary>
                /// <para>The authentication type of the instance.</para>
                /// <para>Valid value:</para>
                /// <list type="bullet">
                /// <item><description>default: intelligent authentication</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("aclType")]
                [Validation(Required=false)]
                public string AclType { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable the elastic TPS feature for the instance.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: enable</description></item>
                /// <item><description>false: disable</description></item>
                /// </list>
                /// <para>This parameter is valid only when the supportAutoScaling parameter is set to enable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("autoScaling")]
                [Validation(Required=false)]
                public bool? AutoScaling { get; set; }

                /// <summary>
                /// <para>The Internet bandwidth. Unit: MB/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("flowOutBandwidth")]
                [Validation(Required=false)]
                public int? FlowOutBandwidth { get; set; }

                /// <summary>
                /// <para>The metering method of Internet usage.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PayByTraffic: pay-by-traffic</description></item>
                /// <item><description>paybybandwidth: pay-by-bandwidth</description></item>
                /// <item><description>uninvolved: N/A</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>payByBandwidth</para>
                /// </summary>
                [NameInMap("flowOutType")]
                [Validation(Required=false)]
                public string FlowOutType { get; set; }

                /// <summary>
                /// <para>Indicates whether Internet access is enabled.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>enable</description></item>
                /// <item><description>disable</description></item>
                /// </list>
                /// <para>By default, you can access ApsaraMQ for RocketMQ instances in virtual private clouds (VPCs). If you enable the Internet access feature, you are charged for Internet outbound bandwidth. For more information, see <a href="https://help.aliyun.com/document_detail/427240.html">Internet access fees</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>enable</para>
                /// </summary>
                [NameInMap("internetSpec")]
                [Validation(Required=false)]
                public string InternetSpec { get; set; }

                /// <summary>
                /// <para>The retention period of messages. Unit: hours.</para>
                /// <para>For information about the valid values of this parameter, see the &quot;Limits on resource quotas&quot; section in <a href="https://help.aliyun.com/document_detail/440347.html">Usage limits</a>.</para>
                /// <para>The storage of messages in ApsaraMQ for RocketMQ is serverless and scalable. You are charged for message storage based on your actual usage. You can change the retention period of messages to adjust storage capacity. For more information, see <a href="https://help.aliyun.com/document_detail/427238.html">Storage fee</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>72</para>
                /// </summary>
                [NameInMap("messageRetentionTime")]
                [Validation(Required=false)]
                public int? MessageRetentionTime { get; set; }

                /// <summary>
                /// <para>The computing specification that is used to send and receive messages. For information about the upper limit of TPS, see <a href="https://help.aliyun.com/document_detail/444715.html">Instance specifications</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rmq.s2.2xlarge</para>
                /// </summary>
                [NameInMap("msgProcessSpec")]
                [Validation(Required=false)]
                public string MsgProcessSpec { get; set; }

                /// <summary>
                /// <para>The ratio between sent messages and received messages in the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("sendReceiveRatio")]
                [Validation(Required=false)]
                public float? SendReceiveRatio { get; set; }

                /// <summary>
                /// <para>Specifies whether the elastic TPS feature is supported by the instance.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: enable</description></item>
                /// <item><description>false: disable</description></item>
                /// </list>
                /// <para>After you enable the elastic TPS feature for a ApsaraMQ for RocketMQ instance, you can use a specific amount of TPS that exceeds the specification limit. You are charged for the elastic TPS feature. For more information, see <a href="https://help.aliyun.com/document_detail/427237.html">Computing fee</a>.</para>
                /// <remarks>
                /// <para>The elastic TPS feature is supported only by specific instance editions. For more information, see <a href="https://help.aliyun.com/document_detail/444715.html">Instance specifications</a>.</para>
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
            /// <para>The number of groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("groupCount")]
            [Validation(Required=false)]
            public long? GroupCount { get; set; }

            /// <summary>
            /// <para>The ID of the instance</para>
            /// 
            /// <b>Example:</b>
            /// <para>rmq-cn-7e22ody****</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test instance</para>
            /// </summary>
            [NameInMap("instanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The instance quotas.</para>
            /// </summary>
            [NameInMap("instanceQuotas")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyDataInstanceQuotas> InstanceQuotas { get; set; }
            public class GetInstanceResponseBodyDataInstanceQuotas : TeaModel {
                /// <summary>
                /// <para>The number of topics that are free of charge on the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("freeCount")]
                [Validation(Required=false)]
                public double? FreeCount { get; set; }

                /// <summary>
                /// <para>The quota name.</para>
                /// <para>Valid value:</para>
                /// <list type="bullet">
                /// <item><description>TOPIC_COUNT: the number of topics that can be created on the instance</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TOPIC_COUNT</para>
                /// </summary>
                [NameInMap("quotaName")]
                [Validation(Required=false)]
                public string QuotaName { get; set; }

                /// <summary>
                /// <para>The total number of topics on the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("totalCount")]
                [Validation(Required=false)]
                public double? TotalCount { get; set; }

                /// <summary>
                /// <para>The number of used topics on the instance.</para>
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
                /// <para>The endpoints.</para>
                /// </summary>
                [NameInMap("endpoints")]
                [Validation(Required=false)]
                public List<GetInstanceResponseBodyDataNetworkInfoEndpoints> Endpoints { get; set; }
                public class GetInstanceResponseBodyDataNetworkInfoEndpoints : TeaModel {
                    /// <summary>
                    /// <para>The type of the endpoint that is used to access the instance.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>TCP_VPC: VPC endpoint</description></item>
                    /// <item><description>TCP_INTERNET: public endpoint</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TCP_INTERNET</para>
                    /// </summary>
                    [NameInMap("endpointType")]
                    [Validation(Required=false)]
                    public string EndpointType { get; set; }

                    /// <summary>
                    /// <para>The endpoint that is used to access the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rmq-cn-c4d2tbk****-vpc.cn-hangzhou.rmq.aliyuncs.com:8080</para>
                    /// </summary>
                    [NameInMap("endpointUrl")]
                    [Validation(Required=false)]
                    public string EndpointUrl { get; set; }

                    /// <summary>
                    /// <para>The whitelist that includes the IP addresses that are allowed to access the ApsaraMQ for RocketMQ broker over the Internet. This parameter can be configured only if you use the public endpoint to access the instance.</para>
                    /// <list type="bullet">
                    /// <item><description>If you do not configure an IP address whitelist, all CIDR blocks are allowed to access the ApsaraMQ for RocketMQ broker over the Internet.</description></item>
                    /// <item><description>If you configure an IP address whitelist, only the IP addresses in the whitelist are allowed to access the ApsaraMQ for RocketMQ broker over the Internet.</description></item>
                    /// </list>
                    /// <para>We recommend that you configure internetInfo.ipWhitelist instead of this parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.168.x.x/24</para>
                    /// </summary>
                    [NameInMap("ipWhitelist")]
                    [Validation(Required=false)]
                    public List<string> IpWhitelist { get; set; }

                }

                /// <summary>
                /// <para>The information about the Internet.</para>
                /// </summary>
                [NameInMap("internetInfo")]
                [Validation(Required=false)]
                public GetInstanceResponseBodyDataNetworkInfoInternetInfo InternetInfo { get; set; }
                public class GetInstanceResponseBodyDataNetworkInfoInternetInfo : TeaModel {
                    /// <summary>
                    /// <para>The Internet bandwidth. Unit: MB/s.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("flowOutBandwidth")]
                    [Validation(Required=false)]
                    public int? FlowOutBandwidth { get; set; }

                    /// <summary>
                    /// <para>The metering method for Internet usage.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>PayByBandwidth: pay-by-bandwidth. If the Internet access feature is enabled, specify this value for the parameter.</description></item>
                    /// <item><description>uninvolved: N/A. If the Internet access feature is not enabled, specify this value for the parameter.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>payByBandwidth</para>
                    /// </summary>
                    [NameInMap("flowOutType")]
                    [Validation(Required=false)]
                    public string FlowOutType { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to enable the Internet access feature.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>enable</description></item>
                    /// <item><description>disable</description></item>
                    /// </list>
                    /// <para>By default, ApsaraMQ for RocketMQ instances are accessed in virtual private clouds (VPCs). If you enable the Internet access feature, you are charged for Internet outbound bandwidth. For more information, see <a href="https://help.aliyun.com/document_detail/427240.html">Internet access fee</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>enable</para>
                    /// </summary>
                    [NameInMap("internetSpec")]
                    [Validation(Required=false)]
                    public string InternetSpec { get; set; }

                    /// <summary>
                    /// <para>The whitelist that includes the IP addresses that are allowed to access the ApsaraMQ for RocketMQ broker.</para>
                    /// <list type="bullet">
                    /// <item><description>If this parameter is not configured, all IP addresses are allowed to access the ApsaraMQ for RocketMQ broker over the Internet.</description></item>
                    /// <item><description>If this parameter is configured, only the IP addresses that are included in the whitelist can access the ApsaraMQ for RocketMQ broker over the Internet.</description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("ipWhitelist")]
                    [Validation(Required=false)]
                    public List<string> IpWhitelist { get; set; }

                }

                /// <summary>
                /// <para>The virtual private cloud (VPC) information.</para>
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
                    /// <para>The ID of the vSwitch with which the instance is associated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-uf6gwtbn6etadpvz7****</para>
                    /// </summary>
                    [NameInMap("vSwitchId")]
                    [Validation(Required=false)]
                    [Obsolete]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// <para>The vSwitches.</para>
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
                    /// <para>The ID of the VPC with which the instance is associated.</para>
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
            /// <para>The billing method of the instance.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PayAsYouGo</description></item>
            /// <item><description>Subscription</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Subscription</para>
            /// </summary>
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// <para>The extended configurations of the instance.</para>
            /// </summary>
            [NameInMap("productInfo")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyDataProductInfo ProductInfo { get; set; }
            public class GetInstanceResponseBodyDataProductInfo : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable the elastic TPS feature for the instance.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: enable</description></item>
                /// <item><description>false: disable</description></item>
                /// </list>
                /// <para>This parameter is valid only when the supportAutoScaling parameter is set to enable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("autoScaling")]
                [Validation(Required=false)]
                public bool? AutoScaling { get; set; }

                [NameInMap("capacityType")]
                [Validation(Required=false)]
                public string CapacityType { get; set; }

                /// <summary>
                /// <para>The retention period of messages. Unit: hours.</para>
                /// <para>For information about the valid values of this parameter, see the &quot;Limits on resource quotas&quot; section in <a href="https://help.aliyun.com/document_detail/440347.html">Usage limits</a>.</para>
                /// <para>The storage of messages in ApsaraMQ for RocketMQ is serverless and scalable. You are charged for message storage based on your actual usage. You can change the retention period of messages to adjust storage capacity. For more information, see <a href="https://help.aliyun.com/document_detail/427238.html">Storage fee</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>72</para>
                /// </summary>
                [NameInMap("messageRetentionTime")]
                [Validation(Required=false)]
                public int? MessageRetentionTime { get; set; }

                /// <summary>
                /// <para>The computing specification that is used to send and receive messages. For information about the upper limit of TPS, see <a href="https://help.aliyun.com/document_detail/444715.html">Instance specifications</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rmq.s2.2xlarge</para>
                /// </summary>
                [NameInMap("msgProcessSpec")]
                [Validation(Required=false)]
                public string MsgProcessSpec { get; set; }

                [NameInMap("provisionedCapacity")]
                [Validation(Required=false)]
                public long? ProvisionedCapacity { get; set; }

                /// <summary>
                /// <para>The ratio between sent messages and received messages in the instance.</para>
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
                /// <para>Specifies whether to enable the elastic TPS feature for the instance.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: enable</description></item>
                /// <item><description>false: disable</description></item>
                /// </list>
                /// <para>After you enable the elastic TPS feature for a ApsaraMQ for RocketMQ instance, you can use a specific amount of TPS that exceeds the specification limit. You are charged for the elastic TPS feature. For more information, see <a href="https://help.aliyun.com/document_detail/427237.html">Computing fee</a>.</para>
                /// <remarks>
                /// <para>The elastic TPS feature is supported by only specific instance editions. For more information, see <a href="https://help.aliyun.com/document_detail/444715.html">Instance specifications</a>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("supportAutoScaling")]
                [Validation(Required=false)]
                public bool? SupportAutoScaling { get; set; }

                /// <summary>
                /// <para>Indicates whether the message trace feature is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// <para>This parameter is not in use. By default, the message trace feature is enabled for ApsaraMQ for RocketMQ instances, regardless of whether this parameter is configured.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("traceOn")]
                [Validation(Required=false)]
                public bool? TraceOn { get; set; }

            }

            /// <summary>
            /// <para>The ID of the region in which the instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The time when the instance was released.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-07 00:00:00</para>
            /// </summary>
            [NameInMap("releaseTime")]
            [Validation(Required=false)]
            public string ReleaseTime { get; set; }

            /// <summary>
            /// <para>The description of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is remark for instance.</para>
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfm3tmjruyribi</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The primary edition of the instance. For information about the differences between primary edition instances, see <a href="https://help.aliyun.com/document_detail/444722.html">Instance selection</a>.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>standard: Standard Edition</description></item>
            /// <item><description>ultimate: Enterprise Platinum Edition</description></item>
            /// <item><description>professional: Professional Edition</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("seriesCode")]
            [Validation(Required=false)]
            public string SeriesCode { get; set; }

            /// <summary>
            /// <para>The code of the service to which the instance belongs. The service code of ApsaraMQ for RocketMQ is rmq.</para>
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
                /// <summary>
                /// <para>The period of upgrade time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>02:00-06:00</para>
                /// </summary>
                [NameInMap("maintainTime")]
                [Validation(Required=false)]
                public string MaintainTime { get; set; }

                /// <summary>
                /// <para>The version of software.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.0-rmq-20230619-1</para>
                /// </summary>
                [NameInMap("softwareVersion")]
                [Validation(Required=false)]
                public string SoftwareVersion { get; set; }

                /// <summary>
                /// <para>The upgrade method.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Auto: automatic upgrade</para>
                /// </description></item>
                /// <item><description><para>Manual: manual upgrade</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>auto</para>
                /// </summary>
                [NameInMap("upgradeMethod")]
                [Validation(Required=false)]
                public string UpgradeMethod { get; set; }

            }

            /// <summary>
            /// <para>The time when the instance was started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-01 00:00:00</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status of the instance.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RELEASED</description></item>
            /// <item><description>RUNNING</description></item>
            /// <item><description>STOPPED</description></item>
            /// <item><description>CHANGING</description></item>
            /// <item><description>CREATING</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The sub-category edition of the instance. For information about the differences between sub-category edition instances, see <a href="https://help.aliyun.com/document_detail/444722.html">Instance selection</a>.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cluster_ha: Cluster High-availability Edition</description></item>
            /// <item><description>single_node: Standalone Edition</description></item>
            /// </list>
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
                /// <para>The tag key of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the resource.</para>
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
            /// <para>The time when the instance was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-02 00:00:00</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The ID of the user who owns the instance.</para>
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
        /// <para>The HTTP status code returned.</para>
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
        /// <para>The ID of the request. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05AB7FBD-F1D3-5D87-BF78-BD782249****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
