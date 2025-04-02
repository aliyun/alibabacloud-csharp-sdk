// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emas_appmonitor20190611.Models
{
    public class RequestUploadTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>Args</para>
        /// </summary>
        [NameInMap("Args")]
        [Validation(Required=false)]
        public Dictionary<string, object> Args { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public RequestUploadTokenResponseBodyModel Model { get; set; }
        public class RequestUploadTokenResponseBodyModel : TeaModel {
            /// <summary>
            /// <para>OSS AccessKeyId</para>
            /// 
            /// <b>Example:</b>
            /// <para>STS.NXEGHKdjkdnINNgLiDE</para>
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// <para>OSS AccessKeySecret</para>
            /// 
            /// <b>Example:</b>
            /// <para>ikKgkNDGedInGEIngL</para>
            /// </summary>
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss-cn-shanghai.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Szi9v92mHNikdknfe</para>
            /// </summary>
            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>symbolic-prod</para>
            /// </summary>
            [NameInMap("UploadBucket")]
            [Validation(Required=false)]
            public string UploadBucket { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/335374903@iphoneos/</para>
            /// </summary>
            [NameInMap("UploadDir")]
            [Validation(Required=false)]
            public string UploadDir { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AB8AB5EC-9636-421D-AE7C-BB227DFC95B0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
