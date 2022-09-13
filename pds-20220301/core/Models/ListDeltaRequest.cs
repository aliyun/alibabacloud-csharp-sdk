// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListDeltaRequest : TeaModel {
        [NameInMap("cursor")]
        [Validation(Required=false)]
        public string Cursor { get; set; }

        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("sync_root_id")]
        [Validation(Required=false)]
        public string SyncRootId { get; set; }

    }

}
