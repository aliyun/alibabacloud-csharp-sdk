// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListProductDimensionGroupsResponseBody : TeaModel {
        /// <summary>
        /// The dimension groups.
        /// </summary>
        [NameInMap("DimensionGroups")]
        [Validation(Required=false)]
        public List<ListProductDimensionGroupsResponseBodyDimensionGroups> DimensionGroups { get; set; }
        public class ListProductDimensionGroupsResponseBodyDimensionGroups : TeaModel {
            /// <summary>
            /// The key of the dimension group.
            /// </summary>
            [NameInMap("DimensionKeys")]
            [Validation(Required=false)]
            public List<string> DimensionKeys { get; set; }

            /// <summary>
            /// The code of the dimension group.
            /// </summary>
            [NameInMap("GroupCode")]
            [Validation(Required=false)]
            public string GroupCode { get; set; }

            /// <summary>
            /// The name of the dimension group.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The service code.
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

        }

        /// <summary>
        /// The maximum number of records that are returned for the query.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that marks the position at which the query ends. An empty value indicates that all data is returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of records that are returned for the query.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
