// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class TraceSiteRequest : TeaModel {
        /// <summary>
        /// <para>The HTTP request body.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;PlainText&quot;:&quot;bc58c54211db&quot;}</para>
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public TraceSiteRequestBody Body { get; set; }
        public class TraceSiteRequestBody : TeaModel {
            /// <summary>
            /// <para>The content in JSON format. If both JSON format content and plain text content are specified, the JSON format content takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;request_id&quot;,&quot;3f809c32&quot;}</para>
            /// </summary>
            [NameInMap("Json")]
            [Validation(Required=false)]
            public object Json { get; set; }

            /// <summary>
            /// <para>The plain text content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bc58c54211db</para>
            /// </summary>
            [NameInMap("PlainText")]
            [Validation(Required=false)]
            public string PlainText { get; set; }

        }

        /// <summary>
        /// <para>The environment context. This parameter is optional.</para>
        /// </summary>
        [NameInMap("Context")]
        [Validation(Required=false)]
        public TraceSiteRequestContext Context { get; set; }
        public class TraceSiteRequestContext : TeaModel {
            /// <summary>
            /// <para>The simulated geolocation information.</para>
            /// </summary>
            [NameInMap("GeoLocation")]
            [Validation(Required=false)]
            public TraceSiteRequestContextGeoLocation GeoLocation { get; set; }
            public class TraceSiteRequestContextGeoLocation : TeaModel {
                /// <summary>
                /// <para>The country/region code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("CountryCode")]
                [Validation(Required=false)]
                public string CountryCode { get; set; }

                /// <summary>
                /// <para>The Internet service provider (ISP) code. This parameter is valid only when the country or region is the Chinese mainland.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100025</para>
                /// </summary>
                [NameInMap("IspCode")]
                [Validation(Required=false)]
                public string IspCode { get; set; }

                /// <summary>
                /// <para>The region or province code. This parameter is valid only when the country or region is the Chinese mainland.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN-BJ</para>
                /// </summary>
                [NameInMap("RegionCode")]
                [Validation(Required=false)]
                public string RegionCode { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to skip the security challenge test.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SkipChallenge")]
            [Validation(Required=false)]
            public bool? SkipChallenge { get; set; }

        }

        /// <summary>
        /// <para>The cookie parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Cookies")]
        [Validation(Required=false)]
        public List<TraceSiteRequestCookies> Cookies { get; set; }
        public class TraceSiteRequestCookies : TeaModel {
            /// <summary>
            /// <para>The cookie name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sessionId</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The cookie value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f9ca1f7d-15bb-4c60-ad99-71b8e3e4985b</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The request headers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public List<TraceSiteRequestHeaders> Headers { get; set; }
        public class TraceSiteRequestHeaders : TeaModel {
            /// <summary>
            /// <para>The HTTP request header name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>User-Agent</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The HTTP request header value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>trace-test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The HTTP method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GET</para>
        /// </summary>
        [NameInMap("Method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// <para>The HTTP protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP/1.1</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The URL of the request.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.com/test">http://example.com/test</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
