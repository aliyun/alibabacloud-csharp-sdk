// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMediaCensorJobDetailResponseBody : TeaModel {
        [NameInMap("MediaCensorJobDetail")]
        [Validation(Required=false)]
        public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetail MediaCensorJobDetail { get; set; }
        public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetail : TeaModel {
            [NameInMap("BarrageCensorResult")]
            [Validation(Required=false)]
            public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailBarrageCensorResult BarrageCensorResult { get; set; }
            public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailBarrageCensorResult : TeaModel {
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("Rate")]
                [Validation(Required=false)]
                public string Rate { get; set; }

                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

            }
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }
            [NameInMap("CoverImageCensorResults")]
            [Validation(Required=false)]
            public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailCoverImageCensorResults CoverImageCensorResults { get; set; }
            public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailCoverImageCensorResults : TeaModel {
                [NameInMap("CoverImageCensorResult")]
                [Validation(Required=false)]
                public List<QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailCoverImageCensorResultsCoverImageCensorResult> CoverImageCensorResult { get; set; }
                public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailCoverImageCensorResultsCoverImageCensorResult : TeaModel {
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                    [NameInMap("Results")]
                    [Validation(Required=false)]
                    public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailCoverImageCensorResultsCoverImageCensorResultResults Results { get; set; }
                    public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailCoverImageCensorResultsCoverImageCensorResultResults : TeaModel {
                        [NameInMap("Result")]
                        [Validation(Required=false)]
                        public List<QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailCoverImageCensorResultsCoverImageCensorResultResultsResult> Result { get; set; }
                        public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailCoverImageCensorResultsCoverImageCensorResultResultsResult : TeaModel {
                            public string Label { get; set; }
                            public string Rate { get; set; }
                            public string Scene { get; set; }
                            public string Suggestion { get; set; }
                        }
                    };

                }

            }
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }
            [NameInMap("DescCensorResult")]
            [Validation(Required=false)]
            public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailDescCensorResult DescCensorResult { get; set; }
            public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailDescCensorResult : TeaModel {
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("Rate")]
                [Validation(Required=false)]
                public string Rate { get; set; }

                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

            }
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }
            [NameInMap("Input")]
            [Validation(Required=false)]
            public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailInput Input { get; set; }
            public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailInput : TeaModel {
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("Object")]
                [Validation(Required=false)]
                public string Object { get; set; }

            }
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }
            [NameInMap("TitleCensorResult")]
            [Validation(Required=false)]
            public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailTitleCensorResult TitleCensorResult { get; set; }
            public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailTitleCensorResult : TeaModel {
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("Rate")]
                [Validation(Required=false)]
                public string Rate { get; set; }

                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

            }
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }
            [NameInMap("VensorCensorResult")]
            [Validation(Required=false)]
            public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResult VensorCensorResult { get; set; }
            public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResult : TeaModel {
                [NameInMap("CensorResults")]
                [Validation(Required=false)]
                public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResultCensorResults CensorResults { get; set; }
                public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResultCensorResults : TeaModel {
                    [NameInMap("CensorResult")]
                    [Validation(Required=false)]
                    public List<QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResultCensorResultsCensorResult> CensorResult { get; set; }
                    public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResultCensorResultsCensorResult : TeaModel {
                        public string Label { get; set; }
                        public string Rate { get; set; }
                        public string Scene { get; set; }
                        public string Suggestion { get; set; }
                    }
                };

                [NameInMap("NextPageToken")]
                [Validation(Required=false)]
                public string NextPageToken { get; set; }

                [NameInMap("VideoTimelines")]
                [Validation(Required=false)]
                public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResultVideoTimelines VideoTimelines { get; set; }
                public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResultVideoTimelines : TeaModel {
                    [NameInMap("VideoTimeline")]
                    [Validation(Required=false)]
                    public List<QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResultVideoTimelinesVideoTimeline> VideoTimeline { get; set; }
                    public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResultVideoTimelinesVideoTimeline : TeaModel {
                        public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResultVideoTimelinesVideoTimelineCensorResults CensorResults { get; set; }
                        public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResultVideoTimelinesVideoTimelineCensorResults : TeaModel {
                            [NameInMap("CensorResult")]
                            [Validation(Required=false)]
                            public List<QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResultVideoTimelinesVideoTimelineCensorResultsCensorResult> CensorResult { get; set; }
                            public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResultVideoTimelinesVideoTimelineCensorResultsCensorResult : TeaModel {
                                [NameInMap("Label")]
                                [Validation(Required=false)]
                                public string Label { get; set; }

                                [NameInMap("Rate")]
                                [Validation(Required=false)]
                                public string Rate { get; set; }

                                [NameInMap("Scene")]
                                [Validation(Required=false)]
                                public string Scene { get; set; }

                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                            }

                        }
                        public string Object { get; set; }
                        public string Timestamp { get; set; }
                    }
                };

            }
            [NameInMap("VideoCensorConfig")]
            [Validation(Required=false)]
            public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVideoCensorConfig VideoCensorConfig { get; set; }
            public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVideoCensorConfig : TeaModel {
                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                [NameInMap("OutputFile")]
                [Validation(Required=false)]
                public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVideoCensorConfigOutputFile OutputFile { get; set; }
                public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVideoCensorConfigOutputFile : TeaModel {
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }
                };

                [NameInMap("VideoCensor")]
                [Validation(Required=false)]
                public string VideoCensor { get; set; }

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
