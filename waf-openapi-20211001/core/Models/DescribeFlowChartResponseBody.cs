// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeFlowChartResponseBody : TeaModel {
        /// <summary>
        /// The traffic statistics.
        /// </summary>
        [NameInMap("FlowChart")]
        [Validation(Required=false)]
        public List<DescribeFlowChartResponseBodyFlowChart> FlowChart { get; set; }
        public class DescribeFlowChartResponseBodyFlowChart : TeaModel {
            /// <summary>
            /// The number of requests that are blocked by custom access control list (ACL) rules.
            /// </summary>
            [NameInMap("AclCustomBlockSum")]
            [Validation(Required=false)]
            public long? AclCustomBlockSum { get; set; }

            /// <summary>
            /// The number of requests that are monitored by custom ACL rules.
            /// </summary>
            [NameInMap("AclCustomReportsSum")]
            [Validation(Required=false)]
            public long? AclCustomReportsSum { get; set; }

            /// <summary>
            /// The number of requests that are blocked by scan protection rules.
            /// </summary>
            [NameInMap("AntiScanBlockSum")]
            [Validation(Required=false)]
            public long? AntiScanBlockSum { get; set; }

            /// <summary>
            /// The number of requests that are blocked by bot management rules.
            /// </summary>
            [NameInMap("AntibotBlockSum")]
            [Validation(Required=false)]
            public long? AntibotBlockSum { get; set; }

            /// <summary>
            /// The number of requests that are monitored by bot management rules.
            /// </summary>
            [NameInMap("AntibotReportSum")]
            [Validation(Required=false)]
            public string AntibotReportSum { get; set; }

            /// <summary>
            /// The number of requests that are monitored by scan protection rules.
            /// </summary>
            [NameInMap("AntiscanReportsSum")]
            [Validation(Required=false)]
            public long? AntiscanReportsSum { get; set; }

            /// <summary>
            /// The number of requests that are blocked by the IP address blacklist.
            /// </summary>
            [NameInMap("BlacklistBlockSum")]
            [Validation(Required=false)]
            public string BlacklistBlockSum { get; set; }

            /// <summary>
            /// The number of requests that are monitored by the IP address blacklist.
            /// </summary>
            [NameInMap("BlacklistReportsSum")]
            [Validation(Required=false)]
            public long? BlacklistReportsSum { get; set; }

            /// <summary>
            /// The number of requests that are blocked by custom HTTP flood protection rules.
            /// </summary>
            [NameInMap("CcCustomBlockSum")]
            [Validation(Required=false)]
            public long? CcCustomBlockSum { get; set; }

            /// <summary>
            /// The number of requests that are monitored by custom HTTP flood protection rules.
            /// </summary>
            [NameInMap("CcCustomReportsSum")]
            [Validation(Required=false)]
            public long? CcCustomReportsSum { get; set; }

            /// <summary>
            /// The number of requests that are blocked by HTTP flood protection rules created by the system.
            /// </summary>
            [NameInMap("CcSystemBlocksSum")]
            [Validation(Required=false)]
            public long? CcSystemBlocksSum { get; set; }

            /// <summary>
            /// The number of requests that are monitored by HTTP flood protection rules created by the system.
            /// </summary>
            [NameInMap("CcSystemReportsSum")]
            [Validation(Required=false)]
            public long? CcSystemReportsSum { get; set; }

            /// <summary>
            /// The total number of requests.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// The total number of requests that are redirected to the WAF instance.
            /// </summary>
            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public long? InBytes { get; set; }

            /// <summary>
            /// The serial number of the time interval. The serial numbers are arranged in chronological order.
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            /// <summary>
            /// The peak traffic.
            /// </summary>
            [NameInMap("MaxPv")]
            [Validation(Required=false)]
            public long? MaxPv { get; set; }

            /// <summary>
            /// The total number of requests that are forwarded by the WAF instance.
            /// </summary>
            [NameInMap("OutBytes")]
            [Validation(Required=false)]
            public long? OutBytes { get; set; }

            /// <summary>
            /// The number of requests that are blocked by rate limiting rules.
            /// </summary>
            [NameInMap("RatelimitBlockSum")]
            [Validation(Required=false)]
            public long? RatelimitBlockSum { get; set; }

            /// <summary>
            /// The number of requests that are monitored by rate limiting rules.
            /// </summary>
            [NameInMap("RatelimitReportSum")]
            [Validation(Required=false)]
            public long? RatelimitReportSum { get; set; }

            /// <summary>
            /// The number of requests that are blocked by region blacklist rules.
            /// </summary>
            [NameInMap("RegionBlockBlocksSum")]
            [Validation(Required=false)]
            public long? RegionBlockBlocksSum { get; set; }

            /// <summary>
            /// The number of requests that are monitored by region blacklist rules.
            /// </summary>
            [NameInMap("RegionBlockReportsSum")]
            [Validation(Required=false)]
            public long? RegionBlockReportsSum { get; set; }

            /// <summary>
            /// The total number of bot requests.
            /// </summary>
            [NameInMap("RobotCount")]
            [Validation(Required=false)]
            public long? RobotCount { get; set; }

            /// <summary>
            /// The number of requests that are blocked by basic protection rules.
            /// </summary>
            [NameInMap("WafBlockSum")]
            [Validation(Required=false)]
            public long? WafBlockSum { get; set; }

            /// <summary>
            /// The number of requests that are monitored by basic protection rules.
            /// </summary>
            [NameInMap("WafReportSum")]
            [Validation(Required=false)]
            public string WafReportSum { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
