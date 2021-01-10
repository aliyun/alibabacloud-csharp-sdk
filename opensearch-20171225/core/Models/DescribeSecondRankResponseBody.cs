// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DescribeSecondRankResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public DescribeSecondRankResponseBodyResult Result { get; set; }
        public class DescribeSecondRankResponseBodyResult : TeaModel {
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }
            [NameInMap("isDefault")]
            [Validation(Required=false)]
            public string IsDefault { get; set; }
            [NameInMap("isSys")]
            [Validation(Required=false)]
            public string IsSys { get; set; }
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("meta")]
            [Validation(Required=false)]
            public string Meta { get; set; }
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }
        };

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
