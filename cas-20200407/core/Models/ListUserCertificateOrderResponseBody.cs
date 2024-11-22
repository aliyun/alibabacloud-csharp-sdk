// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListUserCertificateOrderResponseBody : TeaModel {
        /// <summary>
        /// <para>The certificates and orders.</para>
        /// </summary>
        [NameInMap("CertificateOrderList")]
        [Validation(Required=false)]
        public List<ListUserCertificateOrderResponseBodyCertificateOrderList> CertificateOrderList { get; set; }
        public class ListUserCertificateOrderResponseBodyCertificateOrderList : TeaModel {
            /// <summary>
            /// <para>The algorithm. This parameter is returned only if OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RSA</para>
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud order. This parameter is returned only if OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>234567</para>
            /// </summary>
            [NameInMap("AliyunOrderId")]
            [Validation(Required=false)]
            public long? AliyunOrderId { get; set; }

            /// <summary>
            /// <para>The time at which the order was placed. Unit: milliseconds. This parameter is returned only if OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1634283958000</para>
            /// </summary>
            [NameInMap("BuyDate")]
            [Validation(Required=false)]
            public long? BuyDate { get; set; }

            /// <summary>
            /// <para>The time at which the certificate expires. Unit: milliseconds. This parameter is returned only if OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665819958000</para>
            /// </summary>
            [NameInMap("CertEndTime")]
            [Validation(Required=false)]
            public long? CertEndTime { get; set; }

            /// <summary>
            /// <para>The time at which the certificate starts to take effect. Unit: milliseconds. This parameter is returned only if OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665819958000</para>
            /// </summary>
            [NameInMap("CertStartTime")]
            [Validation(Required=false)]
            public long? CertStartTime { get; set; }

            /// <summary>
            /// <para>The type of the certificate. This parameter is returned only if OrderType is set to CPACK or BUY. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>DV</b>: domain validated (DV) certificate</description></item>
            /// <item><description><b>EV</b>: extended validation (EV) certificate</description></item>
            /// <item><description><b>OV</b>: organization validated (OV) certificate <b>FREE</b>: free certificate, available only on the China site (aliyun.com)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FREE</para>
            /// </summary>
            [NameInMap("CertType")]
            [Validation(Required=false)]
            public string CertType { get; set; }

            /// <summary>
            /// <para>The ID of the certificate. This parameter is returned only if OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>896521</para>
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public long? CertificateId { get; set; }

            /// <summary>
            /// <para>The city in which the organization is located. This parameter is returned only if OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hangzhou</para>
            /// </summary>
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// <para>The parent domain name of the certificate. This parameter is returned only if OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun.com</para>
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// <para>The code of the country in which the organization is located. This parameter is returned only if OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            /// <summary>
            /// <para>The domain name. This parameter is returned only if OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyundoc.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The total number of domain names that can be bound to the certificate. This parameter is returned only if OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DomainCount")]
            [Validation(Required=false)]
            public long? DomainCount { get; set; }

            /// <summary>
            /// <para>The type of the domain name. This parameter is returned only if OrderType is set to CPACK or BUY. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ONE</b>: single domain name</description></item>
            /// <item><description><b>MULTIPLE</b>: multiple domain names</description></item>
            /// <item><description><b>WILDCARD</b>: single wildcard domain name</description></item>
            /// <item><description><b>M_WILDCARD</b>: multiple wildcard domain names</description></item>
            /// <item><description><b>MIX</b>: hybrid domain name</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ONE</para>
            /// </summary>
            [NameInMap("DomainType")]
            [Validation(Required=false)]
            public string DomainType { get; set; }

            /// <summary>
            /// <para>The time at which the certificate expires. This parameter is returned only if OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-17</para>
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// <para>Indicates whether the certificate expires. This parameter is returned only if OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Expired")]
            [Validation(Required=false)]
            public bool? Expired { get; set; }

            /// <summary>
            /// <para>The fingerprint of the certificate. This parameter is returned only if OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CC6B3696E7C7CA715BD26E28E45FF3E3DF435C03</para>
            /// </summary>
            [NameInMap("Fingerprint")]
            [Validation(Required=false)]
            public string Fingerprint { get; set; }

            /// <summary>
            /// <para>The ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cas-instanceId</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The issuer of the certificate. This parameter is returned only if OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyIssuer</para>
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// <para>The name of the certificate. This parameter is returned only if OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cert-name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The order ID. This parameter is returned only if OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2345687</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// <para>The name of the organization that is associated with the certificate. This parameter is returned only if OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud</para>
            /// </summary>
            [NameInMap("OrgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            /// <summary>
            /// <para>The ID of the third-party certificate authority (CA) order. This parameter is returned only if OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca-123456</para>
            /// </summary>
            [NameInMap("PartnerOrderId")]
            [Validation(Required=false)]
            public string PartnerOrderId { get; set; }

            /// <summary>
            /// <para>The specification ID of the order. This parameter is returned only if OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bykj123456</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The specification name of the order. This parameter is returned only if OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CFCA</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>The province or autonomous region in which the organization is located. This parameter is returned only if OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zhejiang</para>
            /// </summary>
            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            /// <summary>
            /// <para>The ID of the resource group. This parameter is returned only if OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-ae******4wia</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The brand of the certificate. Valid values: WoSign, CFCA, DigiCert, and vTrus. This parameter is returned only if OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CFCA</para>
            /// </summary>
            [NameInMap("RootBrand")]
            [Validation(Required=false)]
            public string RootBrand { get; set; }

            /// <summary>
            /// <para>All domain names that are bound to the certificate. Multiple domain names are separated by commas (,). This parameter is returned only if OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun.com</para>
            /// </summary>
            [NameInMap("Sans")]
            [Validation(Required=false)]
            public string Sans { get; set; }

            /// <summary>
            /// <para>The serial number of the certificate. This parameter is returned only if OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>040a6e493cffdda6d744acf99b6576cf</para>
            /// </summary>
            [NameInMap("SerialNo")]
            [Validation(Required=false)]
            public string SerialNo { get; set; }

            /// <summary>
            /// <para>The SHA-2 value of the certificate. This parameter is returned only if OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>56B4DED2243A81DD909D7C39824FFE4DDBD87F91BFA46CD333FF212FE0E7CB11</para>
            /// </summary>
            [NameInMap("Sha2")]
            [Validation(Required=false)]
            public string Sha2 { get; set; }

            /// <summary>
            /// <para>The type of the order. This parameter is returned only if OrderType is set to CPACK or BUY. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cpack</b>: virtual resource order</description></item>
            /// <item><description><b>buy</b>: purchase order</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>buy</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The time at which the certificate starts to take effect. This parameter is returned only if OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-16</para>
            /// </summary>
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// <para>The certificate status of the order. This parameter is returned only if OrderType is set to CPACK or BUY. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PAYED</b>: pending application</description></item>
            /// <item><description><b>CHECKING</b>: reviewing</description></item>
            /// <item><description><b>CHECKED_FAIL</b>: review failed</description></item>
            /// <item><description><b>ISSUED</b>: issued</description></item>
            /// <item><description><b>WILLEXPIRED</b>: about to expire</description></item>
            /// <item><description><b>EXPIRED</b>: expired</description></item>
            /// <item><description><b>NOTACTIVATED</b>: not activated</description></item>
            /// <item><description><b>REVOKED</b>: revoked</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PAYED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The hosting status of the certificate. This parameter is returned only if OrderType is set to CPACK or BUY. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>unTrustee</b>: not hosted</description></item>
            /// <item><description><b>trustee</b>: hosted</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>unTrustee</para>
            /// </summary>
            [NameInMap("TrusteeStatus")]
            [Validation(Required=false)]
            public string TrusteeStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the certificate is an uploaded certificate. This parameter is returned only if OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Upload")]
            [Validation(Required=false)]
            public bool? Upload { get; set; }

            /// <summary>
            /// <para>The number of wildcard domain names that can be bound to the certificate. This parameter is returned only if OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("WildDomainCount")]
            [Validation(Required=false)]
            public long? WildDomainCount { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public long? ShowSize { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
