// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RunInstancesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The number of instances that you want to create. Valid values: 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public long? Amount { get; set; }

        /// <summary>
        /// <para>The time when to automatically release the pay-as-you-go instance. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in Coordinated Universal Time (UTC).</para>
        /// <list type="bullet">
        /// <item><description>If the value of <c>ss</c> is not <c>00</c>, the start time is automatically rounded down to the nearest minute based on the value of <c>mm</c>.</description></item>
        /// <item><description>The specified time must be at least one hour later than the current time.</description></item>
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
        /// <item><description><b>true</b>.</description></item>
        /// <item><description><b>false</b> (default).</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is not available when InstanceChargeType is set to PostPaid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>Specifies whether to use coupons. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public string AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The billing cycle of computing resources of the instance. Only pay-as-you-go instances are supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Day</b>.</description></item>
        /// <item><description><b>Month</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Day</para>
        /// </summary>
        [NameInMap("BillingCycle")]
        [Validation(Required=false)]
        public string BillingCycle { get; set; }

        /// <summary>
        /// <para>The Internet service provider (ISP).</para>
        /// <remarks>
        /// <para> This parameter is not available if ScheduleAreaLevel is set to Region and is required if ScheduleAreaLevel is set to other values.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>telecom</para>
        /// </summary>
        [NameInMap("Carrier")]
        [Validation(Required=false)]
        public string Carrier { get; set; }

        /// <summary>
        /// <para>The specifications of data disks.</para>
        /// </summary>
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public string DataDiskShrink { get; set; }

        /// <summary>
        /// <para>The ID of the node.</para>
        /// <remarks>
        /// <para> This parameter is required if ScheduleAreaLevel is set to Region and is not available if ScheduleAreaLevel is set to other values.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-foshan-telecom</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The name of the host.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-HostName</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The ID of the image. For ARM PCB-based server instances, leave this parameter empty. For other instances, this parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-5si16wo6simkt267p8b7hcmy3</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The billing policy of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>instance</b>: Bills are generated based on instances.</description></item>
        /// <item><description>If you do not specify this parameter, bills are generated based on users.</description></item>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The name of the instance. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with <c>http://</c> or <c>https://</c>. It can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// <para>The default value of this parameter is the value of the InstanceId parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestName</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The instance type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ens.sn1.small</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The bandwidth billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BandwidthByDay</b>: pay by daily peak bandwidth</description></item>
        /// <item><description><b>95BandwidthByMonth</b>: pay by monthly 95th percentile bandwidth</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required if you purchase an ENS instance for the first time. The value that you specified is used as the default value for subsequent purchases.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>BandwidthByDay</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The maximum public bandwidth. If the value of this parameter is greater than 0, a public IP address is assigned to the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public long? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// <para>The type of the IP address. Examples:</para>
        /// <list type="bullet">
        /// <item><description><b>ipv4</b> (default).</description></item>
        /// <item><description><b>ipv6</b>.</description></item>
        /// <item><description><b>ipv4Andipv6</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4</para>
        /// </summary>
        [NameInMap("IpType")]
        [Validation(Required=false)]
        public string IpType { get; set; }

        /// <summary>
        /// <para>The name of the key pair.</para>
        /// <remarks>
        /// <para> You need to specify at least one of <b>Password</b>, <b>KeyPairName</b>, and <b>PasswordInherit</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>wx2-jumpserver</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The code of the region.</para>
        /// <remarks>
        /// <para> This parameter is not available if ScheduleAreaLevel is set to Region and is required if ScheduleAreaLevel is set to other values.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>350000</para>
        /// </summary>
        [NameInMap("NetDistrictCode")]
        [Validation(Required=false)]
        public string NetDistrictCode { get; set; }

        /// <summary>
        /// <para>The ID of the network.</para>
        /// <remarks>
        /// <para> This parameter is available only if ScheduleAreaLevel is set to Region and cannot be configured if ScheduleAreaLevel is set to other values. Otherwise, an error occurs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>net-id</para>
        /// </summary>
        [NameInMap("NetWorkId")]
        [Validation(Required=false)]
        public string NetWorkId { get; set; }

        /// <summary>
        /// <para>The password that is used to connect to the instance.</para>
        /// <remarks>
        /// <para> You need to specify at least one of <b>Password</b>, <b>KeyPairName</b>, and <b>PasswordInherit</b>.</para>
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
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> You need to specify at least one of <b>Password</b>, <b>KeyPairName</b>, and <b>PasswordInherit</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public bool? PasswordInherit { get; set; }

        /// <summary>
        /// <para>The unit of the subscription period.</para>
        /// <list type="bullet">
        /// <item><description>If <b>PeriodUnit</b> is set to <b>Day</b>, <b>Period</b> can only be set to <b>3</b>.</description></item>
        /// <item><description>If <b>PeriodUnit</b> is <b>Month</b>, <b>Period</b> can be set to <b>1 to 9</b> or <b>12</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1-9,12</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Month</b> (default).</description></item>
        /// <item><description><b>Day</b>.</description></item>
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
        /// <para> This parameter is available only if ScheduleAreaLevel is set to Region and cannot be configured if ScheduleAreaLevel is set to other values. Otherwise, an error occurs. If you specify a private IP address, the number of instances must be 1. The private IP address takes effect only when the private IP address and the vSwitch ID are not empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.120</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable public IP address identification. Valid values: true and false. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PublicIpIdentification")]
        [Validation(Required=false)]
        public bool? PublicIpIdentification { get; set; }

        /// <summary>
        /// <para>The scheduling level. This parameter specifies area-level scheduling or node-level scheduling. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Big</b>: greater area</description></item>
        /// <item><description><b>Middle</b>: province</description></item>
        /// <item><description><b>Small</b>: city</description></item>
        /// <item><description><b>Region</b>: node</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Region</para>
        /// </summary>
        [NameInMap("ScheduleAreaLevel")]
        [Validation(Required=false)]
        public string ScheduleAreaLevel { get; set; }

        /// <summary>
        /// <para>The scheduling price policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PriceHighPriority</b>: The high price prevails.</description></item>
        /// <item><description><b>PriceLowPriority</b>: The low price prevails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PriceHighPriority</para>
        /// </summary>
        [NameInMap("SchedulingPriceStrategy")]
        [Validation(Required=false)]
        public string SchedulingPriceStrategy { get; set; }

        /// <summary>
        /// <para>The scheduling policy of the taint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Concentrate</b></description></item>
        /// <item><description><b>Disperse</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> If ScheduleAreaLevel is set to Region, set this parameter to <b>Concentrate</b>. If ScheduleAreaLevel is set to other values, set this parameter to Concentrate or Disperse based on your business requirements.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>concentrate</para>
        /// </summary>
        [NameInMap("SchedulingStrategy")]
        [Validation(Required=false)]
        public string SchedulingStrategy { get; set; }

        /// <summary>
        /// <para>The ID of security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-test</para>
        /// </summary>
        [NameInMap("SecurityId")]
        [Validation(Required=false)]
        public string SecurityId { get; set; }

        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public int? SpotDuration { get; set; }

        /// <summary>
        /// <para>The bidding policy for the pay-as-you-go instance. This parameter is valid only when the <c>InstanceChargeType</c> parameter is set to <c>PostPaid</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: The instance is created as a regular pay-as-you-go instance.</description></item>
        /// <item><description>SpotAsPriceGo: The instance is a preemptible instance for which the market price at the time of purchase is automatically used as the bidding price.</description></item>
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
        /// <para>The specification of the system disk.</para>
        /// </summary>
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public string SystemDiskShrink { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<RunInstancesShrinkRequestTag> Tag { get; set; }
        public class RunInstancesShrinkRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>team</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to append sequential suffixes to the hostname specified by the <b>HostName</b> parameter and to the instance name specified by the <b>InstanceName</b> parameter. The sequential suffixes range from 001 to 999.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("UniqueSuffix")]
        [Validation(Required=false)]
        public bool? UniqueSuffix { get; set; }

        /// <summary>
        /// <para>The custom data. The maximum data size is 16 KB. You can specify <b>UserData</b>. <b>UserData</b> must be Base64-encoded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZWtest</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// <remarks>
        /// <para> This parameter is available only if ScheduleAreaLevel is set to Region and cannot be configured if ScheduleAreaLevel is set to other values. Otherwise, an error occurs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-5sagnw7m613oulalkd10nv0ob</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
