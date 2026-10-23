// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateCloudPhoneNodeShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The ID of the Internet Shared Bandwidth instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cbwp-uf6g3hgg*******8s3lxiob3</para>
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
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The channel cookie that is passed through to the sales system when an order is placed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>channel-cookie-node</para>
        /// </summary>
        [NameInMap("ChannelCookie")]
        [Validation(Required=false)]
        public string ChannelCookie { get; set; }

        /// <summary>
        /// <para>The billing method. Only the subscription billing method is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The Quantity of the cloud phone matrix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public string Count { get; set; }

        /// <summary>
        /// <para>The display settings.</para>
        /// </summary>
        [NameInMap("DisplayConfig")]
        [Validation(Required=false)]
        public string DisplayConfigShrink { get; set; }

        /// <summary>
        /// <para>The downstream bandwidth throttling. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("DownBandwidthLimit")]
        [Validation(Required=false)]
        public int? DownBandwidthLimit { get; set; }

        /// <summary>
        /// <para>The image ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imgc-075cllfeuazh0****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The instance type.</para>
        /// <remarks>
        /// <para>To purchase additional specifications, <a href="https://smartservice.console.aliyun.com/service/pre-sales-chat?spm=5176.6d6ecb63.0.0.729adda2VqVQx7">contact pre-sales support</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ac.max</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a single image disk. Default value: false. A value of false indicates that the system disk and the shared internal storage image disk are used.</para>
        /// </summary>
        [NameInMap("IsSingleImgDisk")]
        [Validation(Required=false)]
        public bool? IsSingleImgDisk { get; set; }

        /// <summary>
        /// <para>The ID of the office network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-5mwr9azebliva****</para>
        /// </summary>
        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public string NetworkId { get; set; }

        /// <summary>
        /// <para>The network mapping information for the instance.</para>
        /// </summary>
        [NameInMap("NetworkInfo")]
        [Validation(Required=false)]
        public string NetworkInfoShrink { get; set; }

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
        /// <para>The name of the cloud phone matrix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>node_name</para>
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// <para>The redirect URL of the payment success page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wya.wuying.aliyun.com/instanceGroup</para>
        /// </summary>
        [NameInMap("PaidCallBackUrl")]
        [Validation(Required=false)]
        public string PaidCallBackUrl { get; set; }

        /// <summary>
        /// <para>The subscription period. The unit is specified by PeriodUnit.</para>
        /// <list type="bullet">
        /// <item><description>If PeriodUnit is set to <b>year</b>, the only valid value is 1.</description></item>
        /// <item><description>If PeriodUnit is set to <b>month</b>, valid values are 1, 2, 3, and 6.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The number of cloud phone instances to create in a single matrix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("PhoneCount")]
        [Validation(Required=false)]
        public int? PhoneCount { get; set; }

        /// <summary>
        /// <para>The size of the independent internal storage. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PhoneDataVolume")]
        [Validation(Required=false)]
        public int? PhoneDataVolume { get; set; }

        /// <summary>
        /// <para>The promotion ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50003308011****</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The resolution height. Unit: pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1280</para>
        /// </summary>
        [NameInMap("ResolutionHeight")]
        [Validation(Required=false)]
        public int? ResolutionHeight { get; set; }

        /// <summary>
        /// <para>The resolution width. Unit: pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>720</para>
        /// </summary>
        [NameInMap("ResolutionWidth")]
        [Validation(Required=false)]
        public int? ResolutionWidth { get; set; }

        /// <summary>
        /// <para>The size of the shared internal storage. Unit: GiB.</para>
        /// <remarks>
        /// <para>The minimum size of the shared internal storage must be greater than the number of instances in the matrix multiplied by 10 GiB.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("ServerShareDataVolume")]
        [Validation(Required=false)]
        public int? ServerShareDataVolume { get; set; }

        /// <summary>
        /// <para>The specification of the cloud phone matrix.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpm.gx7.10xlarge</para>
        /// </summary>
        [NameInMap("ServerType")]
        [Validation(Required=false)]
        public string ServerType { get; set; }

        /// <summary>
        /// <para>The streaming mode for instances in the cloud phone matrix. If this parameter is not specified, the preemptive mode is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("StreamMode")]
        [Validation(Required=false)]
        public int? StreamMode { get; set; }

        /// <summary>
        /// <para>The size of the swap space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SwapSize")]
        [Validation(Required=false)]
        public int? SwapSize { get; set; }

        /// <summary>
        /// <para>The resource tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateCloudPhoneNodeShrinkRequestTag> Tag { get; set; }
        public class CreateCloudPhoneNodeShrinkRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>keyname</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>valuename</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The upstream bandwidth throttling. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("UpBandwidthLimit")]
        [Validation(Required=false)]
        public int? UpBandwidthLimit { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a template during creation. To use a random template from the template list, set the value to Random. To use a specific template, specify the template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Random</para>
        /// </summary>
        [NameInMap("UseTemplate")]
        [Validation(Required=false)]
        public string UseTemplate { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2zeekryyc1q3sm72l****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
