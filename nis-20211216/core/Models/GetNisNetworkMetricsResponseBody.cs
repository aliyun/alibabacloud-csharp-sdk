// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetNisNetworkMetricsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetNisNetworkMetricsResponseBodyData Data { get; set; }
        public class GetNisNetworkMetricsResponseBodyData : TeaModel {
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public List<GetNisNetworkMetricsResponseBodyDataMetrics> Metrics { get; set; }
            public class GetNisNetworkMetricsResponseBodyDataMetrics : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1690684091100</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public long? TimeStamp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>88</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public double? Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Bits/Second</para>
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D5E98683-355B-5867-8D3D-A24755F6895B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
