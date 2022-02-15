// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeRdsVpcsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Vpcs")]
        [Validation(Required=false)]
        public DescribeRdsVpcsResponseBodyVpcs Vpcs { get; set; }
        public class DescribeRdsVpcsResponseBodyVpcs : TeaModel {
            [NameInMap("Vpc")]
            [Validation(Required=false)]
            public List<DescribeRdsVpcsResponseBodyVpcsVpc> Vpc { get; set; }
            public class DescribeRdsVpcsResponseBodyVpcsVpc : TeaModel {
                public string AliUid { get; set; }
                public string Bid { get; set; }
                public string CidrBlock { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public bool? IsDefault { get; set; }
                public string RegionNo { get; set; }
                public string Status { get; set; }
                public List<DescribeRdsVpcsResponseBodyVpcsVpcVSwitchs> VSwitchs { get; set; }
                public class DescribeRdsVpcsResponseBodyVpcsVpcVSwitchs : TeaModel {
                    public string CidrBlock { get; set; }
                    public string GmtCreate { get; set; }
                    public string GmtModified { get; set; }
                    public bool? IsDefault { get; set; }
                    public string IzNo { get; set; }
                    public string Status { get; set; }
                    public string VSwitchId { get; set; }
                    public string VSwitchName { get; set; }
                }
                public string VpcId { get; set; }
                public string VpcName { get; set; }
            }
        };

    }

}
