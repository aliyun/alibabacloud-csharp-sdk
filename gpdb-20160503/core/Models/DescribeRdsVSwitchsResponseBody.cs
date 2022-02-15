// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeRdsVSwitchsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VSwitches")]
        [Validation(Required=false)]
        public DescribeRdsVSwitchsResponseBodyVSwitches VSwitches { get; set; }
        public class DescribeRdsVSwitchsResponseBodyVSwitches : TeaModel {
            [NameInMap("VSwitch")]
            [Validation(Required=false)]
            public List<DescribeRdsVSwitchsResponseBodyVSwitchesVSwitch> VSwitch { get; set; }
            public class DescribeRdsVSwitchsResponseBodyVSwitchesVSwitch : TeaModel {
                public string AliUid { get; set; }
                public string Bid { get; set; }
                public string CidrBlock { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public bool? IsDefault { get; set; }
                public string IzNo { get; set; }
                public string RegionNo { get; set; }
                public string Status { get; set; }
                public string VSwitchId { get; set; }
                public string VSwitchName { get; set; }
            }
        };

    }

}
