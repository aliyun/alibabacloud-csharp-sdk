// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListRoutineBuildsRequest : TeaModel {
        /// <summary>
        /// <para>The page number Settings for paging in a paged query. The value must be greater than or equal to 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The number of entries per page for paging in a paged query. Valid values: 1 to 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the Edge Routine (ER).</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-routine</para>
        /// </summary>
        [NameInMap("RoutineName")]
        [Validation(Required=false)]
        public string RoutineName { get; set; }

        /// <summary>
        /// <para>The field used for sorting. By default, tasks are sorted by creation time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CreateTime: Creation time.</description></item>
        /// <item><description>ExpireTime: Expiration time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The sort order. Default value: desc. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>asc: Ascending order.</description></item>
        /// <item><description>desc: Descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// <para>The status of the build task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>int: Initialized.</description></item>
        /// <item><description>pending: Preparing.</description></item>
        /// <item><description>building: Building.</description></item>
        /// <item><description>succeed: Succeeded.</description></item>
        /// <item><description>failed: Failed.</description></item>
        /// <item><description>canceled: Canceled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>canceled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
