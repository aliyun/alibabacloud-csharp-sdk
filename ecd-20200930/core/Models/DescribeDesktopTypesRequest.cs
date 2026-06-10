// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopTypesRequest : TeaModel {
        /// <summary>
        /// <para>The scope of the instance types to query. Default value: <c>Public</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("AppliedScope")]
        [Validation(Required=false)]
        public string AppliedScope { get; set; }

        [NameInMap("BusinessChannel")]
        [Validation(Required=false)]
        public string BusinessChannel { get; set; }

        /// <summary>
        /// <para>The number of vCPUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CpuCount")]
        [Validation(Required=false)]
        public int? CpuCount { get; set; }

        /// <summary>
        /// <para>The ID of the desktop group to reconfigure. If you specify this parameter, the response returns only the instance types that are compatible with the specified group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dg-abcdefg****</para>
        /// </summary>
        [NameInMap("DesktopGroupIdForModify")]
        [Validation(Required=false)]
        public string DesktopGroupIdForModify { get; set; }

        /// <summary>
        /// <para>The ID of the WUYING Workspace to reconfigure. If you specify this parameter, the response returns only the instance types that are compatible with the specified workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-gx2x1dhsmucyy****</para>
        /// </summary>
        [NameInMap("DesktopIdForModify")]
        [Validation(Required=false)]
        public string DesktopIdForModify { get; set; }

        [NameInMap("DesktopScenario")]
        [Validation(Required=false)]
        public string DesktopScenario { get; set; }

        /// <summary>
        /// <para>The ID of the instance type.</para>
        /// <remarks>
        /// <para>If you omit both the <c>InstanceTypeFamily</c> and <c>DesktopTypeId</c> parameters, the operation returns all available WUYING Workspace instance types.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ecd.graphics.xlarge</para>
        /// </summary>
        [NameInMap("DesktopTypeId")]
        [Validation(Required=false)]
        public string DesktopTypeId { get; set; }

        /// <summary>
        /// <para>An array of instance type IDs.</para>
        /// </summary>
        [NameInMap("DesktopTypeIdList")]
        [Validation(Required=false)]
        public List<string> DesktopTypeIdList { get; set; }

        /// <summary>
        /// <para>The number of vGPUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GpuCount")]
        [Validation(Required=false)]
        public float? GpuCount { get; set; }

        /// <summary>
        /// <para>The GPU driver type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A10</para>
        /// </summary>
        [NameInMap("GpuDriverType")]
        [Validation(Required=false)]
        public string GpuDriverType { get; set; }

        [NameInMap("GpuMemory")]
        [Validation(Required=false)]
        public int? GpuMemory { get; set; }

        /// <summary>
        /// <para>The instance type family.</para>
        /// <remarks>
        /// <para>If you omit both the <c>InstanceTypeFamily</c> and <c>DesktopTypeId</c> parameters, the operation returns all available WUYING Workspace instance types.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ecd.graphics</para>
        /// </summary>
        [NameInMap("InstanceTypeFamily")]
        [Validation(Required=false)]
        public string InstanceTypeFamily { get; set; }

        /// <summary>
        /// <para>The memory size, in MiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4096</para>
        /// </summary>
        [NameInMap("MemorySize")]
        [Validation(Required=false)]
        public int? MemorySize { get; set; }

        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The property by which to sort the results. If you omit this parameter, the results are sorted by creation time in descending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Memory</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The order type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DOWNGRADE</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The ID of the region. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query the regions that Elastic Desktop Service supports.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The billing method of the instance types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FastBuy</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        [NameInMap("ScopeSet")]
        [Validation(Required=false)]
        public List<string> ScopeSet { get; set; }

        /// <summary>
        /// <para>The sort order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("SortType")]
        [Validation(Required=false)]
        public string SortType { get; set; }

        /// <summary>
        /// <para>Filters for instance types that support at least the specified number of concurrent sessions. This parameter applies only to multi-session instance types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SupportMinSessionCount")]
        [Validation(Required=false)]
        public int? SupportMinSessionCount { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
