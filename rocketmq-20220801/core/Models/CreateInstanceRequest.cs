// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the instance. This parameter takes effect only if you set paymentType to Subscription. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal cycle of the instance. This parameter takes effect only if you set autoRenew to true. Unit: months.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Monthly renewal: 1, 2, 3, 6, and 12</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("autoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>The commodity code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ons_rmqpost_public_intl: pay-as-you-go</description></item>
        /// <item><description>ons_rmqsub_public_intl: subscription</description></item>
        /// <item><description>ons_rmqsrvlesspost_public_intl: serverless instance
        /// serverless instance requires this parameter</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ons_ rmqpost_public_cn</para>
        /// </summary>
        [NameInMap("commodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>The name of the instance that you want to create.</para>
        /// <para>If you leave this parameter empty, the instance ID is used as the instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rmq-cn-72u3048uxxx</para>
        /// </summary>
        [NameInMap("instanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The information about the network.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("networkInfo")]
        [Validation(Required=false)]
        public CreateInstanceRequestNetworkInfo NetworkInfo { get; set; }
        public class CreateInstanceRequestNetworkInfo : TeaModel {
            /// <summary>
            /// <para>The Internet-related configurations.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("internetInfo")]
            [Validation(Required=false)]
            public CreateInstanceRequestNetworkInfoInternetInfo InternetInfo { get; set; }
            public class CreateInstanceRequestNetworkInfoInternetInfo : TeaModel {
                /// <summary>
                /// <para>The Internet bandwidth. Unit: MB/s.</para>
                /// <para>This parameter is required only if you set flowOutType to payByBandwidth.</para>
                /// <para>Valid values: 1 to 1000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("flowOutBandwidth")]
                [Validation(Required=false)]
                public int? FlowOutBandwidth { get; set; }

                /// <summary>
                /// <para>The metering method of Internet usage.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>payByBandwidth: pay-by-bandwidth. This value is valid only if you enable Internet access.</description></item>
                /// <item><description>payByTraffic: pay-by-traffic. This value is valid only if you enable Internet access.</description></item>
                /// <item><description>uninvolved: No metering method is involved. This value is valid only if you disable Internet access.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>uninvolved</para>
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
                /// <para>By default, ApsaraMQ for RocketMQ allows you to access instances in VPCs. If you enable Internet access for an instance, you can access the instance over the Internet. After you enable this feature, you are charged for outbound Internet traffic. For more information, see <a href="https://help.aliyun.com/document_detail/427240.html">Internet access fees</a>.</para>
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
                /// <para>The whitelist that includes the CIDR blocks that are allowed to access the ApsaraMQ for RocketMQ broker over the Internet. This parameter can be configured only if you use the public endpoint to access the instance.</para>
                /// <list type="bullet">
                /// <item><description>If you do not configure an IP address whitelist, all CIDR blocks are allowed to access the ApsaraMQ for RocketMQ broker over the Internet.</description></item>
                /// <item><description>If you configure an IP address whitelist, only the CIDR blocks in the whitelist are allowed to access the ApsaraMQ for RocketMQ broker over the Internet.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("ipWhitelist")]
                [Validation(Required=false)]
                [Obsolete]
                public List<string> IpWhitelist { get; set; }

            }

            /// <summary>
            /// <para>The virtual private cloud (VPC)-related configurations.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("vpcInfo")]
            [Validation(Required=false)]
            public CreateInstanceRequestNetworkInfoVpcInfo VpcInfo { get; set; }
            public class CreateInstanceRequestNetworkInfoVpcInfo : TeaModel {
                /// <summary>
                /// <para>The ID of the security group to which the instance belongs.</para>
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
                /// <para>The ID of the vSwitch with which the instance is associated. If you want to specify multiple vSwitches, separate the vSwitches with vertical bars (|).</para>
                /// <remarks>
                /// <para> After you create an ApsaraMQ for RocketMQ instance, you cannot change the vSwitch with which the instance is associated. If you want to change the vSwitch with which the instance is associated, you must release the instance and purchase a new instance.</para>
                /// </remarks>
                /// <remarks>
                /// <para> We recommend that you configure vSwitches instead of this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-uf6gwtbn6etadpv*******</para>
                /// </summary>
                [NameInMap("vSwitchId")]
                [Validation(Required=false)]
                [Obsolete]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The vSwitches.</para>
                /// <remarks>
                /// <para> After you create an ApsaraMQ for RocketMQ instance, you cannot change the vSwitch with which the instance is associated. If you want to change the vSwitch with which the instance is associated, you must release the instance and purchase a new instance.</para>
                /// </remarks>
                /// <remarks>
                /// <para> This parameter is required. We recommend that you configure this parameter instead of vSwitchId.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("vSwitches")]
                [Validation(Required=false)]
                public List<CreateInstanceRequestNetworkInfoVpcInfoVSwitches> VSwitches { get; set; }
                public class CreateInstanceRequestNetworkInfoVpcInfoVSwitches : TeaModel {
                    /// <summary>
                    /// <para>The ID of the vSwitch with which the instance is associated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-uf6gwtbn6etadpv*******</para>
                    /// </summary>
                    [NameInMap("vSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                }

                /// <summary>
                /// <para>The ID of the VPC with which the instance to be created is associated.</para>
                /// <remarks>
                /// <para> After you create an ApsaraMQ for RocketMQ instance, you cannot change the VPC with which the instance is associated. If you want to change the VPC with which the instance is associated, you must release the instance and create a new instance.</para>
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
        /// <para>The billing method of the instance. ApsaraMQ for RocketMQ supports the subscription and pay-as-you-go billing methods.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PayAsYouGo: This billing method allows you to use resources before you pay for the resources.</description></item>
        /// <item><description>Subscription: This billing method allows you to use resources after you pay for the resources.</description></item>
        /// </list>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/427234.html">Billing methods</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Subscription</para>
        /// </summary>
        [NameInMap("paymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The subscription duration of the instance. This parameter takes effect only if you set paymentType to Subscription.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Monthly subscription: 1, 2, 3, 4, 5, and 6</description></item>
        /// <item><description>Yearly subscription: 1, 2, and 3</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month</description></item>
        /// <item><description>Year</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("periodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The information about instance specifications.</para>
        /// </summary>
        [NameInMap("productInfo")]
        [Validation(Required=false)]
        public CreateInstanceRequestProductInfo ProductInfo { get; set; }
        public class CreateInstanceRequestProductInfo : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the elastic TPS feature for the instance.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// <para>After you enable the elastic TPS feature for an ApsaraMQ for RocketMQ instance, you can use a specific amount of TPS that exceeds the specification limit. You are charged for the elastic TPS feature. For more information, see <a href="https://help.aliyun.com/document_detail/427237.html">Computing fees</a>.</para>
            /// <remarks>
            /// <para> The elastic TPS feature is supported only by instances of specific editions. For more information, see <a href="https://help.aliyun.com/document_detail/444715.html">Instance editions</a>.</para>
            /// </remarks>
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
            /// <para>For information about the valid values of this parameter, see the &quot;Limits on resource quotas&quot; section of the <a href="https://help.aliyun.com/document_detail/440347.html">Limits</a> topic.</para>
            /// <para>ApsaraMQ for RocketMQ supports serverless scaling of message storage. You are charged storage fees based on your actual storage usage. You can change the retention period of messages to manage storage capacity. For more information, see <a href="https://help.aliyun.com/document_detail/427238.html">Storage fees</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>72</para>
            /// </summary>
            [NameInMap("messageRetentionTime")]
            [Validation(Required=false)]
            public int? MessageRetentionTime { get; set; }

            /// <summary>
            /// <para>The computing specification that specifies the messaging transactions per second (TPS) of the instance. For more information, see <a href="https://help.aliyun.com/document_detail/444715.html">Instance editions</a>.</para>
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
            /// <para>The ratio of the message sending TPS to the messaging TPS of the instance.</para>
            /// <para>For example, if the maximum messaging TPS of an instance is 1,000 and the ratio of the message sending TPS to the messaging TPS of the instance is 0.8, the maximum message sending TPS of the instance is 800 and the maximum message receiving TPS is 200.</para>
            /// <para>Valid values: 0 to 1. Default value: 0.5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("sendReceiveRatio")]
            [Validation(Required=false)]
            public float? SendReceiveRatio { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the encryption at rest feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("storageEncryption")]
            [Validation(Required=false)]
            public bool? StorageEncryption { get; set; }

            /// <summary>
            /// <para>The key for encryption at rest.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("storageSecretKey")]
            [Validation(Required=false)]
            public string StorageSecretKey { get; set; }

        }

        /// <summary>
        /// <para>The instance description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is the remark for test.</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzy6pist7uuna</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The primary edition of the instance. For information about the differences among primary edition instances, see <a href="https://help.aliyun.com/document_detail/444722.html">Instance selection</a>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>standard: Standard Edition</description></item>
        /// <item><description>ultimate: Enterprise Platinum Edition</description></item>
        /// <item><description>professional: Professional Edition</description></item>
        /// </list>
        /// <remarks>
        /// <para> After you create an instance, you can only upgrade the primary edition of the instance. The following editions are sorted in ascending order: Standard Edition, Professional Edition, Enterprise Platinum Edition. For example, you can upgrade an instance from Standard Edition to Professional Edition, but you cannot downgrade an instance from Professional Edition to Standard Edition.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("seriesCode")]
        [Validation(Required=false)]
        public string SeriesCode { get; set; }

        /// <summary>
        /// <para>The code of the service to which the instance belongs. The service code of ApsaraMQ for RocketMQ is rmq.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rmq</para>
        /// </summary>
        [NameInMap("serviceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// <para>The sub-category edition of the instance. For information about the differences among sub-category edition instances, see <a href="https://help.aliyun.com/document_detail/444722.html">Instance selection</a>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cluster_ha: Cluster High-availability Edition</description></item>
        /// <item><description>single_node: Standalone Edition</description></item>
        /// <item><description>serverless: serverless</description></item>
        /// </list>
        /// <para>If you set seriesCode to ultimate, you can set this parameter only to cluster_ha.</para>
        /// <remarks>
        /// <para> After you create an instance, you cannot change the sub-category edition of the instance.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>serverless: serverless</description></item>
        /// <item><description>cluster_ha: Cluster High-availability Edition</description></item>
        /// <item><description>single_node: Standalone Edition</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster_ha</para>
        /// </summary>
        [NameInMap("subSeriesCode")]
        [Validation(Required=false)]
        public string SubSeriesCode { get; set; }

        /// <summary>
        /// <para>The tags that you want to add to the instance.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestTags> Tags { get; set; }
        public class CreateInstanceRequestTags : TeaModel {
            /// <summary>
            /// <para>The <c>key</c> of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aaa</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The <c>value</c> of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bbb</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value of this parameter, but you must ensure that the value is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c2c5d1274a8d4317a13bc5b0d4******</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
