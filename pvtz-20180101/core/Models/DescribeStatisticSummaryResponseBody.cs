// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeStatisticSummaryResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// The top 3 virtual private clouds (VPCs) that initiate the largest number of DNS requests.
        /// </summary>
        [NameInMap("VpcRequestTops")]
        [Validation(Required=false)]
        public DescribeStatisticSummaryResponseBodyVpcRequestTops VpcRequestTops { get; set; }
        public class DescribeStatisticSummaryResponseBodyVpcRequestTops : TeaModel {
            [NameInMap("VpcRequestTop")]
            [Validation(Required=false)]
            public List<DescribeStatisticSummaryResponseBodyVpcRequestTopsVpcRequestTop> VpcRequestTop { get; set; }
            public class DescribeStatisticSummaryResponseBodyVpcRequestTopsVpcRequestTop : TeaModel {
                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The name of the region.
                /// </summary>
                [NameInMap("RegionName")]
                [Validation(Required=false)]
                public string RegionName { get; set; }

                /// <summary>
                /// The number of DNS requests.
                /// </summary>
                [NameInMap("RequestCount")]
                [Validation(Required=false)]
                public long? RequestCount { get; set; }

                /// <summary>
                /// The tunnel ID.
                /// </summary>
                [NameInMap("TunnelId")]
                [Validation(Required=false)]
                public string TunnelId { get; set; }

                /// <summary>
                /// The VPC ID.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The type of the VPC. Valid values:
                /// 
                /// *   STANDARD: standard VPC
                /// *   EDS: Elastic Desktop Service (EDS) workspace VPC
                /// </summary>
                [NameInMap("VpcType")]
                [Validation(Required=false)]
                public string VpcType { get; set; }

            }

        }

        /// <summary>
        /// The top 3 zones with the largest number of DNS requests.
        /// </summary>
        [NameInMap("ZoneRequestTops")]
        [Validation(Required=false)]
        public DescribeStatisticSummaryResponseBodyZoneRequestTops ZoneRequestTops { get; set; }
        public class DescribeStatisticSummaryResponseBodyZoneRequestTops : TeaModel {
            [NameInMap("ZoneRequestTop")]
            [Validation(Required=false)]
            public List<DescribeStatisticSummaryResponseBodyZoneRequestTopsZoneRequestTop> ZoneRequestTop { get; set; }
            public class DescribeStatisticSummaryResponseBodyZoneRequestTopsZoneRequestTop : TeaModel {
                /// <summary>
                /// The business type. Valid values:
                /// 
                /// *   AUTH_ZONE: authoritative zone
                /// *   RESOLVER_RULE: forwarding rule
                /// </summary>
                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// The number of DNS requests.
                /// </summary>
                [NameInMap("RequestCount")]
                [Validation(Required=false)]
                public long? RequestCount { get; set; }

                /// <summary>
                /// The name of the zone.
                /// </summary>
                [NameInMap("ZoneName")]
                [Validation(Required=false)]
                public string ZoneName { get; set; }

            }

        }

    }

}
