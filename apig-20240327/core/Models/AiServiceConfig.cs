// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiServiceConfig : TeaModel {
        /// <summary>
        /// <para>The generation mode of the API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Custom</para>
        /// </summary>
        [NameInMap("ApiKeyGenerateMode")]
        [Validation(Required=false)]
        public string ApiKeyGenerateMode { get; set; }

        /// <summary>
        /// <para>The service address.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://dashscope.aliyun.com">https://dashscope.aliyun.com</a></para>
        /// </summary>
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>The list of API keys.</para>
        /// </summary>
        [NameInMap("apiKeys")]
        [Validation(Required=false)]
        public List<string> ApiKeys { get; set; }

        /// <summary>
        /// <para>The configuration specific to the Bedrock service.</para>
        /// </summary>
        [NameInMap("bedrockServiceConfig")]
        [Validation(Required=false)]
        public AiServiceConfigBedrockServiceConfig BedrockServiceConfig { get; set; }
        public class AiServiceConfigBedrockServiceConfig : TeaModel {
            /// <summary>
            /// <para>The AWS access key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AKIAIOSFODNN7EXAMPLE</para>
            /// </summary>
            [NameInMap("awsAccessKey")]
            [Validation(Required=false)]
            public string AwsAccessKey { get; set; }

            /// <summary>
            /// <para>The AWS region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>us-east-1</para>
            /// </summary>
            [NameInMap("awsRegion")]
            [Validation(Required=false)]
            public string AwsRegion { get; set; }

            /// <summary>
            /// <para>The AWS secret key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY</para>
            /// </summary>
            [NameInMap("awsSecretKey")]
            [Validation(Required=false)]
            public string AwsSecretKey { get; set; }

        }

        /// <summary>
        /// <para>The list of compatible protocols supported by the service.</para>
        /// </summary>
        [NameInMap("compatibleProtocols")]
        [Validation(Required=false)]
        public List<string> CompatibleProtocols { get; set; }

        /// <summary>
        /// <para>The name of the default model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gpt-4</para>
        /// </summary>
        [NameInMap("defaultModelName")]
        [Validation(Required=false)]
        public string DefaultModelName { get; set; }

        /// <summary>
        /// <para>Indicates whether health check is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableHealthCheck")]
        [Validation(Required=false)]
        public bool? EnableHealthCheck { get; set; }

        /// <summary>
        /// <para>Indicates whether outlier detection is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableOutlierDetection")]
        [Validation(Required=false)]
        public bool? EnableOutlierDetection { get; set; }

        /// <summary>
        /// <para>The configuration specific to the PAI-EAS service.</para>
        /// </summary>
        [NameInMap("paiEASServiceConfig")]
        [Validation(Required=false)]
        public AiServiceConfigPaiEASServiceConfig PaiEASServiceConfig { get; set; }
        public class AiServiceConfigPaiEASServiceConfig : TeaModel {
            /// <summary>
            /// <para>The connection type: private network (vpc) or public network (public).</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;public&quot;，&quot;private&quot;</para>
            /// </summary>
            [NameInMap("endpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            /// <summary>
            /// <para>The service ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>svc-cvaeb0um1hkqp79k72v0</para>
            /// </summary>
            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>The service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>auto-ai-service</para>
            /// </summary>
            [NameInMap("serviceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cb89d4de30042df4459442589664e00d</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The list of model protocols.</para>
        /// </summary>
        [NameInMap("protocols")]
        [Validation(Required=false)]
        public List<string> Protocols { get; set; }

        /// <summary>
        /// <para>The large language model provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen
        /// moonshot
        /// baichuan
        /// yi
        /// zhipuai
        /// 360ai
        /// hunyuan
        /// stepfun
        /// spark
        /// openai
        /// claude
        /// anthropic
        /// doubao
        /// minimax
        /// gemini
        /// azure
        /// deepseek
        /// custom
        /// pai-eas
        /// bedrock
        /// vertex</para>
        /// </summary>
        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>The configuration of the Vertex AI service.</para>
        /// </summary>
        [NameInMap("vertexServiceConfig")]
        [Validation(Required=false)]
        public AiServiceConfigVertexServiceConfig VertexServiceConfig { get; set; }
        public class AiServiceConfigVertexServiceConfig : TeaModel {
            /// <summary>
            /// <para>The safety filtering level settings for the Gemini model.</para>
            /// </summary>
            [NameInMap("geminiSafetySetting")]
            [Validation(Required=false)]
            public Dictionary<string, string> GeminiSafetySetting { get; set; }

            /// <summary>
            /// <para>The authentication key for Vertex AI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;type\&quot;:\&quot;service_account\&quot;,\&quot;project_id\&quot;:\&quot;my-project\&quot;,\&quot;private_key\&quot;:\&quot;-----BEGIN PRIVATE KEY-----...\&quot;,\&quot;client_email\&quot;:\&quot;<a href="mailto:xxx@xxx.iam.gserviceaccount.com">xxx@xxx.iam.gserviceaccount.com</a>\&quot;,\&quot;token_uri\&quot;:\&quot;<a href="https://oauth2.googleapis.com/token%5C%5C%22%7D">https://oauth2.googleapis.com/token\\&quot;}</a></para>
            /// </summary>
            [NameInMap("vertexAuthKey")]
            [Validation(Required=false)]
            public string VertexAuthKey { get; set; }

            /// <summary>
            /// <para>The service name of the authentication service used by Vertex AI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>google-oauth2</para>
            /// </summary>
            [NameInMap("vertexAuthServiceName")]
            [Validation(Required=false)]
            public string VertexAuthServiceName { get; set; }

            /// <summary>
            /// <para>The Google Cloud project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-project</para>
            /// </summary>
            [NameInMap("vertexProjectId")]
            [Validation(Required=false)]
            public string VertexProjectId { get; set; }

            /// <summary>
            /// <para>The Google Cloud region where the Vertex AI service is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>us-central1</para>
            /// </summary>
            [NameInMap("vertexRegion")]
            [Validation(Required=false)]
            public string VertexRegion { get; set; }

            /// <summary>
            /// <para>The number of seconds before the access token expires to refresh it in advance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("vertexTokenRefreshAhead")]
            [Validation(Required=false)]
            public int? VertexTokenRefreshAhead { get; set; }

        }

    }

}
