// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeIpTrafficResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("AvgInBps")]
        [Validation(Required=false)]
        public long? AvgInBps { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("AvgOutBps")]
        [Validation(Required=false)]
        public long? AvgOutBps { get; set; }

        [NameInMap("IpTrafficPoints")]
        [Validation(Required=false)]
        public List<DescribeIpTrafficResponseBodyIpTrafficPoints> IpTrafficPoints { get; set; }
        public class DescribeIpTrafficResponseBodyIpTrafficPoints : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ActConns")]
            [Validation(Required=false)]
            public int? ActConns { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Cps")]
            [Validation(Required=false)]
            public int? Cps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("InactConns")]
            [Validation(Required=false)]
            public int? InactConns { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("MaxInbps")]
            [Validation(Required=false)]
            public long? MaxInbps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("MaxOutbps")]
            [Validation(Required=false)]
            public long? MaxOutbps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1536734112</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("MaxInBps")]
        [Validation(Required=false)]
        public long? MaxInBps { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("MaxOutBps")]
        [Validation(Required=false)]
        public long? MaxOutBps { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
