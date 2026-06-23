// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class ReadPageItem : TeaModel {
        /// <summary>
        /// <para>The error related to the target URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The readable HTML of the target URL.</para>
        /// 
        /// <b>Example:</b>
        /// <html>\\n<head><title>Example Domain</title></head>\\n<body><div>\\n<h1>Example Domain</h1>\\n<para>This domain is for use in documentation examples without needing permission. Avoid use in operations.</para>\\n<para><a href=\\"https://iana.org/domains/example\\">Learn more</a></para>\\n</div></body>\\n</html>
        /// </summary>
        [NameInMap("html")]
        [Validation(Required=false)]
        public string Html { get; set; }

        /// <summary>
        /// <para>The Markdown content of the target URL.</para>
        /// 
        /// <b>Example:</b>
        /// <h1>Example Domain\nThis domain is for use in documentation examples without needing permission. Avoid use in operations.\n<a href="https://iana.org/domains/example">Learn more</a>\n</h1>
        /// </summary>
        [NameInMap("markdown")]
        [Validation(Required=false)]
        public string Markdown { get; set; }

        /// <summary>
        /// <para>The raw HTML of the target URL.</para>
        /// 
        /// <b>Example:</b>
        /// <!doctype html><html lang=\\"en\\"><head><title>Example Domain</title><meta name=\\"viewport\\" content=\\"width=device-width, initial-scale=1\\"><style>body{background:#eee;width:60vw;margin:15vh auto;font-family:system-ui,sans-serif}h1{font-size:1.5em}div{opacity:0.8}a:link,a:visited{color:#348}</style><body><div><h1>Example Domain</h1><para>This domain is for use in documentation examples without needing permission. Avoid use in operations.<para><a href=\\"https://iana.org/domains/example\\">Learn more</a></div></body></html>\\n
        /// </summary>
        [NameInMap("rawHtml")]
        [Validation(Required=false)]
        public string RawHtml { get; set; }

        [NameInMap("screenshot")]
        [Validation(Required=false)]
        public string Screenshot { get; set; }

        /// <summary>
        /// <ol>
        /// <item><description><para>If the request to the target site succeeds, the HTTP status code of the target URL is returned.</para>
        /// </description></item>
        /// <item><description><para>If the request to the target site fails, a custom error code is returned:</para>
        /// <para> 2.1 4030: The target site has security restrictions, such as robots.txt or security policies.</para>
        /// <para> 2.2 4080: The request timed out.</para>
        /// <para> 2.3 4290: The rate limiting policy of the site was triggered.</para>
        /// <para> 2.4 5010: An unknown exception occurred.</para>
        /// </description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// <para>The text content of the target URL.</para>
        /// 
        /// <b>Example:</b>
        /// <h1>Example Domain\nThis domain is for use in documentation examples without needing permission. Avoid use in operations.\nLearn more\n</h1>
        /// </summary>
        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

    }

}
