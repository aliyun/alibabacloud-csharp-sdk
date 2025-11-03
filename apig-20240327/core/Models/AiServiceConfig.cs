// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiServiceConfig : TeaModel {
        [NameInMap("ApiKeyGenerateMode")]
        [Validation(Required=false)]
        public string ApiKeyGenerateMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://dashscope.aliyun.com">https://dashscope.aliyun.com</a></para>
        /// </summary>
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("apiKeys")]
        [Validation(Required=false)]
        public List<string> ApiKeys { get; set; }

        [NameInMap("bedrockServiceConfig")]
        [Validation(Required=false)]
        public AiServiceConfigBedrockServiceConfig BedrockServiceConfig { get; set; }
        public class AiServiceConfigBedrockServiceConfig : TeaModel {
            [NameInMap("awsAccessKey")]
            [Validation(Required=false)]
            public string AwsAccessKey { get; set; }

            [NameInMap("awsRegion")]
            [Validation(Required=false)]
            public string AwsRegion { get; set; }

            [NameInMap("awsSecretKey")]
            [Validation(Required=false)]
            public string AwsSecretKey { get; set; }

        }

        [NameInMap("enableHealthCheck")]
        [Validation(Required=false)]
        public bool? EnableHealthCheck { get; set; }

        [NameInMap("paiEASServiceConfig")]
        [Validation(Required=false)]
        public AiServiceConfigPaiEASServiceConfig PaiEASServiceConfig { get; set; }
        public class AiServiceConfigPaiEASServiceConfig : TeaModel {
            [NameInMap("endpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            [NameInMap("serviceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        [NameInMap("protocols")]
        [Validation(Required=false)]
        public List<string> Protocols { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen</para>
        /// </summary>
        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

    }

}
