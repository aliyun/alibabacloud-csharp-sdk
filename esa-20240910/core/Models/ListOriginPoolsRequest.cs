// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListOriginPoolsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies how to match the origin pool name. The default is <c>exact</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>fuzzy</c>: Performs a fuzzy search.</para>
        /// </description></item>
        /// <item><description><para><c>exact</c>: Performs an exact match.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>exact</para>
        /// </summary>
        [NameInMap("MatchType")]
        [Validation(Required=false)]
        public string MatchType { get; set; }

        /// <summary>
        /// <para>The name of the origin pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pool1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies how the results are sorted. By default, results are sorted by ID in descending order. To sort by ID in ascending order, set this parameter to <c>id</c>. IDs increase with creation time.</para>
        /// <list type="bullet">
        /// <item><description><para>id: Sorts by ID in descending order.</para>
        /// </description></item>
        /// <item><description><para>id: Sorts by ID in ascending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>id</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page number. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The value must be an integer from 1 to 500. If you specify a value greater than 500, the system uses 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The site ID. To get this ID, call the <a href="~~ListSites~~">ListSites</a> operation.</para>
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
