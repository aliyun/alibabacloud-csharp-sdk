// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListSubscribeDeviceResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ListSubscribeDeviceResponseData Data { get; set; }
        public class ListSubscribeDeviceResponseData : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public int? TotalCount { get; set; }
            [NameInMap("SubscribeList")]
            [Validation(Required=true)]
            public List<ListSubscribeDeviceResponseDataSubscribeList> SubscribeList { get; set; }
            public class ListSubscribeDeviceResponseDataSubscribeList : TeaModel {
                public string UserId { get; set; }
                public string DeviceId { get; set; }
                public string PushConfig { get; set; }
                public string CreateTime { get; set; }
                public string UpdateTime { get; set; }
            }
        };

    }

}
