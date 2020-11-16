// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeRdsVSwitchsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("VSwitches")]
        [Validation(Required=true)]
        public DescribeRdsVSwitchsResponseVSwitches VSwitches { get; set; }
        public class DescribeRdsVSwitchsResponseVSwitches : TeaModel {
            [NameInMap("VSwitch")]
            [Validation(Required=true)]
            public List<DescribeRdsVSwitchsResponseVSwitchesVSwitch> VSwitch { get; set; }
            public class DescribeRdsVSwitchsResponseVSwitchesVSwitch : TeaModel {
                public string VSwitchId { get; set; }
                public string VSwitchName { get; set; }
                public string IzNo { get; set; }
                public string Bid { get; set; }
                public string AliUid { get; set; }
                public string RegionNo { get; set; }
                public string CidrBlock { get; set; }
                public bool? IsDefault { get; set; }
                public string Status { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
            }
        };

    }

}
