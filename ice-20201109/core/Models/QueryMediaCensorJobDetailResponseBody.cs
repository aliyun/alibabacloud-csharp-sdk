// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>99.91</para>
                /// </summary>
                [NameInMap("Rate")]
                [Validation(Required=false)]
                public string Rate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>antispam</para>
                /// </summary>
                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pass</para>
                /// </summary>
                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>InvalidParameter.ResourceNotFound</para>
            /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>bucket-out-test-****</para>
                    /// </summary>
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>oss-cn-shanghai</para>
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test/ai/censor/v2/vme-****.jpg</para>
                    /// </summary>
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
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>Normal</para>
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>100</para>
                            /// </summary>
                            [NameInMap("Rate")]
                            [Validation(Required=false)]
                            public string Rate { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>Antispam</para>
                            /// </summary>
                            [NameInMap("Scene")]
                            [Validation(Required=false)]
                            public string Scene { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>pass</para>
                            /// </summary>
                            [NameInMap("Suggestion")]
                            [Validation(Required=false)]
                            public string Suggestion { get; set; }

                        }

                    }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2018-09-13T16:32:24Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("DescCensorResult")]
            [Validation(Required=false)]
            public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailDescCensorResult DescCensorResult { get; set; }
            public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailDescCensorResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>terrorism</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Rate")]
                [Validation(Required=false)]
                public string Rate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>antispam</para>
                /// </summary>
                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>review</para>
                /// </summary>
                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2018-09-13T16:38:24Z</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            [NameInMap("Input")]
            [Validation(Required=false)]
            public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailInput Input { get; set; }
            public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailInput : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>bucket-test-in-****</para>
                /// </summary>
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>oss-cn-shanghai</para>
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test/ai/censor/test-****.mp4</para>
                /// </summary>
                [NameInMap("Object")]
                [Validation(Required=false)]
                public string Object { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>f8f166eea7a44e9bb0a4aecf9543****</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>The resource operated cannot be found</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>c5b30b7c0d0e4a0abde1d5f9e751****</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>block</para>
            /// </summary>
            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }

            [NameInMap("TitleCensorResult")]
            [Validation(Required=false)]
            public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailTitleCensorResult TitleCensorResult { get; set; }
            public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailTitleCensorResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>meaningless</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>99.91</para>
                /// </summary>
                [NameInMap("Rate")]
                [Validation(Required=false)]
                public string Rate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>antispam</para>
                /// </summary>
                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>block</para>
                /// </summary>
                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>example userdata ****</para>
            /// </summary>
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
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>meaningless</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("Rate")]
                        [Validation(Required=false)]
                        public string Rate { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>terrorism</para>
                        /// </summary>
                        [NameInMap("Scene")]
                        [Validation(Required=false)]
                        public string Scene { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>review</para>
                        /// </summary>
                        [NameInMap("Suggestion")]
                        [Validation(Required=false)]
                        public string Suggestion { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ea04afcca7cd4e80b9ece8fbb251****</para>
                /// </summary>
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
                        [NameInMap("CensorResults")]
                        [Validation(Required=false)]
                        public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResultVideoTimelinesVideoTimelineCensorResults CensorResults { get; set; }
                        public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResultVideoTimelinesVideoTimelineCensorResults : TeaModel {
                            [NameInMap("CensorResult")]
                            [Validation(Required=false)]
                            public List<QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResultVideoTimelinesVideoTimelineCensorResultsCensorResult> CensorResult { get; set; }
                            public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResultVideoTimelinesVideoTimelineCensorResultsCensorResult : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>flood</para>
                                /// </summary>
                                [NameInMap("Label")]
                                [Validation(Required=false)]
                                public string Label { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>99.99</para>
                                /// </summary>
                                [NameInMap("Rate")]
                                [Validation(Required=false)]
                                public string Rate { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>porn</para>
                                /// </summary>
                                [NameInMap("Scene")]
                                [Validation(Required=false)]
                                public string Scene { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>block</para>
                                /// </summary>
                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                            }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>output{Count}.jpg</para>
                        /// </summary>
                        [NameInMap("Object")]
                        [Validation(Required=false)]
                        public string Object { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>00:02:59.999</para>
                        /// </summary>
                        [NameInMap("Timestamp")]
                        [Validation(Required=false)]
                        public string Timestamp { get; set; }

                    }

                }

            }

            [NameInMap("VideoCensorConfig")]
            [Validation(Required=false)]
            public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVideoCensorConfig VideoCensorConfig { get; set; }
            public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVideoCensorConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>common</para>
                /// </summary>
                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                [NameInMap("OutputFile")]
                [Validation(Required=false)]
                public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVideoCensorConfigOutputFile OutputFile { get; set; }
                public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVideoCensorConfigOutputFile : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test-bucket-****</para>
                    /// </summary>
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>oss-cn-shanghai</para>
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>output{Count}.jpg</para>
                    /// </summary>
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("VideoCensor")]
                [Validation(Required=false)]
                public string VideoCensor { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B42299E6-F71F-465F-8FE9-4FC2E3D3C2CA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
