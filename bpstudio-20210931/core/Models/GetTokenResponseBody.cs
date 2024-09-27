// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class GetTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The information about the token.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTokenResponseBodyData Data { get; set; }
        public class GetTokenResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The AccessKey ID that is used to access OSS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STS.NTm*****8tu</para>
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// <para>The AccessKey secret used to access OSS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9NG*****K4X</para>
            /// </summary>
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            /// <summary>
            /// <para>The OSS bucket that is used to store the architecture image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bucket-1</para>
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <para>The OSS endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://oss-cn-beijing.aliyuncs.com">https://oss-cn-beijing.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The token that is used to access the Object Storage Service (OSS) bucket that stores the architecture image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ABCD</para>
            /// </summary>
            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

            /// <summary>
            /// <para>The OSS bucket that is used to save data snapshots.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bucket-2</para>
            /// </summary>
            [NameInMap("SnapshotBucket")]
            [Validation(Required=false)]
            public string SnapshotBucket { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A07FFDF2-78FA-1B48-9E38-88E833A93187</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
