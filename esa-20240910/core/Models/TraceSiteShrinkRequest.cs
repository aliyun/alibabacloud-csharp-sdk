// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class TraceSiteShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The HTTP request body.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;PlainText&quot;:&quot;bc58c54211db&quot;}</para>
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public string BodyShrink { get; set; }

        /// <summary>
        /// <para>The environment context. This parameter is optional.</para>
        /// </summary>
        [NameInMap("Context")]
        [Validation(Required=false)]
        public string ContextShrink { get; set; }

        /// <summary>
        /// <para>The cookie parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Cookies")]
        [Validation(Required=false)]
        public string CookiesShrink { get; set; }

        /// <summary>
        /// <para>The request headers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public string HeadersShrink { get; set; }

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
