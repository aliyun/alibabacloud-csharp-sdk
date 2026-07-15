// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketHttpRoute : TeaModel {
        /// <summary>
        /// <para>Indicates whether the route is a built-in route.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("builtin")]
        [Validation(Required=false)]
        public bool? Builtin { get; set; }

        /// <summary>
        /// <para>The route description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Agent route</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of associated domain names.</para>
        /// </summary>
        [NameInMap("domains")]
        [Validation(Required=false)]
        public List<HiMarketDomain> Domains { get; set; }

        /// <summary>
        /// <para>The route matching rule.</para>
        /// </summary>
        [NameInMap("match")]
        [Validation(Required=false)]
        public HiMarketHttpRouteMatch Match { get; set; }
        public class HiMarketHttpRouteMatch : TeaModel {
            /// <summary>
            /// <para>The list of header matching rules.</para>
            /// </summary>
            [NameInMap("headers")]
            [Validation(Required=false)]
            public List<HiMarketHttpRouteMatchHeaders> Headers { get; set; }
            public class HiMarketHttpRouteMatchHeaders : TeaModel {
                /// <summary>
                /// <para>Indicates whether the matching is case-sensitive.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("caseSensitive")]
                [Validation(Required=false)]
                public bool? CaseSensitive { get; set; }

                /// <summary>
                /// <para>The parameter name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>X-Agent-Type</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The matching type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Exact</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The matching value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dashscope</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The list of HTTP methods.</para>
            /// </summary>
            [NameInMap("methods")]
            [Validation(Required=false)]
            public List<string> Methods { get; set; }

            /// <summary>
            /// <para>The list of model matching rules (specific to Agent API).</para>
            /// </summary>
            [NameInMap("modelMatches")]
            [Validation(Required=false)]
            public List<HiMarketHttpRouteMatchModelMatches> ModelMatches { get; set; }
            public class HiMarketHttpRouteMatchModelMatches : TeaModel {
                /// <summary>
                /// <para>Indicates whether the matching is case-sensitive.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("caseSensitive")]
                [Validation(Required=false)]
                public bool? CaseSensitive { get; set; }

                /// <summary>
                /// <para>The parameter name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>X-Agent-Type</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The matching type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Exact</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The matching value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dashscope</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The path matching rule.</para>
            /// </summary>
            [NameInMap("path")]
            [Validation(Required=false)]
            public HiMarketHttpRouteMatchPath Path { get; set; }
            public class HiMarketHttpRouteMatchPath : TeaModel {
                /// <summary>
                /// <para>Indicates whether the matching is case-sensitive.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("caseSensitive")]
                [Validation(Required=false)]
                public bool? CaseSensitive { get; set; }

                /// <summary>
                /// <para>The matching type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Prefix</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The path value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/v1/agents/invoke</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The list of query parameter matching rules.</para>
            /// </summary>
            [NameInMap("queryParams")]
            [Validation(Required=false)]
            public List<HiMarketHttpRouteMatchQueryParams> QueryParams { get; set; }
            public class HiMarketHttpRouteMatchQueryParams : TeaModel {
                /// <summary>
                /// <para>Indicates whether the matching is case-sensitive.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("caseSensitive")]
                [Validation(Required=false)]
                public bool? CaseSensitive { get; set; }

                /// <summary>
                /// <para>The parameter name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>X-Agent-Type</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The matching type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Exact</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The matching value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dashscope</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
