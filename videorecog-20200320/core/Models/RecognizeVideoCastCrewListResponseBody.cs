// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videorecog20200320.Models
{
    public class RecognizeVideoCastCrewListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeVideoCastCrewListResponseBodyData Data { get; set; }
        public class RecognizeVideoCastCrewListResponseBodyData : TeaModel {
            [NameInMap("CastResults")]
            [Validation(Required=false)]
            public List<RecognizeVideoCastCrewListResponseBodyDataCastResults> CastResults { get; set; }
            public class RecognizeVideoCastCrewListResponseBodyDataCastResults : TeaModel {
                [NameInMap("DetailInfo")]
                [Validation(Required=false)]
                public Dictionary<string, string> DetailInfo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.6</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public float? EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.6</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public float? StartTime { get; set; }

            }

            [NameInMap("OcrResults")]
            [Validation(Required=false)]
            public List<RecognizeVideoCastCrewListResponseBodyDataOcrResults> OcrResults { get; set; }
            public class RecognizeVideoCastCrewListResponseBodyDataOcrResults : TeaModel {
                [NameInMap("DetailInfo")]
                [Validation(Required=false)]
                public List<RecognizeVideoCastCrewListResponseBodyDataOcrResultsDetailInfo> DetailInfo { get; set; }
                public class RecognizeVideoCastCrewListResponseBodyDataOcrResultsDetailInfo : TeaModel {
                    [NameInMap("Boxes")]
                    [Validation(Required=false)]
                    public List<int?> Boxes { get; set; }

                    [NameInMap("CharProbs")]
                    [Validation(Required=false)]
                    public List<List<float?>> CharProbs { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>17</para>
                    /// </summary>
                    [NameInMap("FrameIndex")]
                    [Validation(Required=false)]
                    public long? FrameIndex { get; set; }

                    [NameInMap("Position")]
                    [Validation(Required=false)]
                    public List<RecognizeVideoCastCrewListResponseBodyDataOcrResultsDetailInfoPosition> Position { get; set; }
                    public class RecognizeVideoCastCrewListResponseBodyDataOcrResultsDetailInfoPosition : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>266</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public long? X { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>440</para>
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public long? Y { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>92.07685702563117</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.9207685702563116</para>
                    /// </summary>
                    [NameInMap("TextProb")]
                    [Validation(Required=false)]
                    public float? TextProb { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.28</para>
                    /// </summary>
                    [NameInMap("TimeStamp")]
                    [Validation(Required=false)]
                    public float? TimeStamp { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TrackId")]
                    [Validation(Required=false)]
                    public long? TrackId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.28</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public float? EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.28</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public float? StartTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://vibktprfx-prod-prod-media-ai-cn-shanghai.oss-cn-shanghai.aliyuncs.com/video-ocr/1665475907_bGHMygKsFw.json?Expires=1665477707&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=6KQb9OXQldsg30w%2FNurHwAbjiJs%3D">http://vibktprfx-prod-prod-media-ai-cn-shanghai.oss-cn-shanghai.aliyuncs.com/video-ocr/1665475907_bGHMygKsFw.json?Expires=1665477707&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=6KQb9OXQldsg30w%2FNurHwAbjiJs%3D</a></para>
            /// </summary>
            [NameInMap("OcrResultsUrl")]
            [Validation(Required=false)]
            public string OcrResultsUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://vibktprfx-prod-prod-media-ai-cn-shanghai.oss-cn-shanghai.aliyuncs.com/video-ocr/1665475907_VSRvetTHon.json?Expires=1665477707&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=wfQviVVSyVRLPVlHDKXi6cTefHY%3D">http://vibktprfx-prod-prod-media-ai-cn-shanghai.oss-cn-shanghai.aliyuncs.com/video-ocr/1665475907_VSRvetTHon.json?Expires=1665477707&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=wfQviVVSyVRLPVlHDKXi6cTefHY%3D</a></para>
            /// </summary>
            [NameInMap("OcrVideoResultsUrl")]
            [Validation(Required=false)]
            public string OcrVideoResultsUrl { get; set; }

            [NameInMap("SubtitlesResults")]
            [Validation(Required=false)]
            public List<RecognizeVideoCastCrewListResponseBodyDataSubtitlesResults> SubtitlesResults { get; set; }
            public class RecognizeVideoCastCrewListResponseBodyDataSubtitlesResults : TeaModel {
                [NameInMap("SubtitlesAllResults")]
                [Validation(Required=false)]
                public Dictionary<string, string> SubtitlesAllResults { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>url</para>
                /// </summary>
                [NameInMap("SubtitlesAllResultsUrl")]
                [Validation(Required=false)]
                public string SubtitlesAllResultsUrl { get; set; }

                [NameInMap("SubtitlesChineseResults")]
                [Validation(Required=false)]
                public Dictionary<string, string> SubtitlesChineseResults { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>url1</para>
                /// </summary>
                [NameInMap("SubtitlesChineseResultsUrl")]
                [Validation(Required=false)]
                public string SubtitlesChineseResultsUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>hello</para>
                /// </summary>
                [NameInMap("SubtitlesEnglishResults")]
                [Validation(Required=false)]
                public Dictionary<string, object> SubtitlesEnglishResults { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>url2</para>
                /// </summary>
                [NameInMap("SubtitlesEnglishResultsUrl")]
                [Validation(Required=false)]
                public string SubtitlesEnglishResultsUrl { get; set; }

            }

            [NameInMap("VideoOcrResults")]
            [Validation(Required=false)]
            public List<RecognizeVideoCastCrewListResponseBodyDataVideoOcrResults> VideoOcrResults { get; set; }
            public class RecognizeVideoCastCrewListResponseBodyDataVideoOcrResults : TeaModel {
                [NameInMap("DetailInfo")]
                [Validation(Required=false)]
                public List<RecognizeVideoCastCrewListResponseBodyDataVideoOcrResultsDetailInfo> DetailInfo { get; set; }
                public class RecognizeVideoCastCrewListResponseBodyDataVideoOcrResultsDetailInfo : TeaModel {
                    [NameInMap("Boxes")]
                    [Validation(Required=false)]
                    public List<long?> Boxes { get; set; }

                    [NameInMap("Position")]
                    [Validation(Required=false)]
                    public List<RecognizeVideoCastCrewListResponseBodyDataVideoOcrResultsDetailInfoPosition> Position { get; set; }
                    public class RecognizeVideoCastCrewListResponseBodyDataVideoOcrResultsDetailInfoPosition : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>269</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public long? X { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>423</para>
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public long? Y { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>92.07685702563117</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TextType")]
                    [Validation(Required=false)]
                    public long? TextType { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.92</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public float? EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.92</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public float? StartTime { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE5B1A95-064F-1C5E-A6FE-FEE0D734A632</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
