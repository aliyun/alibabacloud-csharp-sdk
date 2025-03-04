// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribePriceRequest : TeaModel {
        /// <summary>
        /// <para>The number of resources. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// <para>The maximum public bandwidth. Unit: Mbit/s.</para>
        /// <list type="bullet">
        /// <item><description>Valid values if you set InternetChargeType to PayByBandwidth: 10 to 1000.</description></item>
        /// <item><description>Valid values if you set InternetChargeType to InternetChargeType: 10 to 200.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The type of hourly plan if you use the Monthly Subscription billing method. If you set <c>ResourceType</c> to <c>DesktopMonthPackage</c>, you must specify this parameter.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>120: the 120-hour computing plan.</description></item>
        /// <item><description>250: the 250-hour computing plan.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>The number of cloud computers in the cloud computer pool. Default value: 1.</para>
        /// <remarks>
        /// <para> This parameter takes effect only if you set <c>ResourceType</c> to <c>DesktopGroup</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GroupDesktopCount")]
        [Validation(Required=false)]
        public int? GroupDesktopCount { get; set; }

        /// <summary>
        /// <para>The resource specifications.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set <c>ResourceType</c> to <c>Desktop</c>, you must specify this parameter.</para>
        /// <list type="bullet">
        /// <item><description>ecd.basic.small</description></item>
        /// <item><description>ecd.basic.large</description></item>
        /// <item><description>ecd.advanced.large</description></item>
        /// <item><description>ecd.advanced.xlarge</description></item>
        /// <item><description>ecd.performance.2xlarge</description></item>
        /// <item><description>ecd.graphics.xlarge</description></item>
        /// <item><description>ecd.graphics.2xlarge</description></item>
        /// <item><description>ecd.advanced.xlarge_s8d2</description></item>
        /// <item><description>ecd.advanced.xlarge_s8d7</description></item>
        /// <item><description>ecd.graphics.1g72c</description></item>
        /// <item><description>eds.general.2c2g</description></item>
        /// <item><description>eds.general.2c4g</description></item>
        /// <item><description>eds.general.2c8g</description></item>
        /// <item><description>eds.general.4c8g</description></item>
        /// <item><description>eds.general.4c16g</description></item>
        /// <item><description>eds.general.8c16g</description></item>
        /// <item><description>eds.general.8c32g</description></item>
        /// <item><description>eds.general.16c32g</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If you set <c>ResourceType</c> to <c>DesktopGroup</c>, set the value of this parameter to <c>large</c>.</para>
        /// </description></item>
        /// <item><description><para>If you set <c>ResourceType</c> to <c>Bandwidth</c>, you can leave this parameter empty.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>eds.general.2c2g</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The metering method for network traffic.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PayByTraffic: You are charged for the actually consumed traffic.</description></item>
        /// <item><description>PayByBandwidth: You are charged by a fixed bandwidth.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The OS type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Linux</description></item>
        /// <item><description>Windows (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Windows</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// <para>The subscription duration. The valid values of this parameter vary based on the value of <c>PeriodUnit</c>.</para>
        /// <list type="bullet">
        /// <item><description>If you set <c>PeriodUnit</c> to <c>Hour</c>, set the value of this parameter to 1.</description></item>
        /// <item><description>If you set <c>PeriodUnit</c> to <c>Month</c>, set the value of this parameter to 1, 2, 3, or 6.</description></item>
        /// <item><description>If you set <c>PeriodUnit</c> to <c>Year</c>, set the value of this parameter to 1, 2, or 3.</description></item>
        /// </list>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The billing cycle.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month</description></item>
        /// <item><description>Year</description></item>
        /// <item><description>Hour (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Hour</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The promotion ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query the regions supported by EDS.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DesktopMonthPackage: the monthly subscription plan (also known as the 120-hour or 250-hour computing plan).</description></item>
        /// <item><description>Desktop (default): the pay-as-you-go cloud computer or the monthly subscription cloud computer (also known as the Unlimited computing plan).</description></item>
        /// <item><description>Bandwidth: the premium bandwidth plan.</description></item>
        /// <item><description>DesktopGroup: the cloud computer pool.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Desktop</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("RootDiskCategory")]
        [Validation(Required=false)]
        public string RootDiskCategory { get; set; }

        /// <summary>
        /// <para>The size of the system disk. Unit: GiB. If you set <c>ResourceType</c> to <c>Desktop</c>, you must specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("RootDiskSizeGib")]
        [Validation(Required=false)]
        public int? RootDiskSizeGib { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("UserDiskCategory")]
        [Validation(Required=false)]
        public string UserDiskCategory { get; set; }

        /// <summary>
        /// <para>The size of the data disk. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("UserDiskSizeGib")]
        [Validation(Required=false)]
        public int? UserDiskSizeGib { get; set; }

    }

}
