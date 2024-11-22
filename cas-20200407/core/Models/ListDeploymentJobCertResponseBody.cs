// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListDeploymentJobCertResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDeploymentJobCertResponseBodyData> Data { get; set; }
        public class ListDeploymentJobCertResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The algorithm of the certificate public key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RSA</para>
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            /// <summary>
            /// <para>The ID of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11174100</para>
            /// </summary>
            [NameInMap("CertId")]
            [Validation(Required=false)]
            public long? CertId { get; set; }

            /// <summary>
            /// <para>The instance ID of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cas-ivauto-2crxzi</para>
            /// </summary>
            [NameInMap("CertInstanceId")]
            [Validation(Required=false)]
            public string CertInstanceId { get; set; }

            /// <summary>
            /// <para>The name of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>edkog.shop</para>
            /// </summary>
            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            /// <summary>
            /// <para>The type of the certificate order. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>upload</b>: uploaded certificate.</description></item>
            /// <item><description><b>buy</b>: purchased certificate.</description></item>
            /// <item><description><b>free</b>: free certificate. This value is available only on the China site (aliyun.com).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>buy</para>
            /// </summary>
            [NameInMap("CertOrderType")]
            [Validation(Required=false)]
            public string CertOrderType { get; set; }

            /// <summary>
            /// <para>The type of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DV</para>
            /// </summary>
            [NameInMap("CertType")]
            [Validation(Required=false)]
            public string CertType { get; set; }

            /// <summary>
            /// <para>The common name of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vaultwebhook.vault-webhook.svc</para>
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// <para>Indicates whether the certificate is hosted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsTrustee")]
            [Validation(Required=false)]
            public bool? IsTrustee { get; set; }

            /// <summary>
            /// <para>The month in which the certificate is applied for.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("Month")]
            [Validation(Required=false)]
            public int? Month { get; set; }

            /// <summary>
            /// <para>The end time of the validity period of the certificate. The value is a timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683625266108</para>
            /// </summary>
            [NameInMap("NotAfterTime")]
            [Validation(Required=false)]
            public long? NotAfterTime { get; set; }

            /// <summary>
            /// <para>The start time of the validity period of the certificate. The value is a timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683625266108</para>
            /// </summary>
            [NameInMap("NotBeforeTime")]
            [Validation(Required=false)]
            public long? NotBeforeTime { get; set; }

            /// <summary>
            /// <para>The ID of the certificate order.</para>
            /// <remarks>
            /// <para> If CertId is returned, this parameter is not returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>6127067</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// <para>The subject alternative name (SAN) extensions of the certificate.</para>
            /// </summary>
            [NameInMap("Sans")]
            [Validation(Required=false)]
            public List<string> Sans { get; set; }

            /// <summary>
            /// <para>The status code of the certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>payed</b>: paid and pending application</description></item>
            /// <item><description><b>checking</b>: being validated</description></item>
            /// <item><description><b>checkedFail</b>: validation failed</description></item>
            /// <item><description><b>revoked</b>: revoked</description></item>
            /// <item><description><b>revokeChecking</b>: revocation request being validated</description></item>
            /// <item><description><b>issued</b>: issued (excluding hosted certificates that are issued, certificates that are about to expire, expired certificates, and uploaded certificates)</description></item>
            /// <item><description><b>trustee</b>: hosted and issued</description></item>
            /// <item><description><b>upload</b>: uploaded (excluding certificates that are about to expire and expired certificates)</description></item>
            /// <item><description><b>willExpired</b>: about to expire (including certificates issued by using the Certificate Management Service console and uploaded certificates)</description></item>
            /// <item><description><b>expired</b>: expired (including certificates issued by using the Certificate Management Service console and uploaded certificates)</description></item>
            /// <item><description><b>validity</b>: valid (including certificates that are not expired or revoked)</description></item>
            /// <item><description><b>refund</b>: refunded</description></item>
            /// <item><description><b>closed</b>: closed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>issued</para>
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }

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
