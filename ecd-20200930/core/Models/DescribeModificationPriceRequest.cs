// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeModificationPriceRequest : TeaModel {
        /// <summary>
        /// <para>The maximum public bandwidth. Unit: Mbit/s.</para>
        /// <remarks>
        /// <para>Valid values when PayByTraffic is set to PayByBandwidth: 10 to 1000.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The ID of either the monthly subscription cloud computer with unlimited hours or the premium bandwidth plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-0gfv2z3sf95zvt****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The specifications.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values when you set <c>ResourceType</c> to <c>Desktop</c>:</para>
        /// <list type="bullet">
        /// <item><description><para>ecd.basic.small</para>
        /// </description></item>
        /// <item><description><para>ecd.basic.large</para>
        /// </description></item>
        /// <item><description><para>ecd.advanced.large</para>
        /// </description></item>
        /// <item><description><para>ecd.advanced.xlarge</para>
        /// </description></item>
        /// <item><description><para>ecd.performance.2xlarge</para>
        /// </description></item>
        /// <item><description><para>ecd.graphics.xlarge</para>
        /// </description></item>
        /// <item><description><para>ecd.graphics.2xlarge</para>
        /// </description></item>
        /// <item><description><para>ecd.advanced.xlarge_s8d2</para>
        /// </description></item>
        /// <item><description><para>ecd.advanced.xlarge_s8d7</para>
        /// </description></item>
        /// <item><description><para>ecd.graphics.1g72c</para>
        /// </description></item>
        /// <item><description><para>eds.general.2c2g</para>
        /// </description></item>
        /// <item><description><para>eds.general.2c4g</para>
        /// </description></item>
        /// <item><description><para>eds.general.2c8g</para>
        /// </description></item>
        /// <item><description><para>eds.general.4c8g</para>
        /// </description></item>
        /// <item><description><para>eds.general.4c16g</para>
        /// </description></item>
        /// <item><description><para>eds.general.8c16g</para>
        /// </description></item>
        /// <item><description><para>eds.general.8c32g</para>
        /// </description></item>
        /// <item><description><para>eds.general.16c32g</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>You can skip this parameter if <c>ResourceType</c> is set to <c>NetworkPackage</c>.</para>
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
        /// <para>Promotion activity ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>youhuiquan_promotion_option_id_for_blank</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="t2167755.xdita#"></a>operation to query the list of regions where Elastic Desktop Service (EDS) Enterprise is available.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>User ID for resource ownership in resale mode. You do not need to specify this parameter if resale mode is not used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1422724566551XXX</para>
        /// </summary>
        [NameInMap("ResellerOwnerUid")]
        [Validation(Required=false)]
        public long? ResellerOwnerUid { get; set; }

        /// <summary>
        /// <para>List of resource specification templates.</para>
        /// </summary>
        [NameInMap("ResourceSpecs")]
        [Validation(Required=false)]
        public List<DescribeModificationPriceRequestResourceSpecs> ResourceSpecs { get; set; }
        public class DescribeModificationPriceRequestResourceSpecs : TeaModel {
            /// <summary>
            /// <para>Cloud computer ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-6ghhzivgmnzgeyXXX</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>System disk size. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("RootDiskSizeGib")]
            [Validation(Required=false)]
            public int? RootDiskSizeGib { get; set; }

            /// <summary>
            /// <para>Data disk size. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("UserDiskSizeGib")]
            [Validation(Required=false)]
            public int? UserDiskSizeGib { get; set; }

        }

        /// <summary>
        /// <para>The resource type. The required parameters depend on the resource type.</para>
        /// <list type="bullet">
        /// <item><description><para>When <c>ResourceType</c> is set to <c>Desktop</c>, the required parameters are <c>InstanceType</c>, <c>RootDiskSizeGib</c>, and <c>UserDiskSizeGib</c>.</para>
        /// </description></item>
        /// <item><description><para>When <c>ResourceType</c> is set to <c>NetworkPackage</c>, the required parameter is <c>Bandwidth</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Desktop</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>Performance level of the system disk. When the WUYING Workspace instance type is set to graphics-optimized or high clock speed, you can specify the disk performance level. For differences between performance levels, see <a href="t583241.xdita#"></a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL0</para>
        /// </summary>
        [NameInMap("RootDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string RootDiskPerformanceLevel { get; set; }

        /// <summary>
        /// <para>The size of the system disk. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("RootDiskSizeGib")]
        [Validation(Required=false)]
        public int? RootDiskSizeGib { get; set; }

        /// <summary>
        /// <para>Performance level of the data disk. When the WUYING Workspace instance type is set to graphics-optimized or high clock speed, you can specify the disk performance level. For differences between performance levels, see <a href="t583241.xdita#"></a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL0</para>
        /// </summary>
        [NameInMap("UserDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string UserDiskPerformanceLevel { get; set; }

        /// <summary>
        /// <para>The size of the data disk. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("UserDiskSizeGib")]
        [Validation(Required=false)]
        public int? UserDiskSizeGib { get; set; }

    }

}
