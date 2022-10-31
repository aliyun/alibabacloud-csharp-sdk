// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterSyncGroupResponseBody : TeaModel {
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

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
                [NameInMap("HostResourceId")]
                [Validation(Required=false)]
                public string HostResourceId { get; set; }

                [NameInMap("Mode")]
                [Validation(Required=false)]
                public int? Mode { get; set; }

                [NameInMap("ResourceIds")]
                [Validation(Required=false)]
                public DescribeCasterSyncGroupResponseBodySyncGroupsSyncGroupResourceIds ResourceIds { get; set; }
                public class DescribeCasterSyncGroupResponseBodySyncGroupsSyncGroupResourceIds : TeaModel {
                    [NameInMap("ResourceId")]
                    [Validation(Required=false)]
                    public List<string> ResourceId { get; set; }

                }

            }

        }

    }

}
