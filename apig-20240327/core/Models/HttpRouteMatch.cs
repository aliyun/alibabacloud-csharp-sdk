// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpRouteMatch : TeaModel {
        /// <summary>
        /// <para>The rules for matching based on HTTP request headers.</para>
        /// </summary>
        [NameInMap("headers")]
        [Validation(Required=false)]
        public List<HttpRouteMatchHeaders> Headers { get; set; }
        public class HttpRouteMatchHeaders : TeaModel {
            /// <summary>
            /// <para>The header name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The match type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Exact: exact match</description></item>
            /// <item><description>Prefix: prefix match</description></item>
            /// <item><description>Regex: regular expression</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Exact</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The header value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether the path is case-insensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ignoreUriCase")]
        [Validation(Required=false)]
        public bool? IgnoreUriCase { get; set; }

        /// <summary>
        /// <para>The HTTP methods.</para>
        /// </summary>
        [NameInMap("methods")]
        [Validation(Required=false)]
        public List<string> Methods { get; set; }

        /// <summary>
        /// <para>The path rule.</para>
        /// </summary>
        [NameInMap("path")]
        [Validation(Required=false)]
        public HttpRouteMatchPath Path { get; set; }
        public class HttpRouteMatchPath : TeaModel {
            /// <summary>
            /// <para>The path matching type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Exact: exact match</description></item>
            /// <item><description>Prefix: prefix match</description></item>
            /// <item><description>Regex: regular expression</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Prefix</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/user</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The rules for matching based on query parameters.</para>
        /// </summary>
        [NameInMap("queryParams")]
        [Validation(Required=false)]
        public List<HttpRouteMatchQueryParams> QueryParams { get; set; }
        public class HttpRouteMatchQueryParams : TeaModel {
            /// <summary>
            /// <para>The parameter name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>age</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The match type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Exact: exact match</description></item>
            /// <item><description>Prefix: prefix match</description></item>
            /// <item><description>Regex: regular expression</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Exact</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The parameter value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
