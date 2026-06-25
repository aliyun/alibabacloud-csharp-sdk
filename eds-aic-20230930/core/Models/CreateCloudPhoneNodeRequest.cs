// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateCloudPhoneNodeRequest : TeaModel {
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
        /// <para>The ID of the Shared Bandwidth instance.</para>
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
        /// <para>The billing method. Only the subscription billing method is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The number of Cloud Phone matrices to purchase.</para>
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
        public CreateCloudPhoneNodeRequestDisplayConfig DisplayConfig { get; set; }
        public class CreateCloudPhoneNodeRequestDisplayConfig : TeaModel {
            /// <summary>
            /// <para>The dots per inch (DPI). Valid values: 72 to 600.</para>
            /// 
            /// <b>Example:</b>
            /// <para>240</para>
            /// </summary>
            [NameInMap("Dpi")]
            [Validation(Required=false)]
            public int? Dpi { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not yet publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Fps")]
            [Validation(Required=false)]
            public int? Fps { get; set; }

            /// <summary>
            /// <para>Specifies whether to lock the resolution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("LockResolution")]
            [Validation(Required=false)]
            public string LockResolution { get; set; }

        }

        /// <summary>
        /// <para>The downstream bandwidth limit, in Mbit/s.</para>
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
        /// <para>To purchase more instance types, <a href="https://smartservice.console.aliyun.com/service/pre-sales-chat?spm=5176.6d6ecb63.0.0.729adda2VqVQx7">contact pre-sales support</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ac.max</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("IsSingleImgDisk")]
        [Validation(Required=false)]
        public bool? IsSingleImgDisk { get; set; }

        /// <summary>
        /// <para>The office network ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-5mwr9azebliva****</para>
        /// </summary>
        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public string NetworkId { get; set; }

        /// <summary>
        /// <para>The network settings for the instance.</para>
        /// </summary>
        [NameInMap("NetworkInfo")]
        [Validation(Required=false)]
        public CreateCloudPhoneNodeRequestNetworkInfo NetworkInfo { get; set; }
        public class CreateCloudPhoneNodeRequestNetworkInfo : TeaModel {
            /// <summary>
            /// <para>The name of the bandwidth package.</para>
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
            /// <para>The billing method for the bandwidth package. Valid values:</para>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description><para><b>PayByBandwidth</b> (default): pay-by-bandwidth.</para>
            /// </description></item>
            /// <item><description><para><b>PayBy95</b>: pay-by-95th-percentile. Note: This billing method is not supported for IPv6 public bandwidth by default. To enable it, contact your account manager.</para>
            /// </description></item>
            /// </list>
            /// <para>\-</para>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <para><b>PayByBandwidth</b> (default): pay-by-bandwidth.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PayByBandwidth</para>
            /// </summary>
            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// <para>The number of Cloud Phone instances that share one elastic IP address (EIP).</para>
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
            /// <para>The maximum bandwidth of the bandwidth package, in Mbit/s. This value limits the aggregate bandwidth of all instances that use the package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("LimitedBandwidth")]
            [Validation(Required=false)]
            public int? LimitedBandwidth { get; set; }

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
        /// <para>The name of the Cloud Phone matrix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>node_name</para>
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        [NameInMap("PaidCallBackUrl")]
        [Validation(Required=false)]
        public string PaidCallBackUrl { get; set; }

        /// <summary>
        /// <para>The subscription duration. The unit is specified by the <c>PeriodUnit</c> parameter.</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>PeriodUnit</c> is set to <b>Year</b>, this parameter can only be set to 1.</para>
        /// </description></item>
        /// <item><description><para>If <c>PeriodUnit</c> is set to <b>Month</b>, valid values are 1, 2, 3, and 6.</para>
        /// </description></item>
        /// </list>
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
        /// <para>The number of Cloud Phone instances to create in a single Cloud Phone matrix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("PhoneCount")]
        [Validation(Required=false)]
        public int? PhoneCount { get; set; }

        /// <summary>
        /// <para>The size of the independent internal storage, in GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PhoneDataVolume")]
        [Validation(Required=false)]
        public int? PhoneDataVolume { get; set; }

        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The vertical resolution, in pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1280</para>
        /// </summary>
        [NameInMap("ResolutionHeight")]
        [Validation(Required=false)]
        public int? ResolutionHeight { get; set; }

        /// <summary>
        /// <para>The horizontal resolution, in pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>720</para>
        /// </summary>
        [NameInMap("ResolutionWidth")]
        [Validation(Required=false)]
        public int? ResolutionWidth { get; set; }

        /// <summary>
        /// <para>The size of the shared internal storage, in GiB.</para>
        /// <remarks>
        /// <para>The size must exceed 10 GiB per instance in the matrix.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("ServerShareDataVolume")]
        [Validation(Required=false)]
        public int? ServerShareDataVolume { get; set; }

        /// <summary>
        /// <para>The server type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpm.gx7.10xlarge</para>
        /// </summary>
        [NameInMap("ServerType")]
        [Validation(Required=false)]
        public string ServerType { get; set; }

        /// <summary>
        /// <para>The streaming mode for instances in the Cloud Phone matrix. Defaults to preemption mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("StreamMode")]
        [Validation(Required=false)]
        public int? StreamMode { get; set; }

        [NameInMap("SwapSize")]
        [Validation(Required=false)]
        public int? SwapSize { get; set; }

        /// <summary>
        /// <para>The resource tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateCloudPhoneNodeRequestTag> Tag { get; set; }
        public class CreateCloudPhoneNodeRequestTag : TeaModel {
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
        /// <para>The upstream bandwidth limit, in Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("UpBandwidthLimit")]
        [Validation(Required=false)]
        public int? UpBandwidthLimit { get; set; }

        /// <summary>
        /// <para>The template for instance creation. Set this parameter to <c>Random</c> to use a random template, or specify a template ID to use a specific template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Random</para>
        /// </summary>
        [NameInMap("UseTemplate")]
        [Validation(Required=false)]
        public string UseTemplate { get; set; }

        /// <summary>
        /// <para>The VSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2zeekryyc1q3sm72l****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
