// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class SearchMediaRequest : TeaModel {
        /// <summary>
        /// <para>The business configuration. A JSON string that can contain ProductionId (project ID).</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ProductionId&quot;:&quot;pd_abc1234567&quot;}</para>
        /// </summary>
        [NameInMap("BizConfig")]
        [Validation(Required=false)]
        public string BizConfig { get; set; }

        /// <summary>
        /// <para>The category ID. You can obtain the category ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>When you create a category by calling the CreateAssetCategory operation, the category ID is the value of the CategoryId response parameter.</description></item>
        /// <item><description>When you query categories by calling the ListAssetCategories operation, the category ID is the value of the CategoryId parameter in the corresponding returned entry.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        /// <summary>
        /// <para>The filter conditions. For syntax rules, see <a href="https://www.alibabacloud.com/help/en/ims/developer-reference/media-asset-search-filter-description">Media asset search protocol</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>title = \&quot;China\&quot; and utcCreate = [\&quot;1693367158561\&quot;,\&quot;1693367158562\&quot;]</para>
        /// </summary>
        [NameInMap("Match")]
        [Validation(Required=false)]
        public string Match { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 10. Maximum value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pd_123456</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The scroll token, which is a 32-character string. You do not need to specify this parameter when you make a search request for the first time. If the search request returns data, the server returns this parameter to record the position of the current search data. Record the returned value and specify this parameter in subsequent searches based on the following requirements or suggestions: This parameter is required to traverse all data that matches the search conditions. If the value of the PageNo parameter exceeds 200, specify this parameter to optimize search performance. You can only scroll forward. The maximum scroll distance is 1,000 media assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8C4F642184DBDA5D93907A70AAE****</para>
        /// </summary>
        [NameInMap("ScrollToken")]
        [Validation(Required=false)]
        public string ScrollToken { get; set; }

        /// <summary>
        /// <para>The sort fields and sort order. Separate multiple fields with commas (,). Format: field1:Desc,field2:Asc. The sort direction can only be Asc or Desc.</para>
        /// 
        /// <b>Example:</b>
        /// <para>utcCreate:Desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

    }

}
