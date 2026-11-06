// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class RevealServiceCredentialResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of Ok indicates success.</para>
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
            /// <para>The current configuration revision. For legacy objects, the value is legacy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("configRevision")]
            [Validation(Required=false)]
            public string ConfigRevision { get; set; }

            /// <summary>
            /// <para>The credential object for the currently active type. Only the fields corresponding to the credentialType are populated.</para>
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
                /// <para>The list of Key Management Service (KMS) reference names. This field is returned only in Reference mode. Reference values are not returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;my-kms-ref&quot;]</para>
                /// </summary>
                [NameInMap("apiKeyReferences")]
                [Validation(Required=false)]
                public List<string> ApiKeyReferences { get; set; }

                /// <summary>
                /// <para>The list of custom API keys. This field is returned only when apiKeyGenerateMode is set to Custom. The keys are returned in their original order without deduplication.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;sk-xxxxxxxx&quot;,&quot;sk-yyyyyyyy&quot;]</para>
                /// </summary>
                [NameInMap("apiKeys")]
                [Validation(Required=false)]
                public List<string> ApiKeys { get; set; }

                /// <summary>
                /// <para>Bedrock AWS Access Key</para>
                /// 
                /// <b>Example:</b>
                /// <para>AKIAxxxxxxxx</para>
                /// </summary>
                [NameInMap("awsAccessKey")]
                [Validation(Required=false)]
                public string AwsAccessKey { get; set; }

                /// <summary>
                /// <para>Bedrock AWS Region</para>
                /// 
                /// <b>Example:</b>
                /// <para>us-east-1</para>
                /// </summary>
                [NameInMap("awsRegion")]
                [Validation(Required=false)]
                public string AwsRegion { get; set; }

                /// <summary>
                /// <para>Bedrock AWS Secret Key</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("awsSecretKey")]
                [Validation(Required=false)]
                public string AwsSecretKey { get; set; }

                /// <summary>
                /// <para>The source of the credential. When backfilled by the PAI-EAS system, the value is pai-eas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pai-eas</para>
                /// </summary>
                [NameInMap("credentialSource")]
                [Validation(Required=false)]
                public string CredentialSource { get; set; }

                /// <summary>
                /// <para>The Bedrock endpoint mode. A value of runtime is returned for historical null values.</para>
                /// 
                /// <b>Example:</b>
                /// <para>runtime</para>
                /// </summary>
                [NameInMap("endpointMode")]
                [Validation(Required=false)]
                public string EndpointMode { get; set; }

                /// <summary>
                /// <para>Kling Access Key</para>
                /// 
                /// <b>Example:</b>
                /// <para>AKxxxxxxxx</para>
                /// </summary>
                [NameInMap("klingAccessKey")]
                [Validation(Required=false)]
                public string KlingAccessKey { get; set; }

                /// <summary>
                /// <para>Kling Secret Key</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
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
                /// <para>Vertex Project ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-gcp-project</para>
                /// </summary>
                [NameInMap("vertexProjectId")]
                [Validation(Required=false)]
                public string VertexProjectId { get; set; }

                /// <summary>
                /// <para>Vertex Region</para>
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
        /// <para>The response message. A value of success indicates success.</para>
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
