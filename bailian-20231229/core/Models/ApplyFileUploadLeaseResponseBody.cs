// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ApplyFileUploadLeaseResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataCenter.FileTooLarge</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data fields.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ApplyFileUploadLeaseResponseBodyData Data { get; set; }
        public class ApplyFileUploadLeaseResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The unique ID of the lease. You need to specify this parameter when you call the <a href="https://help.aliyun.com/zh/model-studio/developer-reference/api-bailian-2023-12-29-addfile">AddFile</a> operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1e6a159107384782be5e45ac4759b247.1719325231035</para>
            /// </summary>
            [NameInMap("FileUploadLeaseId")]
            [Validation(Required=false)]
            public string FileUploadLeaseId { get; set; }

            /// <summary>
            /// <para>The HTTP request parameters used to upload the document.</para>
            /// </summary>
            [NameInMap("Param")]
            [Validation(Required=false)]
            public ApplyFileUploadLeaseResponseBodyDataParam Param { get; set; }
            public class ApplyFileUploadLeaseResponseBodyDataParam : TeaModel {
                /// <summary>
                /// <para>The key-value pair to be placed in the Header. Both the key and the value are strings.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;X-bailian-extra&quot;: &quot;MTAwNTQyNjQ5NTE2OTE3OA==&quot;,
                ///         &quot;Content-Type&quot;: &quot;application/pdf&quot;</para>
                /// </summary>
                [NameInMap("Headers")]
                [Validation(Required=false)]
                public object Headers { get; set; }

                /// <summary>
                /// <para>The HTTP call method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PUT</description></item>
                /// <item><description>POST</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PUT</para>
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// <para>The upload URL of the document.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://bailian-datahub-data-origin-prod.oss-cn-hangzhou.aliyuncs.com/1005426495169178/10024405/68abd1dea7b6404d8f7d7b9f7fbd332d.1716698936847.pdf?Expires=1716699536&OSSAccessKeyId=TestID&Signature=HfwPUZo4pR6DatSDym0zFKVh9Wg%3D">https://bailian-datahub-data-origin-prod.oss-cn-hangzhou.aliyuncs.com/1005426495169178/10024405/68abd1dea7b6404d8f7d7b9f7fbd332d.1716698936847.pdf?Expires=1716699536&amp;OSSAccessKeyId=TestID&amp;Signature=HfwPUZo4pR6DatSDym0zFKVh9Wg%3D</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The upload method of the document. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OSS.PreSignedURL</description></item>
            /// <item><description>HTTP</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>User not authorized to operate on the specified resource</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>778C0B3B-xxxx-5FC1-A947-36EDD13606AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indications whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
