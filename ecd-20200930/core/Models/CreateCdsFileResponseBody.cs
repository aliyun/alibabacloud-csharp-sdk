// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateCdsFileResponseBody : TeaModel {
        /// <summary>
        /// <para>File upload response object.</para>
        /// </summary>
        [NameInMap("FileModel")]
        [Validation(Required=false)]
        public CreateCdsFileResponseBodyFileModel FileModel { get; set; }
        public class CreateCdsFileResponseBodyFileModel : TeaModel {
            /// <summary>
            /// <para>File ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>646ec2f662b1e08f7a2b4d648982f906****</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>File upload task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20BE155AC20943BE9D405B0997A9****</para>
            /// </summary>
            [NameInMap("UploadId")]
            [Validation(Required=false)]
            public string UploadId { get; set; }

            /// <summary>
            /// <para>File upload URL. Valid for 15 minutes by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://data.aliyunpds.com/xxx/xxx?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx&partNumber=1&uploadId=0CC175B9C0F1B6A831C399E26977">https://data.aliyunpds.com/xxx/xxx?Expires=xxx&amp;OSSAccessKeyId=xxx&amp;Signature=xxx&amp;partNumber=1&amp;uploadId=0CC175B9C0F1B6A831C399E26977</a>****</para>
            /// </summary>
            [NameInMap("UploadUrl")]
            [Validation(Required=false)]
            public string UploadUrl { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2BAFE05D-FFB9-5938-96D0-08017DB9****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
