// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetTopicSelectionPerspectiveAnalysisTaskResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTopicSelectionPerspectiveAnalysisTaskResponseBodyData Data { get; set; }
        public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyData : TeaModel {
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("FreshViewPointsResult")]
            [Validation(Required=false)]
            public GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataFreshViewPointsResult FreshViewPointsResult { get; set; }
            public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataFreshViewPointsResult : TeaModel {
                [NameInMap("Attitudes")]
                [Validation(Required=false)]
                public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataFreshViewPointsResultAttitudes> Attitudes { get; set; }
                public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataFreshViewPointsResultAttitudes : TeaModel {
                    [NameInMap("Attitude")]
                    [Validation(Required=false)]
                    public string Attitude { get; set; }

                    [NameInMap("AttitudeType")]
                    [Validation(Required=false)]
                    public string AttitudeType { get; set; }

                    [NameInMap("Ratio")]
                    [Validation(Required=false)]
                    public string Ratio { get; set; }

                    [NameInMap("ViewPoints")]
                    [Validation(Required=false)]
                    public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataFreshViewPointsResultAttitudesViewPoints> ViewPoints { get; set; }
                    public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataFreshViewPointsResultAttitudesViewPoints : TeaModel {
                        [NameInMap("Outlines")]
                        [Validation(Required=false)]
                        public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataFreshViewPointsResultAttitudesViewPointsOutlines> Outlines { get; set; }
                        public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataFreshViewPointsResultAttitudesViewPointsOutlines : TeaModel {
                            [NameInMap("Outline")]
                            [Validation(Required=false)]
                            public string Outline { get; set; }

                            [NameInMap("Summary")]
                            [Validation(Required=false)]
                            public string Summary { get; set; }

                        }

                        [NameInMap("Point")]
                        [Validation(Required=false)]
                        public string Point { get; set; }

                        [NameInMap("Summary")]
                        [Validation(Required=false)]
                        public string Summary { get; set; }

                    }

                }

            }

            [NameInMap("HotViewPointsResult")]
            [Validation(Required=false)]
            public GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResult HotViewPointsResult { get; set; }
            public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResult : TeaModel {
                [NameInMap("Attitudes")]
                [Validation(Required=false)]
                public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResultAttitudes> Attitudes { get; set; }
                public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResultAttitudes : TeaModel {
                    [NameInMap("Attitude")]
                    [Validation(Required=false)]
                    public string Attitude { get; set; }

                    [NameInMap("AttitudeType")]
                    [Validation(Required=false)]
                    public string AttitudeType { get; set; }

                    [NameInMap("News")]
                    [Validation(Required=false)]
                    public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResultAttitudesNews> News { get; set; }
                    public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResultAttitudesNews : TeaModel {
                        [NameInMap("DocId")]
                        [Validation(Required=false)]
                        public string DocId { get; set; }

                        [NameInMap("DocUuid")]
                        [Validation(Required=false)]
                        public string DocUuid { get; set; }

                        [NameInMap("ImageUrls")]
                        [Validation(Required=false)]
                        public List<string> ImageUrls { get; set; }

                        [NameInMap("Tags")]
                        [Validation(Required=false)]
                        public List<string> Tags { get; set; }

                        [NameInMap("Topic")]
                        [Validation(Required=false)]
                        public string Topic { get; set; }

                    }

                    [NameInMap("Ratio")]
                    [Validation(Required=false)]
                    public string Ratio { get; set; }

                    [NameInMap("ViewPoints")]
                    [Validation(Required=false)]
                    public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResultAttitudesViewPoints> ViewPoints { get; set; }
                    public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResultAttitudesViewPoints : TeaModel {
                        [NameInMap("Outlines")]
                        [Validation(Required=false)]
                        public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResultAttitudesViewPointsOutlines> Outlines { get; set; }
                        public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataHotViewPointsResultAttitudesViewPointsOutlines : TeaModel {
                            [NameInMap("Outline")]
                            [Validation(Required=false)]
                            public string Outline { get; set; }

                            [NameInMap("Summary")]
                            [Validation(Required=false)]
                            public string Summary { get; set; }

                        }

                        [NameInMap("Point")]
                        [Validation(Required=false)]
                        public string Point { get; set; }

                        [NameInMap("Summary")]
                        [Validation(Required=false)]
                        public string Summary { get; set; }

                    }

                }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TimedViewPointsResult")]
            [Validation(Required=false)]
            public GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTimedViewPointsResult TimedViewPointsResult { get; set; }
            public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTimedViewPointsResult : TeaModel {
                [NameInMap("Attitudes")]
                [Validation(Required=false)]
                public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTimedViewPointsResultAttitudes> Attitudes { get; set; }
                public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTimedViewPointsResultAttitudes : TeaModel {
                    [NameInMap("Attitude")]
                    [Validation(Required=false)]
                    public string Attitude { get; set; }

                    [NameInMap("AttitudeType")]
                    [Validation(Required=false)]
                    public string AttitudeType { get; set; }

                    [NameInMap("PubTime")]
                    [Validation(Required=false)]
                    public string PubTime { get; set; }

                    [NameInMap("Ratio")]
                    [Validation(Required=false)]
                    public string Ratio { get; set; }

                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                    [NameInMap("ViewPoints")]
                    [Validation(Required=false)]
                    public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTimedViewPointsResultAttitudesViewPoints> ViewPoints { get; set; }
                    public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTimedViewPointsResultAttitudesViewPoints : TeaModel {
                        [NameInMap("Outlines")]
                        [Validation(Required=false)]
                        public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTimedViewPointsResultAttitudesViewPointsOutlines> Outlines { get; set; }
                        public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTimedViewPointsResultAttitudesViewPointsOutlines : TeaModel {
                            [NameInMap("Outline")]
                            [Validation(Required=false)]
                            public string Outline { get; set; }

                            [NameInMap("Summary")]
                            [Validation(Required=false)]
                            public string Summary { get; set; }

                        }

                        [NameInMap("Point")]
                        [Validation(Required=false)]
                        public string Point { get; set; }

                        [NameInMap("Summary")]
                        [Validation(Required=false)]
                        public string Summary { get; set; }

                    }

                }

            }

            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            [NameInMap("TopicSummaryResult")]
            [Validation(Required=false)]
            public GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTopicSummaryResult TopicSummaryResult { get; set; }
            public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTopicSummaryResult : TeaModel {
                [NameInMap("Summaries")]
                [Validation(Required=false)]
                public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTopicSummaryResultSummaries> Summaries { get; set; }
                public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTopicSummaryResultSummaries : TeaModel {
                    [NameInMap("DocList")]
                    [Validation(Required=false)]
                    public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTopicSummaryResultSummariesDocList> DocList { get; set; }
                    public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataTopicSummaryResultSummariesDocList : TeaModel {
                        [NameInMap("Source")]
                        [Validation(Required=false)]
                        public string Source { get; set; }

                        [NameInMap("Title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                    [NameInMap("Summary")]
                    [Validation(Required=false)]
                    public string Summary { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

            }

            [NameInMap("WebReviewPointsResult")]
            [Validation(Required=false)]
            public GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResult WebReviewPointsResult { get; set; }
            public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResult : TeaModel {
                [NameInMap("Attitudes")]
                [Validation(Required=false)]
                public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResultAttitudes> Attitudes { get; set; }
                public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResultAttitudes : TeaModel {
                    [NameInMap("Attitude")]
                    [Validation(Required=false)]
                    public string Attitude { get; set; }

                    [NameInMap("AttitudeType")]
                    [Validation(Required=false)]
                    public string AttitudeType { get; set; }

                    [NameInMap("Comments")]
                    [Validation(Required=false)]
                    public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResultAttitudesComments> Comments { get; set; }
                    public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResultAttitudesComments : TeaModel {
                        [NameInMap("Source")]
                        [Validation(Required=false)]
                        public string Source { get; set; }

                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                        [NameInMap("Title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                        [NameInMap("Username")]
                        [Validation(Required=false)]
                        public string Username { get; set; }

                    }

                    [NameInMap("Ratio")]
                    [Validation(Required=false)]
                    public string Ratio { get; set; }

                    [NameInMap("ViewPoints")]
                    [Validation(Required=false)]
                    public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResultAttitudesViewPoints> ViewPoints { get; set; }
                    public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResultAttitudesViewPoints : TeaModel {
                        [NameInMap("Outlines")]
                        [Validation(Required=false)]
                        public List<GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResultAttitudesViewPointsOutlines> Outlines { get; set; }
                        public class GetTopicSelectionPerspectiveAnalysisTaskResponseBodyDataWebReviewPointsResultAttitudesViewPointsOutlines : TeaModel {
                            [NameInMap("Outline")]
                            [Validation(Required=false)]
                            public string Outline { get; set; }

                            [NameInMap("Summary")]
                            [Validation(Required=false)]
                            public string Summary { get; set; }

                        }

                        [NameInMap("Point")]
                        [Validation(Required=false)]
                        public string Point { get; set; }

                        [NameInMap("Summary")]
                        [Validation(Required=false)]
                        public string Summary { get; set; }

                    }

                }

            }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
