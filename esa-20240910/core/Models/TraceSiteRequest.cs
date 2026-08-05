// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class TraceSiteRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;PlainText&quot;:&quot;bc58c54211db&quot;}</para>
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public TraceSiteRequestBody Body { get; set; }
        public class TraceSiteRequestBody : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;request_id&quot;,&quot;3f809c32&quot;}</para>
            /// </summary>
            [NameInMap("Json")]
            [Validation(Required=false)]
            public object Json { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>bc58c54211db</para>
            /// </summary>
            [NameInMap("PlainText")]
            [Validation(Required=false)]
            public string PlainText { get; set; }

        }

        [NameInMap("Context")]
        [Validation(Required=false)]
        public TraceSiteRequestContext Context { get; set; }
        public class TraceSiteRequestContext : TeaModel {
            [NameInMap("GeoLocation")]
            [Validation(Required=false)]
            public TraceSiteRequestContextGeoLocation GeoLocation { get; set; }
            public class TraceSiteRequestContextGeoLocation : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("CountryCode")]
                [Validation(Required=false)]
                public string CountryCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100025</para>
                /// </summary>
                [NameInMap("IspCode")]
                [Validation(Required=false)]
                public string IspCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CN-BJ</para>
                /// </summary>
                [NameInMap("RegionCode")]
                [Validation(Required=false)]
                public string RegionCode { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SkipChallenge")]
            [Validation(Required=false)]
            public bool? SkipChallenge { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Cookies")]
        [Validation(Required=false)]
        public List<TraceSiteRequestCookies> Cookies { get; set; }
        public class TraceSiteRequestCookies : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>sessionId</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>f9ca1f7d-15bb-4c60-ad99-71b8e3e4985b</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public List<TraceSiteRequestHeaders> Headers { get; set; }
        public class TraceSiteRequestHeaders : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>User-Agent</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>trace-test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>GET</para>
        /// </summary>
        [NameInMap("Method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HTTP/1.1</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
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
