// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsDLQMessagePageQueryByGroupIdResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MsgFoundDo")]
        [Validation(Required=false)]
        public OnsDLQMessagePageQueryByGroupIdResponseBodyMsgFoundDo MsgFoundDo { get; set; }
        public class OnsDLQMessagePageQueryByGroupIdResponseBodyMsgFoundDo : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }
            [NameInMap("MsgFoundList")]
            [Validation(Required=false)]
            public List<OnsDLQMessagePageQueryByGroupIdResponseBodyMsgFoundDoMsgFoundList> MsgFoundList { get; set; }
            public class OnsDLQMessagePageQueryByGroupIdResponseBodyMsgFoundDoMsgFoundList : TeaModel {
                public int? StoreSize { get; set; }
                public int? ReconsumeTimes { get; set; }
                public long? StoreTimestamp { get; set; }
                public string InstanceId { get; set; }
                public string MsgId { get; set; }
                public string StoreHost { get; set; }
                public string Topic { get; set; }
                public List<OnsDLQMessagePageQueryByGroupIdResponseBodyMsgFoundDoMsgFoundListPropertyList> PropertyList { get; set; }
                public class OnsDLQMessagePageQueryByGroupIdResponseBodyMsgFoundDoMsgFoundListPropertyList : TeaModel {
                    public string Value { get; set; }
                    public string Name { get; set; }
                }
                public long? BornTimestamp { get; set; }
                public int? BodyCRC { get; set; }
                public string BornHost { get; set; }
            }
            [NameInMap("MaxPageCount")]
            [Validation(Required=false)]
            public long? MaxPageCount { get; set; }
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }
        };

    }

}
