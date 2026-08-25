// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetFileUploadInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Returns None.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFileUploadInfoResponseBodyData Data { get; set; }
        public class GetFileUploadInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The temporary AccessKey ID returned by Security Token Service (STS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>LTA****</para>
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// <para>The bucket name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>appstream-*</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The expiration time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public string Expiration { get; set; }

            /// <summary>
            /// <para>The folder path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai/aig_upm/***</para>
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <para>The maximum file size in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>52428800</para>
            /// </summary>
            [NameInMap("MaxFileSize")]
            [Validation(Required=false)]
            public long? MaxFileSize { get; set; }

            /// <summary>
            /// <para>The OSS endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-cn-shanghai.aliyuncs.com</para>
            /// </summary>
            [NameInMap("OssPoint")]
            [Validation(Required=false)]
            public string OssPoint { get; set; }

            /// <summary>
            /// <para>The PostObject policy (Base64-encoded).</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>F591F0EA-AA10-52D2-ADA3-68397887B17C</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The PostObject policy signature (HMAC-SHA1).</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

            /// <summary>
            /// <para>The temporary token returned by STS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>C*****</para>
            /// </summary>
            [NameInMap("StsToken")]
            [Validation(Required=false)]
            public string StsToken { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
