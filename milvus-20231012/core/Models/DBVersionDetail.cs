// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class DBVersionDetail : TeaModel {
        [NameInMap("specs")]
        [Validation(Required=false)]
        public List<DBVersionDetailSpecs> Specs { get; set; }
        public class DBVersionDetailSpecs : TeaModel {
            [NameInMap("componentSpecs")]
            [Validation(Required=false)]
            public List<DBVersionDetailSpecsComponentSpecs> ComponentSpecs { get; set; }
            public class DBVersionDetailSpecsComponentSpecs : TeaModel {
                [NameInMap("defaultReplicas")]
                [Validation(Required=false)]
                public int? DefaultReplicas { get; set; }

                [NameInMap("maxReplicas")]
                [Validation(Required=false)]
                public int? MaxReplicas { get; set; }

                [NameInMap("minReplicas")]
                [Validation(Required=false)]
                public int? MinReplicas { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("specs")]
                [Validation(Required=false)]
                public List<string> Specs { get; set; }

                [NameInMap("step")]
                [Validation(Required=false)]
                public int? Step { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("isHA")]
            [Validation(Required=false)]
            public bool? IsHA { get; set; }

            [NameInMap("isStandalone")]
            [Validation(Required=false)]
            public bool? IsStandalone { get; set; }

            [NameInMap("zoneMode")]
            [Validation(Required=false)]
            public string ZoneMode { get; set; }

        }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
