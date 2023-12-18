// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListTrafficMirrorSessionsResponseBody : TeaModel {
        /// <summary>
        /// The token that is used for the next query. Valid values:
        /// 
        /// *   If no value is returned for **NextToken**, no next queries are sent.
        /// *   If a value of **NextToken** is returned, the value is the token that is used for the subsequent query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        /// <summary>
        /// The details about the traffic mirror session.
        /// </summary>
        [NameInMap("TrafficMirrorSessions")]
        [Validation(Required=false)]
        public List<ListTrafficMirrorSessionsResponseBodyTrafficMirrorSessions> TrafficMirrorSessions { get; set; }
        public class ListTrafficMirrorSessionsResponseBodyTrafficMirrorSessions : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// Indicates whether the traffic mirror session was enabled.
            /// 
            /// *   **false**: the traffic mirror session was disabled. This is the default value.
            /// *   **true**: the traffic mirror session was enabled.
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// The maximum transmission unit (MTU).
            /// </summary>
            [NameInMap("PacketLength")]
            [Validation(Required=false)]
            public int? PacketLength { get; set; }

            /// <summary>
            /// The priority of the traffic mirror session.
            /// 
            /// A smaller value indicates a higher priority.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// The ID of the resource group to which the mirrored traffic belongs.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The list of tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTrafficMirrorSessionsResponseBodyTrafficMirrorSessionsTags> Tags { get; set; }
            public class ListTrafficMirrorSessionsResponseBodyTrafficMirrorSessionsTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The ID of the traffic mirror filter.
            /// </summary>
            [NameInMap("TrafficMirrorFilterId")]
            [Validation(Required=false)]
            public string TrafficMirrorFilterId { get; set; }

            /// <summary>
            /// The status of the traffic mirror session.
            /// 
            /// *   **Normal**: active
            /// *   **FinancialLocked**: locked due to overdue payments
            /// </summary>
            [NameInMap("TrafficMirrorSessionBusinessStatus")]
            [Validation(Required=false)]
            public string TrafficMirrorSessionBusinessStatus { get; set; }

            /// <summary>
            /// The description of the traffic mirror session.
            /// </summary>
            [NameInMap("TrafficMirrorSessionDescription")]
            [Validation(Required=false)]
            public string TrafficMirrorSessionDescription { get; set; }

            /// <summary>
            /// The ID of the traffic mirror session.
            /// </summary>
            [NameInMap("TrafficMirrorSessionId")]
            [Validation(Required=false)]
            public string TrafficMirrorSessionId { get; set; }

            /// <summary>
            /// The name of the traffic mirror session.
            /// </summary>
            [NameInMap("TrafficMirrorSessionName")]
            [Validation(Required=false)]
            public string TrafficMirrorSessionName { get; set; }

            /// <summary>
            /// The status of the traffic mirror session. Valid values:
            /// 
            /// *   **Creating**
            /// *   **Created**
            /// *   **Modifying**
            /// *   **Deleting**
            /// </summary>
            [NameInMap("TrafficMirrorSessionStatus")]
            [Validation(Required=false)]
            public string TrafficMirrorSessionStatus { get; set; }

            /// <summary>
            /// The ID of the mirror source.
            /// </summary>
            [NameInMap("TrafficMirrorSourceIds")]
            [Validation(Required=false)]
            public List<string> TrafficMirrorSourceIds { get; set; }

            /// <summary>
            /// The ID of the mirror destination.
            /// </summary>
            [NameInMap("TrafficMirrorTargetId")]
            [Validation(Required=false)]
            public string TrafficMirrorTargetId { get; set; }

            /// <summary>
            /// The type of the traffic mirror destination. Valid values:
            /// 
            /// *   **NetworkInterface**: an ENI
            /// *   **SLB**: an internal-facing SLB instance
            /// </summary>
            [NameInMap("TrafficMirrorTargetType")]
            [Validation(Required=false)]
            public string TrafficMirrorTargetType { get; set; }

            /// <summary>
            /// You can specify VNIs to distinguish different mirrored traffic.
            /// </summary>
            [NameInMap("VirtualNetworkId")]
            [Validation(Required=false)]
            public int? VirtualNetworkId { get; set; }

        }

    }

}
