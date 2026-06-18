// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetCustomHostnameResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the queried SaaS domain name.</para>
        /// </summary>
        [NameInMap("CustomHostnameModel")]
        [Validation(Required=false)]
        public GetCustomHostnameResponseBodyCustomHostnameModel CustomHostnameModel { get; set; }
        public class GetCustomHostnameResponseBodyCustomHostnameModel : TeaModel {
            /// <summary>
            /// <para>The SSL Certificates Service certificate ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000478</para>
            /// </summary>
            [NameInMap("CasId")]
            [Validation(Required=false)]
            public long? CasId { get; set; }

            /// <summary>
            /// <para>The error code for the free certificate application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CertApplyCode")]
            [Validation(Required=false)]
            public long? CertApplyCode { get; set; }

            /// <summary>
            /// <para>The error description for the free certificate application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>canceled</para>
            /// </summary>
            [NameInMap("CertApplyMessage")]
            [Validation(Required=false)]
            public string CertApplyMessage { get; set; }

            /// <summary>
            /// <para>The certificate verification HTTP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://custom.site.com/.well-known/acme-challenge/jLmMHlEaZ3jb352Qo3ciaSoAC8KZ5Hk0F-4_1xLQtgc">http://custom.site.com/.well-known/acme-challenge/jLmMHlEaZ3jb352Qo3ciaSoAC8KZ5Hk0F-4_1xLQtgc</a></para>
            /// </summary>
            [NameInMap("CertHttpKey")]
            [Validation(Required=false)]
            public string CertHttpKey { get; set; }

            /// <summary>
            /// <para>The certificate verification HTTP content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jLmMHlEaZ3jb352Qo3ciaSoAC8KZ5Hk0F-4_1xLQtgc.GridYdfJJB5PgFEL-t89XfaFvMPB4f2-I9fwLpKl6e0</para>
            /// </summary>
            [NameInMap("CertHttpValue")]
            [Validation(Required=false)]
            public string CertHttpValue { get; set; }

            /// <summary>
            /// <para>The certificate ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>baba2c9e90e840b3b55698cedf02b308</para>
            /// </summary>
            [NameInMap("CertId")]
            [Validation(Required=false)]
            public string CertId { get; set; }

            /// <summary>
            /// <para>The certificate expiration time. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-19T11:15:20Z</para>
            /// </summary>
            [NameInMap("CertNotAfter")]
            [Validation(Required=false)]
            public string CertNotAfter { get; set; }

            /// <summary>
            /// <para>The certificate status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>OK</b>: Normal.</description></item>
            /// <item><description><b>Applying</b>: Being applied.</description></item>
            /// <item><description><b>ApplyFailed</b>: Application failed.</description></item>
            /// <item><description><b>Expiring</b>: About to expire.</description></item>
            /// <item><description><b>Expired</b>: Expired.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("CertStatus")]
            [Validation(Required=false)]
            public string CertStatus { get; set; }

            /// <summary>
            /// <para>The certificate verification TXT name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_acme-challenge.custom.site.com</para>
            /// </summary>
            [NameInMap("CertTxtKey")]
            [Validation(Required=false)]
            public string CertTxtKey { get; set; }

            /// <summary>
            /// <para>The certificate verification TXT content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lcKYad3UQXgrZLvMm_6TBUYKK4xTkGmninV0Mzx4gjM</para>
            /// </summary>
            [NameInMap("CertTxtValue")]
            [Validation(Required=false)]
            public string CertTxtValue { get; set; }

            /// <summary>
            /// <para>The certificate type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>free</b>: Free certificate.</description></item>
            /// <item><description><b>upload</b>: Uploaded certificate.</description></item>
            /// <item><description><b>cas</b>: SSL Certificates Service certificate.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>free</para>
            /// </summary>
            [NameInMap("CertType")]
            [Validation(Required=false)]
            public string CertType { get; set; }

            /// <summary>
            /// <para>The certificate content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-----BEGIN CERTIFICATE-----</para>
            /// </summary>
            [NameInMap("Certificate")]
            [Validation(Required=false)]
            public string Certificate { get; set; }

            /// <summary>
            /// <para>The reason why the SaaS domain name is occupied. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>existing_custom_hostname</b>: Conflicts with an existing SaaS domain name.</description></item>
            /// <item><description><b>existing_record</b>: Conflicts with an existing site record.</description></item>
            /// <item><description><b>existing_load_balancer</b>: Conflicts with an existing load balancing instance.</description></item>
            /// <item><description><b>existing_origin_pool</b>: Conflicts with an existing origin IPAM pool.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>existing_custom_hostname</para>
            /// </summary>
            [NameInMap("ConflictWith")]
            [Validation(Required=false)]
            public string ConflictWith { get; set; }

            /// <summary>
            /// <para>The time when the SaaS domain name was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-19T11:15:20Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The SaaS domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom.site.com</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <para>The ID of the SaaS domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890123</para>
            /// </summary>
            [NameInMap("HostnameId")]
            [Validation(Required=false)]
            public long? HostnameId { get; set; }

            /// <summary>
            /// <para>The reason why the SaaS domain name was taken offline. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>expiration_arrears</b>: The subscription plan expired or the account has an overdue payment.</description></item>
            /// <item><description><b>internally_disabled</b>: Disabled by the system.</description></item>
            /// <item><description><b>missing_icp</b>: The domain name does not have an ICP filing.</description></item>
            /// <item><description><b>content_violation</b>: Content violation.</description></item>
            /// <item><description><b>proactively_disabled</b>: You proactively disabled the domain name or the usage cap that you configured was reached.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>missing_icp</para>
            /// </summary>
            [NameInMap("OfflineReason")]
            [Validation(Required=false)]
            public string OfflineReason { get; set; }

            /// <summary>
            /// <para>The private key of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-----BEGIN RSA PRIVATE KEY-----</para>
            /// </summary>
            [NameInMap("PrivateKey")]
            [Validation(Required=false)]
            public string PrivateKey { get; set; }

            /// <summary>
            /// <para>The record ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4042843419650112</para>
            /// </summary>
            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public long? RecordId { get; set; }

            /// <summary>
            /// <para>The record name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>origin.example.com</para>
            /// </summary>
            [NameInMap("RecordName")]
            [Validation(Required=false)]
            public string RecordName { get; set; }

            /// <summary>
            /// <para>The site ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>890601022130656</para>
            /// </summary>
            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public long? SiteId { get; set; }

            /// <summary>
            /// <para>The site name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("SiteName")]
            [Validation(Required=false)]
            public string SiteName { get; set; }

            /// <summary>
            /// <para>The SSL switch. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: SSL is enabled.</description></item>
            /// <item><description><b>off</b>: SSL is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("SslFlag")]
            [Validation(Required=false)]
            public string SslFlag { get; set; }

            /// <summary>
            /// <para>The status of the SaaS domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>pending</b>: Pending verification.</description></item>
            /// <item><description><b>active</b>: Activated.</description></item>
            /// <item><description><b>conflicted</b>: Occupied.</description></item>
            /// <item><description><b>offline</b>: Offline.</description></item>
            /// <item><description><b>configuring</b>: Being configured.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the SaaS domain name was last updated. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-19T11:15:20Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The domain verification TXT content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>verify_16ab7f4d389d4dff6655f995c6a997bd</para>
            /// </summary>
            [NameInMap("VerifyCode")]
            [Validation(Required=false)]
            public string VerifyCode { get; set; }

            /// <summary>
            /// <para>The domain verification TXT name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_esa_custom_hostname.custom.site.com</para>
            /// </summary>
            [NameInMap("VerifyHost")]
            [Validation(Required=false)]
            public string VerifyHost { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C414690-9D7B-5D66-9CD9-AD0B3F25ED49</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
