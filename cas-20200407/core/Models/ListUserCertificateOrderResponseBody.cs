// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListUserCertificateOrderResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of certificates and orders.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;CertificateOrderList&quot;: [{&quot;Status&quot;: &quot;PAYED&quot;,&quot;ProductName&quot;: &quot;专业版通配符 OV SSL&quot;,&quot;InstanceId&quot;: &quot;cert-instanceId&quot;,&quot;ProductCode&quot;: &quot;globalsign-xxxx&quot;,&quot;SourceType&quot;: &quot;buy&quot;,&quot;WildDomainCount&quot;: 1,&quot;CertType&quot;: &quot;OV&quot;,&quot;PartnerOrderId&quot;: &quot;&quot;,&quot;OrderId&quot;: 3451111,&quot;Algorithm&quot;: &quot;RSA&quot;,&quot;RootBrand&quot;: &quot;GlobalSign&quot;,&quot;AliyunOrderId&quot;: 21xxxxxx40655,&quot;DomainType&quot;: &quot;WILDCARD&quot;,&quot;TrusteeStatus&quot;: &quot;trustee&quot;,&quot;Domain&quot;: &quot;&quot;,&quot;BuyDate&quot;: 1632649385000,&quot;DomainCount&quot;: 1}]}</para>
        /// </summary>
        [NameInMap("CertificateOrderList")]
        [Validation(Required=false)]
        public List<ListUserCertificateOrderResponseBodyCertificateOrderList> CertificateOrderList { get; set; }
        public class ListUserCertificateOrderResponseBodyCertificateOrderList : TeaModel {
            /// <summary>
            /// <para>The algorithm. This parameter is returned when OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RSA</para>
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud order. This parameter is returned when OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>234567</para>
            /// </summary>
            [NameInMap("AliyunOrderId")]
            [Validation(Required=false)]
            public long? AliyunOrderId { get; set; }

            /// <summary>
            /// <para>The purchase time. The value is a UNIX timestamp. Unit: milliseconds. This parameter is returned when OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1634283958000</para>
            /// </summary>
            [NameInMap("BuyDate")]
            [Validation(Required=false)]
            public long? BuyDate { get; set; }

            /// <summary>
            /// <para>The expiration time of the certificate. The value is a UNIX timestamp. Unit: milliseconds. This parameter is returned when OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665819958000</para>
            /// </summary>
            [NameInMap("CertEndTime")]
            [Validation(Required=false)]
            public long? CertEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the certificate. The value is a UNIX timestamp. Unit: milliseconds. This parameter is returned when OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665819958000</para>
            /// </summary>
            [NameInMap("CertStartTime")]
            [Validation(Required=false)]
            public long? CertStartTime { get; set; }

            /// <summary>
            /// <para>The certificate type. This parameter is returned when OrderType is set to CPACK or BUY. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>DV</b>: A DV certificate.</para>
            /// </description></item>
            /// <item><description><para><b>EV</b>: An EV certificate.</para>
            /// </description></item>
            /// <item><description><para><b>OV</b>: An OV certificate.</para>
            /// </description></item>
            /// <item><description><para><b>FREE</b>: A free certificate for personal trial. This value is supported only on the Alibaba Cloud China website (www\.aliyun.com).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FREE</para>
            /// </summary>
            [NameInMap("CertType")]
            [Validation(Required=false)]
            public string CertType { get; set; }

            /// <summary>
            /// <para>The certificate ID. This parameter is returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>896521</para>
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public long? CertificateId { get; set; }

            /// <summary>
            /// <para>The city. This parameter is returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>杭州市</para>
            /// </summary>
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// <para>The primary domain name of the certificate. This parameter is returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun.com</para>
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// <para>The country code. This parameter is returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            /// <summary>
            /// <para>The domain name. This parameter is returned when OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyundoc.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The number of domain names that you purchased. This parameter is returned when OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DomainCount")]
            [Validation(Required=false)]
            public long? DomainCount { get; set; }

            /// <summary>
            /// <para>The domain name type. This parameter is returned when OrderType is set to CPACK or BUY. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ONE</b>: A single domain name.</para>
            /// </description></item>
            /// <item><description><para><b>MULTIPLE</b>: Multiple domain names.</para>
            /// </description></item>
            /// <item><description><para><b>WILDCARD</b>: A single wildcard domain name.</para>
            /// </description></item>
            /// <item><description><para><b>M_WILDCARD</b>: Multiple wildcard domain names.</para>
            /// </description></item>
            /// <item><description><para><b>MIX</b>: A hybrid domain name.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ONE</para>
            /// </summary>
            [NameInMap("DomainType")]
            [Validation(Required=false)]
            public string DomainType { get; set; }

            /// <summary>
            /// <para>The end date of the certificate. This parameter is returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-17</para>
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// <para>Indicates whether the certificate has expired. This parameter is returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Expired")]
            [Validation(Required=false)]
            public bool? Expired { get; set; }

            /// <summary>
            /// <para>The certificate fingerprint. This parameter is returned when OrderType is set to CERT or UPLOAD.</para>
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
            /// <para>The issuer of the certificate. This parameter is returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyIssuer</para>
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// <para>The certificate name. This parameter is returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cert-name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The order ID. This parameter is returned when OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2345687</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// <para>The name of the organization that is associated with the certificate. This parameter is returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>阿里云</para>
            /// </summary>
            [NameInMap("OrgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            /// <summary>
            /// <para>The ID of the third-party certificate authority (CA) order. This parameter is returned when OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca-123456</para>
            /// </summary>
            [NameInMap("PartnerOrderId")]
            [Validation(Required=false)]
            public string PartnerOrderId { get; set; }

            /// <summary>
            /// <para>The code for the product specifications. This parameter is returned when OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bykj123456</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The name of the product specifications. This parameter is returned when OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CFCA</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>The province or autonomous region. This parameter is returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>浙江省</para>
            /// </summary>
            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            /// <summary>
            /// <para>The ID of the resource group. This parameter is returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-ae******4wia</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The brand, such as WoSign, CFCA, DigiCert, and vTrus. This parameter is returned when OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CFCA</para>
            /// </summary>
            [NameInMap("RootBrand")]
            [Validation(Required=false)]
            public string RootBrand { get; set; }

            /// <summary>
            /// <para>The domain names that are bound to the certificate. Multiple domain names are separated by commas (,). This parameter is returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun.com</para>
            /// </summary>
            [NameInMap("Sans")]
            [Validation(Required=false)]
            public string Sans { get; set; }

            /// <summary>
            /// <para>The certificate serial number. This parameter is returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>040a6e493cffdda6d744acf99b6576cf</para>
            /// </summary>
            [NameInMap("SerialNo")]
            [Validation(Required=false)]
            public string SerialNo { get; set; }

            /// <summary>
            /// <para>The SHA-2 value of the certificate. This parameter is returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>56B4DED2243A81DD909D7C39824FFE4DDBD87F91BFA46CD333FF212FE0E7CB11</para>
            /// </summary>
            [NameInMap("Sha2")]
            [Validation(Required=false)]
            public string Sha2 { get; set; }

            /// <summary>
            /// <para>The order type. This parameter is returned when OrderType is set to CPACK or BUY.</para>
            /// <list type="bullet">
            /// <item><description><para><b>cpack</b>: An order for a resource plan.</para>
            /// </description></item>
            /// <item><description><para><b>buy</b>: A direct purchase.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>buy</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The start date of the certificate. This parameter is returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-16</para>
            /// </summary>
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// <para>The status of the order or certificate. This parameter is returned when OrderType is set to CPACK or BUY.</para>
            /// <list type="bullet">
            /// <item><description><para><b>PAYED</b>: The certificate is pending application.</para>
            /// </description></item>
            /// <item><description><para><b>CHECKING</b>: The certificate is under review.</para>
            /// </description></item>
            /// <item><description><para><b>CHECKED_FAIL</b>: The review failed.</para>
            /// </description></item>
            /// <item><description><para><b>ISSUED</b>: The certificate is issued.</para>
            /// </description></item>
            /// <item><description><para><b>WILLEXPIRED</b>: The certificate is about to expire.</para>
            /// </description></item>
            /// <item><description><para><b>EXPIRED</b>: The certificate has expired.</para>
            /// </description></item>
            /// <item><description><para><b>NOTACTIVATED</b>: The certificate is not activated.</para>
            /// </description></item>
            /// <item><description><para><b>REVOKED</b>: The certificate is revoked.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PAYED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The hosting status. This parameter is returned when OrderType is set to CPACK or BUY.</para>
            /// <list type="bullet">
            /// <item><description><para><b>unTrustee</b>: Not hosted.</para>
            /// </description></item>
            /// <item><description><para><b>trustee</b>: Hosted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>unTrustee</para>
            /// </summary>
            [NameInMap("TrusteeStatus")]
            [Validation(Required=false)]
            public string TrusteeStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the certificate is an uploaded certificate. This parameter is returned when OrderType is set to CERT or UPLOAD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Upload")]
            [Validation(Required=false)]
            public bool? Upload { get; set; }

            /// <summary>
            /// <para>The number of wildcard domain names that you purchased. This parameter is returned when OrderType is set to CPACK or BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("WildDomainCount")]
            [Validation(Required=false)]
            public long? WildDomainCount { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The request ID. This ID is unique to each request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public long? ShowSize { get; set; }

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
