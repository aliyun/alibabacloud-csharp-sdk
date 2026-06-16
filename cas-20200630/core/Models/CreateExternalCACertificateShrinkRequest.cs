// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class CreateExternalCACertificateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies API parameters that override content from the CSR or add information to the CA certificate.</para>
        /// </summary>
        [NameInMap("ApiPassthrough")]
        [Validation(Required=false)]
        public string ApiPassthroughShrink { get; set; }

        [NameInMap("CertMaxTime")]
        [Validation(Required=false)]
        public int? CertMaxTime { get; set; }

        /// <summary>
        /// <para>The certificate signing request (CSR). The CSR can contain information such as the SubjectDN and custom extensions for the CA certificate. The CA generates the SubjectKeyIdentifier, AuthorityKeyIdentifier, and CRLDistributionPoints extensions, ignoring any corresponding values in the CSR.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE REQUEST-----
        /// MIIBczCCARgCAQAwgYoxFDASBgNVBAMMC2FsaXl1bi50ZXN0MQ0wCwYDVQQ
        /// ...
        /// vbIgMQIhAKHDWD6/WAMbtezAt4bysJ/BZIDz1jPWuUR5GV4TJ/mS
        /// -----END CERTIFICATE REQUEST-----</para>
        /// </summary>
        [NameInMap("Csr")]
        [Validation(Required=false)]
        public string Csr { get; set; }

        /// <summary>
        /// <para>The ID of the external subordinate CA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cas_deposit-cn-1234abcd</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags to add to the certificate.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateExternalCACertificateShrinkRequestTags> Tags { get; set; }
        public class CreateExternalCACertificateShrinkRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag\&quot;s key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>database</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag\&quot;s value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The certificate validity period. You can specify this using either relative or absolute time.</para>
        /// <remarks>
        /// <para>Relative time: Supported units are year, month, and day.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>y - year</para>
        /// </description></item>
        /// <item><description><para>m - month</para>
        /// </description></item>
        /// <item><description><para>d - day</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Absolute time: Use GMT time in the <c>yyyy-MM-dd\\&quot;T\\&quot;HH:mm:ss\\&quot;Z\\&quot;</c> format.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>To specify only the expiration time, use <c>$NotAfter</c>.</para>
        /// </description></item>
        /// <item><description><para>To specify both the start and expiration times, use <c>$NotBefore/$NotAfter</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10y</para>
        /// </summary>
        [NameInMap("Validity")]
        [Validation(Required=false)]
        public string Validity { get; set; }

    }

}
