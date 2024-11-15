// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetChatappUploadAuthorizationResponseBody : TeaModel {
        /// <summary>
        /// <para>Access denied for detailed information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// <list type="bullet">
        /// <item><description>A value of OK indicates that the call is successful.</description></item>
        /// <item><description>Other values indicate that the call fails. For more information, see <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetChatappUploadAuthorizationResponseBodyData Data { get; set; }
        public class GetChatappUploadAuthorizationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The AccessKey ID that is used to authorize a user to upload a file to Object Storage Service (OSS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2skeuurfj****</para>
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// <para>The AccessKey secret that is used to authorize a user to upload a file to OSS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>skdkdukeuuuu****</para>
            /// </summary>
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            /// <summary>
            /// <para>The name of the bucket to which a file is uploaded in OSS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The directory to which the file is uploaded in Object Storage Service (OSS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000102939</para>
            /// </summary>
            [NameInMap("Dir")]
            [Validation(Required=false)]
            public string Dir { get; set; }

            /// <summary>
            /// <para>The address of the OSS server to which a file is uploaded.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://oss.com">https://oss.com</a></para>
            /// </summary>
            [NameInMap("EndPoint")]
            [Validation(Required=false)]
            public string EndPoint { get; set; }

            /// <summary>
            /// <para>The timeout period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("Expire")]
            [Validation(Required=false)]
            public int? Expire { get; set; }

            /// <summary>
            /// <para>The security token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dkdieiii**</para>
            /// </summary>
            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

        }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90E63D28-E31D-1EB2-8939-A94866411B2O</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
