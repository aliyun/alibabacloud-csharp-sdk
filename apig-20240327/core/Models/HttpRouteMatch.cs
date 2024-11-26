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
            /// <summary>
            /// <b>Example:</b>
            /// <para>dev</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Exact</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
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
            /// <summary>
            /// <b>Example:</b>
            /// <para>Prefix</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/user</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("queryParams")]
        [Validation(Required=false)]
        public List<HttpRouteMatchQueryParams> QueryParams { get; set; }
        public class HttpRouteMatchQueryParams : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>age</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Exact</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>17</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
