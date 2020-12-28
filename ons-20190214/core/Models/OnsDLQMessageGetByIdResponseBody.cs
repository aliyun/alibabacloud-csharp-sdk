// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsDLQMessageGetByIdResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsDLQMessageGetByIdResponseBodyData Data { get; set; }
        public class OnsDLQMessageGetByIdResponseBodyData : TeaModel {
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
            public List<OnsDLQMessageGetByIdResponseBodyDataPropertyList> PropertyList { get; set; }
            public class OnsDLQMessageGetByIdResponseBodyDataPropertyList : TeaModel {
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
