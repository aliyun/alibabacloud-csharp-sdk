// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
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
                public string Code { get; set; }
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
                                public string Label { get; set; }
                                public string Rate { get; set; }
                                public string Scene { get; set; }
                                public string Suggestion { get; set; }
                            }
                        };

                    }

                }
                public string CreationTime { get; set; }
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
                public string FinishTime { get; set; }
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
                public string JobId { get; set; }
                public string Message { get; set; }
                public string PipelineId { get; set; }
                public string State { get; set; }
                public string Suggestion { get; set; }
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
                public string UserData { get; set; }
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
                    public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResultVideoTimelines VideoTimelines { get; set; }
                    public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResultVideoTimelines : TeaModel {
                        [NameInMap("VideoTimeline")]
                        [Validation(Required=false)]
                        public List<QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResultVideoTimelinesVideoTimeline> VideoTimeline { get; set; }
                        public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResultVideoTimelinesVideoTimeline : TeaModel {
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
                            public string Object { get; set; }
                            public string Timestamp { get; set; }
                        }
                    };

                }
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
                    };

                    [NameInMap("VideoCensor")]
                    [Validation(Required=false)]
                    public string VideoCensor { get; set; }

                }
            }
        };

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
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
