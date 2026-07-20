// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListUserCertificateOrderResponseBody : TeaModel {
        /// <summary>
        /// <para>The certificate and order list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;CertificateOrderList&quot;: [{&quot;Status&quot;: &quot;PAYED&quot;,&quot;ProductName&quot;: &quot;专业版通配符 OV SSL&quot;,&quot;InstanceId&quot;: &quot;cert-instanceId&quot;,&quot;ProductCode&quot;: &quot;globalsign-xxxx&quot;,&quot;SourceType&quot;: &quot;buy&quot;,&quot;WildDomainCount&quot;: 1,&quot;CertType&quot;: &quot;OV&quot;,&quot;PartnerOrderId&quot;: &quot;&quot;,&quot;OrderId&quot;: 3451111,&quot;Algorithm&quot;: &quot;RSA&quot;,&quot;RootBrand&quot;: &quot;GlobalSign&quot;,&quot;AliyunOrderId&quot;: 21xxxxxx40655,&quot;DomainType&quot;: &quot;WILDCARD&quot;,&quot;TrusteeStatus&quot;: &quot;trustee&quot;,&quot;Domain&quot;: &quot;&quot;,&quot;BuyDate&quot;: 1632649385000,&quot;DomainCount&quot;: 1}]}</para>
        /// </summary>
        [NameInMap("CertificateOrderList")]
        [Validation(Required=false)]
        public List<ListUserCertificateOrderResponseBodyCertificateOrderList> CertificateOrderList { get; set; }
        public class ListUserCertificateOrderResponseBodyCertificateOrderList : TeaModel {
            /// <summary>
            /// <para>The algorithm. Returned when OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RSA</para>
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud order ID. Returned when OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>234567</para>
            /// </summary>
            [NameInMap("AliyunOrderId")]
            [Validation(Required=false)]
            public long? AliyunOrderId { get; set; }

            /// <summary>
            /// <para>The purchase time. Unit: milliseconds. Returned when OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1634283958000</para>
            /// </summary>
            [NameInMap("BuyDate")]
            [Validation(Required=false)]
            public long? BuyDate { get; set; }

            /// <summary>
            /// <para>The certificate expiration time. Unit: milliseconds. Returned when OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665819958000</para>
            /// </summary>
            [NameInMap("CertEndTime")]
            [Validation(Required=false)]
            public long? CertEndTime { get; set; }

            /// <summary>
            /// <para>The certificate start time. Unit: milliseconds. Returned when OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665819958000</para>
            /// </summary>
            [NameInMap("CertStartTime")]
            [Validation(Required=false)]
            public long? CertStartTime { get; set; }

            /// <summary>
            /// <para>The certificate type. Returned when OrderType is set to CPACK or BUY. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>DV</b>: DV certificate.</description></item>
            /// <item><description><b>EV</b>: EV certificate.</description></item>
            /// <item><description><b>OV</b>: OV certificate.</description></item>
            /// <item><description><b>FREE</b>: personal test certificate (supported only on the China site).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FREE</para>
            /// </summary>
            [NameInMap("CertType")]
            [Validation(Required=false)]
            public string CertType { get; set; }

            /// <summary>
            /// <para>The certificate ID. Returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>896521</para>
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public long? CertificateId { get; set; }

            /// <summary>
            /// <para>The city. Returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>杭州市</para>
            /// </summary>
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// <para>The common name of the certificate. Returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun.com</para>
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// <para>The country code. Returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            /// <summary>
            /// <para>The domain name. Returned when OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyundoc.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The total number of purchased domain names. Returned when OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DomainCount")]
            [Validation(Required=false)]
            public long? DomainCount { get; set; }

            /// <summary>
            /// <para>The domain name type. Returned when OrderType is set to CPACK or BUY. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ONE</b>: single domain name.</description></item>
            /// <item><description><b>MULTIPLE</b>: multiple domain names.</description></item>
            /// <item><description><b>WILDCARD</b>: single wildcard domain name.</description></item>
            /// <item><description><b>M_WILDCARD</b>: multiple wildcard domain names.</description></item>
            /// <item><description><b>MIX</b>: hybrid domain names.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ONE</para>
            /// </summary>
            [NameInMap("DomainType")]
            [Validation(Required=false)]
            public string DomainType { get; set; }

            /// <summary>
            /// <para>The certificate end date. Returned when OrderType is set to CERT or UPLOAD. The date is in the YYYY-MM-DD format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-17</para>
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// <para>Indicates whether the certificate has expired. Returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Expired")]
            [Validation(Required=false)]
            public bool? Expired { get; set; }

            /// <summary>
            /// <para>The certificate fingerprint. Returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CC6B3696E7C7CA715BD26E28E45FF3E3DF435C03</para>
            /// </summary>
            [NameInMap("Fingerprint")]
            [Validation(Required=false)]
            public string Fingerprint { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cas-instanceId</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The certificate issuer. Returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyIssuer</para>
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// <para>The certificate name. Returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cert-name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The order ID. Returned when OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2345687</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// <para>The organization name of the certificate. Returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>阿里云</para>
            /// </summary>
            [NameInMap("OrgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            /// <summary>
            /// <para>The third-party CA order ID. Returned when OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca-123456</para>
            /// </summary>
            [NameInMap("PartnerOrderId")]
            [Validation(Required=false)]
            public string PartnerOrderId { get; set; }

            /// <summary>
            /// <para>The order specification ID. Returned when OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bykj123456</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The order specification name. Returned when OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CFCA</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>The province or autonomous region. Returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>浙江省</para>
            /// </summary>
            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            /// <summary>
            /// <para>The resource group ID. Returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-ae******4wia</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The brand (such as WoSign, CFCA, DigiCert, and vTrus). Returned when OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CFCA</para>
            /// </summary>
            [NameInMap("RootBrand")]
            [Validation(Required=false)]
            public string RootBrand { get; set; }

            /// <summary>
            /// <para>All domain names bound to the certificate. Multiple domain names are separated by commas (,). Returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun.com</para>
            /// </summary>
            [NameInMap("Sans")]
            [Validation(Required=false)]
            public string Sans { get; set; }

            /// <summary>
            /// <para>The certificate serial number. Returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>040a6e493cffdda6d744acf99b6576cf</para>
            /// </summary>
            [NameInMap("SerialNo")]
            [Validation(Required=false)]
            public string SerialNo { get; set; }

            /// <summary>
            /// <para>The SHA-2 value of the certificate. Returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>56B4DED2243A81DD909D7C39824FFE4DDBD87F91BFA46CD333FF212FE0E7CB11</para>
            /// </summary>
            [NameInMap("Sha2")]
            [Validation(Required=false)]
            public string Sha2 { get; set; }

            /// <summary>
            /// <para>The order type. Returned when OrderType is set to CPACK or BUY. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cpack</b>: resource virtual order.</description></item>
            /// <item><description><b>buy</b>: purchase order.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>buy</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The certificate start date. Returned when OrderType is set to CERT or UPLOAD. The date is in the YYYY-MM-DD format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-16</para>
            /// </summary>
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// <para>The order or certificate status. Returned when OrderType is set to CPACK or BUY. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PAYED</b>: Pending application.</description></item>
            /// <item><description><b>CHECKING</b>: Under review.</description></item>
            /// <item><description><b>CHECKED_FAIL</b>: Review failed.</description></item>
            /// <item><description><b>ISSUED</b>: Issued.</description></item>
            /// <item><description><b>WILLEXPIRED</b>: About to expire.</description></item>
            /// <item><description><b>EXPIRED</b>: Expired.</description></item>
            /// <item><description><b>NOTACTIVATED</b>: Not activated.</description></item>
            /// <item><description><b>REVOKED</b>: Revoked.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PAYED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The hosting status. Returned when OrderType is set to CPACK or BUY. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>unTrustee</b>: Not hosted.</description></item>
            /// <item><description><b>trustee</b>: Hosted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>unTrustee</para>
            /// </summary>
            [NameInMap("TrusteeStatus")]
            [Validation(Required=false)]
            public string TrusteeStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the certificate is an uploaded certificate. Returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Upload")]
            [Validation(Required=false)]
            public bool? Upload { get; set; }

            /// <summary>
            /// <para>The number of purchased wildcard domain names. Returned when OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("WildDomainCount")]
            [Validation(Required=false)]
            public long? WildDomainCount { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
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
