// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
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

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public float? EndTime { get; set; }

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

                    [NameInMap("FrameIndex")]
                    [Validation(Required=false)]
                    public long? FrameIndex { get; set; }

                    [NameInMap("Position")]
                    [Validation(Required=false)]
                    public List<RecognizeVideoCastCrewListResponseBodyDataOcrResultsDetailInfoPosition> Position { get; set; }
                    public class RecognizeVideoCastCrewListResponseBodyDataOcrResultsDetailInfoPosition : TeaModel {
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public long? X { get; set; }

                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public long? Y { get; set; }

                    }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    [NameInMap("TextProb")]
                    [Validation(Required=false)]
                    public float? TextProb { get; set; }

                    [NameInMap("TimeStamp")]
                    [Validation(Required=false)]
                    public float? TimeStamp { get; set; }

                    [NameInMap("TrackId")]
                    [Validation(Required=false)]
                    public long? TrackId { get; set; }

                }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public float? EndTime { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public float? StartTime { get; set; }

            }

            [NameInMap("SubtitlesResults")]
            [Validation(Required=false)]
            public List<RecognizeVideoCastCrewListResponseBodyDataSubtitlesResults> SubtitlesResults { get; set; }
            public class RecognizeVideoCastCrewListResponseBodyDataSubtitlesResults : TeaModel {
                [NameInMap("SubtitlesAllResults")]
                [Validation(Required=false)]
                public Dictionary<string, string> SubtitlesAllResults { get; set; }

                [NameInMap("SubtitlesAllResultsUrl")]
                [Validation(Required=false)]
                public string SubtitlesAllResultsUrl { get; set; }

                [NameInMap("SubtitlesChineseResults")]
                [Validation(Required=false)]
                public Dictionary<string, string> SubtitlesChineseResults { get; set; }

                [NameInMap("SubtitlesChineseResultsUrl")]
                [Validation(Required=false)]
                public string SubtitlesChineseResultsUrl { get; set; }

                [NameInMap("SubtitlesEnglishResults")]
                [Validation(Required=false)]
                public Dictionary<string, object> SubtitlesEnglishResults { get; set; }

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
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public long? X { get; set; }

                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public long? Y { get; set; }

                    }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    [NameInMap("TextType")]
                    [Validation(Required=false)]
                    public long? TextType { get; set; }

                }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public float? EndTime { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public float? StartTime { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
