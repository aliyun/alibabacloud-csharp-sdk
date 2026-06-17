// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class DomainInfo : TeaModel {
        /// <summary>
        /// <para>The China Security certificate identity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>235556-cn-hangzhou</para>
        /// </summary>
        [NameInMap("certIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        /// <summary>
        /// <para>The client CA certificate.</para>
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
        /// <para>The source from which the domain name was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Console</para>
        /// </summary>
        [NameInMap("createFrom")]
        [Validation(Required=false)]
        public string CreateFrom { get; set; }

        /// <summary>
        /// <para>The creation timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1719386834548</para>
        /// </summary>
        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The domain name ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-cq1lthllhtgja4dk54eg</para>
        /// </summary>
        [NameInMap("domainId")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        [NameInMap("domainScope")]
        [Validation(Required=false)]
        public string DomainScope { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable forced HTTPS redirect when the HTTPS protocol type is configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("forceHttps")]
        [Validation(Required=false)]
        public bool? ForceHttps { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable mTLS mutual authentication.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("mTLSEnabled")]
        [Validation(Required=false)]
        public bool? MTLSEnabled { get; set; }

        /// <summary>
        /// <para>The domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc.com</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The protocol type supported by the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HTTP: Only HTTP is supported.</description></item>
        /// <item><description>HTTPS: Only HTTPS is supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-xxxx</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The domain name status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Published</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The update timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1719386834548</para>
        /// </summary>
        [NameInMap("updateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
