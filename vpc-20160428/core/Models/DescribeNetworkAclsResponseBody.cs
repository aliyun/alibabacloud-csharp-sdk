// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeNetworkAclsResponseBody : TeaModel {
        [NameInMap("NetworkAcls")]
        [Validation(Required=false)]
        public DescribeNetworkAclsResponseBodyNetworkAcls NetworkAcls { get; set; }
        public class DescribeNetworkAclsResponseBodyNetworkAcls : TeaModel {
            [NameInMap("NetworkAcl")]
            [Validation(Required=false)]
            public List<DescribeNetworkAclsResponseBodyNetworkAclsNetworkAcl> NetworkAcl { get; set; }
            public class DescribeNetworkAclsResponseBodyNetworkAclsNetworkAcl : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EgressAclEntries")]
                [Validation(Required=false)]
                public DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclEgressAclEntries EgressAclEntries { get; set; }
                public class DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclEgressAclEntries : TeaModel {
                    [NameInMap("EgressAclEntry")]
                    [Validation(Required=false)]
                    public List<DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclEgressAclEntriesEgressAclEntry> EgressAclEntry { get; set; }
                    public class DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclEgressAclEntriesEgressAclEntry : TeaModel {
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("DestinationCidrIp")]
                        [Validation(Required=false)]
                        public string DestinationCidrIp { get; set; }

                        [NameInMap("NetworkAclEntryId")]
                        [Validation(Required=false)]
                        public string NetworkAclEntryId { get; set; }

                        [NameInMap("NetworkAclEntryName")]
                        [Validation(Required=false)]
                        public string NetworkAclEntryName { get; set; }

                        [NameInMap("Policy")]
                        [Validation(Required=false)]
                        public string Policy { get; set; }

                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public string Port { get; set; }

                        [NameInMap("Protocol")]
                        [Validation(Required=false)]
                        public string Protocol { get; set; }

                    }

                }

                [NameInMap("IngressAclEntries")]
                [Validation(Required=false)]
                public DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclIngressAclEntries IngressAclEntries { get; set; }
                public class DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclIngressAclEntries : TeaModel {
                    [NameInMap("IngressAclEntry")]
                    [Validation(Required=false)]
                    public List<DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclIngressAclEntriesIngressAclEntry> IngressAclEntry { get; set; }
                    public class DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclIngressAclEntriesIngressAclEntry : TeaModel {
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("NetworkAclEntryId")]
                        [Validation(Required=false)]
                        public string NetworkAclEntryId { get; set; }

                        [NameInMap("NetworkAclEntryName")]
                        [Validation(Required=false)]
                        public string NetworkAclEntryName { get; set; }

                        [NameInMap("Policy")]
                        [Validation(Required=false)]
                        public string Policy { get; set; }

                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public string Port { get; set; }

                        [NameInMap("Protocol")]
                        [Validation(Required=false)]
                        public string Protocol { get; set; }

                        [NameInMap("SourceCidrIp")]
                        [Validation(Required=false)]
                        public string SourceCidrIp { get; set; }

                    }

                }

                [NameInMap("NetworkAclId")]
                [Validation(Required=false)]
                public string NetworkAclId { get; set; }

                [NameInMap("NetworkAclName")]
                [Validation(Required=false)]
                public string NetworkAclName { get; set; }

                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Resources")]
                [Validation(Required=false)]
                public DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclResources Resources { get; set; }
                public class DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclResources : TeaModel {
                    [NameInMap("Resource")]
                    [Validation(Required=false)]
                    public List<DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclResourcesResource> Resource { get; set; }
                    public class DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclResourcesResource : TeaModel {
                        [NameInMap("ResourceId")]
                        [Validation(Required=false)]
                        public string ResourceId { get; set; }

                        [NameInMap("ResourceType")]
                        [Validation(Required=false)]
                        public string ResourceType { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclTags Tags { get; set; }
                public class DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclTagsTag> Tag { get; set; }
                    public class DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
