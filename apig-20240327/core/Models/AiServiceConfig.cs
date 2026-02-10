// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiServiceConfig : TeaModel {
        /// <summary>
        /// <para>API key generation mode.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("ApiKeyGenerateMode")]
        [Validation(Required=false)]
        public string ApiKeyGenerateMode { get; set; }

        /// <summary>
        /// <para>The service endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://dashscope.aliyun.com">https://dashscope.aliyun.com</a></para>
        /// </summary>
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>The API keys.</para>
        /// </summary>
        [NameInMap("apiKeys")]
        [Validation(Required=false)]
        public List<string> ApiKeys { get; set; }

        /// <summary>
        /// <para>Bedrock service configuration.</para>
        /// </summary>
        [NameInMap("bedrockServiceConfig")]
        [Validation(Required=false)]
        public AiServiceConfigBedrockServiceConfig BedrockServiceConfig { get; set; }
        public class AiServiceConfigBedrockServiceConfig : TeaModel {
            /// <summary>
            /// <para>AWS-AccessKey</para>
            /// 
            /// <b>Example:</b>
            /// <para>AKIAIOSFODNN7EXAMPLE</para>
            /// </summary>
            [NameInMap("awsAccessKey")]
            [Validation(Required=false)]
            public string AwsAccessKey { get; set; }

            /// <summary>
            /// <para>AWS-Region</para>
            /// 
            /// <b>Example:</b>
            /// <para>us-west-2</para>
            /// </summary>
            [NameInMap("awsRegion")]
            [Validation(Required=false)]
            public string AwsRegion { get; set; }

            /// <summary>
            /// <para>AWS-SecretKey</para>
            /// 
            /// <b>Example:</b>
            /// <para>wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY</para>
            /// </summary>
            [NameInMap("awsSecretKey")]
            [Validation(Required=false)]
            public string AwsSecretKey { get; set; }

        }

        /// <summary>
        /// <para>Supported compatible protocols.</para>
        /// </summary>
        [NameInMap("compatibleProtocols")]
        [Validation(Required=false)]
        public List<string> CompatibleProtocols { get; set; }

        /// <summary>
        /// <para>Default model name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-turbo</para>
        /// </summary>
        [NameInMap("defaultModelName")]
        [Validation(Required=false)]
        public string DefaultModelName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable health check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableHealthCheck")]
        [Validation(Required=false)]
        public bool? EnableHealthCheck { get; set; }

        /// <summary>
        /// <para>Enable outlier detection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enableOutlierDetection")]
        [Validation(Required=false)]
        public bool? EnableOutlierDetection { get; set; }

        /// <summary>
        /// <para>PAI-EAS service configuration settings.</para>
        /// </summary>
        [NameInMap("paiEASServiceConfig")]
        [Validation(Required=false)]
        public AiServiceConfigPaiEASServiceConfig PaiEASServiceConfig { get; set; }
        public class AiServiceConfigPaiEASServiceConfig : TeaModel {
            /// <summary>
            /// <para>Type of endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;public&quot;，&quot;private&quot;</para>
            /// </summary>
            [NameInMap("endpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            /// <summary>
            /// <para>Service identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>svc-d33onfmm1hkn5duhuqjg</para>
            /// </summary>
            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>Name of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service-hello</para>
            /// </summary>
            [NameInMap("serviceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>Workspace identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>plw-d5g7qsem1hkmih54g210</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The LLM protocols.</para>
        /// </summary>
        [NameInMap("protocols")]
        [Validation(Required=false)]
        public List<string> Protocols { get; set; }

        /// <summary>
        /// <para>The Large Language Model (LLM) provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen</para>
        /// </summary>
        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>Vertex AI service configuration.</para>
        /// </summary>
        [NameInMap("vertexServiceConfig")]
        [Validation(Required=false)]
        public AiServiceConfigVertexServiceConfig VertexServiceConfig { get; set; }
        public class AiServiceConfigVertexServiceConfig : TeaModel {
            /// <summary>
            /// <para>Gemini safety settings.</para>
            /// </summary>
            [NameInMap("geminiSafetySetting")]
            [Validation(Required=false)]
            public Dictionary<string, string> GeminiSafetySetting { get; set; }

            /// <summary>
            /// <para>Vertex AI authentication key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;type\&quot;:\&quot;service_account\&quot;,\&quot;project_id\&quot;:\&quot;xxx\&quot;,\&quot;private_key\&quot;:\&quot;-----BEGIN PRIVATE KEY-----\&quot;,\&quot;client_email\&quot;:\&quot;<a href="mailto:xxx@xxx.iam.gserviceaccount.com">xxx@xxx.iam.gserviceaccount.com</a>\&quot;,\&quot;token_uri\&quot;:\&quot;<a href="https://oauth2.googleapis.com/token%5C%5C%22%7D">https://oauth2.googleapis.com/token\\&quot;}</a></para>
            /// </summary>
            [NameInMap("vertexAuthKey")]
            [Validation(Required=false)]
            public string VertexAuthKey { get; set; }

            /// <summary>
            /// <para>Vertex AI auth service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom-vertex-auth</para>
            /// </summary>
            [NameInMap("vertexAuthServiceName")]
            [Validation(Required=false)]
            public string VertexAuthServiceName { get; set; }

            /// <summary>
            /// <para>Vertex AI project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-gcp-project-123</para>
            /// </summary>
            [NameInMap("vertexProjectId")]
            [Validation(Required=false)]
            public string VertexProjectId { get; set; }

            /// <summary>
            /// <para>Vertex AI region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>us-central1</para>
            /// </summary>
            [NameInMap("vertexRegion")]
            [Validation(Required=false)]
            public string VertexRegion { get; set; }

            /// <summary>
            /// <para>Vertex token refresh lead time.</para>
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
