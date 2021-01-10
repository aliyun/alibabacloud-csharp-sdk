// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryMqSofamqMessageByTopicResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryMqSofamqMessageByTopicResponseBodyData Data { get; set; }
        public class QueryMqSofamqMessageByTopicResponseBodyData : TeaModel {
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<QueryMqSofamqMessageByTopicResponseBodyDataContent> Content { get; set; }
            public class QueryMqSofamqMessageByTopicResponseBodyDataContent : TeaModel {
                public string Body { get; set; }
                public long? BodyCrc { get; set; }
                public string BornHost { get; set; }
                public long? BornTimestamp { get; set; }
                public string InstanceId { get; set; }
                public string MsgId { get; set; }
                public long? ReconsumeTimes { get; set; }
                public string StoreHost { get; set; }
                public long? StoreSize { get; set; }
                public long? StoreTimestamp { get; set; }
                public string Topic { get; set; }
                public List<QueryMqSofamqMessageByTopicResponseBodyDataContentPropertyList> PropertyList { get; set; }
                public class QueryMqSofamqMessageByTopicResponseBodyDataContentPropertyList : TeaModel {
                    public string Name { get; set; }
                    public string Value { get; set; }
                }
            }
        };

    }

}
