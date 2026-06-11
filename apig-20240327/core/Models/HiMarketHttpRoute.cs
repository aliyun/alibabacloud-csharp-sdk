// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketHttpRoute : TeaModel {
        /// <summary>
        /// <para>Indicates whether this is a system-defined route. Users cannot modify or delete built-in routes. Defaults to <c>false</c>.</para>
        /// </summary>
        [NameInMap("builtin")]
        [Validation(Required=false)]
        public bool? Builtin { get; set; }

        /// <summary>
        /// <para>An optional description for the HTTP route. This field is for informational purposes only.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>A list of hostnames to which this route applies. The request\&quot;s <c>Host</c> header must match one of the hostnames in this list.</para>
        /// </summary>
        [NameInMap("domains")]
        [Validation(Required=false)]
        public List<HiMarketDomain> Domains { get; set; }

        /// <summary>
        /// <para>Defines the matching criteria for an incoming HTTP request. The request must meet all specified conditions for this route to apply.</para>
        /// </summary>
        [NameInMap("match")]
        [Validation(Required=false)]
        public HiMarketHttpRouteMatch Match { get; set; }
        public class HiMarketHttpRouteMatch : TeaModel {
            /// <summary>
            /// <para>A list of HTTP header match conditions. The request must match all of these conditions.</para>
            /// </summary>
            [NameInMap("headers")]
            [Validation(Required=false)]
            public List<HiMarketHttpRouteMatchHeaders> Headers { get; set; }
            public class HiMarketHttpRouteMatchHeaders : TeaModel {
                /// <summary>
                /// <para>Specifies whether the header match is case-sensitive. Defaults to <c>true</c>.</para>
                /// </summary>
                [NameInMap("caseSensitive")]
                [Validation(Required=false)]
                public bool? CaseSensitive { get; set; }

                /// <summary>
                /// <para>The name of the HTTP header to match, such as <c>Content-Type</c>.</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of header match. Valid values are <c>Exact</c> and <c>RegularExpression</c>. Defaults to <c>Exact</c>.</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The value to match against the header. The match <c>type</c> determines how this value is interpreted.</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>A list of HTTP methods to match, such as <c>GET</c> or <c>POST</c>. If this field is not specified, the route matches requests with any HTTP method.</para>
            /// </summary>
            [NameInMap("methods")]
            [Validation(Required=false)]
            public List<string> Methods { get; set; }

            /// <summary>
            /// <para>A list of conditions for matching against a data model. Use this to validate the request body or other structured data.</para>
            /// </summary>
            [NameInMap("modelMatches")]
            [Validation(Required=false)]
            public List<HiMarketHttpRouteMatchModelMatches> ModelMatches { get; set; }
            public class HiMarketHttpRouteMatchModelMatches : TeaModel {
                /// <summary>
                /// <para>Specifies whether the model field match is case-sensitive. Defaults to <c>true</c>.</para>
                /// </summary>
                [NameInMap("caseSensitive")]
                [Validation(Required=false)]
                public bool? CaseSensitive { get; set; }

                /// <summary>
                /// <para>The name of the model field to match.</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of match, such as <c>Exact</c>, <c>Pattern</c>, or <c>Range</c>.</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The value or pattern to match against the model field.</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Specifies the conditions for matching the request path.</para>
            /// </summary>
            [NameInMap("path")]
            [Validation(Required=false)]
            public HiMarketHttpRouteMatchPath Path { get; set; }
            public class HiMarketHttpRouteMatchPath : TeaModel {
                /// <summary>
                /// <para>Specifies whether the path match is case-sensitive. Defaults to <c>true</c>.</para>
                /// </summary>
                [NameInMap("caseSensitive")]
                [Validation(Required=false)]
                public bool? CaseSensitive { get; set; }

                /// <summary>
                /// <para>The type of path match. Valid values are <c>Exact</c> and <c>Prefix</c>. Defaults to <c>Exact</c> if not specified.</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The path value to match. The specified <c>type</c> determines how this value is interpreted.</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>A list of URL query parameter match conditions. The request must match all of these conditions.</para>
            /// </summary>
            [NameInMap("queryParams")]
            [Validation(Required=false)]
            public List<HiMarketHttpRouteMatchQueryParams> QueryParams { get; set; }
            public class HiMarketHttpRouteMatchQueryParams : TeaModel {
                /// <summary>
                /// <para>Specifies whether the query parameter match is case-sensitive. Defaults to <c>true</c>.</para>
                /// </summary>
                [NameInMap("caseSensitive")]
                [Validation(Required=false)]
                public bool? CaseSensitive { get; set; }

                /// <summary>
                /// <para>The name of the query parameter to match.</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of query parameter match. Valid values are <c>Exact</c> and <c>RegularExpression</c>. Defaults to <c>Exact</c>.</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The value to match against the query parameter. The match <c>type</c> determines how this value is interpreted.</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
