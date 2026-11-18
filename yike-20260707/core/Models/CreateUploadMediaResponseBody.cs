// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class CreateUploadMediaResponseBody : TeaModel {
        /// <summary>
        /// <para>The unsigned OSS URL of the file. The format is <c>oss://bucket/objectKey</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://yike-shared-ap-southeast-1-1/yike-v1/gi3dkn-gi3dkn/2026-11-18/08/video/b7e94fc0e1bf71f1bfa2f6e7c5486601aB3xYz01.mp4</para>
        /// </summary>
        [NameInMap("FileURL")]
        [Validation(Required=false)]
        public string FileURL { get; set; }

        /// <summary>
        /// <para>The media asset ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b7e94fc0e*****6e7c5486601</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The OSS object key. The format is <c>yike-v1/uid segment-ws segment/date/hour/type/mediaId+random string+source suffix.file name extension</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yike-v1/gi3dkn-gi3dkn/2026-11-18/08/video/b7e94fc0e1bf71f1bfa2f6e7c5486601aB3xYz01.mp4</para>
        /// </summary>
        [NameInMap("ObjectKey")]
        [Validation(Required=false)]
        public string ObjectKey { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B4C2E10-3F5A-4D6B-8C7D-1E2F3A4B5C6D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The storage location identifier. The format is <c>bucket.endpoint</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yike-shared-ap-southeast-1-1.oss-ap-southeast-1.aliyuncs.com</para>
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

        /// <summary>
        /// <para>The expiration time of the ticket. The time is in UTC and follows the ISO 8601 standard. This field is returned when UPLOAD_TICKET is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-18T12:00:00Z</para>
        /// </summary>
        [NameInMap("TicketExpiration")]
        [Validation(Required=false)]
        public string TicketExpiration { get; set; }

        /// <summary>
        /// <para>The upload credentials. Some fields may be empty depending on the <c>CredentialType</c>.</para>
        /// </summary>
        [NameInMap("UploadCredentials")]
        [Validation(Required=false)]
        public CreateUploadMediaResponseBodyUploadCredentials UploadCredentials { get; set; }
        public class CreateUploadMediaResponseBodyUploadCredentials : TeaModel {
            /// <summary>
            /// <para>The temporary STS <c>AccessKey ID</c>. This field is returned when <c>STS_TOKEN</c> is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STS.NUgYrLnoC63mLqWeRtYuIoPaSdF</para>
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// <para>The temporary STS AccessKey secret. This field is returned when STS_TOKEN is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CVwjCkNzTMupZ8nRtYeXwQaBcDfGhIjK</para>
            /// </summary>
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            /// <summary>
            /// <para>The OSS bucket. This field is returned when STS_TOKEN, POST_POLICY, or PRESIGNED_URL is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yike-shared-ap-southeast-1-1</para>
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <para>The expiration time of the credential. The time is in UTC and follows the ISO 8601 standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-18T12:00:00Z</para>
            /// </summary>
            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public string Expiration { get; set; }

            /// <summary>
            /// <para>The Base64-encoded PostObject policy. This field is returned when POST_POLICY is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJleHBpcmF0aW9uIjoiMjAyNi0xMS0xOFQxMjowMDowMFoiLCJjb25kaXRpb25zIjpbXX0=</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The AccessKey ID used for the signature. This field is returned when POST_POLICY is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LTAI5tG8XkQmP2vR9wYzAbCd</para>
            /// </summary>
            [NameInMap("PostAccessKeyId")]
            [Validation(Required=false)]
            public string PostAccessKeyId { get; set; }

            /// <summary>
            /// <para>The target endpoint for the POST request. This field is returned when POST_POLICY is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://yike-shared-ap-southeast-1-1.oss-ap-southeast-1.aliyuncs.com">https://yike-shared-ap-southeast-1-1.oss-ap-southeast-1.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("PostEndpoint")]
            [Validation(Required=false)]
            public string PostEndpoint { get; set; }

            /// <summary>
            /// <para>The OSS region. This field is returned in all three credential modes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ap-southeast-1</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The STS security token. This field is returned when STS_TOKEN is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CAISjgJ1q6Ft5B2yfSjIr5DDEOTM2pZ6g7oIExampleToken</para>
            /// </summary>
            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

            /// <summary>
            /// <para>The PostObject signature. This field is returned when POST_POLICY is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vXkQ9dRt2mLpN8sYwZaBcDfEgHj=</para>
            /// </summary>
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

            /// <summary>
            /// <para>The pre-signed PUT URL. This field is returned when PRESIGNED_URL is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://yike-shared-ap-southeast-1-1.oss-ap-southeast-1.aliyuncs.com/yike-v1/.../demo.mp4?Expires=1763467200&OSSAccessKeyId=STS.xxx&Signature=xxx">https://yike-shared-ap-southeast-1-1.oss-ap-southeast-1.aliyuncs.com/yike-v1/.../demo.mp4?Expires=1763467200&amp;OSSAccessKeyId=STS.xxx&amp;Signature=xxx</a></para>
            /// </summary>
            [NameInMap("SignedUrl")]
            [Validation(Required=false)]
            public string SignedUrl { get; set; }

        }

        /// <summary>
        /// <para>The upload ticket. This field is returned when UPLOAD_TICKET is used. The ticket is a 27-character string in the format of UT1+region code+random string+check digit. A real credential is issued based on this ticket during a ticket exchange.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UT1SGK7M2QX9R4T6V8W0Y3Z5ABC</para>
        /// </summary>
        [NameInMap("UploadTicket")]
        [Validation(Required=false)]
        public string UploadTicket { get; set; }

    }

}
