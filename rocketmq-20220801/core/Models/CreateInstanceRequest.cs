// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable auto-renewal for the instance. This parameter takes effect only if you set PaymentType to Subscription.
        /// 
        /// *   true: enable
        /// *   false: disable
        /// </summary>
        [NameInMap("autoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// The auto-renewal cycle of the instance. This parameter takes effect only if you set autoRenew to true. Unit: months.
        /// 
        /// Valid values:
        /// 
        /// *   Monthly renewal: 1, 2, 3, 6, and 12
        /// </summary>
        [NameInMap("autoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// The commodity code.
        /// 
        /// *   ons_rmqpost_public_intl: pay-as-you-go
        /// *   ons_rmqsub_public_intl: subscription
        /// </summary>
        [NameInMap("commodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// The name of the instance that you want to create.
        /// 
        /// If you do not configure this parameter, the instance ID is used as the instance name.
        /// </summary>
        [NameInMap("instanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The network configurations.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("networkInfo")]
        [Validation(Required=false)]
        public CreateInstanceRequestNetworkInfo NetworkInfo { get; set; }
        public class CreateInstanceRequestNetworkInfo : TeaModel {
            /// <summary>
            /// The Internet-related configurations.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("internetInfo")]
            [Validation(Required=false)]
            public CreateInstanceRequestNetworkInfoInternetInfo InternetInfo { get; set; }
            public class CreateInstanceRequestNetworkInfoInternetInfo : TeaModel {
                /// <summary>
                /// The Internet bandwidth. Unit: MB/s.
                /// 
                /// This parameter is required only if you set flowOutType to payByBandwidth.
                /// 
                /// Valid values: 1 to 1000.
                /// </summary>
                [NameInMap("flowOutBandwidth")]
                [Validation(Required=false)]
                public int? FlowOutBandwidth { get; set; }

                /// <summary>
                /// The billing method of Internet usage.
                /// 
                /// Valid values:
                /// 
                /// *   payByBandwidth: pay-by-bandwidth. If Internet access is enabled for an instance, specify this value for the parameter.
                /// *   payByTraffic: pay-by-traffic. If Internet access is enabled for an instance, specify this value for the parameter.
                /// *   uninvolved: No billing method is involved. If Internet access is disabled for an instance, specify this value for the parameter.
                /// 
                /// This parameter is required.
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
                /// By default, ApsaraMQ for RocketMQ allows you to access instances in VPCs. If you enable Internet access for an instance, you can access the instance over the Internet. After you enable this feature, you are charged for outbound Internet traffic. For more information, see [Internet access fee](https://help.aliyun.com/document_detail/427240.html).
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("internetSpec")]
                [Validation(Required=false)]
                public string InternetSpec { get; set; }

                /// <summary>
                /// The whitelist that includes the IP addresses that are allowed to access the ApsaraMQ for RocketMQ broker over the Internet. This parameter can be configured only if you use a public endpoint to access the instance.
                /// 
                /// *   If you do not configure an IP address whitelist, all CIDR blocks are allowed to access the ApsaraMQ for RocketMQ broker over the Internet.
                /// *   If configure an IP address whitlist, only the IP addresses in the whitelist are allowed to access the ApsaraMQ for RocketMQ broker over the Internet.
                /// </summary>
                [NameInMap("ipWhitelist")]
                [Validation(Required=false)]
                public List<string> IpWhitelist { get; set; }

            }

            /// <summary>
            /// The virtual private cloud (VPC)-related configurations.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("vpcInfo")]
            [Validation(Required=false)]
            public CreateInstanceRequestNetworkInfoVpcInfo VpcInfo { get; set; }
            public class CreateInstanceRequestNetworkInfoVpcInfo : TeaModel {
                /// <summary>
                /// The ID of the security group to which the instance belongs.
                /// </summary>
                [NameInMap("securityGroupIds")]
                [Validation(Required=false)]
                public string SecurityGroupIds { get; set; }

                /// <summary>
                /// The ID of the vSwitch with which you want to associate the instance, If there are multiple vSwitchs, please concatenate them using the "|" character.
                /// 
                /// >  After an ApsaraMQ for RocketMQ instance is created, you cannot change the vSwitch with which the instance is associated. If you want to change the vSwitch with which the instance is associated, you must release the instance and purchase a new instance.
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
                public List<CreateInstanceRequestNetworkInfoVpcInfoVSwitches> VSwitches { get; set; }
                public class CreateInstanceRequestNetworkInfoVpcInfoVSwitches : TeaModel {
                    /// <summary>
                    /// The ID of the vSwitch with which the instance is associated.
                    /// </summary>
                    [NameInMap("vSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                }

                /// <summary>
                /// The ID of the VPC in which you want to deploy the instance.
                /// 
                /// >  After an ApsaraMQ for RocketMQ instance is created, you cannot change the VPC in which the instance is deployed. If you want to change the VPC in which the instance is deployed, you must release the instance and create a new instance.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// The billing method of the instance. ApsaraMQ for RocketMQ supports the subscription and pay-as-you-go billing methods.
        /// 
        /// Valid values:
        /// 
        /// *   PayAsYouGo: This billing method allows you to use resources before you pay for the resources.
        /// *   Subscription: This billing method allows you to use resources after you pay for the resources.
        /// 
        /// For more information, see [Billing methods](https://help.aliyun.com/document_detail/427234.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("paymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// The subscription duration of the instance. This parameter takes effect only if you set PaymentType to Subscription.
        /// 
        /// Valid values:
        /// 
        /// *   Monthly subscription: 1, 2, 3, 4, 5, and 6
        /// *   Yearly subscription: 1, 2, and 3
        /// </summary>
        [NameInMap("period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The unit of the subscription duration.
        /// 
        /// Valid values:
        /// 
        /// *   Month
        /// *   Year
        /// </summary>
        [NameInMap("periodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// The information about the instance specifications.
        /// </summary>
        [NameInMap("productInfo")]
        [Validation(Required=false)]
        public CreateInstanceRequestProductInfo ProductInfo { get; set; }
        public class CreateInstanceRequestProductInfo : TeaModel {
            /// <summary>
            /// Specifies whether to enable the elastic TPS feature for the instance.
            /// 
            /// Valid values:
            /// 
            /// *   true: enable
            /// *   false: disable
            /// 
            /// After you enable the elastic TPS feature for an ApsaraMQ for RocketMQ instance, you can use a specific number of TPS that exceeds the specification limit. You are charged for using the elastic TPS feature. For more information, see [Computing fees](https://help.aliyun.com/document_detail/427237.html).
            /// 
            /// >  The elastic TPS feature is supported only by instances of specific editions. For more information, see [Instance editions](https://help.aliyun.com/document_detail/444715.html).
            /// </summary>
            [NameInMap("autoScaling")]
            [Validation(Required=false)]
            public bool? AutoScaling { get; set; }

            /// <summary>
            /// The billing method.
            /// 
            /// Valid values:
            /// 
            /// *   provisioned
            /// *   ondemand
            /// </summary>
            [NameInMap("chargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// This parameter is no longer used. You do not need to configure this parameter.
            /// </summary>
            [NameInMap("intranetSpec")]
            [Validation(Required=false)]
            public string IntranetSpec { get; set; }

            /// <summary>
            /// The retention period of messages. Unit: hours.
            /// 
            /// For information about the valid values of this parameter, see the "Limits on resource quotas" section of the [Limits](https://help.aliyun.com/document_detail/440347.html) topic.
            /// 
            /// ApsaraMQ for RocketMQ supports serverless scaling of message storage. You are charged storage fees based on your actual storage usage. You can change the retention period of messages to manage storage capacity. For more information, see [Storage fees](https://help.aliyun.com/document_detail/427238.html).
            /// </summary>
            [NameInMap("messageRetentionTime")]
            [Validation(Required=false)]
            public int? MessageRetentionTime { get; set; }

            /// <summary>
            /// The computing specification that specifies the messaging transactions per second (TPS) of the instance. For information about computing specification limits, see [Instance specifications](https://help.aliyun.com/document_detail/444715.html).
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("msgProcessSpec")]
            [Validation(Required=false)]
            public string MsgProcessSpec { get; set; }

            /// <summary>
            /// The proportion of message sending TPS to the messaging TPS on the instance.
            /// 
            /// For example, you create an instance whose peak messaging TPS is specified as 1,000 and the proportion of message sending TPS is specified as 0.8. In this case, the peak message sending TPS is 800 and the peak message receiving TPS is 200 on the instance.
            /// 
            /// Valid values: 0 to 1. Default value: 0.5.
            /// </summary>
            [NameInMap("sendReceiveRatio")]
            [Validation(Required=false)]
            public float? SendReceiveRatio { get; set; }

        }

        /// <summary>
        /// The instance description.
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The resource group ID.
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
        /// 
        /// >  After an instance is created, you can only upgrade the primary edition of the instance. The following editions are sorted in ascending order: Standard Edition, Professional Edition, Enterprise Platinum Edition. For example, you can upgrade an instance of Standard Edition to Professional Edition, but cannot downgrade an instance of Professional Edition to Standard Edition.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("seriesCode")]
        [Validation(Required=false)]
        public string SeriesCode { get; set; }

        /// <summary>
        /// The code of the service to which the instance belongs. The service code of ApsaraMQ for RocketMQ is rmq.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("serviceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// The sub-category edition of the instance. For information about the differences between sub-category edition instances, see [Instance selection](https://help.aliyun.com/document_detail/444722.html).
        /// 
        /// Valid values:
        /// 
        /// *   cluster_ha: High-availability Cluster Edition
        /// *   single_node: Standalone Edition
        /// *   serverless: Serverless Edition
        /// 
        /// If you set seriesCode to ultimate, you can set this parameter to only cluster_ha.
        /// 
        /// >  After an instance is created, you cannot change the sub-category edition of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("subSeriesCode")]
        [Validation(Required=false)]
        public string SubSeriesCode { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value of this parameter, but you must ensure that the value is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
