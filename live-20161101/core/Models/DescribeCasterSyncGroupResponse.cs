// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterSyncGroupResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("CasterId")]
        [Validation(Required=true)]
        public string CasterId { get; set; }

        [NameInMap("SyncGroups")]
        [Validation(Required=true)]
        public DescribeCasterSyncGroupResponseSyncGroups SyncGroups { get; set; }
        public class DescribeCasterSyncGroupResponseSyncGroups : TeaModel {
            [NameInMap("SyncGroup")]
            [Validation(Required=true)]
            public List<DescribeCasterSyncGroupResponseSyncGroupsSyncGroup> SyncGroup { get; set; }
            public class DescribeCasterSyncGroupResponseSyncGroupsSyncGroup : TeaModel {
                public int? Mode { get; set; }
                public string HostResourceId { get; set; }
                public DescribeCasterSyncGroupResponseSyncGroupsSyncGroupResourceIds ResourceIds { get; set; }
                public class DescribeCasterSyncGroupResponseSyncGroupsSyncGroupResourceIds : TeaModel {
                    /// <summary>
                    /// ResourceId
                    /// </summary>
                    [NameInMap("ResourceId")]
                    [Validation(Required=true)]
                    public List<string> ResourceId { get; set; }

                }
            }
        };

    }

}
