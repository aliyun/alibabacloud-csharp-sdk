// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class CreateOssUploadResponseBody : TeaModel {
        /// <summary>
        /// <para>OSS ObjectKey</para>
        /// </summary>
        [NameInMap("ObjectKey")]
        [Validation(Required=false)]
        public string ObjectKey { get; set; }

        /// <summary>
        /// <para>The <b>OSS pre-signed GET URL</b>, which is valid for 24 hours and uses the public endpoint. If the signature generation fails, null is returned, which does not affect direct upload using the credentials.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://yike-shared-pre-2.oss-cn-shanghai.aliyuncs.com/yike-v1/ge2tqn-o5zv6m/2026/11/18/13/upload/media/hkyo9v003.mp4?Expires=1795095160&OSSAccessKeyId=STS.Nxxxxxxxxxxxxxxxxxxxxxxxx&Signature=xxxxxxxxxxx%3D">https://yike-shared-pre-2.oss-cn-shanghai.aliyuncs.com/yike-v1/ge2tqn-o5zv6m/2026/11/18/13/upload/media/hkyo9v003.mp4?Expires=1795095160&amp;OSSAccessKeyId=STS.Nxxxxxxxxxxxxxxxxxxxxxxxx&amp;Signature=xxxxxxxxxxx%3D</a></para>
        /// </summary>
        [NameInMap("OssUrl")]
        [Validation(Required=false)]
        public string OssUrl { get; set; }

        /// <summary>
        /// <para>The <b>request ID</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F99F2AE5-***-BBD18F101455</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The upload credentials. Some fields may be empty depending on the CredentialType.</para>
        /// </summary>
        [NameInMap("UploadCredentials")]
        [Validation(Required=false)]
        public CreateOssUploadResponseBodyUploadCredentials UploadCredentials { get; set; }
        public class CreateOssUploadResponseBodyUploadCredentials : TeaModel {
            /// <summary>
            /// <para>The STS temporary AccessKey ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STS.Nxxxxxxxxxxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// <para>The STS temporary AccessKey secret.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            /// <summary>
            /// <para>OSS Bucket</para>
            /// 
            /// <b>Example:</b>
            /// <para>yike-shared-cn-shanghai-1</para>
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <para>The expiration time of the credential in UTC and ISO 8601 format. The actual return value prevails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-20T01:32:40Z</para>
            /// </summary>
            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public string Expiration { get; set; }

            /// <summary>
            /// <para>The PostObject policy, which is Base64-encoded. This is returned when POST_POLICY is used.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The AccessKey ID used for the signature. This is returned when POST_POLICY is used.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("PostAccessKeyId")]
            [Validation(Required=false)]
            public string PostAccessKeyId { get; set; }

            /// <summary>
            /// <para>The target endpoint for the POST request. This is returned when POST_POLICY is used.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("PostEndpoint")]
            [Validation(Required=false)]
            public string PostEndpoint { get; set; }

            /// <summary>
            /// <para>The OSS region, such as cn-shanghai.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The STS security token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

            /// <summary>
            /// <para>The PostObject signature. This is returned when POST_POLICY is used.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

            /// <summary>
            /// <para>The pre-signed PUT URL. This is returned when PRESIGNED_URL is used.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("SignedUrl")]
            [Validation(Required=false)]
            public string SignedUrl { get; set; }

        }

    }

}
