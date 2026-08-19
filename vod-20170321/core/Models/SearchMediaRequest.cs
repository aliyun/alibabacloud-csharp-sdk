// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SearchMediaRequest : TeaModel {
        /// <summary>
        /// <para>The media asset fields to return in the search results.</para>
        /// <para>By default, only basic media asset fields are returned. You can specify additional media asset fields to return. For more information, see <a href="https://help.aliyun.com/document_detail/99179.html">Usage examples</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Title,CoverURL</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public string Fields { get; set; }

        /// <summary>
        /// <para>The filter conditions. For syntax rules, see <a href="https://help.aliyun.com/document_detail/86991.html">Search protocol syntax</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>field = value</para>
        /// </summary>
        [NameInMap("Match")]
        [Validation(Required=false)]
        public string Match { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// <remarks>
        /// <para>If this parameter exceeds <b>200</b>, set the ScrollToken parameter as well.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of records per page. Default value: <b>10</b>. Maximum value: <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The pagination token. The value is a 32-character string.
        /// You do not need to set this parameter for the first search request. When the search request matches data, the server returns this parameter value, which records the current position of the search data. Record the returned value and set this parameter in the next search request based on the following requirements or recommendations:</para>
        /// <list type="bullet">
        /// <item><description>If SearchType is set to <b>video</b> or <b>audio</b> and you need to traverse all data that matches the search conditions, this parameter is required.</description></item>
        /// <item><description>If PageNo exceeds <b>200</b>, set this parameter to optimize search performance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>24e0fba7188fae707e146esa54****</para>
        /// </summary>
        [NameInMap("ScrollToken")]
        [Validation(Required=false)]
        public string ScrollToken { get; set; }

        /// <summary>
        /// <para>The type of media asset to search. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>video</b> (default): video.</description></item>
        /// <item><description><b>audio</b>: audio.</description></item>
        /// <item><description><b>image</b>: image.</description></item>
        /// <item><description><b>attached</b>: auxiliary media asset.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is set to <b>video</b> or <b>audio</b> and you need to traverse all data that matches the search conditions, you must set the ScrollToken parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("SearchType")]
        [Validation(Required=false)]
        public string SearchType { get; set; }

        /// <summary>
        /// <para>The sort field and sort order. Separate multiple values with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CreationTime:Desc</b> (default): sorts by creation time in descending order.</description></item>
        /// <item><description><b>CreationTime:Asc</b>: sorts by creation time in ascending order.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For sort field examples, see <a href="https://help.aliyun.com/document_detail/99179.html">Sort fields</a>.</description></item>
        /// <item><description>When retrieving the first 5,000 records of search results, up to three sort fields are supported.</description></item>
        /// <item><description>When retrieving all data that matches the search conditions, only one sort field is supported.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CreationTime:Desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

    }

}
