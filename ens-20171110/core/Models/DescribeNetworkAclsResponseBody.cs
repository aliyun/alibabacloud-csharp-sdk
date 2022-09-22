// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeNetworkAclsResponseBody : TeaModel {
        [NameInMap("NetworkAcls")]
        [Validation(Required=false)]
        public List<DescribeNetworkAclsResponseBodyNetworkAcls> NetworkAcls { get; set; }
        public class DescribeNetworkAclsResponseBodyNetworkAcls : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EgressAclEntries")]
            [Validation(Required=false)]
            public List<DescribeNetworkAclsResponseBodyNetworkAclsEgressAclEntries> EgressAclEntries { get; set; }
            public class DescribeNetworkAclsResponseBodyNetworkAclsEgressAclEntries : TeaModel {
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

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

                [NameInMap("PortRange")]
                [Validation(Required=false)]
                public string PortRange { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("IngressAclEntries")]
            [Validation(Required=false)]
            public List<DescribeNetworkAclsResponseBodyNetworkAclsIngressAclEntries> IngressAclEntries { get; set; }
            public class DescribeNetworkAclsResponseBodyNetworkAclsIngressAclEntries : TeaModel {
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

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

                [NameInMap("PortRange")]
                [Validation(Required=false)]
                public string PortRange { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("NetworkAclId")]
            [Validation(Required=false)]
            public string NetworkAclId { get; set; }

            [NameInMap("NetworkAclName")]
            [Validation(Required=false)]
            public string NetworkAclName { get; set; }

            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<DescribeNetworkAclsResponseBodyNetworkAclsResources> Resources { get; set; }
            public class DescribeNetworkAclsResponseBodyNetworkAclsResources : TeaModel {
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

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

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
