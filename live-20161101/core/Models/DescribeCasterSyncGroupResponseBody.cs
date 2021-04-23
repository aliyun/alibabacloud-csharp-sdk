// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterSyncGroupResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SyncGroups")]
        [Validation(Required=false)]
        public DescribeCasterSyncGroupResponseBodySyncGroups SyncGroups { get; set; }
        public class DescribeCasterSyncGroupResponseBodySyncGroups : TeaModel {
            [NameInMap("SyncGroup")]
            [Validation(Required=false)]
            public List<DescribeCasterSyncGroupResponseBodySyncGroupsSyncGroup> SyncGroup { get; set; }
            public class DescribeCasterSyncGroupResponseBodySyncGroupsSyncGroup : TeaModel {
                public string HostResourceId { get; set; }
                public DescribeCasterSyncGroupResponseBodySyncGroupsSyncGroupResourceIds ResourceIds { get; set; }
                public class DescribeCasterSyncGroupResponseBodySyncGroupsSyncGroupResourceIds : TeaModel {
                    [NameInMap("ResourceId")]
                    [Validation(Required=false)]
                    public List<string> ResourceId { get; set; }

                }
                public int? Mode { get; set; }
            }
        };

        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

    }

}
