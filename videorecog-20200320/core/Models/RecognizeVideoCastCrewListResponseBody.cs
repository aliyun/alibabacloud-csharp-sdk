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
                public Dictionary<string, string> DetailInfo { get; set; }
                public float? EndTime { get; set; }
                public float? StartTime { get; set; }
            }
            [NameInMap("OcrResults")]
            [Validation(Required=false)]
            public List<RecognizeVideoCastCrewListResponseBodyDataOcrResults> OcrResults { get; set; }
            public class RecognizeVideoCastCrewListResponseBodyDataOcrResults : TeaModel {
                public List<RecognizeVideoCastCrewListResponseBodyDataOcrResultsDetailInfo> DetailInfo { get; set; }
                public class RecognizeVideoCastCrewListResponseBodyDataOcrResultsDetailInfo : TeaModel {
                    public List<string> Boxes { get; set; }
                    public List<string> CharProbs { get; set; }
                    public long? FrameIndex { get; set; }
                    public List<RecognizeVideoCastCrewListResponseBodyDataOcrResultsDetailInfoPosition> Position { get; set; }
                    public class RecognizeVideoCastCrewListResponseBodyDataOcrResultsDetailInfoPosition : TeaModel {
                        public long? X { get; set; }
                        public long? Y { get; set; }
                    }
                    public float? Score { get; set; }
                    public string Text { get; set; }
                    public float? TextProb { get; set; }
                    public float? TimeStamp { get; set; }
                    public long? TrackId { get; set; }
                }
                public float? EndTime { get; set; }
                public float? StartTime { get; set; }
            }
            [NameInMap("SubtitlesResults")]
            [Validation(Required=false)]
            public List<RecognizeVideoCastCrewListResponseBodyDataSubtitlesResults> SubtitlesResults { get; set; }
            public class RecognizeVideoCastCrewListResponseBodyDataSubtitlesResults : TeaModel {
                public Dictionary<string, string> SubtitlesAllResults { get; set; }
                public string SubtitlesAllResultsUrl { get; set; }
                public Dictionary<string, string> SubtitlesChineseResults { get; set; }
                public string SubtitlesChineseResultsUrl { get; set; }
                public Dictionary<string, string> SubtitlesEnglishResults { get; set; }
                public string SubtitlesEnglishResultsUrl { get; set; }
            }
            [NameInMap("VideoOcrResults")]
            [Validation(Required=false)]
            public List<RecognizeVideoCastCrewListResponseBodyDataVideoOcrResults> VideoOcrResults { get; set; }
            public class RecognizeVideoCastCrewListResponseBodyDataVideoOcrResults : TeaModel {
                public List<RecognizeVideoCastCrewListResponseBodyDataVideoOcrResultsDetailInfo> DetailInfo { get; set; }
                public class RecognizeVideoCastCrewListResponseBodyDataVideoOcrResultsDetailInfo : TeaModel {
                    public List<string> Boxes { get; set; }
                    public List<RecognizeVideoCastCrewListResponseBodyDataVideoOcrResultsDetailInfoPosition> Position { get; set; }
                    public class RecognizeVideoCastCrewListResponseBodyDataVideoOcrResultsDetailInfoPosition : TeaModel {
                        public long? X { get; set; }
                        public long? Y { get; set; }
                    }
                    public float? Score { get; set; }
                    public string Text { get; set; }
                    public long? TextType { get; set; }
                }
                public float? EndTime { get; set; }
                public float? StartTime { get; set; }
            }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
