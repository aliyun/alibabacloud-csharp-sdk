// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifyTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>OSS upload token information.</para>
        /// </summary>
        [NameInMap("OssUploadToken")]
        [Validation(Required=false)]
        public DescribeVerifyTokenResponseBodyOssUploadToken OssUploadToken { get; set; }
        public class DescribeVerifyTokenResponseBodyOssUploadToken : TeaModel {
            /// <summary>
            /// <para>OSS file storage bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloudauth-zhangjiakou-external</para>
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <para>Access endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://oss-cn-zhangjiakou.aliyuncs.com">https://oss-cn-zhangjiakou.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("EndPoint")]
            [Validation(Required=false)]
            public string EndPoint { get; set; }

            /// <summary>
            /// <para>Expiration time. Expressed in timestamp format, unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1582636610000</para>
            /// </summary>
            [NameInMap("Expired")]
            [Validation(Required=false)]
            public long? Expired { get; set; }

            /// <summary>
            /// <para>The key required for file upload.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STS.NU8rUBj****</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>File storage path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod/RdNLC@Ox2n-1s7NMt</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The secret required for file upload.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FwmnyoqT8dHj7nJLuM67T****</para>
            /// </summary>
            [NameInMap("Secret")]
            [Validation(Required=false)]
            public string Secret { get; set; }

            /// <summary>
            /// <para>The token required for file upload.</para>
            /// 
            /// <b>Example:</b>
            /// <para>uWia500nTS5knZaDzq4/KqpvhcLnO****</para>
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

        }

        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The entry link for the original H5 verification scheme, which has been discontinued and no longer supports new integrations. If you need to integrate an H5 verification scheme, it is recommended to use the <a href="https://help.aliyun.com/document_detail/173779.html">PC or mobile H5 web integration solution</a> of financial-grade real-person authentication.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http%3A%2F%2Fjiangsu.china.com.cn%2Fuploadfile%2F2015%2F0114%2F1421221304095989.jpg</para>
        /// </summary>
        [NameInMap("VerifyPageUrl")]
        [Validation(Required=false)]
        public string VerifyPageUrl { get; set; }

        /// <summary>
        /// <para>The token for this verification, used to link various interfaces in the verification request, valid for 30 minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c302c0797679457685410ee51a5ba375</para>
        /// </summary>
        [NameInMap("VerifyToken")]
        [Validation(Required=false)]
        public string VerifyToken { get; set; }

    }

}
