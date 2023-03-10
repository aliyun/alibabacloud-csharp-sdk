// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListTrafficMirrorSessionsResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        [NameInMap("TrafficMirrorSessions")]
        [Validation(Required=false)]
        public List<ListTrafficMirrorSessionsResponseBodyTrafficMirrorSessions> TrafficMirrorSessions { get; set; }
        public class ListTrafficMirrorSessionsResponseBodyTrafficMirrorSessions : TeaModel {
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("PacketLength")]
            [Validation(Required=false)]
            public int? PacketLength { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTrafficMirrorSessionsResponseBodyTrafficMirrorSessionsTags> Tags { get; set; }
            public class ListTrafficMirrorSessionsResponseBodyTrafficMirrorSessionsTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("TrafficMirrorFilterId")]
            [Validation(Required=false)]
            public string TrafficMirrorFilterId { get; set; }

            [NameInMap("TrafficMirrorSessionBusinessStatus")]
            [Validation(Required=false)]
            public string TrafficMirrorSessionBusinessStatus { get; set; }

            [NameInMap("TrafficMirrorSessionDescription")]
            [Validation(Required=false)]
            public string TrafficMirrorSessionDescription { get; set; }

            [NameInMap("TrafficMirrorSessionId")]
            [Validation(Required=false)]
            public string TrafficMirrorSessionId { get; set; }

            [NameInMap("TrafficMirrorSessionName")]
            [Validation(Required=false)]
            public string TrafficMirrorSessionName { get; set; }

            [NameInMap("TrafficMirrorSessionStatus")]
            [Validation(Required=false)]
            public string TrafficMirrorSessionStatus { get; set; }

            [NameInMap("TrafficMirrorSourceIds")]
            [Validation(Required=false)]
            public List<string> TrafficMirrorSourceIds { get; set; }

            [NameInMap("TrafficMirrorTargetId")]
            [Validation(Required=false)]
            public string TrafficMirrorTargetId { get; set; }

            [NameInMap("TrafficMirrorTargetType")]
            [Validation(Required=false)]
            public string TrafficMirrorTargetType { get; set; }

            [NameInMap("VirtualNetworkId")]
            [Validation(Required=false)]
            public int? VirtualNetworkId { get; set; }

        }

    }

}
