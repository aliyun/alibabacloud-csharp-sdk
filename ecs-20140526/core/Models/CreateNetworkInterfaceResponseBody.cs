// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateNetworkInterfaceResponseBody : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("NetworkInterfaceName")]
        [Validation(Required=false)]
        public string NetworkInterfaceName { get; set; }

        [NameInMap("MacAddress")]
        [Validation(Required=false)]
        public string MacAddress { get; set; }

        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public string NetworkInterfaceId { get; set; }

        [NameInMap("ServiceID")]
        [Validation(Required=false)]
        public long? ServiceID { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public CreateNetworkInterfaceResponseBodySecurityGroupIds SecurityGroupIds { get; set; }
        public class CreateNetworkInterfaceResponseBodySecurityGroupIds : TeaModel {
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public List<string> SecurityGroupId { get; set; }
        };

        [NameInMap("PrivateIpSets")]
        [Validation(Required=false)]
        public CreateNetworkInterfaceResponseBodyPrivateIpSets PrivateIpSets { get; set; }
        public class CreateNetworkInterfaceResponseBodyPrivateIpSets : TeaModel {
            [NameInMap("PrivateIpSet")]
            [Validation(Required=false)]
            public List<CreateNetworkInterfaceResponseBodyPrivateIpSetsPrivateIpSet> PrivateIpSet { get; set; }
            public class CreateNetworkInterfaceResponseBodyPrivateIpSetsPrivateIpSet : TeaModel {
                public string PrivateIpAddress { get; set; }
                public bool? Primary { get; set; }
            }
        };

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public CreateNetworkInterfaceResponseBodyTags Tags { get; set; }
        public class CreateNetworkInterfaceResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<CreateNetworkInterfaceResponseBodyTagsTag> Tag { get; set; }
            public class CreateNetworkInterfaceResponseBodyTagsTag : TeaModel {
                public string TagValue { get; set; }
                public string TagKey { get; set; }
            }
        };

        [NameInMap("Ipv6Sets")]
        [Validation(Required=false)]
        public CreateNetworkInterfaceResponseBodyIpv6Sets Ipv6Sets { get; set; }
        public class CreateNetworkInterfaceResponseBodyIpv6Sets : TeaModel {
            [NameInMap("Ipv6Set")]
            [Validation(Required=false)]
            public List<CreateNetworkInterfaceResponseBodyIpv6SetsIpv6Set> Ipv6Set { get; set; }
            public class CreateNetworkInterfaceResponseBodyIpv6SetsIpv6Set : TeaModel {
                public string Ipv6Address { get; set; }
            }
        };

    }

}
