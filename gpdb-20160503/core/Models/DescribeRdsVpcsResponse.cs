// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeRdsVpcsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Vpcs")]
        [Validation(Required=true)]
        public DescribeRdsVpcsResponseVpcs Vpcs { get; set; }
        public class DescribeRdsVpcsResponseVpcs : TeaModel {
            [NameInMap("Vpc")]
            [Validation(Required=true)]
            public List<DescribeRdsVpcsResponseVpcsVpc> Vpc { get; set; }
            public class DescribeRdsVpcsResponseVpcsVpc : TeaModel {
                public string VpcId { get; set; }
                public string VpcName { get; set; }
                public string Bid { get; set; }
                public string AliUid { get; set; }
                public string RegionNo { get; set; }
                public string CidrBlock { get; set; }
                public bool? IsDefault { get; set; }
                public string Status { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public List<DescribeRdsVpcsResponseVpcsVpcVSwitchs> VSwitchs { get; set; }
                public class DescribeRdsVpcsResponseVpcsVpcVSwitchs : TeaModel {
                    public string VSwitchId { get; set; }
                    public string VSwitchName { get; set; }
                    public string IzNo { get; set; }
                    public string CidrBlock { get; set; }
                    public bool? IsDefault { get; set; }
                    public string Status { get; set; }
                    public string GmtCreate { get; set; }
                    public string GmtModified { get; set; }
                }
            }
        };

    }

}
