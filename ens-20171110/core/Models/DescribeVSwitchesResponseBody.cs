// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeVSwitchesResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("VSwitches")]
        [Validation(Required=false)]
        public DescribeVSwitchesResponseBodyVSwitches VSwitches { get; set; }
        public class DescribeVSwitchesResponseBodyVSwitches : TeaModel {
            [NameInMap("VSwitch")]
            [Validation(Required=false)]
            public List<DescribeVSwitchesResponseBodyVSwitchesVSwitch> VSwitch { get; set; }
            public class DescribeVSwitchesResponseBodyVSwitchesVSwitch : TeaModel {
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                [NameInMap("FreeIpCount")]
                [Validation(Required=false)]
                public long? FreeIpCount { get; set; }

                [NameInMap("NetworkId")]
                [Validation(Required=false)]
                public string NetworkId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("VSwitchName")]
                [Validation(Required=false)]
                public string VSwitchName { get; set; }

            }

        }

    }

}
