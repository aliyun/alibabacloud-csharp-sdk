// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DtsAI20260401.Models
{
    public class WebFetchResponseBody : TeaModel {
        /// <summary>
        /// <para>The content of the web page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Spring Boot makes it easy to create stand-alone, production-grade Spring based Applications.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The actual output format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>markdown</b>: Markdown format.</para>
        /// </description></item>
        /// <item><description><para><b>html</b>: HTML format.</para>
        /// </description></item>
        /// <item><description><para><b>text</b>: Plain text format.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>markdown</para>
        /// </summary>
        [NameInMap("ContentFormat")]
        [Validation(Required=false)]
        public string ContentFormat { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ErrorMessage Code</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ErrorMessage Example</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A30D0930-xxxx-xxxx-xxxx-C2C661CC8B58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The title of the web page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Spring Boot</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The URL of the web page.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxxx/projects/spring-boot">https://xxxx/projects/spring-boot</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        /// <summary>
        /// <para>The URL classification result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>static_html</b>: A static HTML page.</description></item>
        /// <item><description><b>dynamic_js</b>: A single-page application (SPA) page that requires JavaScript rendering.</description></item>
        /// <item><description><b>audio</b>: An audio file.</description></item>
        /// <item><description><b>video</b>: A video file.</description></item>
        /// <item><description><b>document</b>: A document file (PDF, Word, PPT, or Excel).</description></item>
        /// <item><description><b>unknown</b>: Unrecognizable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>static_html</para>
        /// </summary>
        [NameInMap("UrlType")]
        [Validation(Required=false)]
        public string UrlType { get; set; }

    }

}
