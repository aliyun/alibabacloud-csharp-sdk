// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SearchMediaRequest : TeaModel {
        /// <summary>
        /// <para>The custom filter, specified as a JSON string. Supports the integer field intField1 and the string fields strField1 and strField2. Use only one match type per field. Conditions on different fields are combined with a logical AND.</para>
        /// <list type="bullet">
        /// <item><description><para>Exact match: <c>{&quot;intField1&quot;:12,&quot;strField1&quot;:&quot;abc&quot;}</c></para>
        /// </description></item>
        /// <item><description><para>Multi-value match: <c>{&quot;intField1&quot;:[12,13],&quot;strField1&quot;:[&quot;abc&quot;,&quot;cd&quot;]}</c></para>
        /// </description></item>
        /// <item><description><para>Range match: <c>{&quot;intField1&quot;:{&quot;gte&quot;:12,&quot;lte&quot;:13}}</c></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;intField1&quot;:{&quot;gte&quot;:12,&quot;lte&quot;:13},&quot;strField2&quot;:[&quot;cd&quot;,&quot;de&quot;],&quot;strField1&quot;:&quot;abc&quot;}</para>
        /// </summary>
        [NameInMap("CustomFilters")]
        [Validation(Required=false)]
        public string CustomFilters { get; set; }

        /// <summary>
        /// <para>The entity ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2d3bf1e35a1e42b5ab338d701efa****</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// <para>The filter condition for the search. &lt;props=&quot;china&quot;&gt;For syntax rules, see the <a href="https://help.aliyun.com/document_detail/2584256.html">Media Search Protocol</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Title = \&quot;China\&quot; and utcCreate = [\&quot;1693367158561\&quot;,\&quot;1693367158562\&quot;]</para>
        /// </summary>
        [NameInMap("Match")]
        [Validation(Required=false)]
        public string Match { get; set; }

        /// <summary>
        /// <para>The page number to return. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of results per page. The default value is 10, and the maximum value is 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The scroll token for deep pagination. It is a 32-character string. This parameter is not required for the first search request. If a search is successful, the response includes a <c>ScrollToken</c> to mark the current position. Use this token in subsequent requests to retrieve the next page of results. This parameter is required to iterate through all matching results. For optimal performance, use this parameter when the <c>PageNo</c> value exceeds 200. You can scroll only forward, up to a maximum of 1,000 media assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8C4F642184DBDA5D93907A70AAE****</para>
        /// </summary>
        [NameInMap("ScrollToken")]
        [Validation(Required=false)]
        public string ScrollToken { get; set; }

        /// <summary>
        /// <para>The name of the search library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-1</para>
        /// </summary>
        [NameInMap("SearchLibName")]
        [Validation(Required=false)]
        public string SearchLibName { get; set; }

        /// <summary>
        /// <para>The sort field and sort order. Separate multiple sort criteria with a comma (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>utcCreate:Desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

    }

}
