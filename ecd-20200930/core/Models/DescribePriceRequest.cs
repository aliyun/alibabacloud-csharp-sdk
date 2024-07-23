// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribePriceRequest : TeaModel {
        /// <summary>
        /// <para>The number of the resources. Default value: 1.</para>
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
        /// <item><description>Valid values if the PayByTraffic parameter is set to PayByBandwidth: 10 to 1000</description></item>
        /// <item><description>Valid values if the PayByTraffic parameter is set to PayByTraffic: 10 to 200</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("BundleModels")]
        [Validation(Required=false)]
        public List<DescribePriceRequestBundleModels> BundleModels { get; set; }
        public class DescribePriceRequestBundleModels : TeaModel {
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public int? Amount { get; set; }

            [NameInMap("BundleId")]
            [Validation(Required=false)]
            public string BundleId { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            [NameInMap("RootDiskId")]
            [Validation(Required=false)]
            public string RootDiskId { get; set; }

            [NameInMap("UserDiskId")]
            [Validation(Required=false)]
            public string UserDiskId { get; set; }

        }

        [NameInMap("EduCdsEnable")]
        [Validation(Required=false)]
        public string EduCdsEnable { get; set; }

        [NameInMap("EduCdsSize")]
        [Validation(Required=false)]
        public int? EduCdsSize { get; set; }

        [NameInMap("EduCommittedTime")]
        [Validation(Required=false)]
        public int? EduCommittedTime { get; set; }

        [NameInMap("EduDesktopBundleId")]
        [Validation(Required=false)]
        public string EduDesktopBundleId { get; set; }

        [NameInMap("EduDesktopNum")]
        [Validation(Required=false)]
        public int? EduDesktopNum { get; set; }

        [NameInMap("EduRoomClassify")]
        [Validation(Required=false)]
        public string EduRoomClassify { get; set; }

        [NameInMap("EduStudentBundleId")]
        [Validation(Required=false)]
        public string EduStudentBundleId { get; set; }

        [NameInMap("EduStudentNum")]
        [Validation(Required=false)]
        public int? EduStudentNum { get; set; }

        [NameInMap("EduTeacherBundleId")]
        [Validation(Required=false)]
        public string EduTeacherBundleId { get; set; }

        [NameInMap("EduTeacherNum")]
        [Validation(Required=false)]
        public int? EduTeacherNum { get; set; }

        [NameInMap("GroupDesktopCount")]
        [Validation(Required=false)]
        public int? GroupDesktopCount { get; set; }

        /// <summary>
        /// <para>The model of the WUYING hardware client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hide</para>
        /// </summary>
        [NameInMap("HardwareVersion")]
        [Validation(Required=false)]
        public string HardwareVersion { get; set; }

        /// <summary>
        /// <para>The resource specifications.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set ResourceType to Desktop, set this parameter to one of the following values:</para>
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
        /// <item><description><para>If you set ResourceType to OfficeSite, set this parameter to large.</para>
        /// </description></item>
        /// <item><description><para>If you set ResourceType to Bandwidth, leave this parameter empty.</para>
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
        /// <para>The metering method of the Internet access package. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PayByBandwidth: pay-by-bandwidth</description></item>
        /// <item><description>PayByTraffic: pay-by-data-transfer</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The OS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Windows</description></item>
        /// <item><description>Linux</description></item>
        /// </list>
        /// <para>Default value: Windows.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Windows</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        [NameInMap("PackageSize")]
        [Validation(Required=false)]
        public int? PackageSize { get; set; }

        /// <summary>
        /// <para>The subscription duration. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the billing cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Hour</description></item>
        /// <item><description>Month</description></item>
        /// <item><description>Year</description></item>
        /// </list>
        /// <para>Default value: Hour.</para>
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
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Desktop: cloud desktop</description></item>
        /// <item><description>OfficeSite: workspace</description></item>
        /// <item><description>Bandwidth: network bandwidth</description></item>
        /// </list>
        /// <para>Default value: Desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Desktop</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The performance level (PL) of the system disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PL0</description></item>
        /// <item><description>PL1</description></item>
        /// <item><description>PL2</description></item>
        /// <item><description>PL3</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PL0</para>
        /// </summary>
        [NameInMap("RootDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string RootDiskPerformanceLevel { get; set; }

        /// <summary>
        /// <para>The system disk size. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("RootDiskSizeGib")]
        [Validation(Required=false)]
        public int? RootDiskSizeGib { get; set; }

        [NameInMap("SpPeriodInfo")]
        [Validation(Required=false)]
        public string SpPeriodInfo { get; set; }

        [NameInMap("SpPrice")]
        [Validation(Required=false)]
        public bool? SpPrice { get; set; }

        [NameInMap("SpType")]
        [Validation(Required=false)]
        public string SpType { get; set; }

        /// <summary>
        /// <para>The PL of the data disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PL0</description></item>
        /// <item><description>PL1</description></item>
        /// <item><description>PL2</description></item>
        /// <item><description>PL3</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PL0</para>
        /// </summary>
        [NameInMap("UserDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string UserDiskPerformanceLevel { get; set; }

        /// <summary>
        /// <para>The data disk size. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("UserDiskSizeGib")]
        [Validation(Required=false)]
        public int? UserDiskSizeGib { get; set; }

    }

}
