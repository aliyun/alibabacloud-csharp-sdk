// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListVirtualPhysicalConnectionsRequest : TeaModel {
        [NameInMap("IsConfirmed")]
        [Validation(Required=false)]
        public bool? IsConfirmed { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PhysicalConnectionId")]
        [Validation(Required=false)]
        public string PhysicalConnectionId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListVirtualPhysicalConnectionsRequestTags> Tags { get; set; }
        public class ListVirtualPhysicalConnectionsRequestTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("VirtualPhysicalConnectionAliUids")]
        [Validation(Required=false)]
        public List<string> VirtualPhysicalConnectionAliUids { get; set; }

        [NameInMap("VirtualPhysicalConnectionBusinessStatus")]
        [Validation(Required=false)]
        public string VirtualPhysicalConnectionBusinessStatus { get; set; }

        [NameInMap("VirtualPhysicalConnectionIds")]
        [Validation(Required=false)]
        public List<string> VirtualPhysicalConnectionIds { get; set; }

        [NameInMap("VirtualPhysicalConnectionStatuses")]
        [Validation(Required=false)]
        public List<string> VirtualPhysicalConnectionStatuses { get; set; }

        [NameInMap("VlanIds")]
        [Validation(Required=false)]
        public List<string> VlanIds { get; set; }

    }

}
