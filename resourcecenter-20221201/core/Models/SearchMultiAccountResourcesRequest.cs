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
            /// <para>The key of the filter condition. For more information, see <c>Supported filter parameters</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ResourceGroupId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The matching mode.</para>
            /// <para>The value Equals indicates an equal match.</para>
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
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// <para>If the total number of entries returned for the current request exceeds the value of the <c>MaxResults</c> parameter, the entries are truncated. In this case, you can use the token to initiate another request and obtain the remaining entries.``</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJzZWFyY2hBZnRlcnMiOlsiMTAwMTU2Nzk4MTU1OSJd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The search scope. You can set the value to one of the following items:</para>
        /// <list type="bullet">
        /// <item><description>ID of a resource directory: Resources within the management account and all members of the resource directory are searched. You can call the <a href="https://help.aliyun.com/document_detail/159995.html">GetResourceDirectory</a> operation to obtain the ID.</description></item>
        /// <item><description>ID of the Root folder: Resources within all members in the Root folder and the subfolders of the Root folder are searched. You can call the <a href="https://help.aliyun.com/document_detail/159997.html">ListFoldersForParent</a> operation to obtain the ID.</description></item>
        /// <item><description>ID of a folder: Resources within all members in the folder are searched. You can call the <a href="https://help.aliyun.com/document_detail/159997.html">ListFoldersForParent</a> operation to obtain the ID.</description></item>
        /// <item><description>ID of a member: Resources within the member are searched. You can call the <a href="https://help.aliyun.com/document_detail/160016.html">ListAccounts</a> operation to obtain the ID.</description></item>
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
        /// <para>The method that is used to sort the entries returned.</para>
        /// </summary>
        [NameInMap("SortCriterion")]
        [Validation(Required=false)]
        public SearchMultiAccountResourcesRequestSortCriterion SortCriterion { get; set; }
        public class SearchMultiAccountResourcesRequestSortCriterion : TeaModel {
            /// <summary>
            /// <para>The attribute based on which the entries are sorted.</para>
            /// <para>The value CreateTime indicates the creation time of resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CreateTime</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The order in which the entries are sorted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ASC: The entries are sorted in ascending order. This value is the default value.</description></item>
            /// <item><description>DESC: The entries are sorted in descending order.</description></item>
            /// </list>
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
