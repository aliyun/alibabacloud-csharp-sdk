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
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("LastModifyTime")]
                [Validation(Required=false)]
                public long? LastModifyTime { get; set; }

                [NameInMap("LoggingEnabled")]
                [Validation(Required=false)]
                public bool? LoggingEnabled { get; set; }

                [NameInMap("MaxMessageSize")]
                [Validation(Required=false)]
                public long? MaxMessageSize { get; set; }

                [NameInMap("MessageCount")]
                [Validation(Required=false)]
                public long? MessageCount { get; set; }

                [NameInMap("MessageRetentionPeriod")]
                [Validation(Required=false)]
                public long? MessageRetentionPeriod { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListTopicResponseBodyDataPageDataTags> Tags { get; set; }
                public class ListTopicResponseBodyDataPageDataTags : TeaModel {
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

                [NameInMap("TopicInnerUrl")]
                [Validation(Required=false)]
                public string TopicInnerUrl { get; set; }

                [NameInMap("TopicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

                [NameInMap("TopicUrl")]
                [Validation(Required=false)]
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

        }

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
