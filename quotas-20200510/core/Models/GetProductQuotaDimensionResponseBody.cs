// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetProductQuotaDimensionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("QuotaDimension")]
        [Validation(Required=false)]
        public GetProductQuotaDimensionResponseBodyQuotaDimension QuotaDimension { get; set; }
        public class GetProductQuotaDimensionResponseBodyQuotaDimension : TeaModel {
            [NameInMap("DimensionKey")]
            [Validation(Required=false)]
            public string DimensionKey { get; set; }
            [NameInMap("DependentDimensions")]
            [Validation(Required=false)]
            public List<string> DependentDimensions { get; set; }
            [NameInMap("DimensionValues")]
            [Validation(Required=false)]
            public List<string> DimensionValues { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
        };

    }

}
