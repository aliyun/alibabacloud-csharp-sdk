// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DescribeClientCertificateStatusForSerialNumberResponseBody : TeaModel {
        /// <summary>
        /// <para>The object.</para>
        /// </summary>
        [NameInMap("CertificateStatus")]
        [Validation(Required=false)]
        public List<DescribeClientCertificateStatusForSerialNumberResponseBodyCertificateStatus> CertificateStatus { get; set; }
        public class DescribeClientCertificateStatusForSerialNumberResponseBodyCertificateStatus : TeaModel {
            /// <summary>
            /// <para>The date on which the certificate was revoked.</para>
            /// <remarks>
            /// <para> This parameter is returned only when the value of the <b>Status</b> parameter is <b>revoked</b>. The value revoked indicates that the certificate is revoked.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-01T00:00</para>
            /// </summary>
            [NameInMap("RevokeTime")]
            [Validation(Required=false)]
            public long? RevokeTime { get; set; }

            /// <summary>
            /// <para>The serial number of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b67e53ebcea9b77d65b0c3236646d715****</para>
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            /// <summary>
            /// <para>The status of the certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>good</b>: The certificate is not revoked.</description></item>
            /// <item><description><b>revoked</b>: The certificate is revoked.</description></item>
            /// <item><description><b>unknown</b>: The server cannot determine the status of the certificate.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>good</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
