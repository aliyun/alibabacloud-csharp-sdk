// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class DescribePackageStateResponseBody : TeaModel {
        /// <summary>
        /// The number of issued certificates of the specified specifications.
        /// </summary>
        [NameInMap("IssuedCount")]
        [Validation(Required=false)]
        public long? IssuedCount { get; set; }

        /// <summary>
        /// The specifications of the certificate resource plan. Valid values:
        /// 
        /// *   **digicert-free-1-free**: DigiCert single-domain DV certificate in a three-month free trial, available only on the China site (aliyun.com).
        /// *   **symantec-free-1-free**: DigiCert single-domain DV certificate in a one-year free trial, available only on the China site (aliyun.com).
        /// *   **symantec-dv-1-starter**: DigiCert wildcard DV certificate.
        /// *   **symantec-ov-1-personal**: DigiCert single-domain OV certificate.
        /// *   **symantec-ov-w-personal**: DigiCert wildcard OV certificate.
        /// *   **geotrust-dv-1-starter**: GeoTrust single-domain DV certificate.
        /// *   **geotrust-dv-w-starter**: GeoTrust wildcard DV certificate.
        /// *   **geotrust-ov-1-personal**: GeoTrust single-domain OV certificate.
        /// *   **geotrust-ov-w-personal**: GeoTrust wildcard OV certificate.
        /// *   **globalsign-dv-1-personal**: GlobalSign single-domain DV certificate.
        /// *   **globalsign-dv-w-advanced**: GlobalSign wildcard DV certificate.
        /// *   **globalsign-ov-1-personal**: GlobalSign single-domain OV certificate.
        /// *   **globalsign-ov-w-advanced**: GlobalSign wildcard OV certificate.
        /// *   **cfca-ov-1-personal**: CFCA single-domain OV certificate, available only on the China site (aliyun.com).
        /// *   **cfca-ev-w-advanced**: CFCA wildcard OV certificate, available only on the China site (aliyun.com).
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of purchased certificate resource plans of the specified specifications.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// The number of certificate applications that you submitted for certificates of the specified specifications.
        /// 
        /// > : A successful call of the [CreateCertificateForPackageRequest](https://help.aliyun.com/document_detail/204087.html), [CreateCertificateRequest](https://help.aliyun.com/document_detail/164105.html), or [CreateCertificateWithCsrRequest](https://help.aliyun.com/document_detail/178732.html) operation is counted as one a certificate application, regardless of whether the certificate is issued.
        /// </summary>
        [NameInMap("UsedCount")]
        [Validation(Required=false)]
        public long? UsedCount { get; set; }

    }

}
