// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListHotNewsWithTypeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListHotNewsWithTypeResponseBodyData> Data { get; set; }
        public class ListHotNewsWithTypeResponseBodyData : TeaModel {
            [NameInMap("News")]
            [Validation(Required=false)]
            public List<ListHotNewsWithTypeResponseBodyDataNews> News { get; set; }
            public class ListHotNewsWithTypeResponseBodyDataNews : TeaModel {
                [NameInMap("Author")]
                [Validation(Required=false)]
                public string Author { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("DocUuid")]
                [Validation(Required=false)]
                public string DocUuid { get; set; }

                [NameInMap("ImageUrls")]
                [Validation(Required=false)]
                public List<string> ImageUrls { get; set; }

                [NameInMap("PubTime")]
                [Validation(Required=false)]
                public string PubTime { get; set; }

                [NameInMap("SearchSource")]
                [Validation(Required=false)]
                public string SearchSource { get; set; }

                [NameInMap("SearchSourceName")]
                [Validation(Required=false)]
                public string SearchSourceName { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("NewsType")]
            [Validation(Required=false)]
            public string NewsType { get; set; }

            [NameInMap("NewsTypeName")]
            [Validation(Required=false)]
            public string NewsTypeName { get; set; }

            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

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
