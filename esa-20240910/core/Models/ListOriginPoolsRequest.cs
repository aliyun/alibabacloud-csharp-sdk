// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListOriginPoolsRequest : TeaModel {
        /// <summary>
        /// <para>Type of name match query, supporting the following two types, with exact match as the default.</para>
        /// <list type="bullet">
        /// <item><description>fuzzy: Fuzzy query.</description></item>
        /// <item><description>exact: Exact query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>exact</para>
        /// </summary>
        [NameInMap("MatchType")]
        [Validation(Required=false)]
        public string MatchType { get; set; }

        /// <summary>
        /// <para>Name of the origin pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pool1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Sorting, supports ascending and descending order by ID, default is descending by ID, which is positively correlated with creation time.</para>
        /// <list type="bullet">
        /// <item><description>-id: Sort by ID in descending order.</description></item>
        /// <item><description>id: Sort by ID in ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>id</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>Page number, default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size, an integer greater than 0, with a maximum of 500. If the value exceeds 500, it will be set to 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Site ID, which can be obtained by calling the <a href="~~ListSites~~">ListSites</a> API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>151538882642832</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
