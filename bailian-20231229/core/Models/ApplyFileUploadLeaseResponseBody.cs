// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ApplyFileUploadLeaseResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DataCenter.FileTooLarge</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ApplyFileUploadLeaseResponseBodyData Data { get; set; }
        public class ApplyFileUploadLeaseResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1e6a159107384782be5e45ac4759b247.1719325231035</para>
            /// </summary>
            [NameInMap("FileUploadLeaseId")]
            [Validation(Required=false)]
            public string FileUploadLeaseId { get; set; }

            [NameInMap("Param")]
            [Validation(Required=false)]
            public ApplyFileUploadLeaseResponseBodyDataParam Param { get; set; }
            public class ApplyFileUploadLeaseResponseBodyDataParam : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;X-bailian-extra&quot;: &quot;MTAwNTQyNjQ5NTE2OTE3OA==&quot;,
                ///         &quot;Content-Type&quot;: &quot;application/pdf&quot;</para>
                /// </summary>
                [NameInMap("Headers")]
                [Validation(Required=false)]
                public object Headers { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PUT</para>
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://bailian-datahub-data-origin-prod.oss-cn-hangzhou.aliyuncs.com/1005426495169178/10024405/68abd1dea7b6404d8f7d7b9f7fbd332d.1716698936847.pdf?Expires=1716699536&OSSAccessKeyId=TestID&Signature=HfwPUZo4pR6DatSDym0zFKVh9Wg%3D">https://bailian-datahub-data-origin-prod.oss-cn-hangzhou.aliyuncs.com/1005426495169178/10024405/68abd1dea7b6404d8f7d7b9f7fbd332d.1716698936847.pdf?Expires=1716699536&amp;OSSAccessKeyId=TestID&amp;Signature=HfwPUZo4pR6DatSDym0zFKVh9Wg%3D</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>User not authorized to operate on the specified resource</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>778C0B3B-xxxx-5FC1-A947-36EDD13606AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
