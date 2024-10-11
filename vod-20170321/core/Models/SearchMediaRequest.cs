// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SearchMediaRequest : TeaModel {
        /// <summary>
        /// <para>The media asset fields to return in the query results.</para>
        /// <para>By default, only the basic media asset fields are returned. You can specify additional media asset fields that need to be returned in the request. For more information, see the &quot;API examples&quot; section of the <a href="https://help.aliyun.com/document_detail/99179.html">Search for media asset information</a> topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Title,CoverURL</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public string Fields { get; set; }

        /// <summary>
        /// <para>The filter condition. For more information about the syntax, see <a href="https://help.aliyun.com/document_detail/86991.html">Protocol for media asset search</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>field = value</para>
        /// </summary>
        [NameInMap("Match")]
        [Validation(Required=false)]
        public string Match { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// <remarks>
        /// <para>If the value of this parameter exceeds <b>200</b>, we recommend that you set the ScrollToken parameter as well.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>10</b>. Maximum value: <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The pagination identifier. The password must be 32 characters in length The first time you call this operation for each new search, you do not need to specify this parameter. The value of this parameter is returned each time data records that meet the specified filter condition are found. The value is used to record the current position of queried data. Record the returned parameter value and set this parameter according to the following requirements during the next search:</para>
        /// <list type="bullet">
        /// <item><description>If SearchType is set to <b>video</b> or <b>audio</b> and you need to traverse all data that meets the filter criteria, you must set the ScrollToken parameter.</description></item>
        /// <item><description>If the value of the PageNo parameter exceeds <b>200</b>, we recommend that you set this parameter to optimize search performance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>24e0fba7188fae707e146esa54****</para>
        /// </summary>
        [NameInMap("ScrollToken")]
        [Validation(Required=false)]
        public string ScrollToken { get; set; }

        /// <summary>
        /// <para>The type of the media asset that you want to query. Default value: video. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>video</b></description></item>
        /// <item><description><b>audio</b></description></item>
        /// <item><description><b>image</b></description></item>
        /// <item><description><b>attached</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is set to <b>video</b> or <b>audio</b> and you want to traverse all data that meets the filter criteria, you must set the ScrollToken parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("SearchType")]
        [Validation(Required=false)]
        public string SearchType { get; set; }

        /// <summary>
        /// <para>The sort field and order. Separate multiple values with commas (,). Default value: CreationTime:Desc. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CreationTime:Desc</b>: The results are sorted in reverse chronological order based on the creation time.</description></item>
        /// <item><description><b>CreationTime:Asc</b>: The results are sorted in chronological order based on the creation time.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For more information about the sort field, see &quot;Sort field&quot; in the <a href="https://help.aliyun.com/document_detail/99179.html">Search for media asset information</a> topic.</description></item>
        /// <item><description>To obtain the first 5,000 data records that meet the specified filter criteria, you can specify a maximum of three sort fields.</description></item>
        /// <item><description>To obtain all the data records that meet the specified filter criteria, you can specify only one sort field.</description></item>
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
