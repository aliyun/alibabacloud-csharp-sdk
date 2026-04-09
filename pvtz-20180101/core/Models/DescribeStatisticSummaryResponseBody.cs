// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeStatisticSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A73F3BD0-B1A8-42A9-A9B6-689BBABC4891</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2254</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("VpcRequestTops")]
        [Validation(Required=false)]
        public DescribeStatisticSummaryResponseBodyVpcRequestTops VpcRequestTops { get; set; }
        public class DescribeStatisticSummaryResponseBodyVpcRequestTops : TeaModel {
            [NameInMap("VpcRequestTop")]
            [Validation(Required=false)]
            public List<DescribeStatisticSummaryResponseBodyVpcRequestTopsVpcRequestTop> VpcRequestTop { get; set; }
            public class DescribeStatisticSummaryResponseBodyVpcRequestTopsVpcRequestTop : TeaModel {
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("RegionName")]
                [Validation(Required=false)]
                public string RegionName { get; set; }

                [NameInMap("RequestCount")]
                [Validation(Required=false)]
                public long? RequestCount { get; set; }

                [NameInMap("TunnelId")]
                [Validation(Required=false)]
                public string TunnelId { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("VpcType")]
                [Validation(Required=false)]
                public string VpcType { get; set; }

            }

        }

        [NameInMap("ZoneRequestTops")]
        [Validation(Required=false)]
        public DescribeStatisticSummaryResponseBodyZoneRequestTops ZoneRequestTops { get; set; }
        public class DescribeStatisticSummaryResponseBodyZoneRequestTops : TeaModel {
            [NameInMap("ZoneRequestTop")]
            [Validation(Required=false)]
            public List<DescribeStatisticSummaryResponseBodyZoneRequestTopsZoneRequestTop> ZoneRequestTop { get; set; }
            public class DescribeStatisticSummaryResponseBodyZoneRequestTopsZoneRequestTop : TeaModel {
                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                [NameInMap("RequestCount")]
                [Validation(Required=false)]
                public long? RequestCount { get; set; }

                [NameInMap("ZoneName")]
                [Validation(Required=false)]
                public string ZoneName { get; set; }

            }

        }

    }

}
