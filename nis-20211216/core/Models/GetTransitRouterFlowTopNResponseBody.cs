// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetTransitRouterFlowTopNResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D5E98683-355B-5867-8D3D-A24755F6895B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ranking result of inter-region traffic data.</para>
        /// </summary>
        [NameInMap("TransitRouterFlowTopN")]
        [Validation(Required=false)]
        public List<GetTransitRouterFlowTopNResponseBodyTransitRouterFlowTopN> TransitRouterFlowTopN { get; set; }
        public class GetTransitRouterFlowTopNResponseBodyTransitRouterFlowTopN : TeaModel {
            /// <summary>
            /// <para>The account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>118639953821xxxx</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The ID of the CEN bandwidth plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cenbwp-ia8kw1zjv4hyal****</para>
            /// </summary>
            [NameInMap("BandwithPackageId")]
            [Validation(Required=false)]
            public string BandwithPackageId { get; set; }

            /// <summary>
            /// <para>The total volume of traffic in the specified time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>188</para>
            /// </summary>
            [NameInMap("Bytes")]
            [Validation(Required=false)]
            public double? Bytes { get; set; }

            /// <summary>
            /// <para>The CEN instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen-ia8kw1zjv4hyal****</para>
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// <para>The end of the time range that you queried. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-31T06:40:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The remote IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.216.XX.XX</para>
            /// </summary>
            [NameInMap("OtherIp")]
            [Validation(Required=false)]
            public string OtherIp { get; set; }

            /// <summary>
            /// <para>The remote port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>53470</para>
            /// </summary>
            [NameInMap("OtherPort")]
            [Validation(Required=false)]
            public string OtherPort { get; set; }

            /// <summary>
            /// <para>The remote region where the <b>remote IP address</b> resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ap-southeast-1</para>
            /// </summary>
            [NameInMap("OtherRegion")]
            [Validation(Required=false)]
            public string OtherRegion { get; set; }

            /// <summary>
            /// <para>The total number of packets in the specified time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>88</para>
            /// </summary>
            [NameInMap("Packets")]
            [Validation(Required=false)]
            public double? Packets { get; set; }

            /// <summary>
            /// <para>The protocol number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The beginning of the time range that you queried. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-31T05:40:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The local IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.8.XX.XX</para>
            /// </summary>
            [NameInMap("ThisIp")]
            [Validation(Required=false)]
            public string ThisIp { get; set; }

            /// <summary>
            /// <para>The local port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("ThisPort")]
            [Validation(Required=false)]
            public string ThisPort { get; set; }

            /// <summary>
            /// <para>The local region where the <b>local IP address</b> resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("ThisRegion")]
            [Validation(Required=false)]
            public string ThisRegion { get; set; }

        }

    }

}
