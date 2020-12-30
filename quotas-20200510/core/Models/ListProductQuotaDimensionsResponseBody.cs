// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListProductQuotaDimensionsResponseBody : TeaModel {
        [NameInMap("QuotaDimensions")]
        [Validation(Required=false)]
        public List<ListProductQuotaDimensionsResponseBodyQuotaDimensions> QuotaDimensions { get; set; }
        public class ListProductQuotaDimensionsResponseBodyQuotaDimensions : TeaModel {
            [NameInMap("Requisite")]
            [Validation(Required=false)]
            public bool? Requisite { get; set; }

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

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

    }

}
