// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsMqttQueryClientByClientIdResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MqttClientInfoDo")]
        [Validation(Required=false)]
        public OnsMqttQueryClientByClientIdResponseBodyMqttClientInfoDo MqttClientInfoDo { get; set; }
        public class OnsMqttQueryClientByClientIdResponseBodyMqttClientInfoDo : TeaModel {
            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }
            [NameInMap("LastTouch")]
            [Validation(Required=false)]
            public long? LastTouch { get; set; }
            [NameInMap("SocketChannel")]
            [Validation(Required=false)]
            public string SocketChannel { get; set; }
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }
            [NameInMap("SubScriptonData")]
            [Validation(Required=false)]
            public List<OnsMqttQueryClientByClientIdResponseBodyMqttClientInfoDoSubScriptonData> SubScriptonData { get; set; }
            public class OnsMqttQueryClientByClientIdResponseBodyMqttClientInfoDoSubScriptonData : TeaModel {
                public string SubTopic { get; set; }
                public string ParentTopic { get; set; }
                public int? Qos { get; set; }
            }
        };

    }

}
