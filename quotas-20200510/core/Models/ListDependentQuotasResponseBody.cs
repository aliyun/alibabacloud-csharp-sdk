// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListDependentQuotasResponseBody : TeaModel {
        /// <summary>
        /// The list of quotas on which the specified quota depends.
        /// </summary>
        [NameInMap("Quotas")]
        [Validation(Required=false)]
        public List<ListDependentQuotasResponseBodyQuotas> Quotas { get; set; }
        public class ListDependentQuotasResponseBodyQuotas : TeaModel {
            /// <summary>
            /// The dimensions of a quota on which the specified quota depends.
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public List<ListDependentQuotasResponseBodyQuotasDimensions> Dimensions { get; set; }
            public class ListDependentQuotasResponseBodyQuotasDimensions : TeaModel {
                /// <summary>
                /// The dimension of a quota on which the specified quota depends.
                /// </summary>
                [NameInMap("DependentDimension")]
                [Validation(Required=false)]
                public List<string> DependentDimension { get; set; }

                /// <summary>
                /// The dimension key.
                /// </summary>
                [NameInMap("DimensionKey")]
                [Validation(Required=false)]
                public string DimensionKey { get; set; }

                /// <summary>
                /// The dimension values.
                /// </summary>
                [NameInMap("DimensionValues")]
                [Validation(Required=false)]
                public List<string> DimensionValues { get; set; }

            }

            /// <summary>
            /// The abbreviation of the cloud service name.
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// The ID of the quota.
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
