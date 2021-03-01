// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetMockRuleByProviderAppIdResponseBody : TeaModel {
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetMockRuleByProviderAppIdResponseBodyData> Data { get; set; }
        public class GetMockRuleByProviderAppIdResponseBodyData : TeaModel {
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            [NameInMap("ScMockItemJson")]
            [Validation(Required=false)]
            public string ScMockItemJson { get; set; }

            [NameInMap("ConsumerAppName")]
            [Validation(Required=false)]
            public string ConsumerAppName { get; set; }

            [NameInMap("ConsumerAppId")]
            [Validation(Required=false)]
            public string ConsumerAppId { get; set; }

            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("ExtraJson")]
            [Validation(Required=false)]
            public string ExtraJson { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("ProviderAppId")]
            [Validation(Required=false)]
            public string ProviderAppId { get; set; }

            [NameInMap("ProviderAppName")]
            [Validation(Required=false)]
            public string ProviderAppName { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
