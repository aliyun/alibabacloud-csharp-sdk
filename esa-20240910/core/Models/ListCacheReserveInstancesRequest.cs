// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListCacheReserveInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cache reserve instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-xcdn-96wblslz****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>1 to 500</b>. Default value: <b>500</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The criterion by which you want to sort the queried instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ExpireTime: sorts the instances by the time when the instances expire.</description></item>
        /// <item><description>CreateTime: sorts the instances by the time when the instances were purchased.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ExpireTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The order by which you want to sort the queried instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>asc: in ascending order.</description></item>
        /// <item><description>desc: in descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// <para>The status of the cache reserve instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>online: The instance is in service.</description></item>
        /// <item><description>offline: The instance has expired within an allowable period. In this state, the plan is unavailable.</description></item>
        /// <item><description>disable: The instance is released.</description></item>
        /// <item><description>overdue: The instance is stopped due to overdue payments.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ListCacheReserveInstances</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
