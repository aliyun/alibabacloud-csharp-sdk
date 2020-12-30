// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpcAttributeResponseBody : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("IsDefault")]
        [Validation(Required=false)]
        public bool? IsDefault { get; set; }

        [NameInMap("DhcpOptionsSetStatus")]
        [Validation(Required=false)]
        public string DhcpOptionsSetStatus { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ClassicLinkEnabled")]
        [Validation(Required=false)]
        public bool? ClassicLinkEnabled { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public DescribeVpcAttributeResponseBodyVSwitchIds VSwitchIds { get; set; }
        public class DescribeVpcAttributeResponseBodyVSwitchIds : TeaModel {
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public List<string> VSwitchId { get; set; }
        };

        [NameInMap("SecondaryCidrBlocks")]
        [Validation(Required=false)]
        public DescribeVpcAttributeResponseBodySecondaryCidrBlocks SecondaryCidrBlocks { get; set; }
        public class DescribeVpcAttributeResponseBodySecondaryCidrBlocks : TeaModel {
            [NameInMap("SecondaryCidrBlock")]
            [Validation(Required=false)]
            public List<string> SecondaryCidrBlock { get; set; }
        };

        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        [NameInMap("UserCidrs")]
        [Validation(Required=false)]
        public DescribeVpcAttributeResponseBodyUserCidrs UserCidrs { get; set; }
        public class DescribeVpcAttributeResponseBodyUserCidrs : TeaModel {
            [NameInMap("UserCidr")]
            [Validation(Required=false)]
            public List<string> UserCidr { get; set; }
        };

        [NameInMap("VRouterId")]
        [Validation(Required=false)]
        public string VRouterId { get; set; }

        [NameInMap("DhcpOptionsSetId")]
        [Validation(Required=false)]
        public string DhcpOptionsSetId { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("AssociatedCens")]
        [Validation(Required=false)]
        public DescribeVpcAttributeResponseBodyAssociatedCens AssociatedCens { get; set; }
        public class DescribeVpcAttributeResponseBodyAssociatedCens : TeaModel {
            [NameInMap("AssociatedCen")]
            [Validation(Required=false)]
            public List<DescribeVpcAttributeResponseBodyAssociatedCensAssociatedCen> AssociatedCen { get; set; }
            public class DescribeVpcAttributeResponseBodyAssociatedCensAssociatedCen : TeaModel {
                public long? CenOwnerId { get; set; }
                public string CenId { get; set; }
                public string CenStatus { get; set; }
            }
        };

        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        [NameInMap("VpcName")]
        [Validation(Required=false)]
        public string VpcName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Ipv6CidrBlock")]
        [Validation(Required=false)]
        public string Ipv6CidrBlock { get; set; }

        [NameInMap("CloudResources")]
        [Validation(Required=false)]
        public DescribeVpcAttributeResponseBodyCloudResources CloudResources { get; set; }
        public class DescribeVpcAttributeResponseBodyCloudResources : TeaModel {
            [NameInMap("CloudResourceSetType")]
            [Validation(Required=false)]
            public List<DescribeVpcAttributeResponseBodyCloudResourcesCloudResourceSetType> CloudResourceSetType { get; set; }
            public class DescribeVpcAttributeResponseBodyCloudResourcesCloudResourceSetType : TeaModel {
                public int? ResourceCount { get; set; }
                public string ResourceType { get; set; }
            }
        };

    }

}
