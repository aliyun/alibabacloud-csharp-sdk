// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GenerateUploadConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenerateUploadConfigResponseBodyData Data { get; set; }
        public class GenerateUploadConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The unique identifier of the file. You can use this value as a URL for AI Writing Assistant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://default/oss-bucket-name/aimiaobi/2021/07/01/1625126400000/1.docx</para>
            /// </summary>
            [NameInMap("FileKey")]
            [Validation(Required=false)]
            public string FileKey { get; set; }

            /// <summary>
            /// <para>The credentials for uploading the file to OSS.</para>
            /// <pre><code class="language-json">{
            ///   &quot;OSSAccessKeyId&quot;: &quot;xxx&quot;,
            ///   &quot;Signature&quot;: &quot;xxx+xxx=&quot;,
            ///   &quot;MaxSize&quot;: 31457280,
            ///   &quot;key&quot;: &quot;aimiaobi/dataset/2_2/xx.txt&quot;,
            ///   &quot;policy&quot;: &quot;xxx==&quot;
            /// }
            /// </c></pre>
            /// </summary>
            [NameInMap("FormDatas")]
            [Validation(Required=false)]
            public Dictionary<string, string> FormDatas { get; set; }

            /// <summary>
            /// <para>The address for uploading the file to OSS. This is a dedicated OSS domain name for AI Writing Assistant. The value is fixed to \<c>https\\://aimiaobi-service-prod.oss-cn-beijing.aliyuncs.com/\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://aimiaobi-service-prod.oss-cn-beijing.aliyuncs.com/">https://aimiaobi-service-prod.oss-cn-beijing.aliyuncs.com/</a></para>
            /// </summary>
            [NameInMap("PostUrl")]
            [Validation(Required=false)]
            public string PostUrl { get; set; }

        }

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
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. \<c>true\\</c> indicates success. \<c>false\\</c> indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
