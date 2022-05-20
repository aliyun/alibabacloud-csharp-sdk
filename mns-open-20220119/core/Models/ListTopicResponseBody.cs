// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class ListTopicResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTopicResponseBodyData Data { get; set; }
        public class ListTopicResponseBodyData : TeaModel {
            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<ListTopicResponseBodyDataPageData> PageData { get; set; }
            public class ListTopicResponseBodyDataPageData : TeaModel {
                public long? CreateTime { get; set; }
                public long? LastModifyTime { get; set; }
                public bool? LoggingEnabled { get; set; }
                public long? MaxMessageSize { get; set; }
                public long? MessageCount { get; set; }
                public long? MessageRetentionPeriod { get; set; }
                public string TopicInnerUrl { get; set; }
                public string TopicName { get; set; }
                public string TopicUrl { get; set; }
            }
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
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
