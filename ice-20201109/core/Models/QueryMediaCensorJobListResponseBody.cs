// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QueryMediaCensorJobListResponseBody : TeaModel {
        [NameInMap("MediaCensorJobList")]
        [Validation(Required=false)]
        public QueryMediaCensorJobListResponseBodyMediaCensorJobList MediaCensorJobList { get; set; }
        public class QueryMediaCensorJobListResponseBodyMediaCensorJobList : TeaModel {
            [NameInMap("MediaCensorJob")]
            [Validation(Required=false)]
            public List<QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJob> MediaCensorJob { get; set; }
            public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJob : TeaModel {
                [NameInMap("BarrageCensorResult")]
                [Validation(Required=false)]
                public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobBarrageCensorResult BarrageCensorResult { get; set; }
                public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobBarrageCensorResult : TeaModel {
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
                public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobCoverImageCensorResults CoverImageCensorResults { get; set; }
                public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobCoverImageCensorResults : TeaModel {
                    [NameInMap("CoverImageCensorResult")]
                    [Validation(Required=false)]
                    public List<QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobCoverImageCensorResultsCoverImageCensorResult> CoverImageCensorResult { get; set; }
                    public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobCoverImageCensorResultsCoverImageCensorResult : TeaModel {
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
                        public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobCoverImageCensorResultsCoverImageCensorResultResults Results { get; set; }
                        public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobCoverImageCensorResultsCoverImageCensorResultResults : TeaModel {
                            [NameInMap("Result")]
                            [Validation(Required=false)]
                            public List<QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobCoverImageCensorResultsCoverImageCensorResultResultsResult> Result { get; set; }
                            public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobCoverImageCensorResultsCoverImageCensorResultResultsResult : TeaModel {
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

                    }

                }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("DescCensorResult")]
                [Validation(Required=false)]
                public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobDescCensorResult DescCensorResult { get; set; }
                public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobDescCensorResult : TeaModel {
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
                public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobInput Input { get; set; }
                public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobInput : TeaModel {
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
                public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobTitleCensorResult TitleCensorResult { get; set; }
                public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobTitleCensorResult : TeaModel {
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
                public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResult VensorCensorResult { get; set; }
                public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResult : TeaModel {
                    [NameInMap("CensorResults")]
                    [Validation(Required=false)]
                    public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResultCensorResults CensorResults { get; set; }
                    public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResultCensorResults : TeaModel {
                        [NameInMap("CensorResult")]
                        [Validation(Required=false)]
                        public List<QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResultCensorResultsCensorResult> CensorResult { get; set; }
                        public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResultCensorResultsCensorResult : TeaModel {
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

                    [NameInMap("NextPageToken")]
                    [Validation(Required=false)]
                    public string NextPageToken { get; set; }

                    [NameInMap("VideoTimelines")]
                    [Validation(Required=false)]
                    public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResultVideoTimelines VideoTimelines { get; set; }
                    public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResultVideoTimelines : TeaModel {
                        [NameInMap("VideoTimeline")]
                        [Validation(Required=false)]
                        public List<QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResultVideoTimelinesVideoTimeline> VideoTimeline { get; set; }
                        public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResultVideoTimelinesVideoTimeline : TeaModel {
                            [NameInMap("CensorResults")]
                            [Validation(Required=false)]
                            public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResultVideoTimelinesVideoTimelineCensorResults CensorResults { get; set; }
                            public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResultVideoTimelinesVideoTimelineCensorResults : TeaModel {
                                [NameInMap("CensorResult")]
                                [Validation(Required=false)]
                                public List<QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResultVideoTimelinesVideoTimelineCensorResultsCensorResult> CensorResult { get; set; }
                                public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResultVideoTimelinesVideoTimelineCensorResultsCensorResult : TeaModel {
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

                            [NameInMap("Object")]
                            [Validation(Required=false)]
                            public string Object { get; set; }

                            [NameInMap("Timestamp")]
                            [Validation(Required=false)]
                            public string Timestamp { get; set; }

                        }

                    }

                }

                [NameInMap("VideoCensorConfig")]
                [Validation(Required=false)]
                public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVideoCensorConfig VideoCensorConfig { get; set; }
                public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVideoCensorConfig : TeaModel {
                    [NameInMap("BizType")]
                    [Validation(Required=false)]
                    public string BizType { get; set; }

                    [NameInMap("OutputFile")]
                    [Validation(Required=false)]
                    public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVideoCensorConfigOutputFile OutputFile { get; set; }
                    public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVideoCensorConfigOutputFile : TeaModel {
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

                    [NameInMap("VideoCensor")]
                    [Validation(Required=false)]
                    public string VideoCensor { get; set; }

                }

            }

        }

        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public QueryMediaCensorJobListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryMediaCensorJobListResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
