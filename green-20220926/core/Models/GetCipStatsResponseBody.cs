// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetCipStatsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCipStatsResponseBodyData Data { get; set; }
        public class GetCipStatsResponseBodyData : TeaModel {
            [NameInMap("LabelStatChart")]
            [Validation(Required=false)]
            public List<GetCipStatsResponseBodyDataLabelStatChart> LabelStatChart { get; set; }
            public class GetCipStatsResponseBodyDataLabelStatChart : TeaModel {
                [NameInMap("ImageTreeChar")]
                [Validation(Required=false)]
                public List<GetCipStatsResponseBodyDataLabelStatChartImageTreeChar> ImageTreeChar { get; set; }
                public class GetCipStatsResponseBodyDataLabelStatChartImageTreeChar : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>nickNameDetection</para>
                /// </summary>
                [NameInMap("ServiceCode")]
                [Validation(Required=false)]
                public string ServiceCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>117</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

                [NameInMap("TreeChart")]
                [Validation(Required=false)]
                public List<GetCipStatsResponseBodyDataLabelStatChartTreeChart> TreeChart { get; set; }
                public class GetCipStatsResponseBodyDataLabelStatChartTreeChart : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>nickNameDetection</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>99.91</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("VoiceTreeChart")]
                [Validation(Required=false)]
                public List<GetCipStatsResponseBodyDataLabelStatChartVoiceTreeChart> VoiceTreeChart { get; set; }
                public class GetCipStatsResponseBodyDataLabelStatChartVoiceTreeChart : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>nickNameDetection</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>99.91</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("X")]
                [Validation(Required=false)]
                public List<string> X { get; set; }

                [NameInMap("Y")]
                [Validation(Required=false)]
                public List<GetCipStatsResponseBodyDataLabelStatChartY> Y { get; set; }
                public class GetCipStatsResponseBodyDataLabelStatChartY : TeaModel {
                    [NameInMap("Data")]
                    [Validation(Required=false)]
                    public List<long?> Data { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>nickNameDetection</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            [NameInMap("TotalStat")]
            [Validation(Required=false)]
            public Dictionary<string, object> TotalStat { get; set; }

            [NameInMap("Uids")]
            [Validation(Required=false)]
            public List<string> Uids { get; set; }

            [NameInMap("X")]
            [Validation(Required=false)]
            public List<string> X { get; set; }

            [NameInMap("Y")]
            [Validation(Required=false)]
            public List<GetCipStatsResponseBodyDataY> Y { get; set; }
            public class GetCipStatsResponseBodyDataY : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<long?> Data { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>nickNameDetection</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Z")]
            [Validation(Required=false)]
            public List<GetCipStatsResponseBodyDataZ> Z { get; set; }
            public class GetCipStatsResponseBodyDataZ : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<long?> Data { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>nickNameDetection</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
