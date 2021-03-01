// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertSwimmingLaneResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public InsertSwimmingLaneResponseBodyData Data { get; set; }
        public class InsertSwimmingLaneResponseBodyData : TeaModel {
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }
            [NameInMap("EntryRule")]
            [Validation(Required=false)]
            public string EntryRule { get; set; }
            [NameInMap("AppInfos")]
            [Validation(Required=false)]
            public string AppInfos { get; set; }
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("SwimmingLaneAppRelationShipList")]
            [Validation(Required=false)]
            public List<InsertSwimmingLaneResponseBodyDataSwimmingLaneAppRelationShipList> SwimmingLaneAppRelationShipList { get; set; }
            public class InsertSwimmingLaneResponseBodyDataSwimmingLaneAppRelationShipList : TeaModel {
                public string AppName { get; set; }
                public string AppId { get; set; }
                public string Rules { get; set; }
                public long? LaneId { get; set; }
            }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
