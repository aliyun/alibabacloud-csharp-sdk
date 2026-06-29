// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListSitesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The access type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>NS</b>: NS-based access.</para>
        /// </description></item>
        /// <item><description><para><b>CNAME</b>: CNAME-based access.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NS</para>
        /// </summary>
        [NameInMap("AccessType")]
        [Validation(Required=false)]
        public string AccessType { get; set; }

        /// <summary>
        /// <para>The acceleration region. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>domestic</b>: the Chinese mainland only.</description></item>
        /// <item><description><b>global</b>: global.</description></item>
        /// <item><description><b>overseas</b>: global (excluding the Chinese mainland).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>global</para>
        /// </summary>
        [NameInMap("Coverage")]
        [Validation(Required=false)]
        public string Coverage { get; set; }

        /// <summary>
        /// <para>Specifies whether to query only Enterprise Edition sites. Set this parameter to <b>true</b> to query only Enterprise Edition sites.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OnlyEnterprise")]
        [Validation(Required=false)]
        public bool? OnlyEnterprise { get; set; }

        /// <summary>
        /// <para>The sort field. By default, results are sorted by creation time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>gmtCreate: site creation time.</description></item>
        /// <item><description>visitTime: site access time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>visitTime</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page number for paging. The value must be greater than or equal to 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for paging. Valid values: 1 to 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The plan subscription type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>basicplan</b>: Basic Edition.</description></item>
        /// <item><description><b>standardplan</b>: Standard Edition.</description></item>
        /// <item><description><b>advancedplan</b>: Premium Edition.</description></item>
        /// <item><description><b>enterpriseplan</b>: Enterprise Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>basicplan</para>
        /// </summary>
        [NameInMap("PlanSubscribeType")]
        [Validation(Required=false)]
        public string PlanSubscribeType { get; set; }

        /// <summary>
        /// <para>The resource group ID. Used as a filter condition for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzd3styujvyei</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The site name. Used as a filter condition for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("SiteName")]
        [Validation(Required=false)]
        public string SiteName { get; set; }

        /// <summary>
        /// <para>The search matching mode for the site name. Default is exact match. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>prefix</b>: prefix match.</description></item>
        /// <item><description><b>suffix</b>: suffix match.</description></item>
        /// <item><description><b>exact</b>: exact match.</description></item>
        /// <item><description><b>fuzzy</b>: fuzzy match.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fuzzy</para>
        /// </summary>
        [NameInMap("SiteSearchType")]
        [Validation(Required=false)]
        public string SiteSearchType { get; set; }

        /// <summary>
        /// <para>The site status. Used as a filter condition for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pending</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tag filter rules.</para>
        /// </summary>
        [NameInMap("TagFilter")]
        [Validation(Required=false)]
        public string TagFilterShrink { get; set; }

    }

}
