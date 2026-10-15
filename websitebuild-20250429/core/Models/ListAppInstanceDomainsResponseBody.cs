// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ListAppInstanceDomainsResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed reason for the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Indicates whether a retry is allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dewuApp</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message, which is used to replace <c>%s</c> in the <b>ErrMessage</b> response parameter.</para>
        /// <remarks>
        /// <para>If <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>DtsJobId</b>, it indicates that the <b>DtsJobId</b> request parameter is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM_ERROR</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The returned error parameters.</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>The number of entries to return for a single query.</para>
        /// <para>Valid values: 10 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public ListAppInstanceDomainsResponseBodyModule Module { get; set; }
        public class ListAppInstanceDomainsResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPageNum")]
            [Validation(Required=false)]
            public int? CurrentPageNum { get; set; }

            /// <summary>
            /// <para>The request result.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListAppInstanceDomainsResponseBodyModuleData> Data { get; set; }
            public class ListAppInstanceDomainsResponseBodyModuleData : TeaModel {
                /// <summary>
                /// <para>The SSL certificate information of the domain name.</para>
                /// </summary>
                [NameInMap("Certificate")]
                [Validation(Required=false)]
                public ListAppInstanceDomainsResponseBodyModuleDataCertificate Certificate { get; set; }
                public class ListAppInstanceDomainsResponseBodyModuleDataCertificate : TeaModel {
                    /// <summary>
                    /// <para>The certificate name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024</para>
                    /// </summary>
                    [NameInMap("CertificateName")]
                    [Validation(Required=false)]
                    public string CertificateName { get; set; }

                    /// <summary>
                    /// <para>The certificate status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ACTIVE</para>
                    /// </summary>
                    [NameInMap("CertificateStatus")]
                    [Validation(Required=false)]
                    public string CertificateStatus { get; set; }

                    /// <summary>
                    /// <para>The certificate type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>self-signed</para>
                    /// </summary>
                    [NameInMap("CertificateType")]
                    [Validation(Required=false)]
                    public string CertificateType { get; set; }

                    /// <summary>
                    /// <para>The expiration time of the certificate. The value is a UNIX timestamp in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4885718400000</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                }

                /// <summary>
                /// <para>The creation time of the instance. Format: yyyy-MM-dd HH:mm:ss. This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1683256054000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The network hosting type. Valid values: CDN, INDEP_DEPLOY, and ESA_SAAS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CDN</para>
                /// </summary>
                [NameInMap("DeployType")]
                [Validation(Required=false)]
                public string DeployType { get; set; }

                /// <summary>
                /// <para>The DNS conflict information. This parameter is returned when resolveStatus is DNS_CONFLICT.</para>
                /// </summary>
                [NameInMap("DnsConflict")]
                [Validation(Required=false)]
                public ListAppInstanceDomainsResponseBodyModuleDataDnsConflict DnsConflict { get; set; }
                public class ListAppInstanceDomainsResponseBodyModuleDataDnsConflict : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether automatic override is supported. Valid values: true (the domain name belongs to the current Alibaba Cloud account) and false (the domain name belongs to another account).</para>
                    /// </summary>
                    [NameInMap("CanAutoResolve")]
                    [Validation(Required=false)]
                    public bool? CanAutoResolve { get; set; }

                    /// <summary>
                    /// <para>Indicates whether a conflict exists.</para>
                    /// </summary>
                    [NameInMap("HasConflict")]
                    [Validation(Required=false)]
                    public bool? HasConflict { get; set; }

                    /// <summary>
                    /// <para>The user-facing prompt message. The message varies based on the scenario.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The domain name <a href="http://www.example.com">www.example.com</a> has a conflicting DNS record (A 192.0.2.1). Delete the conflicting record at your DNS provider and try again</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// <para>The list of conflicting DNS records.</para>
                    /// </summary>
                    [NameInMap("Records")]
                    [Validation(Required=false)]
                    public List<ListAppInstanceDomainsResponseBodyModuleDataDnsConflictRecords> Records { get; set; }
                    public class ListAppInstanceDomainsResponseBodyModuleDataDnsConflictRecords : TeaModel {
                        /// <summary>
                        /// <para>The host record.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>www</para>
                        /// </summary>
                        [NameInMap("Host")]
                        [Validation(Required=false)]
                        public string Host { get; set; }

                        /// <summary>
                        /// <para>The record type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>A</para>
                        /// </summary>
                        [NameInMap("RecordType")]
                        [Validation(Required=false)]
                        public string RecordType { get; set; }

                        /// <summary>
                        /// <para>The status of the conflicting DNS record. A value of ENABLE indicates that the record is enabled.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ENABLE</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// <para>The record value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>192.0.2.1</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kaibaidu.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The domain name management type. Valid values: CUSTOM and PLATFORM_PREFIX.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CUSTOM</para>
                /// </summary>
                [NameInMap("DomainType")]
                [Validation(Required=false)]
                public string DomainType { get; set; }

                /// <summary>
                /// <para>The ICP filing status of the domain name. Valid values: FILED, NOT_FILED, and NOT_REQUIRED.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FILED</para>
                /// </summary>
                [NameInMap("IcpFilingStatus")]
                [Validation(Required=false)]
                public string IcpFilingStatus { get; set; }

                /// <summary>
                /// <para>The domain name migration information. This parameter is returned when a region switch occurs.</para>
                /// </summary>
                [NameInMap("Migration")]
                [Validation(Required=false)]
                public ListAppInstanceDomainsResponseBodyModuleDataMigration Migration { get; set; }
                public class ListAppInstanceDomainsResponseBodyModuleDataMigration : TeaModel {
                    /// <summary>
                    /// <para>The migration status. Valid values: NOT_STARTED, IN_PROGRESS, and COMPLETED.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>IN_PROGRESS</para>
                    /// </summary>
                    [NameInMap("MigrationStatus")]
                    [Validation(Required=false)]
                    public string MigrationStatus { get; set; }

                    /// <summary>
                    /// <para>The complete status of the domain name before migration. The structure is the same as the current domain name DTO, allowing the frontend to reuse the rendering logic.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;DomainName&quot;:&quot;<a href="http://www.example.com%22,%22DomainType%22:%22CUSTOM%22,%22DeployType%22:%22CDN%22%7D">www.example.com&quot;,&quot;DomainType&quot;:&quot;CUSTOM&quot;,&quot;DeployType&quot;:&quot;CDN&quot;}</a></para>
                    /// </summary>
                    [NameInMap("PreviousDomain")]
                    [Validation(Required=false)]
                    public object PreviousDomain { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the website is currently offline. This status belongs to the application instance, and the value is the same for all domain names under the same instance.</para>
                /// </summary>
                [NameInMap("Offline")]
                [Validation(Required=false)]
                public bool? Offline { get; set; }

                /// <summary>
                /// <para>The overall binding status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACTIVE</para>
                /// </summary>
                [NameInMap("OverallStatus")]
                [Validation(Required=false)]
                public string OverallStatus { get; set; }

                /// <summary>
                /// <para>The ownership information of the domain name.</para>
                /// </summary>
                [NameInMap("Ownership")]
                [Validation(Required=false)]
                public ListAppInstanceDomainsResponseBodyModuleDataOwnership Ownership { get; set; }
                public class ListAppInstanceDomainsResponseBodyModuleDataOwnership : TeaModel {
                    /// <summary>
                    /// <para>The account owner type. Valid values: CURRENT and OTHER.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1813244684017878</para>
                    /// </summary>
                    [NameInMap("Account")]
                    [Validation(Required=false)]
                    public string Account { get; set; }

                    /// <summary>
                    /// <para>The registrar type. Valid values: ALIYUN and OTHER.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ROS</para>
                    /// </summary>
                    [NameInMap("Provider")]
                    [Validation(Required=false)]
                    public string Provider { get; set; }

                    /// <summary>
                    /// <para>The name of the root domain name corresponding to the domain name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tjouya.cn</para>
                    /// </summary>
                    [NameInMap("RootDomain")]
                    [Validation(Required=false)]
                    public string RootDomain { get; set; }

                }

                /// <summary>
                /// <para>The qualification information of the domain name.</para>
                /// </summary>
                [NameInMap("Qualification")]
                [Validation(Required=false)]
                public ListAppInstanceDomainsResponseBodyModuleDataQualification Qualification { get; set; }
                public class ListAppInstanceDomainsResponseBodyModuleDataQualification : TeaModel {
                    /// <summary>
                    /// <para>The ICP entity filing number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Zhe ICP No. 123456</para>
                    /// </summary>
                    [NameInMap("IcpRecordNumber")]
                    [Validation(Required=false)]
                    public string IcpRecordNumber { get; set; }

                    /// <summary>
                    /// <para>The ICP website filing number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Zhe ICP No. 123456-1</para>
                    /// </summary>
                    [NameInMap("IcpSiteRecordNumber")]
                    [Validation(Required=false)]
                    public string IcpSiteRecordNumber { get; set; }

                    /// <summary>
                    /// <para>The public security filing number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Public Security Filing No. 11040102700048</para>
                    /// </summary>
                    [NameInMap("PoliceRecordNumber")]
                    [Validation(Required=false)]
                    public string PoliceRecordNumber { get; set; }

                }

                /// <summary>
                /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
                /// </summary>
                [NameInMap("RedirectDomain")]
                [Validation(Required=false)]
                public string RedirectDomain { get; set; }

                /// <summary>
                /// <para>The domain name resolution information.</para>
                /// </summary>
                [NameInMap("Resolution")]
                [Validation(Required=false)]
                public ListAppInstanceDomainsResponseBodyModuleDataResolution Resolution { get; set; }
                public class ListAppInstanceDomainsResponseBodyModuleDataResolution : TeaModel {
                    /// <summary>
                    /// <para>The DNS record information.</para>
                    /// </summary>
                    [NameInMap("DnsRecord")]
                    [Validation(Required=false)]
                    public ListAppInstanceDomainsResponseBodyModuleDataResolutionDnsRecord DnsRecord { get; set; }
                    public class ListAppInstanceDomainsResponseBodyModuleDataResolutionDnsRecord : TeaModel {
                        /// <summary>
                        /// <para>The host record.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>portal-dev.bambulab.net</para>
                        /// </summary>
                        [NameInMap("Host")]
                        [Validation(Required=false)]
                        public string Host { get; set; }

                        /// <summary>
                        /// <para>The record type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("RecordType")]
                        [Validation(Required=false)]
                        public string RecordType { get; set; }

                        /// <summary>
                        /// <para>The record value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Maintenance</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>code: 400, invalid unionId request id: 09CC0F8B-49C2-7EFB-81E8-9AEF49068D02</para>
                    /// </summary>
                    [NameInMap("ErrorMsg")]
                    [Validation(Required=false)]
                    public string ErrorMsg { get; set; }

                    /// <summary>
                    /// <para>The domain name resolution status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SUCCESSFUL</para>
                    /// </summary>
                    [NameInMap("ResolutionStatus")]
                    [Validation(Required=false)]
                    public string ResolutionStatus { get; set; }

                }

                /// <summary>
                /// <para>The domain name verification information.</para>
                /// </summary>
                [NameInMap("Verification")]
                [Validation(Required=false)]
                public ListAppInstanceDomainsResponseBodyModuleDataVerification Verification { get; set; }
                public class ListAppInstanceDomainsResponseBodyModuleDataVerification : TeaModel {
                    /// <summary>
                    /// <para>The guide for DNS records to be configured by the user.</para>
                    /// </summary>
                    [NameInMap("DnsRecord")]
                    [Validation(Required=false)]
                    public ListAppInstanceDomainsResponseBodyModuleDataVerificationDnsRecord DnsRecord { get; set; }
                    public class ListAppInstanceDomainsResponseBodyModuleDataVerificationDnsRecord : TeaModel {
                        /// <summary>
                        /// <para>The host record.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>${host}</para>
                        /// </summary>
                        [NameInMap("Host")]
                        [Validation(Required=false)]
                        public string Host { get; set; }

                        /// <summary>
                        /// <para>The record type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("RecordType")]
                        [Validation(Required=false)]
                        public string RecordType { get; set; }

                        /// <summary>
                        /// <para>The record value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>159.138.94.138</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>code: 400, invalid unionId request id: 2270AB0B-6FD0-7F72-9DC5-7A02B67CBB3B</para>
                    /// </summary>
                    [NameInMap("ErrorMsg")]
                    [Validation(Required=false)]
                    public string ErrorMsg { get; set; }

                    /// <summary>
                    /// <para>The ownership verification status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SUCCESSFUL</para>
                    /// </summary>
                    [NameInMap("VerificationStatus")]
                    [Validation(Required=false)]
                    public string VerificationStatus { get; set; }

                    /// <summary>
                    /// <para>The ownership verification status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NoAliyunServiceRoleForWebsiteBuildPublishAuth</para>
                    /// </summary>
                    [NameInMap("VerificationStatusCode")]
                    [Validation(Required=false)]
                    public string VerificationStatusCode { get; set; }

                }

            }

            /// <summary>
            /// <para>The decision weight.</para>
            /// </summary>
            [NameInMap("Next")]
            [Validation(Required=false)]
            public ListAppInstanceDomainsResponseBodyModuleNext Next { get; set; }
            public class ListAppInstanceDomainsResponseBodyModuleNext : TeaModel {
                /// <summary>
                /// <para>The SSL certificate information of the domain name.</para>
                /// </summary>
                [NameInMap("Certificate")]
                [Validation(Required=false)]
                public ListAppInstanceDomainsResponseBodyModuleNextCertificate Certificate { get; set; }
                public class ListAppInstanceDomainsResponseBodyModuleNextCertificate : TeaModel {
                    /// <summary>
                    /// <para>The certificate name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>jfztkg202502</para>
                    /// </summary>
                    [NameInMap("CertificateName")]
                    [Validation(Required=false)]
                    public string CertificateName { get; set; }

                    /// <summary>
                    /// <para>The certificate status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ACTIVE</para>
                    /// </summary>
                    [NameInMap("CertificateStatus")]
                    [Validation(Required=false)]
                    public string CertificateStatus { get; set; }

                    /// <summary>
                    /// <para>The certificate type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Server</para>
                    /// </summary>
                    [NameInMap("CertificateType")]
                    [Validation(Required=false)]
                    public string CertificateType { get; set; }

                    /// <summary>
                    /// <para>The expiration date of the certificate. The date is in ISO 8601 format and the UTC (Z) time zone.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-01-15T02:04:00Z</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                }

                /// <summary>
                /// <para>The creation time of the instance. Format: yyyy-MM-dd HH:mm:ss. This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1741572465000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The network hosting type: CDN / INDEP_DEPLOY / ESA_SAAS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CDN</para>
                /// </summary>
                [NameInMap("DeployType")]
                [Validation(Required=false)]
                public string DeployType { get; set; }

                /// <summary>
                /// <para>The DNS conflict information. This parameter is returned when resolveStatus is DNS_CONFLICT.</para>
                /// </summary>
                [NameInMap("DnsConflict")]
                [Validation(Required=false)]
                public ListAppInstanceDomainsResponseBodyModuleNextDnsConflict DnsConflict { get; set; }
                public class ListAppInstanceDomainsResponseBodyModuleNextDnsConflict : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether automatic override is supported. Valid values: true (the domain name belongs to the current Alibaba Cloud account) and false (the domain name belongs to another account).</para>
                    /// </summary>
                    [NameInMap("CanAutoResolve")]
                    [Validation(Required=false)]
                    public bool? CanAutoResolve { get; set; }

                    /// <summary>
                    /// <para>Indicates whether a conflict exists.</para>
                    /// </summary>
                    [NameInMap("HasConflict")]
                    [Validation(Required=false)]
                    public bool? HasConflict { get; set; }

                    /// <summary>
                    /// <para>The user-facing prompt message. The message varies based on the scenario.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The domain name <a href="http://www.example.com">www.example.com</a> has a conflicting DNS record (A 192.0.2.1). Delete the conflicting record at your DNS provider and try again</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// <para>The list of conflicting DNS records.</para>
                    /// </summary>
                    [NameInMap("Records")]
                    [Validation(Required=false)]
                    public List<ListAppInstanceDomainsResponseBodyModuleNextDnsConflictRecords> Records { get; set; }
                    public class ListAppInstanceDomainsResponseBodyModuleNextDnsConflictRecords : TeaModel {
                        /// <summary>
                        /// <para>The host record.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>www</para>
                        /// </summary>
                        [NameInMap("Host")]
                        [Validation(Required=false)]
                        public string Host { get; set; }

                        /// <summary>
                        /// <para>The record type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>A</para>
                        /// </summary>
                        [NameInMap("RecordType")]
                        [Validation(Required=false)]
                        public string RecordType { get; set; }

                        /// <summary>
                        /// <para>The record value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>192.0.2.1</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>usdcoin.xin</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The domain name management type: CUSTOM / PLATFORM_PREFIX.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CUSTOM</para>
                /// </summary>
                [NameInMap("DomainType")]
                [Validation(Required=false)]
                public string DomainType { get; set; }

                /// <summary>
                /// <para>The ICP filing status of the domain name. Valid values: FILED, NOT_FILED, and NOT_REQUIRED.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FILED</para>
                /// </summary>
                [NameInMap("IcpFilingStatus")]
                [Validation(Required=false)]
                public string IcpFilingStatus { get; set; }

                /// <summary>
                /// <para>The domain name migration information. This parameter is returned when a region switch occurs.</para>
                /// </summary>
                [NameInMap("Migration")]
                [Validation(Required=false)]
                public ListAppInstanceDomainsResponseBodyModuleNextMigration Migration { get; set; }
                public class ListAppInstanceDomainsResponseBodyModuleNextMigration : TeaModel {
                    /// <summary>
                    /// <para>The migration status. Valid values: NOT_STARTED, IN_PROGRESS, and COMPLETED.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>IN_PROGRESS</para>
                    /// </summary>
                    [NameInMap("MigrationStatus")]
                    [Validation(Required=false)]
                    public string MigrationStatus { get; set; }

                    /// <summary>
                    /// <para>The complete status of the domain name before migration. The structure is the same as the current domain name DTO, allowing the frontend to reuse the rendering logic.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;DomainName&quot;:&quot;<a href="http://www.example.com%22,%22DomainType%22:%22CUSTOM%22,%22DeployType%22:%22CDN%22%7D">www.example.com&quot;,&quot;DomainType&quot;:&quot;CUSTOM&quot;,&quot;DeployType&quot;:&quot;CDN&quot;}</a></para>
                    /// </summary>
                    [NameInMap("PreviousDomain")]
                    [Validation(Required=false)]
                    public object PreviousDomain { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the website is currently offline. This status belongs to the application instance, and the value is the same for all domain names under the same instance.</para>
                /// </summary>
                [NameInMap("Offline")]
                [Validation(Required=false)]
                public bool? Offline { get; set; }

                /// <summary>
                /// <para>The overall binding status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACTIVE</para>
                /// </summary>
                [NameInMap("OverallStatus")]
                [Validation(Required=false)]
                public string OverallStatus { get; set; }

                /// <summary>
                /// <para>The ownership information of the domain name.</para>
                /// </summary>
                [NameInMap("Ownership")]
                [Validation(Required=false)]
                public ListAppInstanceDomainsResponseBodyModuleNextOwnership Ownership { get; set; }
                public class ListAppInstanceDomainsResponseBodyModuleNextOwnership : TeaModel {
                    /// <summary>
                    /// <para>The account owner type. Valid values: CURRENT and OTHER.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ShisiGavin</para>
                    /// </summary>
                    [NameInMap("Account")]
                    [Validation(Required=false)]
                    public string Account { get; set; }

                    /// <summary>
                    /// <para>The registrar type. Valid values: ALIYUN and OTHER.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pai</para>
                    /// </summary>
                    [NameInMap("Provider")]
                    [Validation(Required=false)]
                    public string Provider { get; set; }

                    /// <summary>
                    /// <para>The primary domain name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example.com</para>
                    /// </summary>
                    [NameInMap("RootDomain")]
                    [Validation(Required=false)]
                    public string RootDomain { get; set; }

                }

                /// <summary>
                /// <para>The qualification information of the domain name.</para>
                /// </summary>
                [NameInMap("Qualification")]
                [Validation(Required=false)]
                public ListAppInstanceDomainsResponseBodyModuleNextQualification Qualification { get; set; }
                public class ListAppInstanceDomainsResponseBodyModuleNextQualification : TeaModel {
                    /// <summary>
                    /// <para>The ICP entity filing number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Zhe ICP No. 123456</para>
                    /// </summary>
                    [NameInMap("IcpRecordNumber")]
                    [Validation(Required=false)]
                    public string IcpRecordNumber { get; set; }

                    /// <summary>
                    /// <para>The ICP website filing number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Zhe ICP No. 123456-1</para>
                    /// </summary>
                    [NameInMap("IcpSiteRecordNumber")]
                    [Validation(Required=false)]
                    public string IcpSiteRecordNumber { get; set; }

                    /// <summary>
                    /// <para>The public security filing number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Public Security Filing No. 11040102700048</para>
                    /// </summary>
                    [NameInMap("PoliceRecordNumber")]
                    [Validation(Required=false)]
                    public string PoliceRecordNumber { get; set; }

                }

                /// <summary>
                /// <para>The domain name resolution information.</para>
                /// </summary>
                [NameInMap("Resolution")]
                [Validation(Required=false)]
                public ListAppInstanceDomainsResponseBodyModuleNextResolution Resolution { get; set; }
                public class ListAppInstanceDomainsResponseBodyModuleNextResolution : TeaModel {
                    /// <summary>
                    /// <para>The DNS record information.</para>
                    /// </summary>
                    [NameInMap("DnsRecord")]
                    [Validation(Required=false)]
                    public ListAppInstanceDomainsResponseBodyModuleNextResolutionDnsRecord DnsRecord { get; set; }
                    public class ListAppInstanceDomainsResponseBodyModuleNextResolutionDnsRecord : TeaModel {
                        /// <summary>
                        /// <para>The host record.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>172.16.6.1</para>
                        /// </summary>
                        [NameInMap("Host")]
                        [Validation(Required=false)]
                        public string Host { get; set; }

                        /// <summary>
                        /// <para>The record type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>A</para>
                        /// </summary>
                        [NameInMap("RecordType")]
                        [Validation(Required=false)]
                        public string RecordType { get; set; }

                        /// <summary>
                        /// <para>The record value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2025032000000054nuba0r0b0a79y70c1c983tsz09xw9hg3p04kqxmbt4g2p65h</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aliuid:1133664521498319 assumeOssRole not exist,serviceName:aliyunesarealtimelogpushossrole</para>
                    /// </summary>
                    [NameInMap("ErrorMsg")]
                    [Validation(Required=false)]
                    public string ErrorMsg { get; set; }

                    /// <summary>
                    /// <para>The domain name resolution status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SUCCESSFUL</para>
                    /// </summary>
                    [NameInMap("ResolutionStatus")]
                    [Validation(Required=false)]
                    public string ResolutionStatus { get; set; }

                }

                /// <summary>
                /// <para>The domain name verification information.</para>
                /// </summary>
                [NameInMap("Verification")]
                [Validation(Required=false)]
                public ListAppInstanceDomainsResponseBodyModuleNextVerification Verification { get; set; }
                public class ListAppInstanceDomainsResponseBodyModuleNextVerification : TeaModel {
                    /// <summary>
                    /// <para>The guide for DNS records to be configured by the user.</para>
                    /// </summary>
                    [NameInMap("DnsRecord")]
                    [Validation(Required=false)]
                    public ListAppInstanceDomainsResponseBodyModuleNextVerificationDnsRecord DnsRecord { get; set; }
                    public class ListAppInstanceDomainsResponseBodyModuleNextVerificationDnsRecord : TeaModel {
                        /// <summary>
                        /// <para>The host record.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="http://www.abc.com">www.abc.com</a></para>
                        /// </summary>
                        [NameInMap("Host")]
                        [Validation(Required=false)]
                        public string Host { get; set; }

                        /// <summary>
                        /// <para>The record type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("RecordType")]
                        [Validation(Required=false)]
                        public string RecordType { get; set; }

                        /// <summary>
                        /// <para>The record value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>faHuBlyPcodSjBvBJYpm3-9W_cCSowLLQ4zAUyguEGM</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aliuid:1133664521498319 assumeOssRole not exist,serviceName:aliyunesarealtimelogpushossrole</para>
                    /// </summary>
                    [NameInMap("ErrorMsg")]
                    [Validation(Required=false)]
                    public string ErrorMsg { get; set; }

                    /// <summary>
                    /// <para>The ownership verification status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SUCCESSFUL</para>
                    /// </summary>
                    [NameInMap("VerificationStatus")]
                    [Validation(Required=false)]
                    public string VerificationStatus { get; set; }

                    /// <summary>
                    /// <para>The verification status code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NoAliyunServiceRoleForWebsiteBuildPublishAuth</para>
                    /// </summary>
                    [NameInMap("VerificationStatusCode")]
                    [Validation(Required=false)]
                    public string VerificationStatusCode { get; set; }

                }

            }

            /// <summary>
            /// <para>Indicates whether a next page exists.</para>
            /// </summary>
            [NameInMap("NextPage")]
            [Validation(Required=false)]
            public bool? NextPage { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Indicates whether a previous page exists.</para>
            /// </summary>
            [NameInMap("PrePage")]
            [Validation(Required=false)]
            public bool? PrePage { get; set; }

            /// <summary>
            /// <para>In addition to the pagination limit, the server processes a maximum of the latest 1,000 records for the current query. If the number of results exceeds 1,000, <b>ResultLimit</b> is <b>true</b>. Narrow the time range and search again. Otherwise, <b>ResultLimit</b> is <b>false</b>.</para>
            /// </summary>
            [NameInMap("ResultLimit")]
            [Validation(Required=false)]
            public bool? ResultLimit { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalItemNum")]
            [Validation(Required=false)]
            public int? TotalItemNum { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPageNum")]
            [Validation(Required=false)]
            public int? TotalPageNum { get; set; }

        }

        /// <summary>
        /// <para>The token used to start the next query. If no next query is available, this value is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw+qdTi1EjVSWX/INJdYNw==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C6B99AC-39EC-5350-874C-204128C905E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM.ERROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>System error</para>
        /// </summary>
        [NameInMap("RootErrorMsg")]
        [Validation(Required=false)]
        public string RootErrorMsg { get; set; }

        /// <summary>
        /// <para>The reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
