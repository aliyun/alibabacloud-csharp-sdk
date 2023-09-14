// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListDependentQuotasResponseBody : TeaModel {
        /// <summary>
        /// The quotas on which the specified quota depends.
        /// </summary>
        [NameInMap("Quotas")]
        [Validation(Required=false)]
        public List<ListDependentQuotasResponseBodyQuotas> Quotas { get; set; }
        public class ListDependentQuotasResponseBodyQuotas : TeaModel {
            /// <summary>
            /// The dimensions of the quotas on which the specified quota depends.
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public List<ListDependentQuotasResponseBodyQuotasDimensions> Dimensions { get; set; }
            public class ListDependentQuotasResponseBodyQuotasDimensions : TeaModel {
                [NameInMap("DependentDimension")]
                [Validation(Required=false)]
                public List<string> DependentDimension { get; set; }

                /// <summary>
                /// The key of the quota dimension.
                /// </summary>
                [NameInMap("DimensionKey")]
                [Validation(Required=false)]
                public string DimensionKey { get; set; }

                [NameInMap("DimensionValues")]
                [Validation(Required=false)]
                public List<string> DimensionValues { get; set; }

            }

            /// <summary>
            /// The abbreviation of the Alibaba Cloud service name.
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// The quota ID.
            /// </summary>
            [NameInMap("QuotaActionCode")]
            [Validation(Required=false)]
            public string QuotaActionCode { get; set; }

            /// <summary>
            /// The relationship percentage between the specified quota and the quotas on which the specified quota depends.
            /// </summary>
            [NameInMap("Scale")]
            [Validation(Required=false)]
            public float? Scale { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
