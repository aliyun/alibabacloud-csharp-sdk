// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListUserDefineRegionResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserDefineRegionList")]
        [Validation(Required=false)]
        public ListUserDefineRegionResponseBodyUserDefineRegionList UserDefineRegionList { get; set; }
        public class ListUserDefineRegionResponseBodyUserDefineRegionList : TeaModel {
            [NameInMap("UserDefineRegionEntity")]
            [Validation(Required=false)]
            public List<ListUserDefineRegionResponseBodyUserDefineRegionListUserDefineRegionEntity> UserDefineRegionEntity { get; set; }
            public class ListUserDefineRegionResponseBodyUserDefineRegionListUserDefineRegionEntity : TeaModel {
                public string BelongRegion { get; set; }
                public bool? DebugEnable { get; set; }
                public string Description { get; set; }
                public long? Id { get; set; }
                public string RegionId { get; set; }
                public string RegionName { get; set; }
                public string UserId { get; set; }
            }
        };

    }

}
