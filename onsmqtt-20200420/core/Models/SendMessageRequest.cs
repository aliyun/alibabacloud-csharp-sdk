// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class SendMessageRequest : TeaModel {
        [NameInMap("MqttTopic")]
        [Validation(Required=false)]
        public string MqttTopic { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Payload")]
        [Validation(Required=false)]
        public string Payload { get; set; }

    }

}
