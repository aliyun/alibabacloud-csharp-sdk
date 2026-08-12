// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class EnableSSLConnectionRequest : TeaModel {
        /// <summary>
        /// <para>Custom SSL certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MIIP0wIBAzCCD4wGCSqGSIb3DQEHAaCCD30Egg95MIIPdTCCBbwGCSqGSIb3DQEHAaCCBa0EggWpMIIFpTCCBaEGCyqGSIb3DQEMCgECoIIFQDCCBTwwZgYJKoZIhvcNAQUNMFkwOAYJKoZIhvcNAQUMMCsEFHkQJTDaeFabOsRTB4Q7hgW6if7hAgInEAIBIDAMBggqhkiG9w0CCQU</para>
        /// </summary>
        [NameInMap("CustomSSLCertificate")]
        [Validation(Required=false)]
        public string CustomSSLCertificate { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a custom certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableCustom")]
        [Validation(Required=false)]
        public bool? EnableCustom { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-0104730e9de40215</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Indicates whether this request renews an existing certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Renewal")]
        [Validation(Required=false)]
        public bool? Renewal { get; set; }

        /// <summary>
        /// <para>Key password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KoZ13vcNAQ</para>
        /// </summary>
        [NameInMap("SslKeyPassword")]
        [Validation(Required=false)]
        public string SslKeyPassword { get; set; }

        /// <summary>
        /// <para>Keystore password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21esSd9Ao</para>
        /// </summary>
        [NameInMap("SslKeystorePassword")]
        [Validation(Required=false)]
        public string SslKeystorePassword { get; set; }

    }

}
