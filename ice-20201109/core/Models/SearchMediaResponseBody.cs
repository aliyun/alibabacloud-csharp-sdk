// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SearchMediaResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("MediaInfoList")]
        [Validation(Required=false)]
        public List<SearchMediaResponseBodyMediaInfoList> MediaInfoList { get; set; }
        public class SearchMediaResponseBodyMediaInfoList : TeaModel {
            [NameInMap("AiData")]
            [Validation(Required=false)]
            public SearchMediaResponseBodyMediaInfoListAiData AiData { get; set; }
            public class SearchMediaResponseBodyMediaInfoListAiData : TeaModel {
                [NameInMap("AiLabelInfo")]
                [Validation(Required=false)]
                public List<SearchMediaResponseBodyMediaInfoListAiDataAiLabelInfo> AiLabelInfo { get; set; }
                public class SearchMediaResponseBodyMediaInfoListAiDataAiLabelInfo : TeaModel {
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
                    public List<SearchMediaResponseBodyMediaInfoListAiDataAiLabelInfoOccurrences> Occurrences { get; set; }
                    public class SearchMediaResponseBodyMediaInfoListAiDataAiLabelInfoOccurrences : TeaModel {
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
                        public List<SearchMediaResponseBodyMediaInfoListAiDataAiLabelInfoOccurrencesTracks> Tracks { get; set; }
                        public class SearchMediaResponseBodyMediaInfoListAiDataAiLabelInfoOccurrencesTracks : TeaModel {
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

                        [NameInMap("clipId")]
                        [Validation(Required=false)]
                        public string ClipId { get; set; }

                    }

                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                }

                [NameInMap("AsrInfo")]
                [Validation(Required=false)]
                public List<SearchMediaResponseBodyMediaInfoListAiDataAsrInfo> AsrInfo { get; set; }
                public class SearchMediaResponseBodyMediaInfoListAiDataAsrInfo : TeaModel {
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
                public List<SearchMediaResponseBodyMediaInfoListAiDataOcrInfo> OcrInfo { get; set; }
                public class SearchMediaResponseBodyMediaInfoListAiDataOcrInfo : TeaModel {
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

            [NameInMap("AiRoughData")]
            [Validation(Required=false)]
            public SearchMediaResponseBodyMediaInfoListAiRoughData AiRoughData { get; set; }
            public class SearchMediaResponseBodyMediaInfoListAiRoughData : TeaModel {
                /// <summary>
                /// 电视剧
                /// </summary>
                [NameInMap("AiCategory")]
                [Validation(Required=false)]
                public string AiCategory { get; set; }

                [NameInMap("AiJobId")]
                [Validation(Required=false)]
                public string AiJobId { get; set; }

                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                [NameInMap("SaveType")]
                [Validation(Required=false)]
                public string SaveType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// FileInfos。
            /// </summary>
            [NameInMap("FileInfoList")]
            [Validation(Required=false)]
            public List<SearchMediaResponseBodyMediaInfoListFileInfoList> FileInfoList { get; set; }
            public class SearchMediaResponseBodyMediaInfoListFileInfoList : TeaModel {
                [NameInMap("FileBasicInfo")]
                [Validation(Required=false)]
                public SearchMediaResponseBodyMediaInfoListFileInfoListFileBasicInfo FileBasicInfo { get; set; }
                public class SearchMediaResponseBodyMediaInfoListFileInfoListFileBasicInfo : TeaModel {
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    [NameInMap("FileSize")]
                    [Validation(Required=false)]
                    public string FileSize { get; set; }

                    [NameInMap("FileStatus")]
                    [Validation(Required=false)]
                    public string FileStatus { get; set; }

                    [NameInMap("FileType")]
                    [Validation(Required=false)]
                    public string FileType { get; set; }

                    [NameInMap("FileUrl")]
                    [Validation(Required=false)]
                    public string FileUrl { get; set; }

                    [NameInMap("FormatName")]
                    [Validation(Required=false)]
                    public string FormatName { get; set; }

                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public string ModifiedTime { get; set; }

                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

            }

            [NameInMap("MediaBasicInfo")]
            [Validation(Required=false)]
            public SearchMediaResponseBodyMediaInfoListMediaBasicInfo MediaBasicInfo { get; set; }
            public class SearchMediaResponseBodyMediaInfoListMediaBasicInfo : TeaModel {
                [NameInMap("Biz")]
                [Validation(Required=false)]
                public string Biz { get; set; }

                [NameInMap("BusinessType")]
                [Validation(Required=false)]
                public string BusinessType { get; set; }

                [NameInMap("CateId")]
                [Validation(Required=false)]
                public long? CateId { get; set; }

                [NameInMap("CateName")]
                [Validation(Required=false)]
                public string CateName { get; set; }

                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DeletedTime")]
                [Validation(Required=false)]
                public string DeletedTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("InputURL")]
                [Validation(Required=false)]
                public string InputURL { get; set; }

                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                [NameInMap("MediaTags")]
                [Validation(Required=false)]
                public string MediaTags { get; set; }

                [NameInMap("MediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("ReferenceId")]
                [Validation(Required=false)]
                public string ReferenceId { get; set; }

                [NameInMap("Snapshots")]
                [Validation(Required=false)]
                public string Snapshots { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("SpriteImages")]
                [Validation(Required=false)]
                public string SpriteImages { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("TranscodeStatus")]
                [Validation(Required=false)]
                public string TranscodeStatus { get; set; }

                [NameInMap("UploadSource")]
                [Validation(Required=false)]
                public string UploadSource { get; set; }

                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }

            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

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
