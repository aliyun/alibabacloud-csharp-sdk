// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsMessageGetByMsgIdResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsMessageGetByMsgIdResponseBodyData Data { get; set; }
        public class OnsMessageGetByMsgIdResponseBodyData : TeaModel {
            [NameInMap("StoreSize")]
            [Validation(Required=false)]
            public int? StoreSize { get; set; }
            [NameInMap("ReconsumeTimes")]
            [Validation(Required=false)]
            public int? ReconsumeTimes { get; set; }
            [NameInMap("StoreTimestamp")]
            [Validation(Required=false)]
            public long? StoreTimestamp { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("MsgId")]
            [Validation(Required=false)]
            public string MsgId { get; set; }
            [NameInMap("StoreHost")]
            [Validation(Required=false)]
            public string StoreHost { get; set; }
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }
            [NameInMap("PropertyList")]
            [Validation(Required=false)]
            public List<OnsMessageGetByMsgIdResponseBodyDataPropertyList> PropertyList { get; set; }
            public class OnsMessageGetByMsgIdResponseBodyDataPropertyList : TeaModel {
                public string Value { get; set; }
                public string Name { get; set; }
            }
            [NameInMap("BornTimestamp")]
            [Validation(Required=false)]
            public long? BornTimestamp { get; set; }
            [NameInMap("BodyCRC")]
            [Validation(Required=false)]
            public int? BodyCRC { get; set; }
            [NameInMap("BornHost")]
            [Validation(Required=false)]
            public string BornHost { get; set; }
        };

    }

}
