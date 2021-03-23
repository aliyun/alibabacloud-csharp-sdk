// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class DescribeMqttMessageResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public DescribeMqttMessageResponseBodyMessage Message { get; set; }
        public class DescribeMqttMessageResponseBodyMessage : TeaModel {
            [NameInMap("Mid")]
            [Validation(Required=false)]
            public string Mid { get; set; }
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }
            [NameInMap("QoS")]
            [Validation(Required=false)]
            public int? QoS { get; set; }
            [NameInMap("Payload")]
            [Validation(Required=false)]
            public string Payload { get; set; }
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }
        };

    }

}
