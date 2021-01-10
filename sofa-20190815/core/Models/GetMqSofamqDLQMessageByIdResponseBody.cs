// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetMqSofamqDLQMessageByIdResponseBody : TeaModel {
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
        public GetMqSofamqDLQMessageByIdResponseBodyData Data { get; set; }
        public class GetMqSofamqDLQMessageByIdResponseBodyData : TeaModel {
            [NameInMap("Body")]
            [Validation(Required=false)]
            public string Body { get; set; }
            [NameInMap("BodyCrc")]
            [Validation(Required=false)]
            public long? BodyCrc { get; set; }
            [NameInMap("BornHost")]
            [Validation(Required=false)]
            public string BornHost { get; set; }
            [NameInMap("BornTimestamp")]
            [Validation(Required=false)]
            public long? BornTimestamp { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("MsgId")]
            [Validation(Required=false)]
            public string MsgId { get; set; }
            [NameInMap("ReconsumeTimes")]
            [Validation(Required=false)]
            public long? ReconsumeTimes { get; set; }
            [NameInMap("StoreHost")]
            [Validation(Required=false)]
            public string StoreHost { get; set; }
            [NameInMap("StoreSize")]
            [Validation(Required=false)]
            public long? StoreSize { get; set; }
            [NameInMap("StoreTimestamp")]
            [Validation(Required=false)]
            public long? StoreTimestamp { get; set; }
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }
            [NameInMap("PropertyList")]
            [Validation(Required=false)]
            public List<GetMqSofamqDLQMessageByIdResponseBodyDataPropertyList> PropertyList { get; set; }
            public class GetMqSofamqDLQMessageByIdResponseBodyDataPropertyList : TeaModel {
                public string Name { get; set; }
                public string Value { get; set; }
            }
        };

    }

}
