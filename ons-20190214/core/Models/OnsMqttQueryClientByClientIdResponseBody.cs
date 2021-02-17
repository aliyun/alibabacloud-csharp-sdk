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
            public OnsMqttQueryClientByClientIdResponseBodyMqttClientInfoDoSubScriptonData SubScriptonData { get; set; }
            public class OnsMqttQueryClientByClientIdResponseBodyMqttClientInfoDoSubScriptonData : TeaModel {
                [NameInMap("SubscriptionDo")]
                [Validation(Required=false)]
                public List<OnsMqttQueryClientByClientIdResponseBodyMqttClientInfoDoSubScriptonDataSubscriptionDo> SubscriptionDo { get; set; }
                public class OnsMqttQueryClientByClientIdResponseBodyMqttClientInfoDoSubScriptonDataSubscriptionDo : TeaModel {
                    [NameInMap("SubTopic")]
                    [Validation(Required=false)]
                    public string SubTopic { get; set; }

                    [NameInMap("ParentTopic")]
                    [Validation(Required=false)]
                    public string ParentTopic { get; set; }

                    [NameInMap("Qos")]
                    [Validation(Required=false)]
                    public int? Qos { get; set; }

                }

            }
        };

    }

}
