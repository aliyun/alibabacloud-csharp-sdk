// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMediaListRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

        [NameInMap("IncludePlayList")]
        [Validation(Required=false)]
        public bool? IncludePlayList { get; set; }

        [NameInMap("IncludeSnapshotList")]
        [Validation(Required=false)]
        public bool? IncludeSnapshotList { get; set; }

        [NameInMap("IncludeMediaInfo")]
        [Validation(Required=false)]
        public bool? IncludeMediaInfo { get; set; }

        [NameInMap("IncludeSummaryList")]
        [Validation(Required=false)]
        public bool? IncludeSummaryList { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

    }

}
