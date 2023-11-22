// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SearchMediaByAILabelResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("MediaList")]
        [Validation(Required=false)]
        public List<SearchMediaByAILabelResponseBodyMediaList> MediaList { get; set; }
        public class SearchMediaByAILabelResponseBodyMediaList : TeaModel {
            [NameInMap("AiData")]
            [Validation(Required=false)]
            public SearchMediaByAILabelResponseBodyMediaListAiData AiData { get; set; }
            public class SearchMediaByAILabelResponseBodyMediaListAiData : TeaModel {
                [NameInMap("AiLabelInfo")]
                [Validation(Required=false)]
                public List<SearchMediaByAILabelResponseBodyMediaListAiDataAiLabelInfo> AiLabelInfo { get; set; }
                public class SearchMediaByAILabelResponseBodyMediaListAiDataAiLabelInfo : TeaModel {
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    [NameInMap("FaceId")]
                    [Validation(Required=false)]
                    public string FaceId { get; set; }

                    [NameInMap("LabelId")]
                    [Validation(Required=false)]
                    public string LabelId { get; set; }

                    [NameInMap("LabelName")]
                    [Validation(Required=false)]
                    public string LabelName { get; set; }

                    [NameInMap("LabelType")]
                    [Validation(Required=false)]
                    public string LabelType { get; set; }

                    [NameInMap("Occurrences")]
                    [Validation(Required=false)]
                    public List<SearchMediaByAILabelResponseBodyMediaListAiDataAiLabelInfoOccurrences> Occurrences { get; set; }
                    public class SearchMediaByAILabelResponseBodyMediaListAiDataAiLabelInfoOccurrences : TeaModel {
                        [NameInMap("ClipId")]
                        [Validation(Required=false)]
                        public string ClipId { get; set; }

                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        [NameInMap("FinegrainId")]
                        [Validation(Required=false)]
                        public string FinegrainId { get; set; }

                        [NameInMap("FinegrainName")]
                        [Validation(Required=false)]
                        public string FinegrainName { get; set; }

                        [NameInMap("From")]
                        [Validation(Required=false)]
                        public double? From { get; set; }

                        [NameInMap("Image")]
                        [Validation(Required=false)]
                        public string Image { get; set; }

                        [NameInMap("Score")]
                        [Validation(Required=false)]
                        public double? Score { get; set; }

                        [NameInMap("TableBatchSeqId")]
                        [Validation(Required=false)]
                        public string TableBatchSeqId { get; set; }

                        [NameInMap("To")]
                        [Validation(Required=false)]
                        public double? To { get; set; }

                        [NameInMap("Tracks")]
                        [Validation(Required=false)]
                        public List<SearchMediaByAILabelResponseBodyMediaListAiDataAiLabelInfoOccurrencesTracks> Tracks { get; set; }
                        public class SearchMediaByAILabelResponseBodyMediaListAiDataAiLabelInfoOccurrencesTracks : TeaModel {
                            [NameInMap("Position")]
                            [Validation(Required=false)]
                            public string Position { get; set; }

                            [NameInMap("Size")]
                            [Validation(Required=false)]
                            public double? Size { get; set; }

                            [NameInMap("Timestamp")]
                            [Validation(Required=false)]
                            public double? Timestamp { get; set; }

                        }

                    }

                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                }

                [NameInMap("AsrInfo")]
                [Validation(Required=false)]
                public List<SearchMediaByAILabelResponseBodyMediaListAiDataAsrInfo> AsrInfo { get; set; }
                public class SearchMediaByAILabelResponseBodyMediaListAiDataAsrInfo : TeaModel {
                    [NameInMap("ClipId")]
                    [Validation(Required=false)]
                    public string ClipId { get; set; }

                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("From")]
                    [Validation(Required=false)]
                    public double? From { get; set; }

                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public double? Timestamp { get; set; }

                    [NameInMap("To")]
                    [Validation(Required=false)]
                    public double? To { get; set; }

                }

                [NameInMap("OcrInfo")]
                [Validation(Required=false)]
                public List<SearchMediaByAILabelResponseBodyMediaListAiDataOcrInfo> OcrInfo { get; set; }
                public class SearchMediaByAILabelResponseBodyMediaListAiDataOcrInfo : TeaModel {
                    [NameInMap("ClipId")]
                    [Validation(Required=false)]
                    public string ClipId { get; set; }

                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("From")]
                    [Validation(Required=false)]
                    public double? From { get; set; }

                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public double? Timestamp { get; set; }

                    [NameInMap("To")]
                    [Validation(Required=false)]
                    public double? To { get; set; }

                }

            }

            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("CoverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("Snapshots")]
            [Validation(Required=false)]
            public List<string> Snapshots { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StorageLocation")]
            [Validation(Required=false)]
            public string StorageLocation { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
