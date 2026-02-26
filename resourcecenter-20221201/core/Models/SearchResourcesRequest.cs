// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class SearchResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<SearchResourcesRequestFilter> Filter { get; set; }
        public class SearchResourcesRequestFilter : TeaModel {
            /// <summary>
            /// <para>The key of the filter condition. For more information about the valid values, see the &quot;<c>Supported filter parameters</c>&quot; section below.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RegionId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The matching method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Equals: Exact match.</para>
            /// </description></item>
            /// <item><description><para>Prefix: Prefix match.</para>
            /// </description></item>
            /// <item><description><para>Contains: Contains a value.</para>
            /// </description></item>
            /// <item><description><para>NotContains: Does not contain a value.</para>
            /// </description></item>
            /// <item><description><para>Exists: The key exists.</para>
            /// </description></item>
            /// <item><description><para>NotExists: The key does not exist.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Equals</para>
            /// </summary>
            [NameInMap("MatchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            /// <summary>
            /// <para>The value of the filter condition.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to include deleted resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeDeletedResources")]
        [Validation(Required=false)]
        public bool? IncludeDeletedResources { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// <para>Valid values: 1 to 500.</para>
        /// <para>Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of <c>NextToken</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJzZWFyY2hBZnRlcnMiOlsiMTAwMTU2Nzk4MTU1OSJd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The search keyword. Resource Center filters and sorts the search results based on relevance.
        /// If you do not specify a sorting parameter, resources that better match the keyword are displayed with higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>keywords</para>
        /// </summary>
        [NameInMap("SearchExpression")]
        [Validation(Required=false)]
        public string SearchExpression { get; set; }

        /// <summary>
        /// <para>The sorting parameters.</para>
        /// </summary>
        [NameInMap("SortCriterion")]
        [Validation(Required=false)]
        public SearchResourcesRequestSortCriterion SortCriterion { get; set; }
        public class SearchResourcesRequestSortCriterion : TeaModel {
            /// <summary>
            /// <para>The sort key.</para>
            /// <para>Set this parameter to <c>CreateTime</c>, which means the results are sorted by resource creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CreateTime</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The sort order. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ASC: Ascending order.</para>
            /// </description></item>
            /// <item><description><para>DESC: Descending order.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: ASC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ASC</para>
            /// </summary>
            [NameInMap("Order")]
            [Validation(Required=false)]
            public string Order { get; set; }

        }

    }

}
