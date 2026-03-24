// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeFlowChartResponseBody : TeaModel {
        /// <summary>
        /// <para>The traffic statistics.</para>
        /// </summary>
        [NameInMap("FlowChart")]
        [Validation(Required=false)]
        public List<DescribeFlowChartResponseBodyFlowChart> FlowChart { get; set; }
        public class DescribeFlowChartResponseBodyFlowChart : TeaModel {
            /// <summary>
            /// <para>The number of requests that are blocked by custom access control list (ACL) rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AclCustomBlockSum")]
            [Validation(Required=false)]
            public long? AclCustomBlockSum { get; set; }

            /// <summary>
            /// <para>The number of requests that are monitored by custom ACL rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AclCustomReportsSum")]
            [Validation(Required=false)]
            public long? AclCustomReportsSum { get; set; }

            /// <summary>
            /// <para>The number of requests that are blocked by scan protection rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AntiScanBlockSum")]
            [Validation(Required=false)]
            public long? AntiScanBlockSum { get; set; }

            /// <summary>
            /// <para>The number of requests that are blocked by bot management rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AntibotBlockSum")]
            [Validation(Required=false)]
            public long? AntibotBlockSum { get; set; }

            /// <summary>
            /// <para>The number of requests that are monitored by bot management rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AntibotReportSum")]
            [Validation(Required=false)]
            public string AntibotReportSum { get; set; }

            /// <summary>
            /// <para>The number of requests that are monitored by scan protection rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AntiscanReportsSum")]
            [Validation(Required=false)]
            public long? AntiscanReportsSum { get; set; }

            /// <summary>
            /// <para>The number of requests that are blocked by the IP address blacklist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BlacklistBlockSum")]
            [Validation(Required=false)]
            public string BlacklistBlockSum { get; set; }

            /// <summary>
            /// <para>The number of requests that are monitored by the IP address blacklist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BlacklistReportsSum")]
            [Validation(Required=false)]
            public long? BlacklistReportsSum { get; set; }

            /// <summary>
            /// <para>The number of requests that are blocked by custom HTTP flood protection rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CcCustomBlockSum")]
            [Validation(Required=false)]
            public long? CcCustomBlockSum { get; set; }

            /// <summary>
            /// <para>The number of requests that are monitored by custom HTTP flood protection rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CcCustomReportsSum")]
            [Validation(Required=false)]
            public long? CcCustomReportsSum { get; set; }

            /// <summary>
            /// <para>The number of requests that are blocked by system HTTP flood protection rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CcSystemBlocksSum")]
            [Validation(Required=false)]
            public long? CcSystemBlocksSum { get; set; }

            /// <summary>
            /// <para>The number of requests that are monitored by system HTTP flood protection rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CcSystemReportsSum")]
            [Validation(Required=false)]
            public long? CcSystemReportsSum { get; set; }

            /// <summary>
            /// <para>The total number of requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2932</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The total volume of inbound traffic. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>121645464</para>
            /// </summary>
            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public long? InBytes { get; set; }

            /// <summary>
            /// <para>The time sequence number, sorted in chronological order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            /// <summary>
            /// <para>The peak number of requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2932</para>
            /// </summary>
            [NameInMap("MaxPv")]
            [Validation(Required=false)]
            public long? MaxPv { get; set; }

            /// <summary>
            /// <para>The total volume of outbound traffic. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1200540464</para>
            /// </summary>
            [NameInMap("OutBytes")]
            [Validation(Required=false)]
            public long? OutBytes { get; set; }

            /// <summary>
            /// <para>The number of requests that are blocked by peak traffic throttling rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RatelimitBlockSum")]
            [Validation(Required=false)]
            public long? RatelimitBlockSum { get; set; }

            /// <summary>
            /// <para>The number of requests that are monitored by peak traffic throttling rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RatelimitReportSum")]
            [Validation(Required=false)]
            public long? RatelimitReportSum { get; set; }

            /// <summary>
            /// <para>The number of requests that are blocked by Location Blacklist rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RegionBlockBlocksSum")]
            [Validation(Required=false)]
            public long? RegionBlockBlocksSum { get; set; }

            /// <summary>
            /// <para>The number of requests that are monitored by Location Blacklist rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RegionBlockReportsSum")]
            [Validation(Required=false)]
            public long? RegionBlockReportsSum { get; set; }

            /// <summary>
            /// <para>The total number of requests from bots.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1110</para>
            /// </summary>
            [NameInMap("RobotCount")]
            [Validation(Required=false)]
            public long? RobotCount { get; set; }

            /// <summary>
            /// <para>The number of requests that are blocked by basic protection rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("WafBlockSum")]
            [Validation(Required=false)]
            public long? WafBlockSum { get; set; }

            /// <summary>
            /// <para>The number of requests that are monitored by basic protection rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("WafReportSum")]
            [Validation(Required=false)]
            public string WafReportSum { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BFA71416-670E-585D-AAE6-E7BBEE248FAB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
