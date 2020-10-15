// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeVSwitchesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("VSwitches")]
        [Validation(Required=true)]
        public DescribeVSwitchesResponseVSwitches VSwitches { get; set; }
        public class DescribeVSwitchesResponseVSwitches : TeaModel {
            [NameInMap("VSwitch")]
            [Validation(Required=true)]
            public List<DescribeVSwitchesResponseVSwitchesVSwitch> VSwitch { get; set; }
            public class DescribeVSwitchesResponseVSwitchesVSwitch : TeaModel {
                public string VSwitchId { get; set; }
                public string VSwitchName { get; set; }
                public string Status { get; set; }
                public string CidrBlock { get; set; }
                public string EnsRegionId { get; set; }
                public long FreeIpCount { get; set; }
                public string CreatedTime { get; set; }
            }
        };

    }

}
