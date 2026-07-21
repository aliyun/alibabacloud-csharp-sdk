// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ListTextbookAssistantArticlesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListTextbookAssistantArticlesResponseBodyData> Data { get; set; }
        public class ListTextbookAssistantArticlesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The article ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0c05700d4d9411efbe6e0c42a106bb02</para>
            /// </summary>
            [NameInMap("articleId")]
            [Validation(Required=false)]
            public string ArticleId { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description><para>A value of 0 indicates success.</para>
        /// </description></item>
        /// <item><description><para>A value greater than 0 indicates a specific error.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>未知错误</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70412360-4272-571A-827D-84C2C07C450F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call succeeded.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The call succeeded.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The call failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
