// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable auto-renewal. This parameter takes effect only when the PaymentType parameter is set to Subscription.
        /// 
        /// *   true: enable
        /// *   false: disable
        /// </summary>
        [NameInMap("autoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// The auto-renewal cycle of the instance. This parameter takes effect only when the autoRenew parameter is set to true. Unit: months.
        /// 
        /// Valid values:
        /// 
        /// *   Monthly renewal: 1, 2, 3, 6, and 12
        /// </summary>
        [NameInMap("autoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// The name of the instance that you want to create.
        /// 
        /// If you do not configure this parameter, the instance ID is used as the instance name.
        /// </summary>
        [NameInMap("instanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The information about the network.
        /// </summary>
        [NameInMap("networkInfo")]
        [Validation(Required=false)]
        public CreateInstanceRequestNetworkInfo NetworkInfo { get; set; }
        public class CreateInstanceRequestNetworkInfo : TeaModel {
            /// <summary>
            /// The Internet-related configurations.
            /// </summary>
            [NameInMap("internetInfo")]
            [Validation(Required=false)]
            public CreateInstanceRequestNetworkInfoInternetInfo InternetInfo { get; set; }
            public class CreateInstanceRequestNetworkInfoInternetInfo : TeaModel {
                /// <summary>
                /// The Internet bandwidth. Unit: MB/s.
                /// 
                /// This parameter is required only when the flowOutType parameter is set to payByBandwidth.
                /// 
                /// Valid values: 1 to 1000.
                /// </summary>
                [NameInMap("flowOutBandwidth")]
                [Validation(Required=false)]
                public int? FlowOutBandwidth { get; set; }

                /// <summary>
                /// The metering method for Internet usage.
                /// 
                /// Valid values:
                /// 
                /// *   payByBandwidth: pay-by-bandwidth. If the Internet access feature is enabled, specify this value for the parameter.
                /// *   uninvolved: N/A. If the Internet access feature is disabled, specify this value for the parameter.
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
                /// By default, ApsaraMQ for RocketMQ instances are accessed in VPCs. If you enable the Internet access feature, you are charged for Internet outbound bandwidth. For more information, see [Internet access fee](~~427240~~).
                /// </summary>
                [NameInMap("internetSpec")]
                [Validation(Required=false)]
                public string InternetSpec { get; set; }

                /// <summary>
                /// The whitelist that includes the IP addresses that are allowed to access the ApsaraMQ for RocketMQ broker over the Internet. This parameter can be configured only when you use a public endpoint to access the ApsaraMQ for RocketMQ broker.
                /// 
                /// *   If this parameter is not configured, all IP addresses are allowed to access the ApsaraMQ for RocketMQ broker over the Internet.
                /// *   If this parameter is configured, only the IP addresses that are included in the whitelist can access the ApsaraMQ for RocketMQ broker over the Internet.
                /// </summary>
                [NameInMap("ipWhitelist")]
                [Validation(Required=false)]
                public List<string> IpWhitelist { get; set; }

            }

            /// <summary>
            /// The virtual private cloud (VPC)-related configurations.
            /// </summary>
            [NameInMap("vpcInfo")]
            [Validation(Required=false)]
            public CreateInstanceRequestNetworkInfoVpcInfo VpcInfo { get; set; }
            public class CreateInstanceRequestNetworkInfoVpcInfo : TeaModel {
                /// <summary>
                /// The ID of the vSwitch with which the instance is associated.
                /// 
                /// > After you create a ApsaraMQ for RocketMQ instance, you cannot change the vSwitch to which the instance is connected. If you want to change the vSwitch with which a ApsaraMQ for RocketMQ is associated, you must release the instance and purchase a new instance.
                /// </summary>
                [NameInMap("vSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The ID of the VPC with which the instance that you want to create is associated.
                /// 
                /// > After you create a ApsaraMQ for RocketMQ instance, you cannot change the VPC in which the instance is created. If you want to change the VPC with which a ApsaraMQ for RocketMQ is associated, you must release the instance and purchase a new instance.
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// The billing method of the instance. ApsaraMQ for RocketMQ supports the subscription and pay-as-you-go billing methods.
        /// 
        /// Valid values:
        /// 
        /// *   PayAsYouGo: pay-as-you go. This billing method allows you to use resources before you pay for the resources.
        /// *   Subscription: This billing method allows you to use resources after you pay for the resources.
        /// 
        /// For more information, see [Billing methods](~~427234~~).
        /// </summary>
        [NameInMap("paymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// The subscription duration of the instance. This parameter takes effect only when the PaymentType parameter is set to Subscription.
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
        /// The information about the instance specification.
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
            /// After you enable the elastic TPS feature for a ApsaraMQ for RocketMQ instance, you can use a specific amount of TPS that exceeds the specification limit. You are charged for the elastic TPS feature. For more information, see [Computing fee](~~427237~~).
            /// 
            /// > The elastic TPS feature is supported by only specific instance editions. For more information, see [Instance specifications](~~444715~~).
            /// </summary>
            [NameInMap("autoScaling")]
            [Validation(Required=false)]
            public bool? AutoScaling { get; set; }

            /// <summary>
            /// The retention period of messages. Unit: hours.
            /// 
            /// For information about the valid values of this parameter, see the "Limits on resource quotas" section in [Usage limits](~~440347~~).
            /// 
            /// The storage of messages in ApsaraMQ for RocketMQ is serverless and scalable. You are charged for message storage based on your actual usage. You can change the retention period of messages to adjust storage capacity. For more information, see [Storage fee](~~427238~~).
            /// </summary>
            [NameInMap("messageRetentionTime")]
            [Validation(Required=false)]
            public int? MessageRetentionTime { get; set; }

            /// <summary>
            /// The computing specification that is used to send and receive messages. For information about the upper limit of TPS, see [Instance specifications](~~444715~~).
            /// </summary>
            [NameInMap("msgProcessSpec")]
            [Validation(Required=false)]
            public string MsgProcessSpec { get; set; }

            /// <summary>
            /// The ratio between sent messages and received messages in the instance.
            /// 
            /// Value values: 0.2 to 0.5.
            /// </summary>
            [NameInMap("sendReceiveRatio")]
            [Validation(Required=false)]
            public float? SendReceiveRatio { get; set; }

        }

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
        /// The primary edition of the instance. For information about the differences between primary edition instances, see [Instance selection](~~444722~~).
        /// 
        /// Valid values:
        /// 
        /// *   standard: Standard Edition
        /// *   ultimate: Enterprise Platinum Edition
        /// *   professional: Professional Edition
        /// 
        /// > After you create a ApsaraMQ for RocketMQ instance, you can only upgrade the primary edition of the instance. The following editions are sorted in ascending order: Standard Edition, Professional Edition, and Platinum Edition. For example, an instance of Standard Edition can be upgraded to Professional Edition. However, an instance of Professional Edition cannot be downgraded to Standard Edition.
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
        /// The sub-category edition of the instance. For information about the differences between sub-category edition instances, see [Instance selection](~~444722~~).
        /// 
        /// Valid values:
        /// 
        /// *   cluster_ha: Cluster High-availability Edition
        /// *   single_node: Standalone Edition
        /// 
        /// If you set the seriesCode parameter to ultimate, you can set this parameter to only cluster_ha.
        /// 
        /// > After you create a ApsaraMQ for RocketMQ instance, you cannot change the sub-category edition of the instance.
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
