// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeHaVipsResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("HaVips")]
        [Validation(Required=false)]
        public DescribeHaVipsResponseBodyHaVips HaVips { get; set; }
        public class DescribeHaVipsResponseBodyHaVips : TeaModel {
            [NameInMap("HaVip")]
            [Validation(Required=false)]
            public List<DescribeHaVipsResponseBodyHaVipsHaVip> HaVip { get; set; }
            public class DescribeHaVipsResponseBodyHaVipsHaVip : TeaModel {
                public string Status { get; set; }
                public string VpcId { get; set; }
                public string VSwitchId { get; set; }
                public string IpAddress { get; set; }
                public string Description { get; set; }
                public string HaVipId { get; set; }
                public string CreateTime { get; set; }
                public string MasterInstanceId { get; set; }
                public string RegionId { get; set; }
                public DescribeHaVipsResponseBodyHaVipsHaVipAssociatedEipAddresses AssociatedEipAddresses { get; set; }
                public class DescribeHaVipsResponseBodyHaVipsHaVipAssociatedEipAddresses : TeaModel {
                    [NameInMap("associatedEipAddresse")]
                    [Validation(Required=false)]
                    public List<string> AssociatedEipAddresse { get; set; }

                }
                public DescribeHaVipsResponseBodyHaVipsHaVipAssociatedInstances AssociatedInstances { get; set; }
                public class DescribeHaVipsResponseBodyHaVipsHaVipAssociatedInstances : TeaModel {
                    [NameInMap("associatedInstance")]
                    [Validation(Required=false)]
                    public List<string> AssociatedInstance { get; set; }

                }
            }
        };

    }

}
