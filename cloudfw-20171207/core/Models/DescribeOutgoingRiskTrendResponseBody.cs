// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeOutgoingRiskTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of returned data.</para>
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeOutgoingRiskTrendResponseBodyDataList> DataList { get; set; }
        public class DescribeOutgoingRiskTrendResponseBodyDataList : TeaModel {
            /// <summary>
            /// <para>The number of threat domain names.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("RiskDomain")]
            [Validation(Required=false)]
            public int? RiskDomain { get; set; }

            /// <summary>
            /// <para>The number of threat IP addresses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("RiskIp")]
            [Validation(Required=false)]
            public int? RiskIp { get; set; }

            /// <summary>
            /// <para>The timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1659405600</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

        }

        /// <summary>
        /// <para>The time interval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CA8D98E-A71B-5856-A658-3E8B3152E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of threat domain names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalRiskDomain")]
        [Validation(Required=false)]
        public int? TotalRiskDomain { get; set; }

        /// <summary>
        /// <para>The total number of threat IP addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalRiskIp")]
        [Validation(Required=false)]
        public int? TotalRiskIp { get; set; }

    }

}
