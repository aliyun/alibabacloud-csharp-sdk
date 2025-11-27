// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class ListPoolsRequest : TeaModel {
        /// <summary>
        /// <para>Queries the filter conditions of a resource pool.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public ListPoolsRequestFilter Filter { get; set; }
        public class ListPoolsRequestFilter : TeaModel {
            /// <summary>
            /// <para>Queries the list of resource pool names.</para>
            /// </summary>
            [NameInMap("PoolName")]
            [Validation(Required=false)]
            public List<string> PoolName { get; set; }

            /// <summary>
            /// <para>Queries resource pool status list.</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public List<string> Status { get; set; }

            /// <summary>
            /// <para>For node pools created after this time, the time in the region is converted into a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1703819914</para>
            /// </summary>
            [NameInMap("TimeCreatedAfter")]
            [Validation(Required=false)]
            public int? TimeCreatedAfter { get; set; }

            /// <summary>
            /// <para>For node pools created before this time, the time in the region is converted into a UNIX timestamp.</para>
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
        /// <para>The number of entries on each page. Maximum value: 50. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
