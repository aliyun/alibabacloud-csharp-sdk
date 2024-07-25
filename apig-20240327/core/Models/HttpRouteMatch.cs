// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpRouteMatch : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public List<HttpRouteMatchHeaders> Headers { get; set; }
        public class HttpRouteMatchHeaders : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("ignoreUriCase")]
        [Validation(Required=false)]
        public bool? IgnoreUriCase { get; set; }

        [NameInMap("methods")]
        [Validation(Required=false)]
        public List<string> Methods { get; set; }

        [NameInMap("path")]
        [Validation(Required=false)]
        public HttpRouteMatchPath Path { get; set; }
        public class HttpRouteMatchPath : TeaModel {
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("queryParams")]
        [Validation(Required=false)]
        public List<HttpRouteMatchQueryParams> QueryParams { get; set; }
        public class HttpRouteMatchQueryParams : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
