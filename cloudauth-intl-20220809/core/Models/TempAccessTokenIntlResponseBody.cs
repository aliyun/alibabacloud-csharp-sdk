// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class TempAccessTokenIntlResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public TempAccessTokenIntlResponseBodyData Data { get; set; }
        public class TempAccessTokenIntlResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3hxuRpEJ3Jv2Rtzyg4HooFCYqps762XcNtzhn19wQymk</para>
            /// </summary>
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>liyi</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test001</para>
            /// </summary>
            [NameInMap("FileNamePrefix")]
            [Validation(Required=false)]
            public string FileNamePrefix { get; set; }

            /// <summary>
            /// <para>OssEndPoint。</para>
            /// 
            /// <b>Example:</b>
            /// <para>ossEndPoint</para>
            /// </summary>
            [NameInMap("OssEndPoint")]
            [Validation(Required=false)]
            public string OssEndPoint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>86C40EC3-5940-5F47-995C-BFE90B70E540</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
