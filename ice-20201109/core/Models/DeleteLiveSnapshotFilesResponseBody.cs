// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeleteLiveSnapshotFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of deleted files.</para>
        /// </summary>
        [NameInMap("DeleteFileResultList")]
        [Validation(Required=false)]
        public List<DeleteLiveSnapshotFilesResponseBodyDeleteFileResultList> DeleteFileResultList { get; set; }
        public class DeleteLiveSnapshotFilesResponseBodyDeleteFileResultList : TeaModel {
            /// <summary>
            /// <para>The time when the file was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1660638613798</para>
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>The result of deletion. A value of OK indicates that the file is deleted. Other values indicate that the file failed to be deleted.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OK: The file was deleted.</description></item>
            /// <item><description>NotFound: The file was not found.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>2876-6263-4B75-8F2C-CD0F7FCF</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
