// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelService20220614.Models
{
    public class GetUserResponseBody : TeaModel {
        [NameInMap("AnthropicHost")]
        [Validation(Required=false)]
        public string AnthropicHost { get; set; }

        [NameInMap("ApiKeys")]
        [Validation(Required=false)]
        public List<GetUserResponseBodyApiKeys> ApiKeys { get; set; }
        public class GetUserResponseBodyApiKeys : TeaModel {
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            [NameInMap("InnerApiKey")]
            [Validation(Required=false)]
            public string InnerApiKey { get; set; }

        }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        [NameInMap("InnerToken")]
        [Validation(Required=false)]
        public string InnerToken { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
