// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeInterAuthStatisticsGlobalOverviewResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeInterAuthStatisticsGlobalOverviewResponseBodyData Data { get; set; }
        public class DescribeInterAuthStatisticsGlobalOverviewResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>72</para>
            /// </summary>
            [NameInMap("AvgSuccessRatio")]
            [Validation(Required=false)]
            public long? AvgSuccessRatio { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>75</para>
            /// </summary>
            [NameInMap("AvgSuccessRatioTrend")]
            [Validation(Required=false)]
            public long? AvgSuccessRatioTrend { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>18349</para>
            /// </summary>
            [NameInMap("TotalResolveCount")]
            [Validation(Required=false)]
            public long? TotalResolveCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2341</para>
            /// </summary>
            [NameInMap("TotalResolveCountTrend")]
            [Validation(Required=false)]
            public long? TotalResolveCountTrend { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>389DFFA3-77A5-4A9E-BF3D-147C6F98A5BA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
