// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeleteLiveSnapshotFilesResponseBody : TeaModel {
        [NameInMap("DeleteFileResultList")]
        [Validation(Required=false)]
        public List<DeleteLiveSnapshotFilesResponseBodyDeleteFileResultList> DeleteFileResultList { get; set; }
        public class DeleteLiveSnapshotFilesResponseBodyDeleteFileResultList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1660638613798</para>
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>2876-6263-4B75-8F2C-CD0F7FCF</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
