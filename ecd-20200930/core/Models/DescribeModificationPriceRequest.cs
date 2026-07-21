// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeModificationPriceRequest : TeaModel {
        /// <summary>
        /// <para>The peak Internet bandwidth. Unit: Mbit/s.</para>
        /// <remarks>
        /// <para>If you use the pay-by-bandwidth billing method, the valid values range from 10 to 1000.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The instance ID. The value can be the ID of a monthly-subscribed (unlimited-duration) cloud computer or the ID of a premium Internet bandwidth instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-0gfv2z3sf95zvt****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The resource specification.</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>ResourceType</c> is set to <c>Desktop</c>, valid values include:</para>
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
        /// <item><description><para>If <c>ResourceType</c> is set to <c>NetworkPackage</c>, you do not need to specify this parameter.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>eds.enterprise_office.8c16g</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The promotion ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>youhuiquan_promotion_option_id_for_blank</para>
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
        /// <para>The user ID for resource ownership in the reseller pattern. You do not need to specify this parameter in non-reseller pattern.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1422724566551XXX</para>
        /// </summary>
        [NameInMap("ResellerOwnerUid")]
        [Validation(Required=false)]
        public long? ResellerOwnerUid { get; set; }

        /// <summary>
        /// <para>The list of resource specification templates.</para>
        /// </summary>
        [NameInMap("ResourceSpecs")]
        [Validation(Required=false)]
        public List<DescribeModificationPriceRequestResourceSpecs> ResourceSpecs { get; set; }
        public class DescribeModificationPriceRequestResourceSpecs : TeaModel {
            /// <summary>
            /// <para>The cloud computer ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-6ghhzivgmnzgeyXXX</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The system cloud disk size. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("RootDiskSizeGib")]
            [Validation(Required=false)]
            public int? RootDiskSizeGib { get; set; }

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

        /// <summary>
        /// <para>The resource type. The required parameters vary based on the resource type for which you want to query the specification change price:</para>
        /// <list type="bullet">
        /// <item><description>If <c>ResourceType</c> is set to <c>Desktop</c>, you must specify the <c>InstanceType</c>, <c>RootDiskSizeGib</c>, and <c>UserDiskSizeGib</c> parameters.</description></item>
        /// <item><description>If <c>ResourceType</c> is set to <c>NetworkPackage</c>, you must specify the <c>Bandwidth</c> parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Desktop</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The performance level of the system cloud disk. You can configure the disk performance level in Settings when the cloud computer specification is set to graphics-accelerated or high frequency. For more information about the differences between performance levels, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>. standard SSD does not support performance level configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL0</para>
        /// </summary>
        [NameInMap("RootDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string RootDiskPerformanceLevel { get; set; }

        /// <summary>
        /// <para>The system cloud disk size. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("RootDiskSizeGib")]
        [Validation(Required=false)]
        public int? RootDiskSizeGib { get; set; }

        /// <summary>
        /// <para>The performance level of the data cloud disk. You can configure the disk performance level in Settings when the cloud computer specification is set to graphics-accelerated or high frequency. For more information about the differences between performance levels, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>. standard SSD does not support performance level configuration.</para>
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
        /// <para>50</para>
        /// </summary>
        [NameInMap("UserDiskSizeGib")]
        [Validation(Required=false)]
        public int? UserDiskSizeGib { get; set; }

    }

}
