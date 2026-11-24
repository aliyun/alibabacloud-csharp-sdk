// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeVulDesktopsRequest : TeaModel {
        /// <summary>
        /// <para>The connection status of the cloud desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Connected</para>
        /// </summary>
        [NameInMap("ConnectionStatus")]
        [Validation(Required=false)]
        public string ConnectionStatus { get; set; }

        /// <summary>
        /// <para>The vulnerability ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CVE-2026-43284</para>
        /// </summary>
        [NameInMap("CveId")]
        [Validation(Required=false)]
        public string CveId { get; set; }

        /// <summary>
        /// <para>The list of cloud desktop IDs.</para>
        /// </summary>
        [NameInMap("DesktopIdList")]
        [Validation(Required=false)]
        public List<string> DesktopIdList { get; set; }

        /// <summary>
        /// <para>The running status of the cloud desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("DesktopStatus")]
        [Validation(Required=false)]
        public string DesktopStatus { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the patch update results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeFixResult")]
        [Validation(Required=false)]
        public bool? IncludeFixResult { get; set; }

        /// <summary>
        /// <para>Specifies whether to include cloud desktops that have scheduled patch tasks.</para>
        /// </summary>
        [NameInMap("IncludePatchTask")]
        [Validation(Required=false)]
        public bool? IncludePatchTask { get; set; }

        /// <summary>
        /// <para>The language of the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ch</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paging query.
        /// Maximum value: 100.
        /// Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6nmB7qrRFJ8vmttjxPL****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to include only cloud desktops for which fix tasks have been executed in the current month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OnlyCurrentMonthFixAttempted")]
        [Validation(Required=false)]
        public bool? OnlyCurrentMonthFixAttempted { get; set; }

        /// <summary>
        /// <para>The page number of the current page for a paging query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size for a paging query.</para>
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
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the list of regions supported by WUYING Workspace.</para>
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
        /// <para>The search region ID. This parameter is used to filter cloud desktop information for a specified region.</para>
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
        /// <item><description><b>low</b>: low-risk.</description></item>
        /// <item><description><b>medium</b>: medium-risk.</description></item>
        /// <item><description><b>critical</b>: high-risk.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, vulnerabilities of all security levels are queried.</para>
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
