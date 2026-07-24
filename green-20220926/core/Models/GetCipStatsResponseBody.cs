// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetCipStatsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code, which is the same as the HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCipStatsResponseBodyData Data { get; set; }
        public class GetCipStatsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The label usage chart.</para>
            /// </summary>
            [NameInMap("LabelStatChart")]
            [Validation(Required=false)]
            public List<GetCipStatsResponseBodyDataLabelStatChart> LabelStatChart { get; set; }
            public class GetCipStatsResponseBodyDataLabelStatChart : TeaModel {
                /// <summary>
                /// <para>The image label statistics.</para>
                /// </summary>
                [NameInMap("ImageTreeChar")]
                [Validation(Required=false)]
                public List<GetCipStatsResponseBodyDataLabelStatChartImageTreeChar> ImageTreeChar { get; set; }
                public class GetCipStatsResponseBodyDataLabelStatChartImageTreeChar : TeaModel {
                    /// <summary>
                    /// <para>The description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>未检测出风险</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The label.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>nonLabel</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The label proportion.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0274</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The service code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nickNameDetection</para>
                /// </summary>
                [NameInMap("ServiceCode")]
                [Validation(Required=false)]
                public string ServiceCode { get; set; }

                /// <summary>
                /// <para>The text label statistics.</para>
                /// </summary>
                [NameInMap("TextTreeChart")]
                [Validation(Required=false)]
                public List<GetCipStatsResponseBodyDataLabelStatChartTextTreeChart> TextTreeChart { get; set; }
                public class GetCipStatsResponseBodyDataLabelStatChartTextTreeChart : TeaModel {
                    /// <summary>
                    /// <para>The description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>未检测出风险</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The label.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>nonLabel</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The proportion.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0274</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The total count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>117</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

                /// <summary>
                /// <para>The tree view.</para>
                /// </summary>
                [NameInMap("TreeChart")]
                [Validation(Required=false)]
                public List<GetCipStatsResponseBodyDataLabelStatChartTreeChart> TreeChart { get; set; }
                public class GetCipStatsResponseBodyDataLabelStatChartTreeChart : TeaModel {
                    /// <summary>
                    /// <para>The label description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>疑似政治人物</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The label.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>nickNameDetection</para>
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

                /// <summary>
                /// <para>The audio tree view.</para>
                /// </summary>
                [NameInMap("VoiceTreeChart")]
                [Validation(Required=false)]
                public List<GetCipStatsResponseBodyDataLabelStatChartVoiceTreeChart> VoiceTreeChart { get; set; }
                public class GetCipStatsResponseBodyDataLabelStatChartVoiceTreeChart : TeaModel {
                    /// <summary>
                    /// <para>The label description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>疑似特定歌曲</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The label.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>nickNameDetection</para>
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
                public List<GetCipStatsResponseBodyDataLabelStatChartY> Y { get; set; }
                public class GetCipStatsResponseBodyDataLabelStatChartY : TeaModel {
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
                    /// <para>nickNameDetection</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// <para>The total count by category.</para>
            /// </summary>
            [NameInMap("TotalStat")]
            [Validation(Required=false)]
            public Dictionary<string, Dictionary<string, object>> TotalStat { get; set; }

            /// <summary>
            /// <para>The list of UIDs.</para>
            /// </summary>
            [NameInMap("Uids")]
            [Validation(Required=false)]
            public List<string> Uids { get; set; }

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
            public List<GetCipStatsResponseBodyDataY> Y { get; set; }
            public class GetCipStatsResponseBodyDataY : TeaModel {
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
                /// <para>nickNameDetection</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The hit data.</para>
            /// </summary>
            [NameInMap("Z")]
            [Validation(Required=false)]
            public List<GetCipStatsResponseBodyDataZ> Z { get; set; }
            public class GetCipStatsResponseBodyDataZ : TeaModel {
                /// <summary>
                /// <para>The count.</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<long?> Data { get; set; }

                /// <summary>
                /// <para>The service code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nickNameDetection</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The further description of the error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The request ID assigned by the backend. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
