// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopTypesRequest : TeaModel {
        /// <summary>
        /// <para>Applicable Scope of specifications. Default value: <c>Public</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("AppliedScope")]
        [Validation(Required=false)]
        public string AppliedScope { get; set; }

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
        /// <para>The ID of the cloud computer share you want to modify. If this parameter is provided, the response will include compatibility information for the specified specification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dg-abcdefg****</para>
        /// </summary>
        [NameInMap("DesktopGroupIdForModify")]
        [Validation(Required=false)]
        public string DesktopGroupIdForModify { get; set; }

        /// <summary>
        /// <para>The ID of the cloud computer when you change instance types of cloud computers. If you specify this parameter, the information about whether the instance type is compatible with the cloud computer is included in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-gx2x1dhsmucyy****</para>
        /// </summary>
        [NameInMap("DesktopIdForModify")]
        [Validation(Required=false)]
        public string DesktopIdForModify { get; set; }

        /// <summary>
        /// <para>The specification ID.</para>
        /// <remarks>
        /// <para> If both <c>InstanceTypeFamily</c> and <c>DesktopTypeId</c> are empty, all cloud computer specifications will be queried.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>eds.enterprise_office.4c8g</description></item>
        /// <item><description>eds.hf.4c8g</description></item>
        /// <item><description>ecd.basic.large</description></item>
        /// <item><description>ecd.advanced.large</description></item>
        /// <item><description>eds.enterprise_office.8c16g</description></item>
        /// <item><description>ecd.basic.small</description></item>
        /// <item><description>ecd.graphics.2xlarge</description></item>
        /// <item><description>eds.hf.8c16g</description></item>
        /// <item><description>eds.hf.12c24g</description></item>
        /// <item><description>eds.general.8c16g</description></item>
        /// <item><description>eds.general.16c32g</description></item>
        /// <item><description>ecd.advanced.xlarge</description></item>
        /// <item><description>eds.graphics.16c1t4</description></item>
        /// <item><description>ecd.graphics.xlarge</description></item>
        /// <item><description>ecd.performance.2xlarge</description></item>
        /// <item><description>eds.general.8c32g</description></item>
        /// <item><description>eds.general.2c2g</description></item>
        /// <item><description>eds.general.2c4g</description></item>
        /// <item><description>eds.graphics.24c1t4</description></item>
        /// <item><description>eds.general.4c8g</description></item>
        /// <item><description>eds.enterprise_office.2c4g</description></item>
        /// <item><description>eds.general.4c16g</description></item>
        /// <item><description>eds.general.2c8g</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ecd.graphics.xlarge</para>
        /// </summary>
        [NameInMap("DesktopTypeId")]
        [Validation(Required=false)]
        public string DesktopTypeId { get; set; }

        /// <summary>
        /// <para>The specification IDs.</para>
        /// </summary>
        [NameInMap("DesktopTypeIdList")]
        [Validation(Required=false)]
        public List<string> DesktopTypeIdList { get; set; }

        /// <summary>
        /// <para>The number of GPUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GpuCount")]
        [Validation(Required=false)]
        public float? GpuCount { get; set; }

        /// <summary>
        /// <para>The GPU driver type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>T4</description></item>
        /// <item><description>A10</description></item>
        /// <item><description>G28</description></item>
        /// <item><description>G39</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>A10</para>
        /// </summary>
        [NameInMap("GpuDriverType")]
        [Validation(Required=false)]
        public string GpuDriverType { get; set; }

        /// <summary>
        /// <para>The GPU memory size. Unit: MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("GpuMemory")]
        [Validation(Required=false)]
        public int? GpuMemory { get; set; }

        /// <summary>
        /// <para>The name of the specification family.</para>
        /// <remarks>
        /// <para> If both <c>InstanceTypeFamily</c> and <c>DesktopTypeId</c> are empty, all specification families will be queried.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ecd.advanced</description></item>
        /// <item><description>eds.graphics</description></item>
        /// <item><description>ecd.basic</description></item>
        /// <item><description>eds.enterprise_office</description></item>
        /// <item><description>eds.hf</description></item>
        /// <item><description>ecd.graphics</description></item>
        /// <item><description>eds.general</description></item>
        /// <item><description>ecd.performance</description></item>
        /// </list>
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
        /// <para>4</para>
        /// </summary>
        [NameInMap("MemorySize")]
        [Validation(Required=false)]
        public int? MemorySize { get; set; }

        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The sorting field. If this parameter is not provided, results are sorted by creation time in descending order.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Memory: sorts by memory size.</description></item>
        /// <item><description>Cpu: sorts by the number of vCPUs.</description></item>
        /// </list>
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
        /// <para>The region ID. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query the list of regions where Elastic Desktop Service (EDS) Enterprise is available.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The sales mode of the specification.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MonthPackage: the monthly subscription mode.</description></item>
        /// <item><description>FastBuy: the quick purchase mode.</description></item>
        /// </list>
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
        /// <para>The sorting order.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC (default): the ascending order.</description></item>
        /// <item><description>DESC: the descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("SortType")]
        [Validation(Required=false)]
        public string SortType { get; set; }

        /// <summary>
        /// <para>The number of sessions supported by the specification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SupportMinSessionCount")]
        [Validation(Required=false)]
        public int? SupportMinSessionCount { get; set; }

        /// <summary>
        /// <remarks>
        /// <para> This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
