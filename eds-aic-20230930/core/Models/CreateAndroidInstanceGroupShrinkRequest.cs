// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateAndroidInstanceGroupShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The number of instance groups to create. Valid values: 1 to 100. Default value: 1.</para>
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
        /// <para>Specifies whether to enable auto-renewal for subscription resources. Default value: false.</para>
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
        /// <para>The region ID. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query the regions where Cloud Phone instances are available.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>A client-generated token to ensure request idempotence. This parameter prevents duplicate requests. The token can be up to 100 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asadbuvwiabdbvchj****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not publicly available.</para>
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
        /// <para>The image ID. You can call the <a href="~~DescribeImageList~~">DescribeImageList</a> operation to query available images for Cloud Phone instances.</para>
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
        /// <para>The name can be up to 30 characters in length. It must start with an uppercase or lowercase letter or a Chinese character, and cannot start with <c>http://</c> or <c>https://</c>. The name can contain only Chinese characters, letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Cloud phoneA</para>
        /// </summary>
        [NameInMap("InstanceGroupName")]
        [Validation(Required=false)]
        public string InstanceGroupName { get; set; }

        /// <summary>
        /// <para>The instance group specification. You can call the <a href="~~DescribeSpec~~">DescribeSpec</a> operation to query the specifications that are available for Cloud Phone instances.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acp.basic.small</para>
        /// </summary>
        [NameInMap("InstanceGroupSpec")]
        [Validation(Required=false)]
        public string InstanceGroupSpec { get; set; }

        [NameInMap("InstanceVersion")]
        [Validation(Required=false)]
        public string InstanceVersion { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Ipv6Bandwidth")]
        [Validation(Required=false)]
        public int? Ipv6Bandwidth { get; set; }

        /// <summary>
        /// <para>The key pair ID. If you specify a valid key pair ID when you create the instance group, the system attaches the key pair to all successfully created instances. No separate API call is required to attach the key pair.</para>
        /// <remarks>
        /// <para>Attaching a key pair during a scale-out operation is not supported.</para>
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
        public string NetworkInfoShrink { get; set; }

        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The number of instances in the instance group. The maximum value is 100.</para>
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
        /// <item><description><para>To create instances in a Shared Network: This parameter is optional. Specify the ID of a <b>Shared Network</b>. You can find the ID on the <a href="https://wya.wuying.aliyun.com/network">Cloud Phone console &gt; Network</a> page. If no Shared Network is available in the console, you can omit this parameter. The system automatically creates a Shared Network when you create the instance group.</para>
        /// </description></item>
        /// <item><description><para>To create instances in a VPC: This parameter is required. Specify the ID of a <b>VPC</b>. You can find the ID on the <a href="https://wya.wuying.aliyun.com/network">Cloud Phone console &gt; Network</a> page. If no VPC is available in the console, you must create one first.</para>
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
        /// <b>Example:</b>
        /// <para>wya.wuying.aliyun.com/instanceGroup</para>
        /// </summary>
        [NameInMap("PaidCallBackUrl")]
        [Validation(Required=false)]
        public string PaidCallBackUrl { get; set; }

        /// <summary>
        /// <para>The subscription duration. The PeriodUnit parameter specifies the unit.</para>
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
        /// <para>The policy ID. You can call the <a href="~~ListPolicyGroups~~">ListPolicyGroups</a> operation to query available policies.</para>
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

        [NameInMap("SaleMode")]
        [Validation(Required=false)]
        public string SaleMode { get; set; }

        [NameInMap("StreamMode")]
        [Validation(Required=false)]
        public int? StreamMode { get; set; }

        /// <summary>
        /// <para>The resource tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateAndroidInstanceGroupShrinkRequestTag> Tag { get; set; }
        public class CreateAndroidInstanceGroupShrinkRequestTag : TeaModel {
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
        /// <para>The vSwitch ID. You can call the <a href="https://help.aliyun.com/document_detail/448774.html">DescribeVSwitches</a> operation to query available vSwitches.</para>
        /// <list type="bullet">
        /// <item><description><para>If you create instances in a Shared Network, omit this parameter.</para>
        /// </description></item>
        /// <item><description><para>If you create instances in a VPC, this parameter is required. The system creates the instances in the specified vSwitch.</para>
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
