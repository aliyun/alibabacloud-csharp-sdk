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
        /// <para>The configuration for API key failure ejection and recovery.</para>
        /// </summary>
        [NameInMap("apiKeyFailover")]
        [Validation(Required=false)]
        public AiServiceConfigApiKeyFailover ApiKeyFailover { get; set; }
        public class AiServiceConfigApiKeyFailover : TeaModel {
            /// <summary>
            /// <para>The cooldown duration after an API key is ejected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000</para>
            /// </summary>
            [NameInMap("cooldownDuration")]
            [Validation(Required=false)]
            public long? CooldownDuration { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable API key failure ejection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The set of response status matching rules that trigger API key failure ejection.</para>
            /// </summary>
            [NameInMap("failoverOnStatus")]
            [Validation(Required=false)]
            public List<string> FailoverOnStatus { get; set; }

            /// <summary>
            /// <para>The failure count threshold that triggers API key ejection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("failureThreshold")]
            [Validation(Required=false)]
            public long? FailureThreshold { get; set; }

        }

        /// <summary>
        /// <para>The read-only summary of KMS reference names, excluding credential values.</para>
        /// </summary>
        [NameInMap("apiKeyReferences")]
        [Validation(Required=false)]
        public List<string> ApiKeyReferences { get; set; }

        /// <summary>
        /// <para>The list of API keys.</para>
        /// </summary>
        [NameInMap("apiKeys")]
        [Validation(Required=false)]
        public List<string> ApiKeys { get; set; }

        /// <summary>
        /// <para>The name of the request header used to pass authentication credentials to the upstream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Authorization</para>
        /// </summary>
        [NameInMap("authHeaderKey")]
        [Validation(Required=false)]
        public string AuthHeaderKey { get; set; }

        /// <summary>
        /// <para>The Bedrock service-specific configuration.</para>
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

            /// <summary>
            /// <para>Configures whether to insert Bedrock cache markers based on prompt positions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;systemPrompt&quot;:true}</para>
            /// </summary>
            [NameInMap("bedrockPromptCachePointPositions")]
            [Validation(Required=false)]
            public Dictionary<string, bool?> BedrockPromptCachePointPositions { get; set; }

            /// <summary>
            /// <para>The Bedrock service endpoint mode, which supports runtime and mantle. If omitted, runtime is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>runtime</para>
            /// </summary>
            [NameInMap("endpointMode")]
            [Validation(Required=false)]
            public string EndpointMode { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable prompt caching for the Bedrock upstream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("promptCacheEnable")]
            [Validation(Required=false)]
            public bool? PromptCacheEnable { get; set; }

            /// <summary>
            /// <para>The data retention policy for the prompt cache.</para>
            /// 
            /// <b>Example:</b>
            /// <para>in_memory</para>
            /// </summary>
            [NameInMap("promptCacheRetention")]
            [Validation(Required=false)]
            public string PromptCacheRetention { get; set; }

            /// <summary>
            /// <para>The applicable model strategy for Bedrock prompt caching.</para>
            /// 
            /// <b>Example:</b>
            /// <para>supported_models_only</para>
            /// </summary>
            [NameInMap("promptCacheStrategy")]
            [Validation(Required=false)]
            public string PromptCacheStrategy { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable Claude Code compatibility mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("claudeCodeMode")]
        [Validation(Required=false)]
        public bool? ClaudeCodeMode { get; set; }

        /// <summary>
        /// <para>The list of compatible protocols supported by the service.</para>
        /// </summary>
        [NameInMap("compatibleProtocols")]
        [Validation(Required=false)]
        public List<string> CompatibleProtocols { get; set; }

        /// <summary>
        /// <para>The read-only service configuration version. Use expectedConfigRevision for conditional updates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7e4f52a9b0c34d16a268e913f5c2087b</para>
        /// </summary>
        [NameInMap("configRevision")]
        [Validation(Required=false)]
        public string ConfigRevision { get; set; }

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
        /// <para>Specifies whether to enable health checks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableHealthCheck")]
        [Validation(Required=false)]
        public bool? EnableHealthCheck { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the outlier detection feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableOutlierDetection")]
        [Validation(Required=false)]
        public bool? EnableOutlierDetection { get; set; }

        /// <summary>
        /// <para>The authentication and token configuration specific to the KlingAI service.</para>
        /// </summary>
        [NameInMap("klingServiceConfig")]
        [Validation(Required=false)]
        public AiServiceConfigKlingServiceConfig KlingServiceConfig { get; set; }
        public class AiServiceConfigKlingServiceConfig : TeaModel {
            /// <summary>
            /// <para>The KlingAI access key identifier. Examples use desensitized values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kling-access-key-****</para>
            /// </summary>
            [NameInMap("klingAccessKey")]
            [Validation(Required=false)]
            public string KlingAccessKey { get; set; }

            /// <summary>
            /// <para>The KlingAI secret key. Examples use desensitized values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kling-secret-key-****</para>
            /// </summary>
            [NameInMap("klingSecretKey")]
            [Validation(Required=false)]
            public string KlingSecretKey { get; set; }

            /// <summary>
            /// <para>The advance refresh configuration for KlingAI tokens.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("klingTokenRefreshAhead")]
            [Validation(Required=false)]
            public long? KlingTokenRefreshAhead { get; set; }

        }

        /// <summary>
        /// <para>The PAI-EAS service-specific configuration.</para>
        /// </summary>
        [NameInMap("paiEASServiceConfig")]
        [Validation(Required=false)]
        public AiServiceConfigPaiEASServiceConfig PaiEASServiceConfig { get; set; }
        public class AiServiceConfigPaiEASServiceConfig : TeaModel {
            /// <summary>
            /// <para>The connection type, which can be a private network (VPC) or a public network.</para>
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
        /// <para>The configuration for retrying with a different key after the current request fails.</para>
        /// </summary>
        [NameInMap("retryOnFailure")]
        [Validation(Required=false)]
        public AiServiceConfigRetryOnFailure RetryOnFailure { get; set; }
        public class AiServiceConfigRetryOnFailure : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable retries upon current request failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The maximum number of retries for the current request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("maxRetries")]
            [Validation(Required=false)]
            public long? MaxRetries { get; set; }

            /// <summary>
            /// <para>The set of response status matching rules that trigger retries for the current request.</para>
            /// </summary>
            [NameInMap("retryOnStatus")]
            [Validation(Required=false)]
            public List<string> RetryOnStatus { get; set; }

            /// <summary>
            /// <para>The retry timeout configuration for the current request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000</para>
            /// </summary>
            [NameInMap("retryTimeout")]
            [Validation(Required=false)]
            public long? RetryTimeout { get; set; }

        }

        /// <summary>
        /// <para>The upstream authentication mode, which distinguishes between API key authentication, no authentication, and pass-through downstream authentication.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api-key</para>
        /// </summary>
        [NameInMap("upstreamAuthMode")]
        [Validation(Required=false)]
        public string UpstreamAuthMode { get; set; }

        /// <summary>
        /// <para>The configuration information for the Vertex AI service.</para>
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
            /// <para>The authentication service name used by Vertex AI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>google-oauth2</para>
            /// </summary>
            [NameInMap("vertexAuthServiceName")]
            [Validation(Required=false)]
            public string VertexAuthServiceName { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the OpenAI-compatible interface of Vertex AI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("vertexOpenAICompatible")]
            [Validation(Required=false)]
            public bool? VertexOpenAICompatible { get; set; }

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
            /// <para>The number of seconds before access token expiration to trigger an advance refresh.</para>
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
