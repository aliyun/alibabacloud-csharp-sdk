// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateNetworkAclResponseBody : TeaModel {
        [NameInMap("NetworkAclId")]
        [Validation(Required=false)]
        public string NetworkAclId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NetworkAclAttribute")]
        [Validation(Required=false)]
        public CreateNetworkAclResponseBodyNetworkAclAttribute NetworkAclAttribute { get; set; }
        public class CreateNetworkAclResponseBodyNetworkAclAttribute : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("EgressAclEntries")]
            [Validation(Required=false)]
            public CreateNetworkAclResponseBodyNetworkAclAttributeEgressAclEntries EgressAclEntries { get; set; }
            public class CreateNetworkAclResponseBodyNetworkAclAttributeEgressAclEntries : TeaModel {
                [NameInMap("EgressAclEntry")]
                [Validation(Required=false)]
                public List<CreateNetworkAclResponseBodyNetworkAclAttributeEgressAclEntriesEgressAclEntry> EgressAclEntry { get; set; }
                public class CreateNetworkAclResponseBodyNetworkAclAttributeEgressAclEntriesEgressAclEntry : TeaModel {
                    [NameInMap("NetworkAclEntryId")]
                    [Validation(Required=false)]
                    public string NetworkAclEntryId { get; set; }

                    [NameInMap("EntryType")]
                    [Validation(Required=false)]
                    public string EntryType { get; set; }

                    [NameInMap("NetworkAclEntryName")]
                    [Validation(Required=false)]
                    public string NetworkAclEntryName { get; set; }

                    [NameInMap("Policy")]
                    [Validation(Required=false)]
                    public string Policy { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    [NameInMap("DestinationCidrIp")]
                    [Validation(Required=false)]
                    public string DestinationCidrIp { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                }

            }
            [NameInMap("NetworkAclName")]
            [Validation(Required=false)]
            public string NetworkAclName { get; set; }
            [NameInMap("IngressAclEntries")]
            [Validation(Required=false)]
            public CreateNetworkAclResponseBodyNetworkAclAttributeIngressAclEntries IngressAclEntries { get; set; }
            public class CreateNetworkAclResponseBodyNetworkAclAttributeIngressAclEntries : TeaModel {
                [NameInMap("IngressAclEntry")]
                [Validation(Required=false)]
                public List<CreateNetworkAclResponseBodyNetworkAclAttributeIngressAclEntriesIngressAclEntry> IngressAclEntry { get; set; }
                public class CreateNetworkAclResponseBodyNetworkAclAttributeIngressAclEntriesIngressAclEntry : TeaModel {
                    [NameInMap("NetworkAclEntryId")]
                    [Validation(Required=false)]
                    public string NetworkAclEntryId { get; set; }

                    [NameInMap("EntryType")]
                    [Validation(Required=false)]
                    public string EntryType { get; set; }

                    [NameInMap("NetworkAclEntryName")]
                    [Validation(Required=false)]
                    public string NetworkAclEntryName { get; set; }

                    [NameInMap("Policy")]
                    [Validation(Required=false)]
                    public string Policy { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("SourceCidrIp")]
                    [Validation(Required=false)]
                    public string SourceCidrIp { get; set; }

                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                }

            }
            [NameInMap("NetworkAclId")]
            [Validation(Required=false)]
            public string NetworkAclId { get; set; }
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public CreateNetworkAclResponseBodyNetworkAclAttributeResources Resources { get; set; }
            public class CreateNetworkAclResponseBodyNetworkAclAttributeResources : TeaModel {
                [NameInMap("Resource")]
                [Validation(Required=false)]
                public List<CreateNetworkAclResponseBodyNetworkAclAttributeResourcesResource> Resource { get; set; }
                public class CreateNetworkAclResponseBodyNetworkAclAttributeResourcesResource : TeaModel {
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("ResourceType")]
                    [Validation(Required=false)]
                    public string ResourceType { get; set; }

                    [NameInMap("ResourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                }

            }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
        };

    }

}
