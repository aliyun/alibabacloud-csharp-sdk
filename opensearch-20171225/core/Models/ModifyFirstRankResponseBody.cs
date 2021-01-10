// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ModifyFirstRankResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ModifyFirstRankResponseBodyResult Result { get; set; }
        public class ModifyFirstRankResponseBodyResult : TeaModel {
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("meta")]
            [Validation(Required=false)]
            public List<ModifyFirstRankResponseBodyResultMeta> Meta { get; set; }
            public class ModifyFirstRankResponseBodyResultMeta : TeaModel {
                public string Arg { get; set; }
                public string Attribute { get; set; }
                public float? Weight { get; set; }
            }
        };

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
