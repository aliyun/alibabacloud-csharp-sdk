// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateModelConnectionRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateModelConnectionRequestBody Body { get; set; }
        public class UpdateModelConnectionRequestBody : TeaModel {
            [NameInMap("apiKeys")]
            [Validation(Required=false)]
            public List<string> ApiKeys { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("providerType")]
            [Validation(Required=false)]
            public string ProviderType { get; set; }

        }

        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
