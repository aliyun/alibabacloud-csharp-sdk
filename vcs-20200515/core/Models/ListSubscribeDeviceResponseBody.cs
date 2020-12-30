// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListSubscribeDeviceResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListSubscribeDeviceResponseBodyData Data { get; set; }
        public class ListSubscribeDeviceResponseBodyData : TeaModel {
            [NameInMap("SubscribeList")]
            [Validation(Required=false)]
            public List<ListSubscribeDeviceResponseBodyDataSubscribeList> SubscribeList { get; set; }
            public class ListSubscribeDeviceResponseBodyDataSubscribeList : TeaModel {
                public string PushConfig { get; set; }
                public string UpdateTime { get; set; }
                public string DeviceId { get; set; }
                public string CreateTime { get; set; }
                public string UserId { get; set; }
            }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
