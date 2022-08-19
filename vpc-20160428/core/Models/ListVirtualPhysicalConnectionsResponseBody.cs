// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListVirtualPhysicalConnectionsResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("VirtualPhysicalConnections")]
        [Validation(Required=false)]
        public List<ListVirtualPhysicalConnectionsResponseBodyVirtualPhysicalConnections> VirtualPhysicalConnections { get; set; }
        public class ListVirtualPhysicalConnectionsResponseBodyVirtualPhysicalConnections : TeaModel {
            [NameInMap("AccessPointId")]
            [Validation(Required=false)]
            public string AccessPointId { get; set; }

            [NameInMap("AdLocation")]
            [Validation(Required=false)]
            public string AdLocation { get; set; }

            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            [NameInMap("BusinessStatus")]
            [Validation(Required=false)]
            public string BusinessStatus { get; set; }

            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("CircuitCode")]
            [Validation(Required=false)]
            public string CircuitCode { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EnabledTime")]
            [Validation(Required=false)]
            public string EnabledTime { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("ExpectSpec")]
            [Validation(Required=false)]
            public string ExpectSpec { get; set; }

            [NameInMap("LineOperator")]
            [Validation(Required=false)]
            public string LineOperator { get; set; }

            [NameInMap("LoaStatus")]
            [Validation(Required=false)]
            public string LoaStatus { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OrderMode")]
            [Validation(Required=false)]
            public string OrderMode { get; set; }

            [NameInMap("ParentPhysicalConnectionAliUid")]
            [Validation(Required=false)]
            public string ParentPhysicalConnectionAliUid { get; set; }

            [NameInMap("ParentPhysicalConnectionId")]
            [Validation(Required=false)]
            public string ParentPhysicalConnectionId { get; set; }

            [NameInMap("PeerLocation")]
            [Validation(Required=false)]
            public string PeerLocation { get; set; }

            [NameInMap("PhysicalConnectionId")]
            [Validation(Required=false)]
            public string PhysicalConnectionId { get; set; }

            [NameInMap("PortNumber")]
            [Validation(Required=false)]
            public string PortNumber { get; set; }

            [NameInMap("PortType")]
            [Validation(Required=false)]
            public string PortType { get; set; }

            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            [NameInMap("RedundantPhysicalConnectionId")]
            [Validation(Required=false)]
            public string RedundantPhysicalConnectionId { get; set; }

            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("VirtualPhysicalConnectionStatus")]
            [Validation(Required=false)]
            public string VirtualPhysicalConnectionStatus { get; set; }

            [NameInMap("VlanId")]
            [Validation(Required=false)]
            public string VlanId { get; set; }

        }

    }

}
