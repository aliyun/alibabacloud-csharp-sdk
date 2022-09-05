// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListDependentQuotasResponseBody : TeaModel {
        [NameInMap("Quotas")]
        [Validation(Required=false)]
        public List<ListDependentQuotasResponseBodyQuotas> Quotas { get; set; }
        public class ListDependentQuotasResponseBodyQuotas : TeaModel {
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public List<ListDependentQuotasResponseBodyQuotasDimensions> Dimensions { get; set; }
            public class ListDependentQuotasResponseBodyQuotasDimensions : TeaModel {
                [NameInMap("DependentDimension")]
                [Validation(Required=false)]
                public List<string> DependentDimension { get; set; }

                [NameInMap("DimensionKey")]
                [Validation(Required=false)]
                public string DimensionKey { get; set; }

                [NameInMap("DimensionValues")]
                [Validation(Required=false)]
                public List<string> DimensionValues { get; set; }

            }

            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("QuotaActionCode")]
            [Validation(Required=false)]
            public string QuotaActionCode { get; set; }

            [NameInMap("Scale")]
            [Validation(Required=false)]
            public float? Scale { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
