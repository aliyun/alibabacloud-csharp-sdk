// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListUserCertificateOrderResponseBody : TeaModel {
        /// <summary>
        /// The certificates and orders.
        /// </summary>
        [NameInMap("CertificateOrderList")]
        [Validation(Required=false)]
        public List<ListUserCertificateOrderResponseBodyCertificateOrderList> CertificateOrderList { get; set; }
        public class ListUserCertificateOrderResponseBodyCertificateOrderList : TeaModel {
            /// <summary>
            /// The algorithm. This parameter is returned only if OrderType is set to CPACK or BUY.
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud order. This parameter is returned only if OrderType is set to CPACK or BUY.
            /// </summary>
            [NameInMap("AliyunOrderId")]
            [Validation(Required=false)]
            public long? AliyunOrderId { get; set; }

            /// <summary>
            /// The time at which the order was placed. Unit: milliseconds. This parameter is returned only if OrderType is set to CPACK or BUY.
            /// </summary>
            [NameInMap("BuyDate")]
            [Validation(Required=false)]
            public long? BuyDate { get; set; }

            /// <summary>
            /// The time at which the certificate expires. Unit: milliseconds. This parameter is returned only if OrderType is set to CPACK or BUY.
            /// </summary>
            [NameInMap("CertEndTime")]
            [Validation(Required=false)]
            public long? CertEndTime { get; set; }

            /// <summary>
            /// The time at which the certificate starts to take effect. Unit: milliseconds. This parameter is returned only if OrderType is set to CPACK or BUY.
            /// </summary>
            [NameInMap("CertStartTime")]
            [Validation(Required=false)]
            public long? CertStartTime { get; set; }

            /// <summary>
            /// The type of the certificate. This parameter is returned only if OrderType is set to CPACK or BUY. Valid values:
            /// 
            /// *   **DV**: domain validated (DV) certificate
            /// *   **EV**: extended validation (EV) certificate
            /// *   **OV**: organization validated (OV) certificate **FREE**: free certificate, available only on the China site (aliyun.com)
            /// </summary>
            [NameInMap("CertType")]
            [Validation(Required=false)]
            public string CertType { get; set; }

            /// <summary>
            /// The ID of the certificate. This parameter is returned only if OrderType is set to CERT or UPLOAD.
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public long? CertificateId { get; set; }

            /// <summary>
            /// The city in which the organization is located. This parameter is returned only if OrderType is set to CERT or UPLOAD.
            /// </summary>
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// The parent domain name of the certificate. This parameter is returned only if OrderType is set to CERT or UPLOAD.
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// The code of the country in which the organization is located. This parameter is returned only if OrderType is set to CERT or UPLOAD.
            /// </summary>
            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            /// <summary>
            /// The domain name. This parameter is returned only if OrderType is set to CPACK or BUY.
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The total number of domain names that can be bound to the certificate. This parameter is returned only if OrderType is set to CPACK or BUY.
            /// </summary>
            [NameInMap("DomainCount")]
            [Validation(Required=false)]
            public long? DomainCount { get; set; }

            /// <summary>
            /// The type of the domain name. This parameter is returned only if OrderType is set to CPACK or BUY. Valid values:
            /// 
            /// *   **ONE**: single domain name
            /// *   **MULTIPLE**: multiple domain names
            /// *   **WILDCARD**: single wildcard domain name
            /// *   **M_WILDCARD**: multiple wildcard domain names
            /// *   **MIX**: hybrid domain name
            /// </summary>
            [NameInMap("DomainType")]
            [Validation(Required=false)]
            public string DomainType { get; set; }

            /// <summary>
            /// The time at which the certificate expires. This parameter is returned only if OrderType is set to CERT or UPLOAD.
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// Indicates whether the certificate expires. This parameter is returned only if OrderType is set to CERT or UPLOAD.
            /// </summary>
            [NameInMap("Expired")]
            [Validation(Required=false)]
            public bool? Expired { get; set; }

            /// <summary>
            /// The fingerprint of the certificate. This parameter is returned only if OrderType is set to CERT or UPLOAD.
            /// </summary>
            [NameInMap("Fingerprint")]
            [Validation(Required=false)]
            public string Fingerprint { get; set; }

            /// <summary>
            /// The ID of the resource.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The issuer of the certificate. This parameter is returned only if OrderType is set to CERT or UPLOAD.
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// The name of the certificate. This parameter is returned only if OrderType is set to CERT or UPLOAD.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The order ID. This parameter is returned only if OrderType is set to CPACK or BUY.
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// The name of the organization that is associated with the certificate. This parameter is returned only if OrderType is set to CERT or UPLOAD.
            /// </summary>
            [NameInMap("OrgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            /// <summary>
            /// The ID of the third-party certificate authority (CA) order. This parameter is returned only if OrderType is set to CPACK or BUY.
            /// </summary>
            [NameInMap("PartnerOrderId")]
            [Validation(Required=false)]
            public string PartnerOrderId { get; set; }

            /// <summary>
            /// The specification ID of the order. This parameter is returned only if OrderType is set to CPACK or BUY.
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// The specification name of the order. This parameter is returned only if OrderType is set to CPACK or BUY.
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// The province or autonomous region in which the organization is located. This parameter is returned only if OrderType is set to CERT or UPLOAD.
            /// </summary>
            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            /// <summary>
            /// The ID of the resource group. This parameter is returned only if OrderType is set to CERT or UPLOAD.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The brand of the certificate. Valid values: WoSign, CFCA, DigiCert, and vTrus. This parameter is returned only if OrderType is set to CPACK or BUY.
            /// </summary>
            [NameInMap("RootBrand")]
            [Validation(Required=false)]
            public string RootBrand { get; set; }

            /// <summary>
            /// All domain names that are bound to the certificate. Multiple domain names are separated by commas (,). This parameter is returned only if OrderType is set to CERT or UPLOAD.
            /// </summary>
            [NameInMap("Sans")]
            [Validation(Required=false)]
            public string Sans { get; set; }

            /// <summary>
            /// The serial number of the certificate. This parameter is returned only if OrderType is set to CERT or UPLOAD.
            /// </summary>
            [NameInMap("SerialNo")]
            [Validation(Required=false)]
            public string SerialNo { get; set; }

            /// <summary>
            /// The SHA-2 value of the certificate. This parameter is returned only if OrderType is set to CERT or UPLOAD.
            /// </summary>
            [NameInMap("Sha2")]
            [Validation(Required=false)]
            public string Sha2 { get; set; }

            /// <summary>
            /// The type of the order. This parameter is returned only if OrderType is set to CPACK or BUY. Valid values:
            /// 
            /// *   **cpack**: virtual resource order
            /// *   **buy**: purchase order
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// The time at which the certificate starts to take effect. This parameter is returned only if OrderType is set to CERT or UPLOAD.
            /// </summary>
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// The certificate status of the order. This parameter is returned only if OrderType is set to CPACK or BUY. Valid values:
            /// 
            /// *   **PAYED**: pending application
            /// *   **CHECKING**: reviewing
            /// *   **CHECKED_FAIL**: review failed
            /// *   **ISSUED**: issued
            /// *   **WILLEXPIRED**: about to expire
            /// *   **EXPIRED**: expired
            /// *   **NOTACTIVATED**: not activated
            /// *   **REVOKED**: revoked
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The hosting status of the certificate. This parameter is returned only if OrderType is set to CPACK or BUY. Valid values:
            /// 
            /// *   **unTrustee**: not hosted
            /// *   **trustee**: hosted
            /// </summary>
            [NameInMap("TrusteeStatus")]
            [Validation(Required=false)]
            public string TrusteeStatus { get; set; }

            /// <summary>
            /// Indicates whether the certificate is an uploaded certificate. This parameter is returned only if OrderType is set to CERT or UPLOAD.
            /// </summary>
            [NameInMap("Upload")]
            [Validation(Required=false)]
            public bool? Upload { get; set; }

            /// <summary>
            /// The number of wildcard domain names that can be bound to the certificate. This parameter is returned only if OrderType is set to CPACK or BUY.
            /// </summary>
            [NameInMap("WildDomainCount")]
            [Validation(Required=false)]
            public long? WildDomainCount { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public long? ShowSize { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
