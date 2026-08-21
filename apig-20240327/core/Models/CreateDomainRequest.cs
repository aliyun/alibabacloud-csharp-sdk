// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateDomainRequest : TeaModel {
        /// <summary>
        /// <para>The CA certificate identifier. This parameter is optional for Dedicated with HTTPS. This parameter is not allowed for Serverless and is not validated for Dedicated with HTTP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ef1da5f-38ed-69b3-****-037781890265</para>
        /// </summary>
        [NameInMap("caCertIdentifier")]
        [Validation(Required=false)]
        public string CaCertIdentifier { get; set; }

        /// <summary>
        /// <para>The certificate identifier. This parameter is required for Dedicated with HTTPS and must pass validation. This parameter is not allowed for Serverless and is not validated for Dedicated with HTTP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ef1da5f-38ed-69b3-****-037781890265</para>
        /// </summary>
        [NameInMap("certIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        /// <summary>
        /// <para>The client CA certificate. This parameter is conditionally required for Dedicated with HTTPS (required when MTLSEnabled is set to true). This parameter is not allowed for Serverless and is not validated for Dedicated with HTTP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----
        /// MIIFBTCCAu2gAwIBAgIUORLpYPGSFD1YOP6PMbE7Wd/mpTQwDQYJKoZIhvcNAQEL
        /// BQAwE************************************************2VwVOJ2gqX3
        /// YuGaxvIbDy0iQJ1GMerPRyzJTeVEtdIKT29u0PdFRr4KZWom35qX7G4=
        /// -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("clientCACert")]
        [Validation(Required=false)]
        public string ClientCACert { get; set; }

        /// <summary>
        /// <para>The domain scope. Valid values: Dedicated (dedicated gateway domain name), Serverless (Serverless gateway domain name). Default value: Dedicated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dedicated</para>
        /// </summary>
        [NameInMap("domainScope")]
        [Validation(Required=false)]
        public string DomainScope { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable forced HTTPS redirect when the protocol type is HTTPS. This parameter is required for Serverless and for Dedicated with HTTPS. This parameter is not validated for Dedicated with HTTP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("forceHttps")]
        [Validation(Required=false)]
        public bool? ForceHttps { get; set; }

        /// <summary>
        /// <para>The gateway type. If not specified, the default value is API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>API</para>
        /// </summary>
        [NameInMap("gatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

        /// <summary>
        /// <para>The HTTP/2 setting. Valid values: GlobalConfig (follows the global configuration), Open (enabled), Close (disabled). Default value: GlobalConfig. This setting is supported only for HTTPS domain names in the Dedicated scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Open</para>
        /// </summary>
        [NameInMap("http2Option")]
        [Validation(Required=false)]
        public string Http2Option { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable mTLS mutual authentication. This parameter is optional for Dedicated with HTTPS. If set to true, ClientCACert is required. This parameter is not allowed for Serverless.</para>
        /// </summary>
        [NameInMap("mTLSEnabled")]
        [Validation(Required=false)]
        public bool? MTLSEnabled { get; set; }

        /// <summary>
        /// <para>The domain name. The name must be 1 to 128 characters in length, such as abc.com.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc.com</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The protocol type used by the domain name. Valid values: HTTP, HTTPS. This parameter is required for the Dedicated scope and is not allowed for the Serverless scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/151181.html">resource group ID</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzhiv7derfweq</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The TLS cipher suite configuration, including the configuration type, cipher suite names, and supported TLS versions. This configuration is supported only for HTTPS domain names in the Dedicated scope.</para>
        /// </summary>
        [NameInMap("tlsCipherSuitesConfig")]
        [Validation(Required=false)]
        public TlsCipherSuitesConfig TlsCipherSuitesConfig { get; set; }

        /// <summary>
        /// <para>The maximum TLS protocol version. This parameter is optional for Dedicated with HTTPS. If not specified, the value is derived from TlsMin. The value must be greater than or equal to TlsMin. This parameter is not allowed for Serverless.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TLS1.3</para>
        /// </summary>
        [NameInMap("tlsMax")]
        [Validation(Required=false)]
        public string TlsMax { get; set; }

        /// <summary>
        /// <para>The minimum TLS protocol version. This parameter is optional for Dedicated with HTTPS. If not specified, the default value is TLS 1.0. Valid values range from TLS 1.0 to TLS 1.3, compatible with TLSv1.x. This parameter is not allowed for Serverless.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TLS1.0</para>
        /// </summary>
        [NameInMap("tlsMin")]
        [Validation(Required=false)]
        public string TlsMin { get; set; }

        /// <summary>
        /// <para>The idempotency token generated by the caller as a globally unique value (UUID recommended). The value must be up to 64 characters in length. Within approximately 24 hours after the first successful request, a duplicate request with the same ClientToken and identical request parameters directly returns the domainId created by the first request without creating a duplicate domain name. If the same ClientToken is used with different request parameters, an IdempotentParameterMismatch error is returned. If the first request is still being processed, an IdempotentProcessing error is returned. If this parameter is not specified, idempotency control is not enabled, and the behavior is consistent with the existing version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5f7a2c1e-9b3d-4e8f-a1c6-0d2b8e4f7a13</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run. If set to true, all synchronous validations consistent with actual creation are performed (including idempotency checks for existing test domain names), but no domain name is created and no side effects are produced. If not specified or set to false, the behavior is consistent with the existing version.</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
