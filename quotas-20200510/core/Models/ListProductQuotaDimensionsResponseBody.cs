// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListProductQuotaDimensionsResponseBody : TeaModel {
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
        /// The information about quota dimensions.
        /// </summary>
        [NameInMap("QuotaDimensions")]
        [Validation(Required=false)]
        public List<ListProductQuotaDimensionsResponseBodyQuotaDimensions> QuotaDimensions { get; set; }
        public class ListProductQuotaDimensionsResponseBodyQuotaDimensions : TeaModel {
            [NameInMap("DependentDimensions")]
            [Validation(Required=false)]
            public List<string> DependentDimensions { get; set; }

            /// <summary>
            /// The key of the quota dimension. Valid values:
            /// 
            /// *   regionId: the region ID.
            /// *   zoneId: the zone ID.
            /// *   chargeType: the billing method.
            /// *   networkType: the network type.
            /// </summary>
            [NameInMap("DimensionKey")]
            [Validation(Required=false)]
            public string DimensionKey { get; set; }

            /// <summary>
            /// The details of the quota dimension value.
            /// </summary>
            [NameInMap("DimensionValueDetail")]
            [Validation(Required=false)]
            public List<ListProductQuotaDimensionsResponseBodyQuotaDimensionsDimensionValueDetail> DimensionValueDetail { get; set; }
            public class ListProductQuotaDimensionsResponseBodyQuotaDimensionsDimensionValueDetail : TeaModel {
                /// <summary>
                /// The name of the quota dimension value.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The quota dimension value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("DimensionValues")]
            [Validation(Required=false)]
            public List<string> DimensionValues { get; set; }

            /// <summary>
            /// The name of the quota dimension.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Indicates whether the quota dimension is required when you query quota dimensions. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("Requisite")]
            [Validation(Required=false)]
            public bool? Requisite { get; set; }

        }

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
