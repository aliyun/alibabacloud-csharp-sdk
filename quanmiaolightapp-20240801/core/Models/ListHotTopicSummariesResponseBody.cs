// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class ListHotTopicSummariesResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListHotTopicSummariesResponseBodyData> Data { get; set; }
        public class ListHotTopicSummariesResponseBodyData : TeaModel {
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("hotTopic")]
            [Validation(Required=false)]
            public string HotTopic { get; set; }

            [NameInMap("hotTopicVersion")]
            [Validation(Required=false)]
            public string HotTopicVersion { get; set; }

            [NameInMap("hotValue")]
            [Validation(Required=false)]
            public double? HotValue { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("news")]
            [Validation(Required=false)]
            public List<ListHotTopicSummariesResponseBodyDataNews> News { get; set; }
            public class ListHotTopicSummariesResponseBodyDataNews : TeaModel {
                [NameInMap("comments")]
                [Validation(Required=false)]
                public List<ListHotTopicSummariesResponseBodyDataNewsComments> Comments { get; set; }
                public class ListHotTopicSummariesResponseBodyDataNewsComments : TeaModel {
                    [NameInMap("text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("pubTime")]
                [Validation(Required=false)]
                public string PubTime { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// url
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("summary")]
            [Validation(Required=false)]
            public ListHotTopicSummariesResponseBodyDataSummary Summary { get; set; }
            public class ListHotTopicSummariesResponseBodyDataSummary : TeaModel {
                [NameInMap("summaries")]
                [Validation(Required=false)]
                public List<ListHotTopicSummariesResponseBodyDataSummarySummaries> Summaries { get; set; }
                public class ListHotTopicSummariesResponseBodyDataSummarySummaries : TeaModel {
                    [NameInMap("summary")]
                    [Validation(Required=false)]
                    public string Summary { get; set; }

                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

            }

            [NameInMap("textSummary")]
            [Validation(Required=false)]
            public string TextSummary { get; set; }

        }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
