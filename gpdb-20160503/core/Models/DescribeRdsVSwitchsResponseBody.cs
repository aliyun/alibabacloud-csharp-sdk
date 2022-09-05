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
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public string AliUid { get; set; }

                [NameInMap("Bid")]
                [Validation(Required=false)]
                public string Bid { get; set; }

                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                [NameInMap("IzNo")]
                [Validation(Required=false)]
                public string IzNo { get; set; }

                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

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
