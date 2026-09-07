// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeVulDesktopsRequest : TeaModel {
        /// <summary>
        /// <para>The CVE ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CVE-2026-43284</para>
        /// </summary>
        [NameInMap("CveId")]
        [Validation(Required=false)]
        public string CveId { get; set; }

        /// <summary>
        /// <para>The list of cloud computer IDs.</para>
        /// </summary>
        [NameInMap("DesktopIdList")]
        [Validation(Required=false)]
        public List<string> DesktopIdList { get; set; }

        /// <summary>
        /// <para>Specifies whether to include patch update results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeFixResult")]
        [Validation(Required=false)]
        public bool? IncludeFixResult { get; set; }

        /// <summary>
        /// <para>The language type of the returned information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ch</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query.</para>
        /// <para>Maximum value: 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6nmB7qrRFJ8vmttjxPL****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to include only cloud computers on which fix tasks were executed in the current month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OnlyCurrentMonthFixAttempted")]
        [Validation(Required=false)]
        public bool? OnlyCurrentMonthFixAttempted { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The patch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KB5082063</para>
        /// </summary>
        [NameInMap("PatchId")]
        [Validation(Required=false)]
        public string PatchId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to query the regions supported by WUYING Workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-f3s3dgt8dtb0vlqc8</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The region ID used to filter cloud computer information for a specific region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("SearchRegionId")]
        [Validation(Required=false)]
        public string SearchRegionId { get; set; }

        /// <summary>
        /// <para>The list of vulnerability status details.</para>
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public List<string> StatusList { get; set; }

        /// <summary>
        /// <para>The security level of the intrusion prevention event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>low</b>: Low risk.</description></item>
        /// <item><description><b>medium</b>: Medium risk.</description></item>
        /// <item><description><b>critical</b>: High risk.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not set this parameter, vulnerabilities of all security levels are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>low</para>
        /// </summary>
        [NameInMap("VulLevel")]
        [Validation(Required=false)]
        public string VulLevel { get; set; }

    }

}
