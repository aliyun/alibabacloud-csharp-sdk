// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The list of instances.</para>
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<ListInstancesResponseBodyInstanceList> InstanceList { get; set; }
        public class ListInstancesResponseBodyInstanceList : TeaModel {
            /// <summary>
            /// <para>Indicates whether automatic managed renewal is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enable: enabled.</description></item>
            /// <item><description>disable: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enable</para>
            /// </summary>
            [NameInMap("AutoReissue")]
            [Validation(Required=false)]
            public string AutoReissue { get; set; }

            /// <summary>
            /// <para>The CA brand. Valid values: WoSign, CFCA, DigiCert, GeoTrust, GlobalSign, vTrus, and Alibaba.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DigiCert</para>
            /// </summary>
            [NameInMap("Brand")]
            [Validation(Required=false)]
            public string Brand { get; set; }

            /// <summary>
            /// <para>The global certificate ID, in the format of certificate ID + &quot;-&quot; + site region ID. This ID is commonly used across Alibaba Cloud services.</para>
            /// <list type="bullet">
            /// <item><description>For the China site: certificate ID + &quot;-cn-hangzhou&quot;</description></item>
            /// <item><description>For the China site: certificate ID + &quot;-ap-southeast-1&quot;</description></item>
            /// </list>
            /// <para>For example, if the certificate ID is 123, the CertIdentifier on the China site is &quot;123-cn-hangzhou&quot;, and the CertIdentifier on the International site is &quot;123-ap-southeast-1&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21795675-cn-hangzhou</para>
            /// </summary>
            [NameInMap("CertIdentifier")]
            [Validation(Required=false)]
            public string CertIdentifier { get; set; }

            /// <summary>
            /// <para>The domain name of the latest issued certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc.com,<a href="http://www.abc.com">www.abc.com</a></para>
            /// </summary>
            [NameInMap("CertificateDomain")]
            [Validation(Required=false)]
            public string CertificateDomain { get; set; }

            /// <summary>
            /// <para>The certificate ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18541349</para>
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public long? CertificateId { get; set; }

            /// <summary>
            /// <para>The certificate name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cert-13216408</para>
            /// </summary>
            [NameInMap("CertificateName")]
            [Validation(Required=false)]
            public string CertificateName { get; set; }

            /// <summary>
            /// <para>The end time of the latest certificate, in timestamp format. If no certificate has been issued, this field is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1801324800000</para>
            /// </summary>
            [NameInMap("CertificateNotAfter")]
            [Validation(Required=false)]
            public long? CertificateNotAfter { get; set; }

            /// <summary>
            /// <para>The start time of the latest certificate, in timestamp format. If no certificate has been issued, this field is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1776988800000</para>
            /// </summary>
            [NameInMap("CertificateNotBefore")]
            [Validation(Required=false)]
            public long? CertificateNotBefore { get; set; }

            /// <summary>
            /// <para>The revocation time of the latest certificate, in timestamp format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1801324800000</para>
            /// </summary>
            [NameInMap("CertificateRevokeTime")]
            [Validation(Required=false)]
            public long? CertificateRevokeTime { get; set; }

            /// <summary>
            /// <para>The status of the certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>issued</b>: Issued.</description></item>
            /// <item><description><b>revoked</b>: Revoked.</description></item>
            /// <item><description><b>willExpire</b>: About to expire.</description></item>
            /// <item><description><b>expired</b>: Expired.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>issued</para>
            /// </summary>
            [NameInMap("CertificateStatus")]
            [Validation(Required=false)]
            public string CertificateStatus { get; set; }

            /// <summary>
            /// <para>The type of the certificate. Valid values: DV, OV, and EV.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DV</para>
            /// </summary>
            [NameInMap("CertificateType")]
            [Validation(Required=false)]
            public string CertificateType { get; set; }

            /// <summary>
            /// <para>The domain name bound to the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The number of exact-match domain names.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FullDomainCount")]
            [Validation(Required=false)]
            public int? FullDomainCount { get; set; }

            /// <summary>
            /// <para>The expiration time of the instance, in timestamp format. If no certificate has been issued, this field is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1801324800000</para>
            /// </summary>
            [NameInMap("InstanceEndTime")]
            [Validation(Required=false)]
            public long? InstanceEndTime { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cas_dv-cn-123</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The start time of the instance, in timestamp format. If no certificate has been issued, this field is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1801324800000</para>
            /// </summary>
            [NameInMap("InstanceStartTime")]
            [Validation(Required=false)]
            public long? InstanceStartTime { get; set; }

            /// <summary>
            /// <para>The instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BUY: official certificate.</description></item>
            /// <item><description>TEST: test certificate.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BUY</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The certificate algorithm. Default value: RSA_2048. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>RSA_2048</b></description></item>
            /// <item><description><b>RSA_3072</b></description></item>
            /// <item><description><b>RSA_4096</b></description></item>
            /// <item><description><b>ECC_256</b></description></item>
            /// <item><description><b>SM2</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RSA_2048</para>
            /// </summary>
            [NameInMap("KeyAlgorithm")]
            [Validation(Required=false)]
            public string KeyAlgorithm { get; set; }

            /// <summary>
            /// <para>The end time of the instance purchase, in timestamp format. Used to determine the purchase duration of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1801324800000</para>
            /// </summary>
            [NameInMap("OrderEndTime")]
            [Validation(Required=false)]
            public long? OrderEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the instance purchase, in timestamp format. Used to determine the refund time limit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1801324800000</para>
            /// </summary>
            [NameInMap("OrderStartTime")]
            [Validation(Required=false)]
            public long? OrderStartTime { get; set; }

            /// <summary>
            /// <para>The result returned by the CA during the last certificate operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pending</para>
            /// </summary>
            [NameInMap("PendingResult")]
            [Validation(Required=false)]
            public string PendingResult { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The purchased instance specification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ss.dv.t</para>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            /// <summary>
            /// <para>The instance status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>inactive</b>: pending use.</description></item>
            /// <item><description><b>pending</b>: under review. The latest certificate is being reviewed.</description></item>
            /// <item><description><b>willExpire</b>: about to expire.</description></item>
            /// <item><description><b>expired</b>: expired.</description></item>
            /// <item><description><b>refund</b>: refunded.</description></item>
            /// <item><description><b>normal</b>: normal.</description></item>
            /// <item><description><b>closed</b>: closed and unavailable.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>inactive</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of cloud services to which the latest certificate is deployed.</para>
            /// </summary>
            [NameInMap("UsingProductList")]
            [Validation(Required=false)]
            public List<string> UsingProductList { get; set; }

            /// <summary>
            /// <para>The number of wildcard domain names.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("WildcardDomainCount")]
            [Validation(Required=false)]
            public int? WildcardDomainCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-1234-1234-123456789ABC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of records per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// <para>The total number of instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
