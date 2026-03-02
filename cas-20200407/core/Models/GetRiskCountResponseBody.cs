// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class GetRiskCountResponseBody : TeaModel {
        [NameInMap("AliyunAssetCertificateExpiredCount")]
        [Validation(Required=false)]
        public int? AliyunAssetCertificateExpiredCount { get; set; }

        [NameInMap("AliyunAssetCertificateWillExpiredCount")]
        [Validation(Required=false)]
        public int? AliyunAssetCertificateWillExpiredCount { get; set; }

        [NameInMap("BuyCertificateExpireCount")]
        [Validation(Required=false)]
        public int? BuyCertificateExpireCount { get; set; }

        [NameInMap("BuyCertificateNotDeploymentCount")]
        [Validation(Required=false)]
        public int? BuyCertificateNotDeploymentCount { get; set; }

        [NameInMap("BuyCertificateNotTrusteeCount")]
        [Validation(Required=false)]
        public int? BuyCertificateNotTrusteeCount { get; set; }

        [NameInMap("BuyCertificateWillExpiredCount")]
        [Validation(Required=false)]
        public int? BuyCertificateWillExpiredCount { get; set; }

        [NameInMap("BuyCheckedFailCount")]
        [Validation(Required=false)]
        public int? BuyCheckedFailCount { get; set; }

        [NameInMap("DomainAssetNotMonitorCount")]
        [Validation(Required=false)]
        public int? DomainAssetNotMonitorCount { get; set; }

        [NameInMap("FreeCertificateExpireCount")]
        [Validation(Required=false)]
        public int? FreeCertificateExpireCount { get; set; }

        [NameInMap("FreeCertificateNotDeploymentCount")]
        [Validation(Required=false)]
        public int? FreeCertificateNotDeploymentCount { get; set; }

        [NameInMap("FreeCertificateWillExpiredCount")]
        [Validation(Required=false)]
        public int? FreeCertificateWillExpiredCount { get; set; }

        [NameInMap("FreeCheckedFailCount")]
        [Validation(Required=false)]
        public int? FreeCheckedFailCount { get; set; }

        [NameInMap("MultiCloudAssetCertificateExpiredCount")]
        [Validation(Required=false)]
        public int? MultiCloudAssetCertificateExpiredCount { get; set; }

        [NameInMap("MultiCloudAssetCertificateWillExpiredCount")]
        [Validation(Required=false)]
        public int? MultiCloudAssetCertificateWillExpiredCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5BCD2F6C-7A9D-47C1-8588-2CC6A4E0BE5E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UploadCertificateExpireCount")]
        [Validation(Required=false)]
        public int? UploadCertificateExpireCount { get; set; }

        [NameInMap("UploadCertificateNotDeploymentCount")]
        [Validation(Required=false)]
        public int? UploadCertificateNotDeploymentCount { get; set; }

        [NameInMap("UploadCertificateNotNoticeCount")]
        [Validation(Required=false)]
        public int? UploadCertificateNotNoticeCount { get; set; }

        [NameInMap("UploadCertificateWillExpiredCount")]
        [Validation(Required=false)]
        public int? UploadCertificateWillExpiredCount { get; set; }

    }

}
