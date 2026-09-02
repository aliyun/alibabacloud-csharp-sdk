// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetAiAppStatsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAiAppStatsResponseBodyData Data { get; set; }
        public class GetAiAppStatsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The label usage chart.</para>
            /// </summary>
            [NameInMap("LabelStatChart")]
            [Validation(Required=false)]
            public List<GetAiAppStatsResponseBodyDataLabelStatChart> LabelStatChart { get; set; }
            public class GetAiAppStatsResponseBodyDataLabelStatChart : TeaModel {
                /// <summary>
                /// <para>The tree chart.</para>
                /// </summary>
                [NameInMap("TreeChart")]
                [Validation(Required=false)]
                public List<GetAiAppStatsResponseBodyDataLabelStatChartTreeChart> TreeChart { get; set; }
                public class GetAiAppStatsResponseBodyDataLabelStatChartTreeChart : TeaModel {
                    /// <summary>
                    /// <para>The label description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>desc</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The label.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The score.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>99.91</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The total count categorized statistics.</para>
            /// </summary>
            [NameInMap("TotalStat")]
            [Validation(Required=false)]
            public Dictionary<string, DataTotalStatValue> TotalStat { get; set; }

            /// <summary>
            /// <para>The X value of the coordinate point.</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public List<string> X { get; set; }

            /// <summary>
            /// <para>The Y value of the coordinate point.</para>
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public List<GetAiAppStatsResponseBodyDataY> Y { get; set; }
            public class GetAiAppStatsResponseBodyDataY : TeaModel {
                /// <summary>
                /// <para>The returned data.</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<long?> Data { get; set; }

                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID assigned by the backend to uniquely identify a request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
