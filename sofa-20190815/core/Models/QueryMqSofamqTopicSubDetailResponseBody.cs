// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryMqSofamqTopicSubDetailResponseBody : TeaModel {
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
        public QueryMqSofamqTopicSubDetailResponseBodyData Data { get; set; }
        public class QueryMqSofamqTopicSubDetailResponseBodyData : TeaModel {
            [NameInMap("LatestSendTime")]
            [Validation(Required=false)]
            public long? LatestSendTime { get; set; }
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }
            [NameInMap("SubscriptionDataList")]
            [Validation(Required=false)]
            public List<QueryMqSofamqTopicSubDetailResponseBodyDataSubscriptionDataList> SubscriptionDataList { get; set; }
            public class QueryMqSofamqTopicSubDetailResponseBodyDataSubscriptionDataList : TeaModel {
                public string GroupId { get; set; }
                public string MessageModel { get; set; }
                public string SubString { get; set; }
            }
        };

    }

}
