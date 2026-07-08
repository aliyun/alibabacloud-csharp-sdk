// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class GetRiskCountResponseBody : TeaModel {
        /// <summary>
        /// <para>Number of expired Alibaba Cloud certificates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AliyunAssetCertificateExpiredCount")]
        [Validation(Required=false)]
        public int? AliyunAssetCertificateExpiredCount { get; set; }

        /// <summary>
        /// <para>Number of Alibaba Cloud certificates that will expire soon.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AliyunAssetCertificateWillExpiredCount")]
        [Validation(Required=false)]
        public int? AliyunAssetCertificateWillExpiredCount { get; set; }

        /// <summary>
        /// <para>Number of expired paid certificates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("BuyCertificateExpireCount")]
        [Validation(Required=false)]
        public int? BuyCertificateExpireCount { get; set; }

        /// <summary>
        /// <para>Number of paid certificates not deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("BuyCertificateNotDeploymentCount")]
        [Validation(Required=false)]
        public int? BuyCertificateNotDeploymentCount { get; set; }

        /// <summary>
        /// <para>Number of paid certificates not managed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("BuyCertificateNotTrusteeCount")]
        [Validation(Required=false)]
        public int? BuyCertificateNotTrusteeCount { get; set; }

        /// <summary>
        /// <para>Number of paid certificates that will expire soon.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("BuyCertificateWillExpiredCount")]
        [Validation(Required=false)]
        public int? BuyCertificateWillExpiredCount { get; set; }

        /// <summary>
        /// <para>Number of failed paid certificate orders.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("BuyCheckedFailCount")]
        [Validation(Required=false)]
        public int? BuyCheckedFailCount { get; set; }

        /// <summary>
        /// <para>Number of domains without monitoring configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("DomainAssetNotMonitorCount")]
        [Validation(Required=false)]
        public int? DomainAssetNotMonitorCount { get; set; }

        /// <summary>
        /// <para>Number of expired free certificates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("FreeCertificateExpireCount")]
        [Validation(Required=false)]
        public int? FreeCertificateExpireCount { get; set; }

        /// <summary>
        /// <para>Number of free certificates not deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("FreeCertificateNotDeploymentCount")]
        [Validation(Required=false)]
        public int? FreeCertificateNotDeploymentCount { get; set; }

        /// <summary>
        /// <para>Number of free certificates that will expire soon.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("FreeCertificateWillExpiredCount")]
        [Validation(Required=false)]
        public int? FreeCertificateWillExpiredCount { get; set; }

        /// <summary>
        /// <para>Number of failed free certificate orders.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("FreeCheckedFailCount")]
        [Validation(Required=false)]
        public int? FreeCheckedFailCount { get; set; }

        /// <summary>
        /// <para>Number of expired multicloud certificates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MultiCloudAssetCertificateExpiredCount")]
        [Validation(Required=false)]
        public int? MultiCloudAssetCertificateExpiredCount { get; set; }

        /// <summary>
        /// <para>Number of multicloud certificates that will expire soon.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MultiCloudAssetCertificateWillExpiredCount")]
        [Validation(Required=false)]
        public int? MultiCloudAssetCertificateWillExpiredCount { get; set; }

        /// <summary>
        /// <para>The ID of this API call. Alibaba Cloud generates this unique identifier for each request. Use it to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5BCD2F6C-7A9D-47C1-8588-2CC6A4E0BE5E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Number of expired uploaded certificates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("UploadCertificateExpireCount")]
        [Validation(Required=false)]
        public int? UploadCertificateExpireCount { get; set; }

        /// <summary>
        /// <para>Number of uploaded certificates not deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("UploadCertificateNotDeploymentCount")]
        [Validation(Required=false)]
        public int? UploadCertificateNotDeploymentCount { get; set; }

        /// <summary>
        /// <para>Number of uploaded certificates without alerting configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("UploadCertificateNotNoticeCount")]
        [Validation(Required=false)]
        public int? UploadCertificateNotNoticeCount { get; set; }

        /// <summary>
        /// <para>Number of uploaded certificates that will expire soon.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("UploadCertificateWillExpiredCount")]
        [Validation(Required=false)]
        public int? UploadCertificateWillExpiredCount { get; set; }

    }

}
