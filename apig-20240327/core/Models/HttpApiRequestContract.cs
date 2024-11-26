// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiRequestContract : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public HttpApiRequestContractBody Body { get; set; }
        public class HttpApiRequestContractBody : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>application/json</para>
            /// </summary>
            [NameInMap("contentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;key&quot;:&quot;value&quot;}</para>
            /// </summary>
            [NameInMap("example")]
            [Validation(Required=false)]
            public string Example { get; set; }

            [NameInMap("jsonSchema")]
            [Validation(Required=false)]
            public string JsonSchema { get; set; }

        }

        [NameInMap("headerParameters")]
        [Validation(Required=false)]
        public List<HttpApiParameter> HeaderParameters { get; set; }

        [NameInMap("pathParameters")]
        [Validation(Required=false)]
        public List<HttpApiParameter> PathParameters { get; set; }

        [NameInMap("queryParameters")]
        [Validation(Required=false)]
        public List<HttpApiParameter> QueryParameters { get; set; }

    }

}
