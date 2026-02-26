// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class SearchMultiAccountResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<SearchMultiAccountResourcesRequestFilter> Filter { get; set; }
        public class SearchMultiAccountResourcesRequestFilter : TeaModel {
            /// <summary>
            /// <para>The key of the filter condition. For more information, see the &quot;<c>Supported filter parameters</c>&quot; section below.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ResourceGroupId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The matching method.</para>
            /// <para>Set this parameter to <c>Equals</c>, which means an exact match.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Equals</para>
            /// </summary>
            [NameInMap("MatchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            /// <summary>
            /// <para>The values of the filter condition.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries to return on each page.</para>
        /// <para>Valid values: 1 to 100.</para>
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
        /// <para>The scope of the accounts in which you want to search for resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>The ID of a resource directory: Searches for resources in the management account and all its member accounts. For more information, see <a href="https://help.aliyun.com/document_detail/159995.html">GetResourceDirectory</a>.</para>
        /// </description></item>
        /// <item><description><para>The ID of the Root folder: Searches for resources in all member accounts under the Root folder and its subfolders. For more information, see <a href="https://help.aliyun.com/document_detail/159997.html">ListFoldersForParent</a>.</para>
        /// </description></item>
        /// <item><description><para>The ID of a folder: Searches for resources in all member accounts under the folder. For more information, see <a href="https://help.aliyun.com/document_detail/159997.html">ListFoldersForParent</a>.</para>
        /// </description></item>
        /// <item><description><para>The ID of a member account: Searches for resources in the member account. For more information, see <a href="https://help.aliyun.com/document_detail/160016.html">ListAccounts</a>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rd-r4****</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The sorting parameters.</para>
        /// </summary>
        [NameInMap("SortCriterion")]
        [Validation(Required=false)]
        public SearchMultiAccountResourcesRequestSortCriterion SortCriterion { get; set; }
        public class SearchMultiAccountResourcesRequestSortCriterion : TeaModel {
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
