// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeProjectAttachmentsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>e03a9f78-7b40-4fb3-a015-350913e37e3f</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeProjectAttachmentsResponseBodyResult> Result { get; set; }
        public class DescribeProjectAttachmentsResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Mzc4NDAtODQ3MjY4MzI=</para>
            /// </summary>
            [NameInMap("AttachmentToken")]
            [Validation(Required=false)]
            public string AttachmentToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>File</para>
            /// </summary>
            [NameInMap("AttachmentType")]
            [Validation(Required=false)]
            public string AttachmentType { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://delivery-center.oss-cn-shanghai.aliyuncs.com/6a8****0e2/e0a***f3.jpg?Expires=1589334682&OSSAccessKeyId=wI2r*********&Signature=JWB39pUxs7RCqrcw58qXPEGu6M0%3D">http://delivery-center.oss-cn-shanghai.aliyuncs.com/6a8****0e2/e0a***f3.jpg?Expires=1589334682&amp;OSSAccessKeyId=wI2r*********&amp;Signature=JWB39pUxs7RCqrcw58qXPEGu6M0%3D</a></para>
            /// </summary>
            [NameInMap("FileLink")]
            [Validation(Required=false)]
            public string FileLink { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1589334682404</para>
            /// </summary>
            [NameInMap("FileLinkGmtExpired")]
            [Validation(Required=false)]
            public long? FileLinkGmtExpired { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>f8-test-perview.jpeg</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>109124</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>jpg</para>
            /// </summary>
            [NameInMap("FileSuffix")]
            [Validation(Required=false)]
            public string FileSuffix { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1587968858000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8472</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public long? NodeId { get; set; }

            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>45261111****</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public long? Operator { get; set; }

            [NameInMap("OperatorName")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Provider</para>
            /// </summary>
            [NameInMap("OperatorRole")]
            [Validation(Required=false)]
            public string OperatorRole { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("StepNo")]
            [Validation(Required=false)]
            public int? StepNo { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
