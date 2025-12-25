// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20210610.Models
{
    public class GetAttachmentUploadUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data returned after the call succeeds.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAttachmentUploadUrlResponseBodyData Data { get; set; }
        public class GetAttachmentUploadUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Query the signed URL of an OSS object</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://gts-workorder-pre.oss-cn-beijing.aliyuncs.com">https://gts-workorder-pre.oss-cn-beijing.aliyuncs.com</a>
            /// /20220314/cabb80c3-430b-4079-a9f2-d2a0d1c2a587.png?Expires=1647328689&amp;OSSAccessKeyId=LTAI****************&amp;Signature=AbSEh26G3oYrJ8ivr4B0xzF89zk%3D</para>
            /// </summary>
            [NameInMap("GetSignedUrl")]
            [Validation(Required=false)]
            public string GetSignedUrl { get; set; }

            /// <summary>
            /// <para>Uploaded file identifier</para>
            /// 
            /// <b>Example:</b>
            /// <para>cdb5d174-c282-4b2d-9048-e74ea2223127.jpg</para>
            /// </summary>
            [NameInMap("ObjectKey")]
            [Validation(Required=false)]
            public string ObjectKey { get; set; }

            /// <summary>
            /// <para>The signed URL used to upload the object to OSS.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://gts-workorder-pre.oss-cn-beijing.aliyuncs.com">https://gts-workorder-pre.oss-cn-beijing.aliyuncs.com</a>
            /// /20220314/cabb80c3-430b-4079-a9f2-d2a0d1c2a587.png?Expires=1647328689&amp;OSSAccessKeyId=LTAI****************&amp;Signature=AbSEh26G3oYrJ8ivr4B0xzF89zk%3D</para>
            /// </summary>
            [NameInMap("PutSignedUrl")]
            [Validation(Required=false)]
            public string PutSignedUrl { get; set; }

        }

        /// <summary>
        /// <para>The error message. If success is set to false, the message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ED195C2C-787F-511C-8204-714456781861</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. A value of true indicates that the call is normal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
