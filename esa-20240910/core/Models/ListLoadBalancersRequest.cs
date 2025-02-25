// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListLoadBalancersRequest : TeaModel {
        /// <summary>
        /// <para>Name matching strategy when querying by name:</para>
        /// <list type="bullet">
        /// <item><description>fuzzy: Fuzzy match;</description></item>
        /// <item><description>exact: Exact match, equivalent to an equality query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fuzzy</para>
        /// </summary>
        [NameInMap("MatchType")]
        [Validation(Required=false)]
        public string MatchType { get; set; }

        /// <summary>
        /// <para>Name of the load balancer, which can be used for querying by name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb.example.com</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Sorting field, currently only supports sorting by id. \&quot;id\&quot; indicates ascending order by id, \&quot;-id\&quot; indicates descending order by id. The id is positively correlated with the creation time. If not provided, it defaults to descending order by id.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>Page number for paginated queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size for paginated queries, with a value range of 1-500.</para>
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
        /// <para>21655860979****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
