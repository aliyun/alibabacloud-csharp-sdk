// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateFirstRankResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateFirstRankResponseBodyResult Result { get; set; }
        public class CreateFirstRankResponseBodyResult : TeaModel {
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }
            [NameInMap("meta")]
            [Validation(Required=false)]
            public List<CreateFirstRankResponseBodyResultMeta> Meta { get; set; }
            public class CreateFirstRankResponseBodyResultMeta : TeaModel {
                public string Arg { get; set; }
                public string Attribute { get; set; }
                public float? Weight { get; set; }
            }
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
        };

    }

}
