// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryTopicConfigResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTopicConfigResponseBodyData Data { get; set; }
        public class QueryTopicConfigResponseBodyData : TeaModel {
            [NameInMap("TopicConfigInfo")]
            [Validation(Required=false)]
            public List<QueryTopicConfigResponseBodyDataTopicConfigInfo> TopicConfigInfo { get; set; }
            public class QueryTopicConfigResponseBodyDataTopicConfigInfo : TeaModel {
                [NameInMap("Codec")]
                [Validation(Required=false)]
                public string Codec { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EnableBroadcast")]
                [Validation(Required=false)]
                public bool? EnableBroadcast { get; set; }

                [NameInMap("EnableProxySubscribe")]
                [Validation(Required=false)]
                public bool? EnableProxySubscribe { get; set; }

                [NameInMap("Operation")]
                [Validation(Required=false)]
                public string Operation { get; set; }

                [NameInMap("ProductKey")]
                [Validation(Required=false)]
                public string ProductKey { get; set; }

                [NameInMap("TopicFullName")]
                [Validation(Required=false)]
                public string TopicFullName { get; set; }

            }

        }

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
