// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeStatisticSummaryResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ZoneRequestTops")]
        [Validation(Required=false)]
        public DescribeStatisticSummaryResponseBodyZoneRequestTops ZoneRequestTops { get; set; }
        public class DescribeStatisticSummaryResponseBodyZoneRequestTops : TeaModel {
            [NameInMap("ZoneRequestTop")]
            [Validation(Required=false)]
            public List<DescribeStatisticSummaryResponseBodyZoneRequestTopsZoneRequestTop> ZoneRequestTop { get; set; }
            public class DescribeStatisticSummaryResponseBodyZoneRequestTopsZoneRequestTop : TeaModel {
                public long? RequestCount { get; set; }
                public string ZoneName { get; set; }
                public string BizType { get; set; }
            }
        };

        [NameInMap("VpcRequestTops")]
        [Validation(Required=false)]
        public DescribeStatisticSummaryResponseBodyVpcRequestTops VpcRequestTops { get; set; }
        public class DescribeStatisticSummaryResponseBodyVpcRequestTops : TeaModel {
            [NameInMap("VpcRequestTop")]
            [Validation(Required=false)]
            public List<DescribeStatisticSummaryResponseBodyVpcRequestTopsVpcRequestTop> VpcRequestTop { get; set; }
            public class DescribeStatisticSummaryResponseBodyVpcRequestTopsVpcRequestTop : TeaModel {
                public string VpcId { get; set; }
                public string RegionName { get; set; }
                public string TunnelId { get; set; }
                public long? RequestCount { get; set; }
                public string RegionId { get; set; }
            }
        };

    }

}
