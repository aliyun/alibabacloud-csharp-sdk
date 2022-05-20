// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class ListSubscriptionByTopicResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListSubscriptionByTopicResponseBodyData Data { get; set; }
        public class ListSubscriptionByTopicResponseBodyData : TeaModel {
            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<ListSubscriptionByTopicResponseBodyDataPageData> PageData { get; set; }
            public class ListSubscriptionByTopicResponseBodyDataPageData : TeaModel {
                public long? CreateTime { get; set; }
                public string Endpoint { get; set; }
                public string FilterTag { get; set; }
                public long? LastModifyTime { get; set; }
                public string NotifyContentFormat { get; set; }
                public string NotifyStrategy { get; set; }
                public string SubscriptionName { get; set; }
                public string SubscriptionURL { get; set; }
                public string TopicName { get; set; }
                public string TopicOwner { get; set; }
            }
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("Pages")]
            [Validation(Required=false)]
            public long? Pages { get; set; }
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
