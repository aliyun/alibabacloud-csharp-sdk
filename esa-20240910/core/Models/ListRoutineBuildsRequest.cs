// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListRoutineBuildsRequest : TeaModel {
        /// <summary>
        /// <para>The page number for a paged query. The value must be greater than or equal to 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query. Valid values: 1 to 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ER name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-routine</para>
        /// </summary>
        [NameInMap("RoutineName")]
        [Validation(Required=false)]
        public string RoutineName { get; set; }

        /// <summary>
        /// <para>The field used for sorting. By default, results are sorted by purchase time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CreateTime: purchase time.</description></item>
        /// <item><description>ExpireTime: expiration time.</description></item>
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
        /// <item><description>asc: ascending order.</description></item>
        /// <item><description>desc: descending order.</description></item>
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
        /// <item><description>int: initialization</description></item>
        /// <item><description>pending: preparing</description></item>
        /// <item><description>building: building</description></item>
        /// <item><description>succeed: build succeeded</description></item>
        /// <item><description>failed: build failed</description></item>
        /// <item><description>canceled: canceled</description></item>
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
