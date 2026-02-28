// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeHaVipsResponseBody : TeaModel {
        [NameInMap("HaVips")]
        [Validation(Required=false)]
        public DescribeHaVipsResponseBodyHaVips HaVips { get; set; }
        public class DescribeHaVipsResponseBodyHaVips : TeaModel {
            [NameInMap("HaVip")]
            [Validation(Required=false)]
            public List<DescribeHaVipsResponseBodyHaVipsHaVip> HaVip { get; set; }
            public class DescribeHaVipsResponseBodyHaVipsHaVip : TeaModel {
                [NameInMap("AssociatedEipAddresses")]
                [Validation(Required=false)]
                public DescribeHaVipsResponseBodyHaVipsHaVipAssociatedEipAddresses AssociatedEipAddresses { get; set; }
                public class DescribeHaVipsResponseBodyHaVipsHaVipAssociatedEipAddresses : TeaModel {
                    [NameInMap("associatedEipAddresse")]
                    [Validation(Required=false)]
                    public List<string> AssociatedEipAddresse { get; set; }

                }

                [NameInMap("AssociatedInstanceType")]
                [Validation(Required=false)]
                public string AssociatedInstanceType { get; set; }

                [NameInMap("AssociatedInstances")]
                [Validation(Required=false)]
                public DescribeHaVipsResponseBodyHaVipsHaVipAssociatedInstances AssociatedInstances { get; set; }
                public class DescribeHaVipsResponseBodyHaVipsHaVipAssociatedInstances : TeaModel {
                    [NameInMap("associatedInstance")]
                    [Validation(Required=false)]
                    public List<string> AssociatedInstance { get; set; }

                }

                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("HaVipId")]
                [Validation(Required=false)]
                public string HaVipId { get; set; }

                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                [NameInMap("MasterInstanceId")]
                [Validation(Required=false)]
                public string MasterInstanceId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeHaVipsResponseBodyHaVipsHaVipTags Tags { get; set; }
                public class DescribeHaVipsResponseBodyHaVipsHaVipTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeHaVipsResponseBodyHaVipsHaVipTagsTag> Tag { get; set; }
                    public class DescribeHaVipsResponseBodyHaVipsHaVipTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33E480C5-B46F-4CA5-B6FD-D77C746E86AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
