// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeleteLiveSnapshotFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of deletion results.</para>
        /// </summary>
        [NameInMap("DeleteFileResultList")]
        [Validation(Required=false)]
        public List<DeleteLiveSnapshotFilesResponseBodyDeleteFileResultList> DeleteFileResultList { get; set; }
        public class DeleteLiveSnapshotFilesResponseBodyDeleteFileResultList : TeaModel {
            /// <summary>
            /// <para>The creation timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1660638613798</para>
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>The deletion result. OK indicates that the deletion was successful. Other values indicate that the deletion failed.</para>
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
