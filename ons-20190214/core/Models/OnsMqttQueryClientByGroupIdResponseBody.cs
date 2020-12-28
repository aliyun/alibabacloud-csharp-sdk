// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsMqttQueryClientByGroupIdResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MqttClientSetDo")]
        [Validation(Required=false)]
        public OnsMqttQueryClientByGroupIdResponseBodyMqttClientSetDo MqttClientSetDo { get; set; }
        public class OnsMqttQueryClientByGroupIdResponseBodyMqttClientSetDo : TeaModel {
            [NameInMap("OnlineCount")]
            [Validation(Required=false)]
            public long? OnlineCount { get; set; }
        };

    }

}
