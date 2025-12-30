// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ListTransferFileDownloadUrlResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>F1F01499-8F3D-5657-91AD-48177EB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Urls")]
        [Validation(Required=false)]
        public List<ListTransferFileDownloadUrlResponseBodyUrls> Urls { get; set; }
        public class ListTransferFileDownloadUrlResponseBodyUrls : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>trf-i4pz8emx2k2fr****</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>document.txt</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DELETED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://xxsy-transfer.oss-cn-beijing.aliyuncs.com/xxxx">http://xxsy-transfer.oss-cn-beijing.aliyuncs.com/xxxx</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
