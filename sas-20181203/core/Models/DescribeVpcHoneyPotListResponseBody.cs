// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVpcHoneyPotListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeVpcHoneyPotListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeVpcHoneyPotListResponseBodyPageInfo : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }
        };

        [NameInMap("VpcHoneyPotDTOList")]
        [Validation(Required=false)]
        public List<DescribeVpcHoneyPotListResponseBodyVpcHoneyPotDTOList> VpcHoneyPotDTOList { get; set; }
        public class DescribeVpcHoneyPotListResponseBodyVpcHoneyPotDTOList : TeaModel {
            [NameInMap("VpcName")]
            [Validation(Required=false)]
            public string VpcName { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("HoneyPotEniInstanceId")]
            [Validation(Required=false)]
            public string HoneyPotEniInstanceId { get; set; }

            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            [NameInMap("VpcStatus")]
            [Validation(Required=false)]
            public string VpcStatus { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("HoneyPotVpcSwitchId")]
            [Validation(Required=false)]
            public string HoneyPotVpcSwitchId { get; set; }

            [NameInMap("HoneyPotExistence")]
            [Validation(Required=false)]
            public bool? HoneyPotExistence { get; set; }

            [NameInMap("VpcRegionId")]
            [Validation(Required=false)]
            public string VpcRegionId { get; set; }

            [NameInMap("HoneyPotEcsInstanceStatus")]
            [Validation(Required=false)]
            public string HoneyPotEcsInstanceStatus { get; set; }

            [NameInMap("HoneyPotInstanceStatus")]
            [Validation(Required=false)]
            public string HoneyPotInstanceStatus { get; set; }

            [NameInMap("VpcSwitchIdList")]
            [Validation(Required=false)]
            public List<DescribeVpcHoneyPotListResponseBodyVpcHoneyPotDTOListVpcSwitchIdList> VpcSwitchIdList { get; set; }
            public class DescribeVpcHoneyPotListResponseBodyVpcHoneyPotDTOListVpcSwitchIdList : TeaModel {
                [NameInMap("VpcSwitchName")]
                [Validation(Required=false)]
                public string VpcSwitchName { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                [NameInMap("VpcSwitchId")]
                [Validation(Required=false)]
                public string VpcSwitchId { get; set; }

            }

        }

    }

}
