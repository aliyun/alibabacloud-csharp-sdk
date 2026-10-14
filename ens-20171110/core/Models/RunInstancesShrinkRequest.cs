// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RunInstancesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The number of instances to create. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public long? Amount { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically install the Cloud Assistant client on the instance.</para>
        /// </summary>
        [NameInMap("AutoInstallCloudAssistant")]
        [Validation(Required=false)]
        public bool? AutoInstallCloudAssistant { get; set; }

        /// <summary>
        /// <para>The automatic release time of the pay-as-you-go instance. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <list type="bullet">
        /// <item><description><para>If the value of seconds (<c>ss</c>) is not <c>00</c>, the time is automatically set to the start of the current minute (<c>mm</c>).</para>
        /// </description></item>
        /// <item><description><para>The earliest release time is one hour after the current time.</para>
        /// </description></item>
        /// </list>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-28T14:38:52Z</para>
        /// </summary>
        [NameInMap("AutoReleaseTime")]
        [Validation(Required=false)]
        public string AutoReleaseTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables auto-renewal.</description></item>
        /// <item><description><b>false</b>: does not enable auto-renewal. (Default)</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is invalid for pay-as-you-go instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>Specifies whether to use coupons. Default value: true (AutoUseCoupon=true).</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public string AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The billing cycle for instance compute resources. Only instance-level pay-as-you-go is supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Day</b>: daily billing.</para>
        /// </description></item>
        /// <item><description><para><b>Month</b>: monthly billing.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Day</para>
        /// </summary>
        [NameInMap("BillingCycle")]
        [Validation(Required=false)]
        public string BillingCycle { get; set; }

        /// <summary>
        /// <para>The carrier.</para>
        /// <remarks>
        /// <para>This parameter is required for region-level scheduling.</br>
        /// For node-level scheduling, if a node has multiple carriers and you do not specify a carrier, instances are created for each carrier on the node. For example, if a node has both China Mobile and China Unicom carriers, instances with two ISPs are created.</br>You can call <a href="https://help.aliyun.com/document_detail/2637461.html">DescribeRegionIsps</a> to query the carrier information of a node.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>telecom</para>
        /// </summary>
        [NameInMap("Carrier")]
        [Validation(Required=false)]
        public string Carrier { get; set; }

        /// <summary>
        /// <para>The region for Cloud Assistant access. Valid values: cn-zhangjiakou (Zhangjiakou) and ap-southeast-1 (Singapore).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-zhangjiakou</para>
        /// </summary>
        [NameInMap("CloudAssistantRegion")]
        [Validation(Required=false)]
        public string CloudAssistantRegion { get; set; }

        /// <summary>
        /// <para>The data cloud disk specifications.</para>
        /// </summary>
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public string DataDiskShrink { get; set; }

        /// <summary>
        /// <para>The release protection property of the instance. Specifies whether the instance can be released from the console or by calling an API operation. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>true: Enables instance release protection.</description></item>
        /// <item><description>false: Disables instance release protection.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>This property applies only to pay-as-you-go instances and can only restrict manual release operations. It does not take effect on system-initiated release operations.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>The deployment set ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds-5s1p6x2l3r4b****</para>
        /// </summary>
        [NameInMap("DeploymentSetId")]
        [Validation(Required=false)]
        public string DeploymentSetId { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// <remarks>
        /// <para>This parameter is required for node-level scheduling and is invalid for region-level scheduling.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-foshan-telecom</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The hostname.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-HostName</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The image ID. This parameter cannot be specified for ARM-based instances. This parameter is required for other instance types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-5si16wo6simkt267p8b7h****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The instance billing strategy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>instance</b>: instance-level billing.</description></item>
        /// <item><description>If not specified, the default is user-level billing.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("InstanceChargeStrategy")]
        [Validation(Required=false)]
        public string InstanceChargeStrategy { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PrePaid</b>: subscription.</description></item>
        /// <item><description><b>PostPaid</b>: pay-as-you-go.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The instance name. The name must be 2 to 128 characters in length and must start with a letter or Chinese character. It cannot start with <c>http://</c> or <c>https://</c>. It can contain Chinese characters, letters, digits, colons (:), underscores (_), periods (.), or hyphens (-).</para>
        /// <para>Default value: the InstanceId of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestName</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ens.sn1.small</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>Billable methods for bandwidth. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BandwidthByDay</b>: daily peak bandwidth</description></item>
        /// <item><description><b>95BandwidthByMonth</b>: monthly 95th percentile bandwidth</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can select a billing method only for the first purchase. Subsequent purchases use the billing method selected during the first purchase by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>BandwidthByDay</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The maximum public bandwidth. If the value of this parameter is greater than 0, a public IP address is automatically assigned to the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public long? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// <para>The IP type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ipv4</b> (default): IPv4.</para>
        /// </description></item>
        /// <item><description><para><b>ipv6</b>: IPv6.</para>
        /// </description></item>
        /// <item><description><para><b>ipv4Andipv6</b>: IPv4 and IPv6 (single stack).</para>
        /// </description></item>
        /// <item><description><para><b>ipv4Withipv6</b>: IPv4 and IPv6 (dual-stack).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4</para>
        /// </summary>
        [NameInMap("IpType")]
        [Validation(Required=false)]
        public string IpType { get; set; }

        /// <summary>
        /// <para>The number of randomly generated IPv6 addresses to assign to the primary ENI of the private network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Ipv6AddressCount")]
        [Validation(Required=false)]
        public long? Ipv6AddressCount { get; set; }

        /// <summary>
        /// <para>The key pair name.</para>
        /// <remarks>
        /// <para>Specify at least one of <b>Password</b>, <b>KeyPairName</b>, and <b>PasswordInherit</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>wx2-jumpserver</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The ID of the instance launch template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lt-test</para>
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// <para>The name of the instance launch template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lt-test</para>
        /// </summary>
        [NameInMap("LaunchTemplateName")]
        [Validation(Required=false)]
        public string LaunchTemplateName { get; set; }

        /// <summary>
        /// <para>The version of the instance launch template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LaunchTemplateVersion")]
        [Validation(Required=false)]
        public int? LaunchTemplateVersion { get; set; }

        /// <summary>
        /// <para>The region code.</para>
        /// <remarks>
        /// <para>This parameter is required for region-level scheduling and is invalid for node-level scheduling.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>350000</para>
        /// </summary>
        [NameInMap("NetDistrictCode")]
        [Validation(Required=false)]
        public string NetDistrictCode { get; set; }

        /// <summary>
        /// <para>The network ID.</para>
        /// <remarks>
        /// <para>This parameter can only be used for node-level scheduling. An error is returned if this parameter is specified for region-level scheduling. If you do not specify vSwitch information, only the validity of the network ID is verified. The actual resource creation does not use this network ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>net-id</para>
        /// </summary>
        [NameInMap("NetWorkId")]
        [Validation(Required=false)]
        public string NetWorkId { get; set; }

        /// <summary>
        /// <para>The instance password.</para>
        /// <remarks>
        /// <para>Specify at least one of <b>Password</b>, <b>KeyPairName</b>, and <b>PasswordInherit</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testPassword</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the preset password of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: uses the preset password.</description></item>
        /// <item><description><b>false</b>: does not use the preset password.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Specify at least one of <b>Password</b>, <b>KeyPairName</b>, and <b>PasswordInherit</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public bool? PasswordInherit { get; set; }

        /// <summary>
        /// <para>The duration of the purchased resource.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>PeriodUnit</b> is set to <b>Day</b>, <b>Period</b> can only be set to <b>3</b>.</para>
        /// </description></item>
        /// <item><description><para>If <b>PeriodUnit</b> is set to <b>Month</b>, <b>Period</b> can be set to <b>1-9</b> or <b>12</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        /// <summary>
        /// <para>The unit of the purchase duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Month</b> (default): monthly purchase.</description></item>
        /// <item><description><b>Day</b>: daily purchase.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The private IP address.</para>
        /// <remarks>
        /// <para>This parameter can only be used for node-level scheduling. An error is returned if this parameter is specified for region-level scheduling.
        /// If a private IP address is specified, the number of instances can only be 1. The private IP address takes effect only when both the private IP address and vSwitch ID are specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.XX.XX</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable public IP identification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables public IP identification.</para>
        /// </description></item>
        /// <item><description><para>false: does not enable public IP identification.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PublicIpIdentification")]
        [Validation(Required=false)]
        public bool? PublicIpIdentification { get; set; }

        /// <summary>
        /// <para>The scheduling level. Use this parameter to specify node-level or region-level scheduling. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Big</b>: major area</description></item>
        /// <item><description><b>Middle</b>: province</description></item>
        /// <item><description><b>Small</b>: city</description></item>
        /// <item><description><b>Region</b>: node</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Region</para>
        /// </summary>
        [NameInMap("ScheduleAreaLevel")]
        [Validation(Required=false)]
        public string ScheduleAreaLevel { get; set; }

        /// <summary>
        /// <para>The scheduling price strategy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PriceHighPriority</b>: high price first</description></item>
        /// <item><description><b>PriceLowPriority</b>: low price first</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PriceHighPriority</para>
        /// </summary>
        [NameInMap("SchedulingPriceStrategy")]
        [Validation(Required=false)]
        public string SchedulingPriceStrategy { get; set; }

        /// <summary>
        /// <para>The scheduling strategy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Concentrate</b>: concentrated</description></item>
        /// <item><description><b>Disperse</b>: dispersed</description></item>
        /// </list>
        /// <remarks>
        /// <para>For node-level scheduling, the value is <b>Concentrate</b>. For region-level scheduling, select a value based on your requirements.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Concentrate</para>
        /// </summary>
        [NameInMap("SchedulingStrategy")]
        [Validation(Required=false)]
        public string SchedulingStrategy { get; set; }

        /// <summary>
        /// <para>The security group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-test</para>
        /// </summary>
        [NameInMap("SecurityId")]
        [Validation(Required=false)]
        public string SecurityId { get; set; }

        /// <summary>
        /// <para>The protection period of the spot instance.</para>
        /// <para>Unit: hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public int? SpotDuration { get; set; }

        /// <summary>
        /// <para>The bidding policy for the pay-as-you-go instance. This parameter takes effect when the <c>InstanceChargeType</c> parameter is set to <c>PostPaid</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: a regular pay-as-you-go instance.</description></item>
        /// <item><description>SpotAsPriceGo: the system automatically bids at the current market price.</description></item>
        /// </list>
        /// <para>Default value: NoSpot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SpotAsPriceGo</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>The system cloud disk specifications.</para>
        /// </summary>
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public string SystemDiskShrink { get; set; }

        /// <summary>
        /// <para>The tags that are bound to the instance.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<RunInstancesShrinkRequestTag> Tag { get; set; }
        public class RunInstancesShrinkRequestTag : TeaModel {
            /// <summary>
            /// <para>The custom tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>team</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The tag value cannot exceed 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>, or contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to add sequential suffixes to <b>HostName</b> and <b>InstanceName</b>. The sequential suffixes start from 001 and cannot exceed 999.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("UniqueSuffix")]
        [Validation(Required=false)]
        public bool? UniqueSuffix { get; set; }

        /// <summary>
        /// <para>The custom user data. Maximum size: 16 KB. You can pass in <b>UserData</b> information. <b>UserData</b> is Base64-encoded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZWtest</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// <remarks>
        /// <para>This parameter can only be used for node-level scheduling. An error is returned if this parameter is specified for region-level scheduling.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-5sagnw7m613oulalkd10n****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The VPD network ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpd-5s7xxxxxxx</para>
        /// </summary>
        [NameInMap("VpdId")]
        [Validation(Required=false)]
        public string VpdId { get; set; }

        /// <summary>
        /// <para>The list of VPD vSwitch IDs.</para>
        /// </summary>
        [NameInMap("VpdVSwitchIds")]
        [Validation(Required=false)]
        public string VpdVSwitchIdsShrink { get; set; }

    }

}
