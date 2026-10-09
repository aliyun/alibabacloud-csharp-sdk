// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DescribeClientCertificateStatusForSerialNumberResponseBody : TeaModel {
        /// <summary>
        /// <para>The certificate status details.</para>
        /// </summary>
        [NameInMap("CertificateStatus")]
        [Validation(Required=false)]
        public List<DescribeClientCertificateStatusForSerialNumberResponseBodyCertificateStatus> CertificateStatus { get; set; }
        public class DescribeClientCertificateStatusForSerialNumberResponseBodyCertificateStatus : TeaModel {
            /// <summary>
            /// <para>The date when the certificate was revoked. This value is a UNIX timestamp in milliseconds.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <b>Status</b> is <b>revoked</b> (indicating that the certificate has been revoked).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1787539908871</para>
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
            /// <para>The current status of the certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>good</b>: The certificate has not been revoked.</description></item>
            /// <item><description><b>revoked</b>: The certificate has been revoked.</description></item>
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
