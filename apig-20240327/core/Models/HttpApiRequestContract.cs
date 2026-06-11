// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiRequestContract : TeaModel {
        /// <summary>
        /// <para>The body parameters.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public HttpApiRequestContractBody Body { get; set; }
        public class HttpApiRequestContractBody : TeaModel {
            /// <summary>
            /// <para>The content type of the request body.</para>
            /// 
            /// <b>Example:</b>
            /// <para>application/json</para>
            /// </summary>
            [NameInMap("contentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <para>The parameter description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>body参数描述</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The sample value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;result&quot;:&quot;ok&quot;}</para>
            /// </summary>
            [NameInMap("example")]
            [Validation(Required=false)]
            public string Example { get; set; }

            /// <summary>
            /// <para>The JSON definition description of the request body.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;type&quot;: &quot;object&quot;,
            ///     &quot;required&quot;: [
            ///         &quot;result&quot;
            ///     ],
            ///     &quot;properties&quot;: {
            ///         &quot;result&quot;: {
            ///             &quot;type&quot;: &quot;string&quot;,
            ///             &quot;description&quot;: &quot;操作结果，\&quot;ok\&quot; 表示成功&quot;
            ///         }
            ///     }
            /// }</para>
            /// </summary>
            [NameInMap("jsonSchema")]
            [Validation(Required=false)]
            public string JsonSchema { get; set; }

        }

        /// <summary>
        /// <para>The request header parameters.</para>
        /// </summary>
        [NameInMap("headerParameters")]
        [Validation(Required=false)]
        public List<HttpApiParameter> HeaderParameters { get; set; }

        /// <summary>
        /// <para>The path parameters.</para>
        /// </summary>
        [NameInMap("pathParameters")]
        [Validation(Required=false)]
        public List<HttpApiParameter> PathParameters { get; set; }

        /// <summary>
        /// <para>The query parameters.</para>
        /// </summary>
        [NameInMap("queryParameters")]
        [Validation(Required=false)]
        public List<HttpApiParameter> QueryParameters { get; set; }

    }

}
