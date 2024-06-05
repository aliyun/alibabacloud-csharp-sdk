// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListDeltaRequest : TeaModel {
        /// <summary>
        /// The cursor of the incremental information.
        /// </summary>
        [NameInMap("cursor")]
        [Validation(Required=false)]
        public string Cursor { get; set; }

        /// <summary>
        /// The drive ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// The maximum number of results to return. Valid values: 0 to 100. Default value: 100.
        /// 
        /// The number of returned results must be less than or equal to the specified number.
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The ID of the root file of the synced folder.
        /// </summary>
        [NameInMap("sync_root_id")]
        [Validation(Required=false)]
        public string SyncRootId { get; set; }

    }

}
