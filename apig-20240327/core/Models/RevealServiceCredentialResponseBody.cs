// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class RevealServiceCredentialResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. The value is Ok if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The currently active credential data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;serviceId&quot;:&quot;svc-xxxxxxxx&quot;,&quot;provider&quot;:&quot;qwen&quot;,&quot;credentialType&quot;:&quot;apiKey&quot;,&quot;configRevision&quot;:&quot;1&quot;,&quot;credential&quot;:{&quot;apiKeyGenerateMode&quot;:&quot;Custom&quot;,&quot;apiKeys&quot;:[&quot;sk-xxxxxxxx&quot;]}}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public RevealServiceCredentialResponseBodyData Data { get; set; }
        public class RevealServiceCredentialResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The current configuration revision. The value is legacy for historical objects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("configRevision")]
            [Validation(Required=false)]
            public string ConfigRevision { get; set; }

            /// <summary>
            /// <para>The credential object of the currently active type. Only the fields corresponding to the credentialType are populated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;apiKeyGenerateMode&quot;:&quot;Custom&quot;,&quot;apiKeys&quot;:[&quot;sk-xxxxxxxx&quot;]}</para>
            /// </summary>
            [NameInMap("credential")]
            [Validation(Required=false)]
            public RevealServiceCredentialResponseBodyDataCredential Credential { get; set; }
            public class RevealServiceCredentialResponseBodyDataCredential : TeaModel {
                /// <summary>
                /// <para>The API key generation mode. Valid values: Custom and Reference. Historical null values are treated as Custom.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Custom</para>
                /// </summary>
                [NameInMap("apiKeyGenerateMode")]
                [Validation(Required=false)]
                public string ApiKeyGenerateMode { get; set; }

                /// <summary>
                /// <para>The list of Key Management Service (KMS) reference names. This parameter is returned only in Reference mode. The reference values are not returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;my-kms-ref&quot;]</para>
                /// </summary>
                [NameInMap("apiKeyReferences")]
                [Validation(Required=false)]
                public List<string> ApiKeyReferences { get; set; }

                /// <summary>
                /// <para>The list of custom API keys. This parameter is returned only when apiKeyGenerateMode is set to Custom. The keys are returned in the original order without deduplication.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;sk-xxxxxxxx&quot;,&quot;sk-yyyyyyyy&quot;]</para>
                /// </summary>
                [NameInMap("apiKeys")]
                [Validation(Required=false)]
                public List<string> ApiKeys { get; set; }

                /// <summary>
                /// <para>The AWS access key ID for Bedrock.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AKIAxxxxxxxx</para>
                /// </summary>
                [NameInMap("awsAccessKey")]
                [Validation(Required=false)]
                public string AwsAccessKey { get; set; }

                /// <summary>
                /// <para>The AWS region for Bedrock.</para>
                /// 
                /// <b>Example:</b>
                /// <para>us-east-1</para>
                /// </summary>
                [NameInMap("awsRegion")]
                [Validation(Required=false)]
                public string AwsRegion { get; set; }

                /// <summary>
                /// <para>The AWS secret access key for Bedrock.</para>
                /// 
                /// <b>Example:</b>
                /// <para>wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY</para>
                /// </summary>
                [NameInMap("awsSecretKey")]
                [Validation(Required=false)]
                public string AwsSecretKey { get; set; }

                /// <summary>
                /// <para>The source of the credential. The value is pai-eas when the credential is backfilled by the PAI-EAS system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pai-eas</para>
                /// </summary>
                [NameInMap("credentialSource")]
                [Validation(Required=false)]
                public string CredentialSource { get; set; }

                /// <summary>
                /// <para>The Bedrock endpoint mode. The value is runtime for historical null values.</para>
                /// 
                /// <b>Example:</b>
                /// <para>runtime</para>
                /// </summary>
                [NameInMap("endpointMode")]
                [Validation(Required=false)]
                public string EndpointMode { get; set; }

                /// <summary>
                /// <para>The access key ID for Kling.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AKxxxxxxxx</para>
                /// </summary>
                [NameInMap("klingAccessKey")]
                [Validation(Required=false)]
                public string KlingAccessKey { get; set; }

                /// <summary>
                /// <para>The secret access key for Kling.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sk-kling-9f2c1d7e</para>
                /// </summary>
                [NameInMap("klingSecretKey")]
                [Validation(Required=false)]
                public string KlingSecretKey { get; set; }

                /// <summary>
                /// <para>The original JSON text of the Vertex service account. The text is neither parsed nor reordered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;type&quot;:&quot;service_account&quot;,&quot;private_key&quot;:&quot;********&quot;}</para>
                /// </summary>
                [NameInMap("vertexAuthKey")]
                [Validation(Required=false)]
                public string VertexAuthKey { get; set; }

                /// <summary>
                /// <para>The Vertex project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-gcp-project</para>
                /// </summary>
                [NameInMap("vertexProjectId")]
                [Validation(Required=false)]
                public string VertexProjectId { get; set; }

                /// <summary>
                /// <para>The region for Vertex.</para>
                /// 
                /// <b>Example:</b>
                /// <para>us-central1</para>
                /// </summary>
                [NameInMap("vertexRegion")]
                [Validation(Required=false)]
                public string VertexRegion { get; set; }

            }

            /// <summary>
            /// <para>The currently active credential type. Valid values: apiKey, bedrock, vertex, and kling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apiKey</para>
            /// </summary>
            [NameInMap("credentialType")]
            [Validation(Required=false)]
            public string CredentialType { get; set; }

            /// <summary>
            /// <para>The name of the provider, such as qwen, openai, bedrock, vertex, kling, or pai-eas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen</para>
            /// </summary>
            [NameInMap("provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

            /// <summary>
            /// <para>The unique ID of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>svc-xxxxxxxx</para>
            /// </summary>
            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

        }

        /// <summary>
        /// <para>The response message. The value is success if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
