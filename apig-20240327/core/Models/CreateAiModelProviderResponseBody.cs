// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateAiModelProviderResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateAiModelProviderResponseBodyData Data { get; set; }
        public class CreateAiModelProviderResponseBodyData : TeaModel {
            [NameInMap("boundServices")]
            [Validation(Required=false)]
            public List<ServiceInfo> BoundServices { get; set; }

            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            [NameInMap("modelCards")]
            [Validation(Required=false)]
            public List<CreateAiModelProviderResponseBodyDataModelCards> ModelCards { get; set; }
            public class CreateAiModelProviderResponseBodyDataModelCards : TeaModel {
                [NameInMap("availablePaths")]
                [Validation(Required=false)]
                public List<CreateAiModelProviderResponseBodyDataModelCardsAvailablePaths> AvailablePaths { get; set; }
                public class CreateAiModelProviderResponseBodyDataModelCardsAvailablePaths : TeaModel {
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("credit")]
                [Validation(Required=false)]
                public CreateAiModelProviderResponseBodyDataModelCardsCredit Credit { get; set; }
                public class CreateAiModelProviderResponseBodyDataModelCardsCredit : TeaModel {
                    [NameInMap("cacheCost")]
                    [Validation(Required=false)]
                    public float? CacheCost { get; set; }

                    [NameInMap("inputCost")]
                    [Validation(Required=false)]
                    public float? InputCost { get; set; }

                    [NameInMap("outputCost")]
                    [Validation(Required=false)]
                    public float? OutputCost { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("features")]
                [Validation(Required=false)]
                public Dictionary<string, object> Features { get; set; }

                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                [NameInMap("meta")]
                [Validation(Required=false)]
                public CreateAiModelProviderResponseBodyDataModelCardsMeta Meta { get; set; }
                public class CreateAiModelProviderResponseBodyDataModelCardsMeta : TeaModel {
                    [NameInMap("maxInputTokens")]
                    [Validation(Required=false)]
                    public long? MaxInputTokens { get; set; }

                    [NameInMap("maxOutputTokens")]
                    [Validation(Required=false)]
                    public long? MaxOutputTokens { get; set; }

                    [NameInMap("maxTokens")]
                    [Validation(Required=false)]
                    public long? MaxTokens { get; set; }

                    [NameInMap("supportedInputModalities")]
                    [Validation(Required=false)]
                    public List<string> SupportedInputModalities { get; set; }

                    [NameInMap("supportedOutputModalities")]
                    [Validation(Required=false)]
                    public List<string> SupportedOutputModalities { get; set; }

                }

                [NameInMap("modelCardId")]
                [Validation(Required=false)]
                public string ModelCardId { get; set; }

                [NameInMap("modelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                [NameInMap("modelProvider")]
                [Validation(Required=false)]
                public string ModelProvider { get; set; }

                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            [NameInMap("modelCount")]
            [Validation(Required=false)]
            public int? ModelCount { get; set; }

            [NameInMap("modelProviderId")]
            [Validation(Required=false)]
            public string ModelProviderId { get; set; }

            [NameInMap("provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
