// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class ListPoolsRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions for querying resource pools.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public ListPoolsRequestFilter Filter { get; set; }
        public class ListPoolsRequestFilter : TeaModel {
            /// <summary>
            /// <para>The list of resource pool names to query.</para>
            /// </summary>
            [NameInMap("PoolName")]
            [Validation(Required=false)]
            public List<string> PoolName { get; set; }

            /// <summary>
            /// <para>The list of resource pool statuses to query.</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public List<string> Status { get; set; }

            /// <summary>
            /// <para>Returns only resource pools created after the specified time. The time must be a Unix timestamp in UTC+8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1703819914</para>
            /// </summary>
            [NameInMap("TimeCreatedAfter")]
            [Validation(Required=false)]
            public int? TimeCreatedAfter { get; set; }

            /// <summary>
            /// <para>Returns only resource pools created before the specified time. The time must be a Unix timestamp in UTC+8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1703820113</para>
            /// </summary>
            [NameInMap("TimeCreatedBefore")]
            [Validation(Required=false)]
            public int? TimeCreatedBefore { get; set; }

        }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 50. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
