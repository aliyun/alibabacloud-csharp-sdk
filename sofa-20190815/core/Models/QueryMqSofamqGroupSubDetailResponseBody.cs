// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryMqSofamqGroupSubDetailResponseBody : TeaModel {
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
        public QueryMqSofamqGroupSubDetailResponseBodyData Data { get; set; }
        public class QueryMqSofamqGroupSubDetailResponseBodyData : TeaModel {
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }
            [NameInMap("MessageModel")]
            [Validation(Required=false)]
            public string MessageModel { get; set; }
            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }
            [NameInMap("SubscriptionDataList")]
            [Validation(Required=false)]
            public List<QueryMqSofamqGroupSubDetailResponseBodyDataSubscriptionDataList> SubscriptionDataList { get; set; }
            public class QueryMqSofamqGroupSubDetailResponseBodyDataSubscriptionDataList : TeaModel {
                public bool? Online { get; set; }
                public string SubString { get; set; }
                public string Topic { get; set; }
            }
        };

    }

}
