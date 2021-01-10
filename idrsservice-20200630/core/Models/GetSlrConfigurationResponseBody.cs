// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class GetSlrConfigurationResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSlrConfigurationResponseBodyData Data { get; set; }
        public class GetSlrConfigurationResponseBodyData : TeaModel {
            [NameInMap("MqGroupId")]
            [Validation(Required=false)]
            public string MqGroupId { get; set; }
            [NameInMap("MqTopic")]
            [Validation(Required=false)]
            public string MqTopic { get; set; }
            [NameInMap("MqInstanceId")]
            [Validation(Required=false)]
            public string MqInstanceId { get; set; }
            [NameInMap("MqEventList")]
            [Validation(Required=false)]
            public List<string> MqEventList { get; set; }
            [NameInMap("MqEndpoint")]
            [Validation(Required=false)]
            public string MqEndpoint { get; set; }
            [NameInMap("MqSubscribe")]
            [Validation(Required=false)]
            public bool? MqSubscribe { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
