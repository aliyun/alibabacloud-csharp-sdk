// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ListTlsInspectCACertificatesResponseBody : TeaModel {
        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<ListTlsInspectCACertificatesResponseBodyCertificates> Certificates { get; set; }
        public class ListTlsInspectCACertificatesResponseBodyCertificates : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>RSA</para>
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rsa_ml_***_root</para>
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2732BB48-2969-5716-B5D9-******CA85</para>
            /// </summary>
            [NameInMap("CaCertId")]
            [Validation(Required=false)]
            public string CaCertId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ROOT</para>
            /// </summary>
            [NameInMap("CaCertType")]
            [Validation(Required=false)]
            public string CaCertType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1934***149</para>
            /// </summary>
            [NameInMap("ExpirationTime")]
            [Validation(Required=false)]
            public long? ExpirationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2048</para>
            /// </summary>
            [NameInMap("KeySize")]
            [Validation(Required=false)]
            public int? KeySize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>340BB48-2969-5716-B5D9-****ACA85</para>
            /// </summary>
            [NameInMap("ParentCaCertId")]
            [Validation(Required=false)]
            public string ParentCaCertId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SHA256WITHRSA</para>
            /// </summary>
            [NameInMap("SignAlgorithm")]
            [Validation(Required=false)]
            public string SignAlgorithm { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ISSUE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-******837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
