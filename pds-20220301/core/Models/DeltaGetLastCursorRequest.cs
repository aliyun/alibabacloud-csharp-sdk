// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class DeltaGetLastCursorRequest : TeaModel {
        /// <summary>
        /// The drive ID.
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// The ID of the root file of the synced folder.
        /// </summary>
        [NameInMap("sync_root_id")]
        [Validation(Required=false)]
        public string SyncRootId { get; set; }

    }

}
