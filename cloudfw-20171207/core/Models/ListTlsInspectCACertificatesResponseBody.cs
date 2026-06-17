// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ListTlsInspectCACertificatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of certificates.</para>
        /// </summary>
        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<ListTlsInspectCACertificatesResponseBodyCertificates> Certificates { get; set; }
        public class ListTlsInspectCACertificatesResponseBodyCertificates : TeaModel {
            /// <summary>
            /// <para>The encryption algorithm of the CA certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>RSA</b>: the RSA algorithm.</para>
            /// </description></item>
            /// <item><description><para><b>ECC</b>: the ECC algorithm.</para>
            /// </description></item>
            /// <item><description><para><b>SM2</b>: the SM2 algorithm.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RSA</para>
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            /// <summary>
            /// <para>The alias of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rsa_ml_***_root</para>
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <para>The ID of the CA certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2732BB48-2969-5716-B5D9-******CA85</para>
            /// </summary>
            [NameInMap("CaCertId")]
            [Validation(Required=false)]
            public string CaCertId { get; set; }

            /// <summary>
            /// <para>The type of the CA certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ROOT</b>: a root CA certificate.</para>
            /// </description></item>
            /// <item><description><para><b>SUB_ROOT</b>: a subordinate CA certificate.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ROOT</para>
            /// </summary>
            [NameInMap("CaCertType")]
            [Validation(Required=false)]
            public string CaCertType { get; set; }

            /// <summary>
            /// <para>The expiration timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1934***149</para>
            /// </summary>
            [NameInMap("ExpirationTime")]
            [Validation(Required=false)]
            public long? ExpirationTime { get; set; }

            /// <summary>
            /// <para>The key length of the CA certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2048</para>
            /// </summary>
            [NameInMap("KeySize")]
            [Validation(Required=false)]
            public int? KeySize { get; set; }

            /// <summary>
            /// <para>The ID of the parent CA certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>340BB48-2969-5716-B5D9-****ACA85</para>
            /// </summary>
            [NameInMap("ParentCaCertId")]
            [Validation(Required=false)]
            public string ParentCaCertId { get; set; }

            /// <summary>
            /// <para>The signature algorithm of the CA certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SHA256WITHRSA</para>
            /// </summary>
            [NameInMap("SignAlgorithm")]
            [Validation(Required=false)]
            public string SignAlgorithm { get; set; }

            /// <summary>
            /// <para>The status of the certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ISSUE</b>: enabled.</para>
            /// </description></item>
            /// <item><description><para><b>REVOKE</b>: revoked.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ISSUE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-******837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
