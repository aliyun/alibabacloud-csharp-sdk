// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ModifyFirstRankResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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

            [NameInMap("meta")]
            [Validation(Required=false)]
            public List<ModifyFirstRankResponseBodyResultMeta> Meta { get; set; }
            public class ModifyFirstRankResponseBodyResultMeta : TeaModel {
                [NameInMap("arg")]
                [Validation(Required=false)]
                public string Arg { get; set; }

                [NameInMap("attribute")]
                [Validation(Required=false)]
                public string Attribute { get; set; }

                [NameInMap("weight")]
                [Validation(Required=false)]
                public float? Weight { get; set; }

            }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
