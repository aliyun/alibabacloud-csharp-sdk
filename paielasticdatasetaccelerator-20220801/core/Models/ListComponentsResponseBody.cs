// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIElasticDatasetAccelerator20220801.Models
{
    public class ListComponentsResponseBody : TeaModel {
        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<ListComponentsResponseBodyComponents> Components { get; set; }
        public class ListComponentsResponseBodyComponents : TeaModel {
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            [NameInMap("Template")]
            [Validation(Required=false)]
            public ListComponentsResponseBodyComponentsTemplate Template { get; set; }
            public class ListComponentsResponseBodyComponentsTemplate : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Uri")]
                [Validation(Required=false)]
                public string Uri { get; set; }

            }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
