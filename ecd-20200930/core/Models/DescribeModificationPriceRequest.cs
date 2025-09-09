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
        /// <para> Valid values when PayByTraffic is set to PayByBandwidth: 10 to 1000.</para>
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

        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query the list of regions where Elastic Desktop Service (EDS) Enterprise is available.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResellerOwnerUid")]
        [Validation(Required=false)]
        public long? ResellerOwnerUid { get; set; }

        [NameInMap("ResourceSpecs")]
        [Validation(Required=false)]
        public List<DescribeModificationPriceRequestResourceSpecs> ResourceSpecs { get; set; }
        public class DescribeModificationPriceRequestResourceSpecs : TeaModel {
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            [NameInMap("RootDiskSizeGib")]
            [Validation(Required=false)]
            public int? RootDiskSizeGib { get; set; }

            [NameInMap("UserDiskSizeGib")]
            [Validation(Required=false)]
            public int? UserDiskSizeGib { get; set; }

        }

        /// <summary>
        /// <para>The resource type. The required parameters depend on the resource type.</para>
        /// <list type="bullet">
        /// <item><description>When <c>ResourceType</c> is set to <c>Desktop</c>, the required parameters are <c>InstanceType</c>, <c>RootDiskSizeGib</c>, and <c>UserDiskSizeGib</c>.</description></item>
        /// <item><description>When <c>ResourceType</c> is set to <c>NetworkPackage</c>, the required parameter is <c>Bandwidth</c>.</description></item>
        /// </list>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Desktop (default): cloud computers.</description></item>
        /// <item><description>NetworkPackage: premium bandwidth plans.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Desktop</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

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
