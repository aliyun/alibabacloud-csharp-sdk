// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetProductQuotaDimensionResponseBody : TeaModel {
        /// <summary>
        /// The details of the quota dimension.
        /// </summary>
        [NameInMap("QuotaDimension")]
        [Validation(Required=false)]
        public GetProductQuotaDimensionResponseBodyQuotaDimension QuotaDimension { get; set; }
        public class GetProductQuotaDimensionResponseBodyQuotaDimension : TeaModel {
            /// <summary>
            /// The quota dimensions on which the quota dimension that you want to query is dependent.
            /// </summary>
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
            public List<GetProductQuotaDimensionResponseBodyQuotaDimensionDimensionValueDetail> DimensionValueDetail { get; set; }
            public class GetProductQuotaDimensionResponseBodyQuotaDimensionDimensionValueDetail : TeaModel {
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

            /// <summary>
            /// The values of the quota dimension.
            /// </summary>
            [NameInMap("DimensionValues")]
            [Validation(Required=false)]
            public List<string> DimensionValues { get; set; }

            /// <summary>
            /// The name of the quota dimension.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
