// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListAiToolsResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<ListAiToolsResponseBody> Body { get; set; }
        public class ListAiToolsResponseBody : TeaModel {
            [NameInMap("fields")]
            [Validation(Required=false)]
            public List<ListAiToolsResponseBodyFields> Fields { get; set; }
            public class ListAiToolsResponseBodyFields : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("option")]
                [Validation(Required=false)]
                public List<string> Option { get; set; }

                [NameInMap("required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("example")]
                [Validation(Required=false)]
                public string Example { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

            }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

    }

}
