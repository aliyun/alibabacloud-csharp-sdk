// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateCloudPhoneNodeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the auto-payment feature.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>False (default): You must manually complete the payment in the Alibaba Cloud Expenses and Costs console.</description></item>
        /// <item><description>true: enables the auto-payment feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the auto-renewal feature.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables the auto-renewal feature. In this case, the system automatically renews instances upon expiration.</description></item>
        /// <item><description>false (default): disables the auto-renewal feature. In this case, you need to manually renew instances upon expiration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
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
        /// <para>The number of cloud phone matrixes you want to purchase.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public string Count { get; set; }

        [NameInMap("DisplayConfig")]
        [Validation(Required=false)]
        public CreateCloudPhoneNodeRequestDisplayConfig DisplayConfig { get; set; }
        public class CreateCloudPhoneNodeRequestDisplayConfig : TeaModel {
            [NameInMap("Dpi")]
            [Validation(Required=false)]
            public int? Dpi { get; set; }

            [NameInMap("Fps")]
            [Validation(Required=false)]
            public int? Fps { get; set; }

            [NameInMap("LockResolution")]
            [Validation(Required=false)]
            public string LockResolution { get; set; }

        }

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
        /// <para>The instance specification.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ac.max: By default, this specification allows up to 25 instances. You can adjust this number by using PhoneCount (Value range: 4 to 40).</description></item>
        /// <item><description>ac.plus: By default, this specification allows up to 40 instances. You can adjust this number by using PhoneCount (Value range: 4 to 40).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ac.max</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The office network ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-5mwr9azebliva****</para>
        /// </summary>
        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public string NetworkId { get; set; }

        [NameInMap("NetworkInfo")]
        [Validation(Required=false)]
        public CreateCloudPhoneNodeRequestNetworkInfo NetworkInfo { get; set; }
        public class CreateCloudPhoneNodeRequestNetworkInfo : TeaModel {
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

            [NameInMap("VisibleType")]
            [Validation(Required=false)]
            public string VisibleType { get; set; }

        }

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
        /// <para>The subscription duration. The unit is specified by <c>PeriodUnit</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>When <c>PeriodUnit</c> is set to <b>year</b>: 1.</description></item>
        /// <item><description>When <c>PeriodUnit</c> is set to <b>month</b>: 1, 2, 3, and 6.</description></item>
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
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month (default)</description></item>
        /// <item><description>Year</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The number of instances per cloud phone matrix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("PhoneCount")]
        [Validation(Required=false)]
        public int? PhoneCount { get; set; }

        [NameInMap("PhoneDataVolume")]
        [Validation(Required=false)]
        public int? PhoneDataVolume { get; set; }

        /// <summary>
        /// <para>The resolution height. Unit: pixel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1280</para>
        /// </summary>
        [NameInMap("ResolutionHeight")]
        [Validation(Required=false)]
        public int? ResolutionHeight { get; set; }

        /// <summary>
        /// <para>The resolution width. Unit: pixel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>720</para>
        /// </summary>
        [NameInMap("ResolutionWidth")]
        [Validation(Required=false)]
        public int? ResolutionWidth { get; set; }

        /// <summary>
        /// <para>The shared storage size Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("ServerShareDataVolume")]
        [Validation(Required=false)]
        public int? ServerShareDataVolume { get; set; }

        /// <summary>
        /// <para>The matrix specification.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cpm.gn6.gx1</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpm.gn6.gx1</para>
        /// </summary>
        [NameInMap("ServerType")]
        [Validation(Required=false)]
        public string ServerType { get; set; }

        [NameInMap("StreamMode")]
        [Validation(Required=false)]
        public int? StreamMode { get; set; }

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

        [NameInMap("UpBandwidthLimit")]
        [Validation(Required=false)]
        public int? UpBandwidthLimit { get; set; }

        [NameInMap("UseTemplate")]
        [Validation(Required=false)]
        public string UseTemplate { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2zeekryyc1q3sm72l****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
