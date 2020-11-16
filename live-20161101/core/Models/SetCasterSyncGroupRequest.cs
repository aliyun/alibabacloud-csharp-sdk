// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SetCasterSyncGroupRequest : TeaModel {
        [NameInMap("CasterId")]
        [Validation(Required=true)]
        public string CasterId { get; set; }

        [NameInMap("SyncGroup")]
        [Validation(Required=false)]
        public List<SetCasterSyncGroupRequestSyncGroup> SyncGroup { get; set; }
        public class SetCasterSyncGroupRequestSyncGroup : TeaModel {
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public int? Mode { get; set; }

            [NameInMap("SyncDelayThreshold")]
            [Validation(Required=false)]
            public long SyncDelayThreshold { get; set; }

            [NameInMap("HostResourceId")]
            [Validation(Required=false)]
            public string HostResourceId { get; set; }

            [NameInMap("ResourceIds")]
            [Validation(Required=false)]
            public List<string> ResourceIds { get; set; }

        }

    }

}
