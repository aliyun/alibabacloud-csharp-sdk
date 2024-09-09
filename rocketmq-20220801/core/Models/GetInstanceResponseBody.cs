// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class GetInstanceResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call failed.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyData Data { get; set; }
        public class GetInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// The account information.
            /// </summary>
            [NameInMap("accountInfo")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyDataAccountInfo AccountInfo { get; set; }
            public class GetInstanceResponseBodyDataAccountInfo : TeaModel {
                /// <summary>
                /// The username of the instance. If you access a ApsaraMQ for RocketMQ instance over the Internet, you must configure the username and password of the instance in the SDK code for authentication.
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// The information about access control.
            /// </summary>
            [NameInMap("aclInfo")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyDataAclInfo AclInfo { get; set; }
            public class GetInstanceResponseBodyDataAclInfo : TeaModel {
                /// <summary>
                /// The authentication type of the instance. This parameter is no longer in use. We recommend that you configure aclTypes.
                /// 
                /// Valid values:
                /// 
                /// - default: intelligent identity authentication
                /// 
                /// - apache_acl:access control list (ACL) identity authentication**
                /// </summary>
                [NameInMap("aclType")]
                [Validation(Required=false)]
                [Obsolete]
                public string AclType { get; set; }

                /// <summary>
                /// The authentication types of the instance.
                /// </summary>
                [NameInMap("aclTypes")]
                [Validation(Required=false)]
                public List<string> AclTypes { get; set; }

                /// <summary>
                /// Indicates whether the authentication-free in VPCs feature is enabled.
                /// 
                /// Valid values:
                /// 
                /// *   true
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   false
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// </summary>
                [NameInMap("defaultVpcAuthFree")]
                [Validation(Required=false)]
                public bool? DefaultVpcAuthFree { get; set; }

            }

            /// <summary>
            /// The business ID (BID) of the commodity.
            /// </summary>
            [NameInMap("bid")]
            [Validation(Required=false)]
            public string Bid { get; set; }

            /// <summary>
            /// The commodity code of the instance. The commodity code of a ApsaraMQ for RocketMQ 5.0 instance has a similar format as ons_rmqsub_public_cn.
            /// </summary>
            [NameInMap("commodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// The time when the instance was created.
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The time when the instance expires.
            /// </summary>
            [NameInMap("expireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// The extended configurations. We recommend you configure productInfo, internetInfo, or aclInfo instead of this parameter.
            /// </summary>
            [NameInMap("extConfig")]
            [Validation(Required=false)]
            [Obsolete]
            public GetInstanceResponseBodyDataExtConfig ExtConfig { get; set; }
            public class GetInstanceResponseBodyDataExtConfig : TeaModel {
                /// <summary>
                /// The authentication type of the instance.
                /// 
                /// Valid values:
                /// 
                /// *   default: intelligent authentication
                /// </summary>
                [NameInMap("aclType")]
                [Validation(Required=false)]
                public string AclType { get; set; }

                /// <summary>
                /// Specifies whether to enable the elastic TPS feature for the instance.
                /// 
                /// Valid values:
                /// 
                /// *   true: enable
                /// *   false: disable
                /// 
                /// This parameter is valid only when the supportAutoScaling parameter is set to enable.
                /// </summary>
                [NameInMap("autoScaling")]
                [Validation(Required=false)]
                public bool? AutoScaling { get; set; }

                /// <summary>
                /// The Internet bandwidth. Unit: MB/s.
                /// </summary>
                [NameInMap("flowOutBandwidth")]
                [Validation(Required=false)]
                public int? FlowOutBandwidth { get; set; }

                /// <summary>
                /// The metering method for Internet usage.
                /// 
                /// Valid values:
                /// 
                /// *   PayByTraffic: pay-by-traffic
                /// *   paybybandwidth: pay-by-bandwidth
                /// *   uninvolved: N/A
                /// </summary>
                [NameInMap("flowOutType")]
                [Validation(Required=false)]
                public string FlowOutType { get; set; }

                /// <summary>
                /// Specifies whether to enable the Internet access feature.
                /// 
                /// Valid values:
                /// 
                /// *   enable
                /// *   disable
                /// 
                /// By default, ApsaraMQ for RocketMQ instances are accessed in virtual private clouds (VPCs). If you enable the Internet access feature, you are charged for Internet outbound bandwidth. For more information, see [Internet access fee](https://help.aliyun.com/document_detail/427240.html).
                /// </summary>
                [NameInMap("internetSpec")]
                [Validation(Required=false)]
                public string InternetSpec { get; set; }

                /// <summary>
                /// The retention period of messages. Unit: hours.
                /// 
                /// For information about the valid values of this parameter, see the "Limits on resource quotas" section in [Usage limits](https://help.aliyun.com/document_detail/440347.html).
                /// 
                /// The storage of messages in ApsaraMQ for RocketMQ is serverless and scalable. You are charged for message storage based on your actual usage. You can change the retention period of messages to adjust storage capacity. For more information, see [Storage fee](https://help.aliyun.com/document_detail/427238.html).
                /// </summary>
                [NameInMap("messageRetentionTime")]
                [Validation(Required=false)]
                public int? MessageRetentionTime { get; set; }

                /// <summary>
                /// The computing specification that is used to send and receive messages. For information about the upper limit of TPS, see [Instance specifications](https://help.aliyun.com/document_detail/444715.html).
                /// </summary>
                [NameInMap("msgProcessSpec")]
                [Validation(Required=false)]
                public string MsgProcessSpec { get; set; }

                /// <summary>
                /// The ratio between sent messages and received messages in the instance.
                /// </summary>
                [NameInMap("sendReceiveRatio")]
                [Validation(Required=false)]
                public float? SendReceiveRatio { get; set; }

                /// <summary>
                /// Specifies whether the elastic TPS feature is supported by the instance.
                /// 
                /// Valid values:
                /// 
                /// *   true: enable
                /// *   false: disable
                /// 
                /// After you enable the elastic TPS feature for a ApsaraMQ for RocketMQ instance, you can use a specific amount of TPS that exceeds the specification limit. You are charged for the elastic TPS feature. For more information, see [Computing fee](https://help.aliyun.com/document_detail/427237.html).
                /// 
                /// > The elastic TPS feature is supported only by specific instance editions. For more information, see [Instance specifications](https://help.aliyun.com/document_detail/444715.html).
                /// </summary>
                [NameInMap("supportAutoScaling")]
                [Validation(Required=false)]
                public bool? SupportAutoScaling { get; set; }

            }

            /// <summary>
            /// The number of groups.
            /// </summary>
            [NameInMap("groupCount")]
            [Validation(Required=false)]
            public long? GroupCount { get; set; }

            /// <summary>
            /// The ID of the instance
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the instance.
            /// </summary>
            [NameInMap("instanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The instance quotas.
            /// </summary>
            [NameInMap("instanceQuotas")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyDataInstanceQuotas> InstanceQuotas { get; set; }
            public class GetInstanceResponseBodyDataInstanceQuotas : TeaModel {
                /// <summary>
                /// The number of topics that are free of charge on the instance.
                /// </summary>
                [NameInMap("freeCount")]
                [Validation(Required=false)]
                public double? FreeCount { get; set; }

                /// <summary>
                /// The quota name.
                /// 
                /// Valid value:
                /// 
                /// *   TOPIC_COUNT: the number of topics that can be created on the instance
                /// </summary>
                [NameInMap("quotaName")]
                [Validation(Required=false)]
                public string QuotaName { get; set; }

                /// <summary>
                /// The total number of topics on the instance.
                /// </summary>
                [NameInMap("totalCount")]
                [Validation(Required=false)]
                public double? TotalCount { get; set; }

                /// <summary>
                /// The number of used topics on the instance.
                /// </summary>
                [NameInMap("usedCount")]
                [Validation(Required=false)]
                public double? UsedCount { get; set; }

            }

            /// <summary>
            /// The network information.
            /// </summary>
            [NameInMap("networkInfo")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyDataNetworkInfo NetworkInfo { get; set; }
            public class GetInstanceResponseBodyDataNetworkInfo : TeaModel {
                /// <summary>
                /// The information about endpoints.
                /// </summary>
                [NameInMap("endpoints")]
                [Validation(Required=false)]
                public List<GetInstanceResponseBodyDataNetworkInfoEndpoints> Endpoints { get; set; }
                public class GetInstanceResponseBodyDataNetworkInfoEndpoints : TeaModel {
                    /// <summary>
                    /// The type of the endpoint that is used to access the instance.
                    /// 
                    /// Valid values:
                    /// 
                    /// - TCP_VPC: VPC endpoint
                    /// - TCP_INTERNET:public endpoint
                    /// </summary>
                    [NameInMap("endpointType")]
                    [Validation(Required=false)]
                    public string EndpointType { get; set; }

                    /// <summary>
                    /// The endpoint that is used to access the instance.
                    /// </summary>
                    [NameInMap("endpointUrl")]
                    [Validation(Required=false)]
                    public string EndpointUrl { get; set; }

                    /// <summary>
                    /// The whitelist that includes the IP addresses that are allowed to access the ApsaraMQ for RocketMQ broker over the Internet. This parameter can be configured only if you use the public endpoint to access the instance.
                    /// 
                    /// *   If you do not configure an IP address whitelist, all CIDR blocks are allowed to access the ApsaraMQ for RocketMQ broker over the Internet.
                    /// *   If you configure an IP address whitelist, only the IP addresses in the whitelist are allowed to access the ApsaraMQ for RocketMQ broker over the Internet.
                    /// 
                    /// We recommend that you configure internetInfo.ipWhitelist instead of this parameter.
                    /// </summary>
                    [NameInMap("ipWhitelist")]
                    [Validation(Required=false)]
                    public List<string> IpWhitelist { get; set; }

                }

                /// <summary>
                /// The information about the Internet.
                /// </summary>
                [NameInMap("internetInfo")]
                [Validation(Required=false)]
                public GetInstanceResponseBodyDataNetworkInfoInternetInfo InternetInfo { get; set; }
                public class GetInstanceResponseBodyDataNetworkInfoInternetInfo : TeaModel {
                    /// <summary>
                    /// The Internet bandwidth. Unit: MB/s.
                    /// </summary>
                    [NameInMap("flowOutBandwidth")]
                    [Validation(Required=false)]
                    public int? FlowOutBandwidth { get; set; }

                    /// <summary>
                    /// The metering method for Internet usage.
                    /// 
                    /// Valid values:
                    /// 
                    /// *   PayByBandwidth: pay-by-bandwidth. If the Internet access feature is enabled, specify this value for the parameter.
                    /// *   uninvolved: N/A. If the Internet access feature is not enabled, specify this value for the parameter.
                    /// </summary>
                    [NameInMap("flowOutType")]
                    [Validation(Required=false)]
                    public string FlowOutType { get; set; }

                    /// <summary>
                    /// Specifies whether to enable the Internet access feature.
                    /// 
                    /// Valid values:
                    /// 
                    /// *   enable
                    /// *   disable
                    /// 
                    /// By default, ApsaraMQ for RocketMQ instances are accessed in virtual private clouds (VPCs). If you enable the Internet access feature, you are charged for Internet outbound bandwidth. For more information, see [Internet access fee](https://help.aliyun.com/document_detail/427240.html).
                    /// </summary>
                    [NameInMap("internetSpec")]
                    [Validation(Required=false)]
                    public string InternetSpec { get; set; }

                    /// <summary>
                    /// The whitelist that includes the IP addresses that are allowed to access the ApsaraMQ for RocketMQ broker.
                    /// 
                    /// *   If this parameter is not configured, all IP addresses are allowed to access the ApsaraMQ for RocketMQ broker over the Internet.
                    /// *   If this parameter is configured, only the IP addresses that are included in the whitelist can access the ApsaraMQ for RocketMQ broker over the Internet.
                    /// </summary>
                    [NameInMap("ipWhitelist")]
                    [Validation(Required=false)]
                    public List<string> IpWhitelist { get; set; }

                }

                /// <summary>
                /// The virtual private cloud (VPC) information.
                /// </summary>
                [NameInMap("vpcInfo")]
                [Validation(Required=false)]
                public GetInstanceResponseBodyDataNetworkInfoVpcInfo VpcInfo { get; set; }
                public class GetInstanceResponseBodyDataNetworkInfoVpcInfo : TeaModel {
                    /// <summary>
                    /// The security group ID.
                    /// </summary>
                    [NameInMap("securityGroupIds")]
                    [Validation(Required=false)]
                    public string SecurityGroupIds { get; set; }

                    /// <summary>
                    /// The ID of the vSwitch with which the instance is associated.
                    /// </summary>
                    [NameInMap("vSwitchId")]
                    [Validation(Required=false)]
                    [Obsolete]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// The vSwitches.
                    /// </summary>
                    [NameInMap("vSwitches")]
                    [Validation(Required=false)]
                    public List<GetInstanceResponseBodyDataNetworkInfoVpcInfoVSwitches> VSwitches { get; set; }
                    public class GetInstanceResponseBodyDataNetworkInfoVpcInfoVSwitches : TeaModel {
                        /// <summary>
                        /// The vSwitch ID.
                        /// </summary>
                        [NameInMap("vSwitchId")]
                        [Validation(Required=false)]
                        public string VSwitchId { get; set; }

                        /// <summary>
                        /// The zone ID.
                        /// </summary>
                        [NameInMap("zoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                    /// <summary>
                    /// The ID of the VPC with which the instance is associated.
                    /// </summary>
                    [NameInMap("vpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

            }

            /// <summary>
            /// The billing method of the instance.
            /// 
            /// Valid values:
            /// 
            /// *   PayAsYouGo: pay-as-you-go
            /// *   Subscription
            /// </summary>
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// The extended configurations of the instance.
            /// </summary>
            [NameInMap("productInfo")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyDataProductInfo ProductInfo { get; set; }
            public class GetInstanceResponseBodyDataProductInfo : TeaModel {
                /// <summary>
                /// Specifies whether to enable the elastic TPS feature for the instance.
                /// 
                /// Valid values:
                /// 
                /// *   true: enable
                /// *   false: disable
                /// 
                /// This parameter is valid only when the supportAutoScaling parameter is set to enable.
                /// </summary>
                [NameInMap("autoScaling")]
                [Validation(Required=false)]
                public bool? AutoScaling { get; set; }

                /// <summary>
                /// The retention period of messages. Unit: hours.
                /// 
                /// For information about the valid values of this parameter, see the "Limits on resource quotas" section in [Usage limits](https://help.aliyun.com/document_detail/440347.html).
                /// 
                /// The storage of messages in ApsaraMQ for RocketMQ is serverless and scalable. You are charged for message storage based on your actual usage. You can change the retention period of messages to adjust storage capacity. For more information, see [Storage fee](https://help.aliyun.com/document_detail/427238.html).
                /// </summary>
                [NameInMap("messageRetentionTime")]
                [Validation(Required=false)]
                public int? MessageRetentionTime { get; set; }

                /// <summary>
                /// The computing specification that is used to send and receive messages. For information about the upper limit of TPS, see [Instance specifications](https://help.aliyun.com/document_detail/444715.html).
                /// </summary>
                [NameInMap("msgProcessSpec")]
                [Validation(Required=false)]
                public string MsgProcessSpec { get; set; }

                /// <summary>
                /// The ratio between sent messages and received messages in the instance.
                /// </summary>
                [NameInMap("sendReceiveRatio")]
                [Validation(Required=false)]
                public float? SendReceiveRatio { get; set; }

                /// <summary>
                /// Specifies whether to enable the elastic TPS feature for the instance.
                /// 
                /// Valid values:
                /// 
                /// *   true: enable
                /// *   false: disable
                /// 
                /// After you enable the elastic TPS feature for a ApsaraMQ for RocketMQ instance, you can use a specific amount of TPS that exceeds the specification limit. You are charged for the elastic TPS feature. For more information, see [Computing fee](https://help.aliyun.com/document_detail/427237.html).
                /// 
                /// > The elastic TPS feature is supported by only specific instance editions. For more information, see [Instance specifications](https://help.aliyun.com/document_detail/444715.html).
                /// </summary>
                [NameInMap("supportAutoScaling")]
                [Validation(Required=false)]
                public bool? SupportAutoScaling { get; set; }

                /// <summary>
                /// Indicates whether the message trace feature is enabled. Valid values:
                /// 
                /// *   true
                /// *   false
                /// 
                /// This parameter is not in use. By default, the message trace feature is enabled for ApsaraMQ for RocketMQ instances, regardless of whether this parameter is configured.
                /// </summary>
                [NameInMap("traceOn")]
                [Validation(Required=false)]
                public bool? TraceOn { get; set; }

            }

            /// <summary>
            /// The ID of the region in which the instance resides.
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The time when the instance was released.
            /// </summary>
            [NameInMap("releaseTime")]
            [Validation(Required=false)]
            public string ReleaseTime { get; set; }

            /// <summary>
            /// The description of the instance.
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The primary edition of the instance. For information about the differences between primary edition instances, see [Instance selection](https://help.aliyun.com/document_detail/444722.html).
            /// 
            /// Valid values:
            /// 
            /// *   standard: Standard Edition
            /// *   ultimate: Enterprise Platinum Edition
            /// *   professional: Professional Edition
            /// </summary>
            [NameInMap("seriesCode")]
            [Validation(Required=false)]
            public string SeriesCode { get; set; }

            /// <summary>
            /// The code of the service to which the instance belongs. The service code of ApsaraMQ for RocketMQ is rmq.
            /// </summary>
            [NameInMap("serviceCode")]
            [Validation(Required=false)]
            public string ServiceCode { get; set; }

            /// <summary>
            /// The instance software information.
            /// </summary>
            [NameInMap("software")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyDataSoftware Software { get; set; }
            public class GetInstanceResponseBodyDataSoftware : TeaModel {
                /// <summary>
                /// The period of upgrade time.
                /// </summary>
                [NameInMap("maintainTime")]
                [Validation(Required=false)]
                public string MaintainTime { get; set; }

                /// <summary>
                /// The version of software.
                /// </summary>
                [NameInMap("softwareVersion")]
                [Validation(Required=false)]
                public string SoftwareVersion { get; set; }

                /// <summary>
                /// The upgrade method.
                /// 
                /// Valid values:
                /// 
                /// - Auto: automatic upgrade
                /// 
                /// - Manual: manual upgrade
                /// </summary>
                [NameInMap("upgradeMethod")]
                [Validation(Required=false)]
                public string UpgradeMethod { get; set; }

            }

            /// <summary>
            /// The time when the instance was started.
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The status of the instance.
            /// 
            /// Valid values:
            /// 
            /// *   RELEASED
            /// *   RUNNING
            /// *   STOPPED
            /// *   CHANGING
            /// *   CREATING
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The sub-category edition of the instance. For information about the differences between sub-category edition instances, see [Instance selection](https://help.aliyun.com/document_detail/444722.html).
            /// 
            /// Valid values:
            /// 
            /// *   cluster_ha: Cluster High-availability Edition
            /// *   single_node: Standalone Edition
            /// </summary>
            [NameInMap("subSeriesCode")]
            [Validation(Required=false)]
            public string SubSeriesCode { get; set; }

            /// <summary>
            /// The resource tags.
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyDataTags> Tags { get; set; }
            public class GetInstanceResponseBodyDataTags : TeaModel {
                /// <summary>
                /// The tag key of the resource.
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value of the resource.
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The number of topics.
            /// </summary>
            [NameInMap("topicCount")]
            [Validation(Required=false)]
            public long? TopicCount { get; set; }

            /// <summary>
            /// The time when the instance was last modified.
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// The ID of the user who owns the instance.
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// The dynamic error code.
        /// </summary>
        [NameInMap("dynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// The dynamic error message.
        /// </summary>
        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request. Each request has a unique ID. You can use this ID to troubleshoot issues.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful.
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
