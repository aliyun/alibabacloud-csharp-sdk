// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetProductQuotaDimensionRequest : TeaModel {
        [NameInMap("DependentDimensions")]
        [Validation(Required=false)]
        public List<GetProductQuotaDimensionRequestDependentDimensions> DependentDimensions { get; set; }
        public class GetProductQuotaDimensionRequestDependentDimensions : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("DimensionKey")]
        [Validation(Required=false)]
        public string DimensionKey { get; set; }

        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

    }

}
