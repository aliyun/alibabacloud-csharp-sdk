// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListRdDefaultSyncListResponseBody : TeaModel {
        /// <summary>
        /// The data returned if the call is successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListRdDefaultSyncListResponseBodyData Data { get; set; }
        public class ListRdDefaultSyncListResponseBodyData : TeaModel {
            /// <summary>
            /// The IDs of the folders in the resource directory.
            /// </summary>
            [NameInMap("FolderIds")]
            [Validation(Required=false)]
            public string FolderIds { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
