// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DtsAI20260401.Models
{
    public class WebSearchResponseBody : TeaModel {
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
        /// <para>The search query statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Spring Boot</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

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
        /// <para>The list of search results.</para>
        /// </summary>
        [NameInMap("SearchResult")]
        [Validation(Required=false)]
        public List<WebSearchResponseBodySearchResult> SearchResult { get; set; }
        public class WebSearchResponseBodySearchResult : TeaModel {
            /// <summary>
            /// <para>The snippet of the web page content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Spring Boot makes it easy to create stand-alone, production-grade Spring based Applications.</para>
            /// </summary>
            [NameInMap("Snippet")]
            [Validation(Required=false)]
            public string Snippet { get; set; }

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
            /// <para><a href="https://xxx/projects/spring-boot">https://xxx/projects/spring-boot</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

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
        /// <para>The total number of results returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalResults")]
        [Validation(Required=false)]
        public int? TotalResults { get; set; }

    }

}
