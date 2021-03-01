// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListSwimmingLaneResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListSwimmingLaneResponseBodyData> Data { get; set; }
        public class ListSwimmingLaneResponseBodyData : TeaModel {
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            [NameInMap("ScenarioSign")]
            [Validation(Required=false)]
            public string ScenarioSign { get; set; }

            [NameInMap("EntryRule")]
            [Validation(Required=false)]
            public string EntryRule { get; set; }

            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            [NameInMap("EnableRules")]
            [Validation(Required=false)]
            public bool? EnableRules { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("SwimmingLaneAppRelationShipList")]
            [Validation(Required=false)]
            public List<ListSwimmingLaneResponseBodyDataSwimmingLaneAppRelationShipList> SwimmingLaneAppRelationShipList { get; set; }
            public class ListSwimmingLaneResponseBodyDataSwimmingLaneAppRelationShipList : TeaModel {
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("Rules")]
                [Validation(Required=false)]
                public string Rules { get; set; }

                [NameInMap("LaneId")]
                [Validation(Required=false)]
                public long? LaneId { get; set; }

            }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
