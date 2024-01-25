// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MindLive20210301.Models
{
    public class RequestBindingStateResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RequestBindingStateResponseBodyData Data { get; set; }
        public class RequestBindingStateResponseBodyData : TeaModel {
            [NameInMap("BindAt")]
            [Validation(Required=false)]
            public long? BindAt { get; set; }

            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            [NameInMap("UserAvatar")]
            [Validation(Required=false)]
            public string UserAvatar { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("UserNick")]
            [Validation(Required=false)]
            public string UserNick { get; set; }

            [NameInMap("UserSource")]
            [Validation(Required=false)]
            public string UserSource { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
