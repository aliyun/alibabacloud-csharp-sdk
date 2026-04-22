// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribePvtzStatisticsGlobalOverviewResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribePvtzStatisticsGlobalOverviewResponseBodyData Data { get; set; }
        public class DescribePvtzStatisticsGlobalOverviewResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("AvgResolveLatency")]
            [Validation(Required=false)]
            public long? AvgResolveLatency { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>-2</para>
            /// </summary>
            [NameInMap("AvgResolveLatencyTrend")]
            [Validation(Required=false)]
            public long? AvgResolveLatencyTrend { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>98</para>
            /// </summary>
            [NameInMap("AvgSuccessRatio")]
            [Validation(Required=false)]
            public long? AvgSuccessRatio { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AvgSuccessRatioTrend")]
            [Validation(Required=false)]
            public long? AvgSuccessRatioTrend { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("TotalResolveCount")]
            [Validation(Required=false)]
            public long? TotalResolveCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TotalResolveCountTrend")]
            [Validation(Required=false)]
            public long? TotalResolveCountTrend { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B7AD377-7E86-44A8-B9A8-53E8666E72FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
