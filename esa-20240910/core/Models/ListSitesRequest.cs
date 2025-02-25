// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListSitesRequest : TeaModel {
        /// <summary>
        /// <para>Access type. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>NS</b>: Access through NS hosting.</description></item>
        /// <item><description><b>CNAME</b>: Access through CNAME.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NS</para>
        /// </summary>
        [NameInMap("AccessType")]
        [Validation(Required=false)]
        public string AccessType { get; set; }

        /// <summary>
        /// <para>Acceleration region. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>domestic</b>: China mainland only.</description></item>
        /// <item><description><b>global</b>: Global.</description></item>
        /// <item><description><b>overseas</b>: Global (excluding China mainland).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>global</para>
        /// </summary>
        [NameInMap("Coverage")]
        [Validation(Required=false)]
        public string Coverage { get; set; }

        /// <summary>
        /// <para>Enterprise edition only. When set to <b>true</b>, it indicates that only enterprise edition sites are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OnlyEnterprise")]
        [Validation(Required=false)]
        public bool? OnlyEnterprise { get; set; }

        /// <summary>
        /// <para>Sorting field, default sorted by creation time, supports:</para>
        /// <list type="bullet">
        /// <item><description>gmtCreate: Site creation time</description></item>
        /// <item><description>visitTime: Site access time</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>visitTime</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>Page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size. Default value: <b>500</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Plan subscription type. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>basicplan</b>: Basic plan.</description></item>
        /// <item><description><b>standardplan</b>: Standard plan.</description></item>
        /// <item><description><b>advancedplan</b>: Advanced plan.</description></item>
        /// <item><description><b>enterpriseplan</b>: Enterprise plan.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>basicplan</para>
        /// </summary>
        [NameInMap("PlanSubscribeType")]
        [Validation(Required=false)]
        public string PlanSubscribeType { get; set; }

        /// <summary>
        /// <para>Resource group ID. Used as a filter condition for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzd3styujvyei</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Site name. Used as a filter condition for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("SiteName")]
        [Validation(Required=false)]
        public string SiteName { get; set; }

        /// <summary>
        /// <para>Search match pattern for the site name. The default is exact match, with values:</para>
        /// <list type="bullet">
        /// <item><description><b>prefix</b>: Prefix match.</description></item>
        /// <item><description><b>suffix</b>: Suffix match.</description></item>
        /// <item><description><b>exact</b>: Exact match.</description></item>
        /// <item><description><b>fuzzy</b>: Fuzzy match.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fuzzy</para>
        /// </summary>
        [NameInMap("SiteSearchType")]
        [Validation(Required=false)]
        public string SiteSearchType { get; set; }

        /// <summary>
        /// <para>Site status. Used as a filter condition for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pending</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Tag filtering rules.</para>
        /// </summary>
        [NameInMap("TagFilter")]
        [Validation(Required=false)]
        public List<ListSitesRequestTagFilter> TagFilter { get; set; }
        public class ListSitesRequestTagFilter : TeaModel {
            /// <summary>
            /// <para>Tag key, used as a filter condition for the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Tag value, used as a filter condition for the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aaa</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
