// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeHaVipsResponseBody : TeaModel {
        /// <summary>
        /// The details about the HAVIP.
        /// </summary>
        [NameInMap("HaVips")]
        [Validation(Required=false)]
        public DescribeHaVipsResponseBodyHaVips HaVips { get; set; }
        public class DescribeHaVipsResponseBodyHaVips : TeaModel {
            [NameInMap("HaVip")]
            [Validation(Required=false)]
            public List<DescribeHaVipsResponseBodyHaVipsHaVip> HaVip { get; set; }
            public class DescribeHaVipsResponseBodyHaVipsHaVip : TeaModel {
                /// <summary>
                /// The elastic IP address (EIP) associated with the HAVIP.
                /// </summary>
                [NameInMap("AssociatedEipAddresses")]
                [Validation(Required=false)]
                public DescribeHaVipsResponseBodyHaVipsHaVipAssociatedEipAddresses AssociatedEipAddresses { get; set; }
                public class DescribeHaVipsResponseBodyHaVipsHaVipAssociatedEipAddresses : TeaModel {
                    [NameInMap("associatedEipAddresse")]
                    [Validation(Required=false)]
                    public List<string> AssociatedEipAddresse { get; set; }

                }

                /// <summary>
                /// The type of the instance with which the HAVIP is associated. Valid values:
                /// 
                /// *   **EcsInstance**: an ECS instance
                /// *   **NetworkInterface**: an ENI
                /// </summary>
                [NameInMap("AssociatedInstanceType")]
                [Validation(Required=false)]
                public string AssociatedInstanceType { get; set; }

                /// <summary>
                /// The ID of the instance with which the HAVIP is associated.
                /// </summary>
                [NameInMap("AssociatedInstances")]
                [Validation(Required=false)]
                public DescribeHaVipsResponseBodyHaVipsHaVipAssociatedInstances AssociatedInstances { get; set; }
                public class DescribeHaVipsResponseBodyHaVipsHaVipAssociatedInstances : TeaModel {
                    [NameInMap("associatedInstance")]
                    [Validation(Required=false)]
                    public List<string> AssociatedInstance { get; set; }

                }

                /// <summary>
                /// The parameter is invalid. No value is returned.
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// The time when the HAVIP was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The description of the HAVIP.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the HAVIP.
                /// </summary>
                [NameInMap("HaVipId")]
                [Validation(Required=false)]
                public string HaVipId { get; set; }

                /// <summary>
                /// The private IP address of the HAVIP.
                /// </summary>
                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                /// <summary>
                /// The ID of the active instance that is associated with the HAVIP.
                /// </summary>
                [NameInMap("MasterInstanceId")]
                [Validation(Required=false)]
                public string MasterInstanceId { get; set; }

                /// <summary>
                /// The name of the HAVIP.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the region to which the HAVIP belongs.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the resource group to which the HAVIP belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The status of the HAVIP. Valid values:
                /// 
                /// *   **Creating**
                /// *   **Available**
                /// *   **Deleting**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The list of tags.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeHaVipsResponseBodyHaVipsHaVipTags Tags { get; set; }
                public class DescribeHaVipsResponseBodyHaVipsHaVipTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeHaVipsResponseBodyHaVipsHaVipTagsTag> Tag { get; set; }
                    public class DescribeHaVipsResponseBodyHaVipsHaVipTagsTag : TeaModel {
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

                }

                /// <summary>
                /// The ID of the vSwitch to which the HAVIP belongs.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The ID of the VPC to which the HAVIP belongs.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// The number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        public int? TotalCount { get; set; }

    }

}
