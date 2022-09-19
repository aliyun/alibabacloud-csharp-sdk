// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRiskCheckItemResultResponseBody : TeaModel {
        [NameInMap("PageContentResource")]
        [Validation(Required=false)]
        public DescribeRiskCheckItemResultResponseBodyPageContentResource PageContentResource { get; set; }
        public class DescribeRiskCheckItemResultResponseBodyPageContentResource : TeaModel {
            [NameInMap("ContentResource")]
            [Validation(Required=false)]
            public Dictionary<string, object> ContentResource { get; set; }

            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public int? PageCount { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
