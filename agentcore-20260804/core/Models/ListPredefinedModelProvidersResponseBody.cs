// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListPredefinedModelProvidersResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListPredefinedModelProvidersResponseBodyData> Data { get; set; }
        public class ListPredefinedModelProvidersResponseBodyData : TeaModel {
            [NameInMap("defaultEndpoint")]
            [Validation(Required=false)]
            public string DefaultEndpoint { get; set; }

            [NameInMap("defaultProtocol")]
            [Validation(Required=false)]
            public string DefaultProtocol { get; set; }

            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("providerType")]
            [Validation(Required=false)]
            public string ProviderType { get; set; }

        }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
