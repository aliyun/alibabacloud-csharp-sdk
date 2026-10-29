// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class GetDocumentDownloadUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of Success indicates that the call was successful. If the call fails, a specific error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The document download URL information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDocumentDownloadUrlResponseBodyData Data { get; set; }
        public class GetDocumentDownloadUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The short-lived presigned GET URL. Clients use this URL to download the original file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://my-bucket.oss-cn-hangzhou.aliyuncs.com/kb/doc-bp1xxxxxxxxxxxx?Expires=1788000000&Signature=xxxx">https://my-bucket.oss-cn-hangzhou.aliyuncs.com/kb/doc-bp1xxxxxxxxxxxx?Expires=1788000000&amp;Signature=xxxx</a></para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>The expiration time of the presigned download URL in ISO 8601 format and UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1756022400000</para>
            /// </summary>
            [NameInMap("ExpireAt")]
            [Validation(Required=false)]
            public string ExpireAt { get; set; }

        }

        /// <summary>
        /// <para>The response message. If the call is successful, the value is Operation success. If the call fails, a specific error description is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34AD682D-5B91-5773-8132-AA38C130****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. A value of true indicates that the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
