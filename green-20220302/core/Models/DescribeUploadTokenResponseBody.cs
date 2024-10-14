// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class DescribeUploadTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeUploadTokenResponseBodyData Data { get; set; }
        public class DescribeUploadTokenResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The AccessKey ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STS.NUEUjvDqMuvH6oQA1TXxxH4wVR</para>
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// <para>The AccessKey secret.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            /// <summary>
            /// <para>The bucket name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-cip-shanghai</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The time when the file sharing link expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1720577200</para>
            /// </summary>
            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public int? Expiration { get; set; }

            /// <summary>
            /// <para>The file prefix.</para>
            /// 
            /// <b>Example:</b>
            /// <para>upload/1xxb89/</para>
            /// </summary>
            [NameInMap("FileNamePrefix")]
            [Validation(Required=false)]
            public string FileNamePrefix { get; set; }

            /// <summary>
            /// <para>the oss intranet point.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://oss-cn-shanghai-internal.aliyuncs.com">https://oss-cn-shanghai-internal.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("OssInternalEndPoint")]
            [Validation(Required=false)]
            public string OssInternalEndPoint { get; set; }

            /// <summary>
            /// <para>the oss internet point.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://oss-cn-shanghai.aliyuncs.com">https://oss-cn-shanghai.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("OssInternetEndPoint")]
            [Validation(Required=false)]
            public string OssInternetEndPoint { get; set; }

            /// <summary>
            /// <para>The security token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

        }

        /// <summary>
        /// <para>The message that is returned in response to the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
