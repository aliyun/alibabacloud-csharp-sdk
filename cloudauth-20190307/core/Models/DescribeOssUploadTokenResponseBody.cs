// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeOssUploadTokenResponseBody : TeaModel {
        [NameInMap("OssUploadToken")]
        [Validation(Required=false)]
        public DescribeOssUploadTokenResponseBodyOssUploadToken OssUploadToken { get; set; }
        public class DescribeOssUploadTokenResponseBodyOssUploadToken : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cloudauth-zhangjiakou-external</para>
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://oss-cn-zhangjiakou.aliyuncs.com">https://oss-cn-zhangjiakou.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("EndPoint")]
            [Validation(Required=false)]
            public string EndPoint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1582636610000</para>
            /// </summary>
            [NameInMap("Expired")]
            [Validation(Required=false)]
            public long? Expired { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>STS.NU8rUBj****</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>prod/RdNLC@Ox2n-1s7NMt</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FwmnyoqT8dHj7nJLuM67T****</para>
            /// </summary>
            [NameInMap("Secret")]
            [Validation(Required=false)]
            public string Secret { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>uWia500nTS5knZaDzq4/KqpvhcLnO****</para>
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2FA2C773-47DB-4156-B1EE-5B047321A939</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
