// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetProductQuotaDimensionResponseBody : TeaModel {
        /// <summary>
        /// The details about the quota dimension.
        /// </summary>
        [NameInMap("QuotaDimension")]
        [Validation(Required=false)]
        public GetProductQuotaDimensionResponseBodyQuotaDimension QuotaDimension { get; set; }
        public class GetProductQuotaDimensionResponseBodyQuotaDimension : TeaModel {
            /// <summary>
            /// The quota dimensions that are supported by the cloud service.
            /// </summary>
            [NameInMap("DependentDimensions")]
            [Validation(Required=false)]
            public List<string> DependentDimensions { get; set; }

            /// <summary>
            /// The dimension key. Valid values:
            /// 
            /// *   regionId: region ID
            /// *   zoneId: zone ID
            /// *   chargeType: billing method
            /// *   networkType: network type
            /// </summary>
            [NameInMap("DimensionKey")]
            [Validation(Required=false)]
            public string DimensionKey { get; set; }

            /// <summary>
            /// The details about the dimension value.
            /// </summary>
            [NameInMap("DimensionValueDetail")]
            [Validation(Required=false)]
            public List<GetProductQuotaDimensionResponseBodyQuotaDimensionDimensionValueDetail> DimensionValueDetail { get; set; }
            public class GetProductQuotaDimensionResponseBodyQuotaDimensionDimensionValueDetail : TeaModel {
                /// <summary>
                /// The name of the dimension value.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The dimension value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The dimension values.
            /// </summary>
            [NameInMap("DimensionValues")]
            [Validation(Required=false)]
            public List<string> DimensionValues { get; set; }

            /// <summary>
            /// The name of the dimension.
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
