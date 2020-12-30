// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMessageCallbackResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MessageCallback")]
        [Validation(Required=false)]
        public GetMessageCallbackResponseBodyMessageCallback MessageCallback { get; set; }
        public class GetMessageCallbackResponseBodyMessageCallback : TeaModel {
            [NameInMap("CallbackType")]
            [Validation(Required=false)]
            public string CallbackType { get; set; }
            [NameInMap("CallbackURL")]
            [Validation(Required=false)]
            public string CallbackURL { get; set; }
            [NameInMap("EventTypeList")]
            [Validation(Required=false)]
            public string EventTypeList { get; set; }
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("MnsQueueName")]
            [Validation(Required=false)]
            public string MnsQueueName { get; set; }
            [NameInMap("AuthKey")]
            [Validation(Required=false)]
            public string AuthKey { get; set; }
            [NameInMap("AuthSwitch")]
            [Validation(Required=false)]
            public string AuthSwitch { get; set; }
            [NameInMap("MnsEndpoint")]
            [Validation(Required=false)]
            public string MnsEndpoint { get; set; }
        };

    }

}
