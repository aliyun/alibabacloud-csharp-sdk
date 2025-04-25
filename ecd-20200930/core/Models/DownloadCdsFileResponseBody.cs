// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DownloadCdsFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The download URL of the file.</para>
        /// </summary>
        [NameInMap("DownloadFileModel")]
        [Validation(Required=false)]
        public DownloadCdsFileResponseBodyDownloadFileModel DownloadFileModel { get; set; }
        public class DownloadCdsFileResponseBodyDownloadFileModel : TeaModel {
            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// </summary>
            [NameInMap("DownloadType")]
            [Validation(Required=false)]
            public string DownloadType { get; set; }

            /// <summary>
            /// <para>The download URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://pds-XXXX-bj-1693807057.oss-cn-beijing.aliyuncs.com/A0SKfLOp%2F2%2F6662612e0570fb2bdd5549759716d433439f0572%2F6662612ee3804e4901794928b14f9a7477640ee7?di=XXXX&dr=1030&f=667d5a322ebf7409e91c485d808fb3bd8a73efbb&response-content-disposition=attachment%3B%20">https://pds-XXXX-bj-1693807057.oss-cn-beijing.aliyuncs.com/A0SKfLOp%2F2%2F6662612e0570fb2bdd5549759716d433439f0572%2F6662612ee3804e4901794928b14f9a7477640ee7?di=XXXX&amp;dr=1030&amp;f=667d5a322ebf7409e91c485d808fb3bd8a73efbb&amp;response-content-disposition=attachment%3B%20</a></para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// </summary>
            [NameInMap("ExpirationSecond")]
            [Validation(Required=false)]
            public string ExpirationSecond { get; set; }

            /// <summary>
            /// <para>The validity period of the download URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-18T02:55:49.795Z</para>
            /// </summary>
            [NameInMap("ExpirationTime")]
            [Validation(Required=false)]
            public string ExpirationTime { get; set; }

            /// <summary>
            /// <para>The file ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>667d5a322ebf7409e91c485d808fb3bd8a73efbb</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The size of the file. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1594642</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// </summary>
            [NameInMap("StreamUrl")]
            [Validation(Required=false)]
            public string StreamUrl { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
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
        /// <para>E3ED9519-DD73-5C86-9C0A-43C9281C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
