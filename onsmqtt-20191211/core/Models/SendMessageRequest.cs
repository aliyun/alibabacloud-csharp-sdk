// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20191211.Models
{
    public class SendMessageRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("MqttTopic")]
        [Validation(Required=false)]
        public string MqttTopic { get; set; }

        [NameInMap("Payload")]
        [Validation(Required=false)]
        public string Payload { get; set; }

        [NameInMap("ReceiptId")]
        [Validation(Required=false)]
        public string ReceiptId { get; set; }

    }

}
