// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateAndroidInstanceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The number of instance groups. Default value: 1. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The bandwidth plan ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>np-791ncq8qcuoop9hta</para>
        /// </summary>
        [NameInMap("BandwidthPackageId")]
        [Validation(Required=false)]
        public string BandwidthPackageId { get; set; }

        /// <summary>
        /// <para>The bandwidth type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cbwp_ecd</para>
        /// </summary>
        [NameInMap("BandwidthPackageType")]
        [Validation(Required=false)]
        public string BandwidthPackageType { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query the list of regions where cloud phones are available.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The channel cookie, which is passed through to the sales system when an order is placed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>channel-cookie-ig</para>
        /// </summary>
        [NameInMap("ChannelCookie")]
        [Validation(Required=false)]
        public string ChannelCookie { get; set; }

        /// <summary>
        /// <para>The billing method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate requests. The token can be up to 100 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asadbuvwiabdbvchj****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not available to the public.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("EnableIpv6")]
        [Validation(Required=false)]
        public bool? EnableIpv6 { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable GPU acceleration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("GpuAcceleration")]
        [Validation(Required=false)]
        public bool? GpuAcceleration { get; set; }

        /// <summary>
        /// <para>The image ID. You can call the <a href="~~DescribeImageList~~">DescribeImageList</a> operation to query the image list for cloud phones.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imgc-06zyt9m93zwax****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The name of the instance group.</para>
        /// <remarks>
        /// <para>The name can be up to 30 characters in length. It must start with a letter or a Chinese character, and cannot start with <c>http://</c> or <c>https://</c>. It can contain only Chinese characters, letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Cloud Phone A</para>
        /// </summary>
        [NameInMap("InstanceGroupName")]
        [Validation(Required=false)]
        public string InstanceGroupName { get; set; }

        /// <summary>
        /// <para>The specifications of the instance group. You can call the <a href="~~DescribeSpec~~">DescribeSpec</a> operation to query the available specifications for cloud phones.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acp.basic.small</para>
        /// </summary>
        [NameInMap("InstanceGroupSpec")]
        [Validation(Required=false)]
        public string InstanceGroupSpec { get; set; }

        /// <summary>
        /// <para>The instance version. A value of basic indicates a Wuying cloud phone instance, and a value of EnterpriseAi indicates a JVS Mobile instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EnterpriseAi</para>
        /// </summary>
        [NameInMap("InstanceVersion")]
        [Validation(Required=false)]
        public string InstanceVersion { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not available to the public.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Ipv6Bandwidth")]
        [Validation(Required=false)]
        public int? Ipv6Bandwidth { get; set; }

        /// <summary>
        /// <para>The key pair ID. When creating an instance group, if you specify a valid key pair ID, the key pair is bound to all successfully created instances, and you do not need to call the binding API operation again.</para>
        /// <remarks>
        /// <para>Binding key pairs during scale-out is not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>kp-7o9xywwfutc1l****</para>
        /// </summary>
        [NameInMap("KeyPairId")]
        [Validation(Required=false)]
        public string KeyPairId { get; set; }

        /// <summary>
        /// <para>The network and bandwidth plan configurations of the instance group.</para>
        /// </summary>
        [NameInMap("NetworkInfo")]
        [Validation(Required=false)]
        public CreateAndroidInstanceGroupRequestNetworkInfo NetworkInfo { get; set; }
        public class CreateAndroidInstanceGroupRequestNetworkInfo : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable automatic payment. Default value: false.</para>
            /// </summary>
            [NameInMap("AutoPay")]
            [Validation(Required=false)]
            public bool? AutoPay { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable auto-renewal. Default value: false.</para>
            /// </summary>
            [NameInMap("AutoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>The name of the bandwidth plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>inst-bandwidth-pkg-1</para>
            /// </summary>
            [NameInMap("BandwidthPackageName")]
            [Validation(Required=false)]
            public string BandwidthPackageName { get; set; }

            /// <summary>
            /// <para>The private CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.10.13.0/24</para>
            /// </summary>
            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            /// <summary>
            /// <para>The Billable methods of the bandwidth plan. Valid values:</para>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description><b>PayByBandwidth</b> (default): pay-by-bandwidth.</description></item>
            /// <item><description><b>PayBy95</b>: pay-by-traditional-95th-percentile. By default, IPv6 Internet bandwidth does not support the pay-by-traditional-95th-percentile billing method. To use this billing method, contact your account manager.</description></item>
            /// </list>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description><b>PayByBandwidth</b> (default): pay-by-bandwidth.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayByBandwidth</para>
            /// </summary>
            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// <para>The ratio of IP addresses to instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("IpRatio")]
            [Validation(Required=false)]
            public int? IpRatio { get; set; }

            /// <summary>
            /// <para>The line type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ChinaTelecom</para>
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// <para>The peak bandwidth limit of the bandwidth plan, in Mbit/s. The total bandwidth of all instances using this bandwidth plan is subject to this limit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("LimitedBandwidth")]
            [Validation(Required=false)]
            public int? LimitedBandwidth { get; set; }

            /// <summary>
            /// <para>The redirect URL for the payment success page.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://aim.wuying.aliyun.com/nodes">https://aim.wuying.aliyun.com/nodes</a></para>
            /// </summary>
            [NameInMap("PaidCallbackUrl")]
            [Validation(Required=false)]
            public string PaidCallbackUrl { get; set; }

            /// <summary>
            /// <para>The billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The subscription duration of the resource. The unit is specified by PeriodUnit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// <para>The unit of the subscription duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para>The promotion activity ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50003308011****</para>
            /// </summary>
            [NameInMap("PromotionId")]
            [Validation(Required=false)]
            public string PromotionId { get; set; }

            /// <summary>
            /// <para>The visibility scope.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CPS</para>
            /// </summary>
            [NameInMap("VisibleType")]
            [Validation(Required=false)]
            public string VisibleType { get; set; }

        }

        /// <summary>
        /// <para>The network type of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>network_pro_ecd</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The number of instances in the instance group. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NumberOfInstances")]
        [Validation(Required=false)]
        public int? NumberOfInstances { get; set; }

        /// <summary>
        /// <para>The network ID.</para>
        /// <list type="bullet">
        /// <item><description><para>To create a shared network instance: The network ID is optional. Enter the network ID of the <b>Shared Network</b> type on the <a href="https://wya.wuying.aliyun.com/network">Cloud Phone Console &gt; Network</a> page. If no shared network is available in the console, you can leave this parameter empty, and automatic creation of a shared network is triggered when the instance group is created.</para>
        /// </description></item>
        /// <item><description><para>To create a VPC network instance: The network ID is required. Enter the network ID of the <b>VPC Network</b> type on the <a href="https://wya.wuying.aliyun.com/network">Cloud Phone Console &gt; Network</a> page. If no VPC network is available in the console, you must create a network first.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-745976****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The redirect URL for the payment success page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wya.wuying.aliyun.com/instanceGroup</para>
        /// </summary>
        [NameInMap("PaidCallBackUrl")]
        [Validation(Required=false)]
        public string PaidCallBackUrl { get; set; }

        /// <summary>
        /// <para>The subscription duration of the resource. The unit is specified by PeriodUnit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The policy ID. You can call the <a href="~~ListPolicyGroups~~">ListPolicyGroups</a> operation to query the policy list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-b7bxrrwxkijjh****</para>
        /// </summary>
        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        /// <summary>
        /// <para>The promotion activity ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50003308011****</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The sales mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance</para>
        /// </summary>
        [NameInMap("SaleMode")]
        [Validation(Required=false)]
        public string SaleMode { get; set; }

        /// <summary>
        /// <para>The streaming mode of the instances in the instance group. If this parameter is not specified, the default mode is preemptive mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("StreamMode")]
        [Validation(Required=false)]
        public int? StreamMode { get; set; }

        /// <summary>
        /// <para>The tags of the resource.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateAndroidInstanceGroupRequestTag> Tag { get; set; }
        public class CreateAndroidInstanceGroupRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The vSwitch ID. You can call the <a href="https://help.aliyun.com/document_detail/448774.html">DescribeVSwitches</a> operation to query the vSwitch list.</para>
        /// <list type="bullet">
        /// <item><description><para>To create a shared network instance: Leave this parameter empty.</para>
        /// </description></item>
        /// <item><description><para>To create a VPC network instance: The vSwitch ID is required. This vSwitch is used to create the instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf61uvzhz8ejaw776****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
