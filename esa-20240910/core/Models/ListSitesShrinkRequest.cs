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
        /// <item><description><para><b>NS</b>: NS access.</para>
        /// </description></item>
        /// <item><description><para><b>CNAME</b>: CNAME access.</para>
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
        /// <item><description><para><b>domestic</b>: Chinese mainland only.</para>
        /// </description></item>
        /// <item><description><para><b>global</b>: Global.</para>
        /// </description></item>
        /// <item><description><para><b>overseas</b>: Global (excluding the Chinese mainland).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>global</para>
        /// </summary>
        [NameInMap("Coverage")]
        [Validation(Required=false)]
        public string Coverage { get; set; }

        /// <summary>
        /// <para>Specifies whether to return only sites that use the Enterprise Edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OnlyEnterprise")]
        [Validation(Required=false)]
        public bool? OnlyEnterprise { get; set; }

        /// <summary>
        /// <para>The field to sort the results by. By default, results are sorted by creation time (gmtCreate). Supported values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>gmtCreate</c>: site creation time</para>
        /// </description></item>
        /// <item><description><para><c>visitTime</c>: site access time</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>visitTime</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The number of the page to return. The default value is <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. The default value is <b>500</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The subscription plan type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>basicplan</b>: Basic Edition.</para>
        /// </description></item>
        /// <item><description><para><b>standardplan</b>: Standard Edition.</para>
        /// </description></item>
        /// <item><description><para><b>advancedplan</b>: Advanced Edition.</para>
        /// </description></item>
        /// <item><description><para><b>enterpriseplan</b>: Enterprise Edition.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>basicplan</para>
        /// </summary>
        [NameInMap("PlanSubscribeType")]
        [Validation(Required=false)]
        public string PlanSubscribeType { get; set; }

        /// <summary>
        /// <para>The resource group ID, used to filter query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzd3styujvyei</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The site name, used to filter query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("SiteName")]
        [Validation(Required=false)]
        public string SiteName { get; set; }

        /// <summary>
        /// <para>The match mode for the <c>SiteName</c> parameter. The default value is <c>exact</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>prefix</b>: prefix match.</para>
        /// </description></item>
        /// <item><description><para><b>suffix</b>: suffix match.</para>
        /// </description></item>
        /// <item><description><para><b>exact</b>: exact match.</para>
        /// </description></item>
        /// <item><description><para><b>fuzzy</b>: fuzzy match.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fuzzy</para>
        /// </summary>
        [NameInMap("SiteSearchType")]
        [Validation(Required=false)]
        public string SiteSearchType { get; set; }

        /// <summary>
        /// <para>The site status, used to filter query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pending</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>A list of tags to use for filtering sites.</para>
        /// </summary>
        [NameInMap("TagFilter")]
        [Validation(Required=false)]
        public string TagFilterShrink { get; set; }

    }

}
