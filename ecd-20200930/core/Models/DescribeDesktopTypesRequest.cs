// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopTypesRequest : TeaModel {
        /// <summary>
        /// <para>The applicable scope of the specification. Default value: <c>Public</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("AppliedScope")]
        [Validation(Required=false)]
        public string AppliedScope { get; set; }

        /// <summary>
        /// <para>The business channel. Valid values:
        /// Enterprise: Enterprise Edition.
        /// Business: Business Edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enterprise</para>
        /// </summary>
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
        /// <para>The ID of the shared cloud computer for which you want to change the specification. If this parameter is specified, the response includes compatibility information between the specification and the shared cloud computer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dg-abcdefg****</para>
        /// </summary>
        [NameInMap("DesktopGroupIdForModify")]
        [Validation(Required=false)]
        public string DesktopGroupIdForModify { get; set; }

        /// <summary>
        /// <para>The ID of the cloud computer for which you want to change the specification. If this parameter is specified, the response includes compatibility information between the specification and the cloud computer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-gx2x1dhsmucyy****</para>
        /// </summary>
        [NameInMap("DesktopIdForModify")]
        [Validation(Required=false)]
        public string DesktopIdForModify { get; set; }

        /// <summary>
        /// <para>The scenarios of the cloud computer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>office</para>
        /// </summary>
        [NameInMap("DesktopScenario")]
        [Validation(Required=false)]
        public string DesktopScenario { get; set; }

        /// <summary>
        /// <para>The specification ID.</para>
        /// <remarks>
        /// <para>If both <c>InstanceTypeFamily</c> and <c>DesktopTypeId</c> are left empty, information about all cloud computer specifications is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ecd.graphics.xlarge</para>
        /// </summary>
        [NameInMap("DesktopTypeId")]
        [Validation(Required=false)]
        public string DesktopTypeId { get; set; }

        /// <summary>
        /// <para>The list of specification IDs.</para>
        /// </summary>
        [NameInMap("DesktopTypeIdList")]
        [Validation(Required=false)]
        public List<string> DesktopTypeIdList { get; set; }

        /// <summary>
        /// <para>The number of GPU cores.</para>
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

        /// <summary>
        /// <para>The GPU memory size. This parameter is meaningful only for GPU-accelerated cloud computers. Unit: MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("GpuMemory")]
        [Validation(Required=false)]
        public int? GpuMemory { get; set; }

        /// <summary>
        /// <para>The instance family name.</para>
        /// <remarks>
        /// <para>If both <c>InstanceTypeFamily</c> and <c>DesktopTypeId</c> are left empty, information about all cloud computer specifications is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ecd.graphics</para>
        /// </summary>
        [NameInMap("InstanceTypeFamily")]
        [Validation(Required=false)]
        public string InstanceTypeFamily { get; set; }

        /// <summary>
        /// <para>The memory size. Unit: MiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4096</para>
        /// </summary>
        [NameInMap("MemorySize")]
        [Validation(Required=false)]
        public int? MemorySize { get; set; }

        /// <summary>
        /// <para>The ID of the office network to which the shared cloud computer belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+os-c5cy7q578s8jc****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The field by which to sort the results. If this parameter is not specified, results are sorted by creation time in descending order.</para>
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
        /// <para>The region ID. You can call <a href="~~DescribeRegions~~">DescribeRegions</a> to query the regions supported by WUYING Workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The billing method of the specification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FastBuy</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The list of applicable scopes.</para>
        /// </summary>
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
        /// <para>The minimum number of multi-sessions supported by the specification.</para>
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
        /// <para>cn-hangzhou-j</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
