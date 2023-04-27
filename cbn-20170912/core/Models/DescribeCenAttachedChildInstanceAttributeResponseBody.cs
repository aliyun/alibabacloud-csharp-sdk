// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenAttachedChildInstanceAttributeResponseBody : TeaModel {
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        [NameInMap("ChildInstanceAttachTime")]
        [Validation(Required=false)]
        public string ChildInstanceAttachTime { get; set; }

        [NameInMap("ChildInstanceAttributes")]
        [Validation(Required=false)]
        public DescribeCenAttachedChildInstanceAttributeResponseBodyChildInstanceAttributes ChildInstanceAttributes { get; set; }
        public class DescribeCenAttachedChildInstanceAttributeResponseBodyChildInstanceAttributes : TeaModel {
            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            [NameInMap("Ipv6CidrBlock")]
            [Validation(Required=false)]
            public string Ipv6CidrBlock { get; set; }

            [NameInMap("Ipv6CidrBlocks")]
            [Validation(Required=false)]
            public DescribeCenAttachedChildInstanceAttributeResponseBodyChildInstanceAttributesIpv6CidrBlocks Ipv6CidrBlocks { get; set; }
            public class DescribeCenAttachedChildInstanceAttributeResponseBodyChildInstanceAttributesIpv6CidrBlocks : TeaModel {
                [NameInMap("ipv6CidrBlock")]
                [Validation(Required=false)]
                public List<DescribeCenAttachedChildInstanceAttributeResponseBodyChildInstanceAttributesIpv6CidrBlocksIpv6CidrBlock> Ipv6CidrBlock { get; set; }
                public class DescribeCenAttachedChildInstanceAttributeResponseBodyChildInstanceAttributesIpv6CidrBlocksIpv6CidrBlock : TeaModel {
                    [NameInMap("Ipv6CidrBlock")]
                    [Validation(Required=false)]
                    public string Ipv6CidrBlock { get; set; }

                    [NameInMap("Ipv6Isp")]
                    [Validation(Required=false)]
                    public string Ipv6Isp { get; set; }

                }

            }

            [NameInMap("SecondaryCidrBlocks")]
            [Validation(Required=false)]
            public DescribeCenAttachedChildInstanceAttributeResponseBodyChildInstanceAttributesSecondaryCidrBlocks SecondaryCidrBlocks { get; set; }
            public class DescribeCenAttachedChildInstanceAttributeResponseBodyChildInstanceAttributesSecondaryCidrBlocks : TeaModel {
                [NameInMap("secondaryCidrBlock")]
                [Validation(Required=false)]
                public List<string> SecondaryCidrBlock { get; set; }

            }

        }

        [NameInMap("ChildInstanceId")]
        [Validation(Required=false)]
        public string ChildInstanceId { get; set; }

        [NameInMap("ChildInstanceName")]
        [Validation(Required=false)]
        public string ChildInstanceName { get; set; }

        [NameInMap("ChildInstanceOwnerId")]
        [Validation(Required=false)]
        public long? ChildInstanceOwnerId { get; set; }

        [NameInMap("ChildInstanceRegionId")]
        [Validation(Required=false)]
        public string ChildInstanceRegionId { get; set; }

        [NameInMap("ChildInstanceType")]
        [Validation(Required=false)]
        public string ChildInstanceType { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
