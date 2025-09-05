// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateAndroidInstanceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The number of instance groups. Default value: 1. Maximum value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Default value: false.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables automatic payment. Make sure that your Alibaba Cloud account has sufficient balance.</description></item>
        /// <item><description>false: disables automatic payment. You must manually complete the payment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Default value: false.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: automatically renew resource upon expiration.</description></item>
        /// <item><description>false: manually renew resources upon expiration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        [NameInMap("BandwidthPackageId")]
        [Validation(Required=false)]
        public string BandwidthPackageId { get; set; }

        [NameInMap("BandwidthPackageType")]
        [Validation(Required=false)]
        public string BandwidthPackageType { get; set; }

        /// <summary>
        /// <para>The ID of the region. You can call the DescribeRegions operation to query the regions where Cloud Phone is supported.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-shenzhen: China (Shenzhen).</description></item>
        /// <item><description>cn-beijing: China (Beijing).</description></item>
        /// <item><description>cn-shanghai: China (Shanghai).</description></item>
        /// <item><description>cn-hongkong: China (Hong Kong).</description></item>
        /// <item><description>ap-southeast-1: Singapore.</description></item>
        /// <item><description>cn-hangzhou: China (Hangzhou).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The billing method.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PostPaid: pay-as-you-go.</description></item>
        /// <item><description>PrePaid: subscription.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. The value cannot exceed 100 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asadbuvwiabdbvchjsbj</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <remarks>
        /// <para> This parameter is not publicly available.</para>
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
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables GPU acceleration.</description></item>
        /// <item><description>false (default): disables GPU acceleration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("GpuAcceleration")]
        [Validation(Required=false)]
        public bool? GpuAcceleration { get; set; }

        /// <summary>
        /// <para>The ID of the image. You can call the <a href="https://help.aliyun.com/document_detail/2807324.html">DescribeImageList</a> operation to query images.</para>
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
        /// <para> The name can be up to 30 characters in length. It can contain letters, digits, colons (:), underscores (_), periods (.), or hyphens (-). It must start with letters but cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>defaultInstanceGroup</para>
        /// </summary>
        [NameInMap("InstanceGroupName")]
        [Validation(Required=false)]
        public string InstanceGroupName { get; set; }

        /// <summary>
        /// <para>The specifications of the instance group. You can call the <a href="https://help.aliyun.com/document_detail/2807299.html">DescribeSpec</a> operation to query the available specifications.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>acp.perf.large: Performance (8 vCPUs, 16 GiB of memory, and 32 GiB of storage.</description></item>
        /// <item><description>acp.basic.small: Lightweight (2 vCPUs, 4 GiB of memory, and 32 GiB of storage).</description></item>
        /// <item><description>acp.std.large: Standard (4 vCPUs, 8 GiB of memory, and 32 GiB of storage).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acp.basic.small</para>
        /// </summary>
        [NameInMap("InstanceGroupSpec")]
        [Validation(Required=false)]
        public string InstanceGroupSpec { get; set; }

        /// <summary>
        /// <remarks>
        /// <para> This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Ipv6Bandwidth")]
        [Validation(Required=false)]
        public int? Ipv6Bandwidth { get; set; }

        /// <summary>
        /// <para>The ID of the key pair. When you create an instance group and specify a valid key pair ID, all cloud phone instances within the group will automatically be bound to that key pair upon creation. This eliminates the need to manually bind key pairs to individual cloud phone instances.</para>
        /// <remarks>
        /// <para> Binding key pairs to cloud phone instances is currently not supported during instance group resizing.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>kp-7o9xywwfutc1l****</para>
        /// </summary>
        [NameInMap("KeyPairId")]
        [Validation(Required=false)]
        public string KeyPairId { get; set; }

        [NameInMap("NetworkInfo")]
        [Validation(Required=false)]
        public CreateAndroidInstanceGroupRequestNetworkInfo NetworkInfo { get; set; }
        public class CreateAndroidInstanceGroupRequestNetworkInfo : TeaModel {
            [NameInMap("AutoPay")]
            [Validation(Required=false)]
            public bool? AutoPay { get; set; }

            [NameInMap("AutoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            [NameInMap("BandwidthPackageName")]
            [Validation(Required=false)]
            public string BandwidthPackageName { get; set; }

            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            [NameInMap("IpRatio")]
            [Validation(Required=false)]
            public int? IpRatio { get; set; }

            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            [NameInMap("LimitedBandwidth")]
            [Validation(Required=false)]
            public int? LimitedBandwidth { get; set; }

            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            [NameInMap("VisibleType")]
            [Validation(Required=false)]
            public string VisibleType { get; set; }

        }

        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The number of cloud phones in the instance group. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NumberOfInstances")]
        [Validation(Required=false)]
        public int? NumberOfInstances { get; set; }

        /// <summary>
        /// <para>The ID of the network.</para>
        /// <list type="bullet">
        /// <item><description>This parameter is required if you assign a shared network to cloud phones. You can go to the <a href="https://wya.wuying.aliyun.com/network">Network</a> page of the Cloud Phone console to retrieve the ID of a <b>shared network</b>. If no shared network is available in the Cloud Phone console, you can leave this parameter empty. The system automatically creates one when you create an instance group.</description></item>
        /// <item><description>This parameter is required if you assign a virtual private cloud (VPC) to cloud phones. You can go to the <a href="https://wya.wuying.aliyun.com/network">Network</a> page of the Cloud Phone console to retrieve the ID of a <b>VPC</b>. If no VPC is available in the Cloud Phone console, you must first create one.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-745976****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The subscription duration. The unit is specified by PeriodUnit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month</description></item>
        /// <item><description>Year</description></item>
        /// <item><description>Hour (Note that this unit is supported only by pay-as-you-go.)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The ID of the policy. You can call the <a href="https://help.aliyun.com/document_detail/2807352.html">ListPolicyGroups</a> operation to query policies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-b7bxrrwxkijjh****</para>
        /// </summary>
        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The tags</para>
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
        /// <para>The ID of the vSwitch. You can call the <a href="https://help.aliyun.com/document_detail/448774.html">DescribeVSwitches</a> operation to query vSwitches.</para>
        /// <list type="bullet">
        /// <item><description>This parameter is not required if you assign a shared network to cloud phones.</description></item>
        /// <item><description>This parameter is required if you assign a VPC to cloud phones. The vSwitch specified by this parameter is used to create cloud phones.</description></item>
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
