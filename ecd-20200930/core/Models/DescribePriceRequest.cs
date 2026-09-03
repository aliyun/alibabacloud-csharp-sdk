// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribePriceRequest : TeaModel {
        /// <summary>
        /// <para>The resource count. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// <para>The peak Internet bandwidth. Unit: Mbit/s.</para>
        /// <list type="bullet">
        /// <item><description>For pay-by-bandwidth, valid values are 10 to 1000.</description></item>
        /// <item><description>For pay-by-traffic, valid values are 10 to 200.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The duration package type for monthly cloud desktop purchases. If ResourceType is set to DesktopMonthPackage, this parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>The number of shared cloud desktops. Default value: 1.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when ResourceType is set to DesktopGroup.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GroupDesktopCount")]
        [Validation(Required=false)]
        public int? GroupDesktopCount { get; set; }

        /// <summary>
        /// <para>The resource specification.</para>
        /// <list type="bullet">
        /// <item><description><para>If ResourceType is set to Desktop, this parameter is required. You can call <a href="~~DescribeDesktopTypes~~">DescribeDesktopTypes</a> to query available values (corresponding to the DesktopTypeId value).</para>
        /// </description></item>
        /// <item><description><para>If ResourceType is set to DesktopGroup, set this parameter to <c>large</c>.</para>
        /// </description></item>
        /// <item><description><para>If ResourceType is set to Bandwidth, you do not need to specify this parameter.</para>
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
        /// <para>The billing method of the Internet access package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The operating system type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Windows</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// <para>The subscription duration. Valid values are determined by the PeriodUnit parameter.</para>
        /// <list type="bullet">
        /// <item><description>If PeriodUnit is set to Hour, the valid value is 1.</description></item>
        /// <item><description>If PeriodUnit is set to Month, valid values are 1, 2, 3, and 6.</description></item>
        /// <item><description>If PeriodUnit is set to Year, valid values are 1, 2, and 3.</description></item>
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
        /// <para>The region ID. You can call <a href="~~DescribeRegions~~">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user ID for resource ownership in reseller mode. You do not need to specify this parameter in non-reseller mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1422724566551XXX</para>
        /// </summary>
        [NameInMap("ResellerOwnerUid")]
        [Validation(Required=false)]
        public long? ResellerOwnerUid { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Desktop</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The system cloud disk type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("RootDiskCategory")]
        [Validation(Required=false)]
        public string RootDiskCategory { get; set; }

        /// <summary>
        /// <para>The performance level (PL) of the system cloud disk. You can set the disk performance level when the cloud desktop specification is set to Graphics or High Frequency. For more information about the differences between performance levels, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD cloud disks</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL0</para>
        /// </summary>
        [NameInMap("RootDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string RootDiskPerformanceLevel { get; set; }

        /// <summary>
        /// <para>The system cloud disk size. Unit: GiB. If ResourceType is set to Desktop, this parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("RootDiskSizeGib")]
        [Validation(Required=false)]
        public int? RootDiskSizeGib { get; set; }

        /// <summary>
        /// <para>The data cloud disk type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("UserDiskCategory")]
        [Validation(Required=false)]
        public string UserDiskCategory { get; set; }

        /// <summary>
        /// <para>The performance level (PL) of the data cloud disk. You can set the disk performance level when the cloud desktop specification is set to Graphics or High Frequency. For more information about the differences between performance levels, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD cloud disks</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL0</para>
        /// </summary>
        [NameInMap("UserDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string UserDiskPerformanceLevel { get; set; }

        /// <summary>
        /// <para>The data cloud disk size. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("UserDiskSizeGib")]
        [Validation(Required=false)]
        public int? UserDiskSizeGib { get; set; }

    }

}
