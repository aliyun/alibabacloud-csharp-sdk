// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListCacheReserveInstancesRequest : TeaModel {
        /// <summary>
        /// <para>Instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-xcdn-96wblslz****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size. Range: <b>1~500</b>, default is <b>500</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Sorting method. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>ExpireTime</b>: Expiration time.</description></item>
        /// <item><description><b>CreateTime</b>: Purchase time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ExpireTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>Sorting order. Supported values:</para>
        /// <list type="bullet">
        /// <item><description><b>asc</b>: Ascending.</description></item>
        /// <item><description><b>desc</b>: Descending.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// <para>Cache reserve instance status. Supported values:</para>
        /// <list type="bullet">
        /// <item><description><b>online</b>: Normal service status.</description></item>
        /// <item><description><b>offline</b>: Expired but not overdue, in an unavailable state.</description></item>
        /// <item><description><b>disable</b>: Released status.</description></item>
        /// <item><description><b>overdue</b>: Overdue and suspended status.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>online</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
