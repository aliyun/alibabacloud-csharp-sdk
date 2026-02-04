// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ListAppInstanceDomainsResponseBody : TeaModel {
        /// <summary>
        /// <para>Detailed reason for access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Whether retry is allowed</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>App name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dewuApp</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>Dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>Dynamic error message, used to replace <c>%s</c> in the error message of the returned parameter <b>ErrMessage</b>.</para>
        /// <remarks>
        /// <para>If <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b>, and <b>DynamicMessage</b> returns <b>DtsJobId</b>, it means that the input request parameter <b>DtsJobId</b> is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM_ERROR</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>Returned error parameters</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>Number of results per query.</para>
        /// <para>Range: 10~100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Response data</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public ListAppInstanceDomainsResponseBodyModule Module { get; set; }
        public class ListAppInstanceDomainsResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>Current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPageNum")]
            [Validation(Required=false)]
            public int? CurrentPageNum { get; set; }

            /// <summary>
            /// <para>Query result.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListAppInstanceDomainsResponseBodyModuleData> Data { get; set; }
            public class ListAppInstanceDomainsResponseBodyModuleData : TeaModel {
                /// <summary>
                /// <para>Domain SSL certificate information</para>
                /// </summary>
                [NameInMap("Certificate")]
                [Validation(Required=false)]
                public ListAppInstanceDomainsResponseBodyModuleDataCertificate Certificate { get; set; }
                public class ListAppInstanceDomainsResponseBodyModuleDataCertificate : TeaModel {
                    /// <summary>
                    /// <para>Certificate name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024</para>
                    /// </summary>
                    [NameInMap("CertificateName")]
                    [Validation(Required=false)]
                    public string CertificateName { get; set; }

                    /// <summary>
                    /// <para>Certificate status</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ACTIVE</para>
                    /// </summary>
                    [NameInMap("CertificateStatus")]
                    [Validation(Required=false)]
                    public string CertificateStatus { get; set; }

                    /// <summary>
                    /// <para>Certificate type</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>self-signed</para>
                    /// </summary>
                    [NameInMap("CertificateType")]
                    [Validation(Required=false)]
                    public string CertificateType { get; set; }

                    /// <summary>
                    /// <para>Certificate expiration date</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4885718400000</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                }

                /// <summary>
                /// <para>Instance creation time (required, format: yyyy-MM-dd HH:mm:ss)</para>
                /// 
                /// <b>Example:</b>
                /// <para>1683256054000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Domain name</para>
                /// 
                /// <b>Example:</b>
                /// <para>kaibaidu.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>Binding overall status</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACTIVE</para>
                /// </summary>
                [NameInMap("OverallStatus")]
                [Validation(Required=false)]
                public string OverallStatus { get; set; }

                /// <summary>
                /// <para>Domain ownership information</para>
                /// </summary>
                [NameInMap("Ownership")]
                [Validation(Required=false)]
                public ListAppInstanceDomainsResponseBodyModuleDataOwnership Ownership { get; set; }
                public class ListAppInstanceDomainsResponseBodyModuleDataOwnership : TeaModel {
                    /// <summary>
                    /// <para>Account owner type: CURRENT OTHER</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1813244684017878</para>
                    /// </summary>
                    [NameInMap("Account")]
                    [Validation(Required=false)]
                    public string Account { get; set; }

                    /// <summary>
                    /// <para>Registrar type: ALIYUN OTHER</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ROS</para>
                    /// </summary>
                    [NameInMap("Provider")]
                    [Validation(Required=false)]
                    public string Provider { get; set; }

                    /// <summary>
                    /// <para>The root domain name of the domain.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tjouya.cn</para>
                    /// </summary>
                    [NameInMap("RootDomain")]
                    [Validation(Required=false)]
                    public string RootDomain { get; set; }

                }

                /// <summary>
                /// <para>Domain resolution information</para>
                /// </summary>
                [NameInMap("Resolution")]
                [Validation(Required=false)]
                public ListAppInstanceDomainsResponseBodyModuleDataResolution Resolution { get; set; }
                public class ListAppInstanceDomainsResponseBodyModuleDataResolution : TeaModel {
                    /// <summary>
                    /// <para>DNS record information</para>
                    /// </summary>
                    [NameInMap("DnsRecord")]
                    [Validation(Required=false)]
                    public ListAppInstanceDomainsResponseBodyModuleDataResolutionDnsRecord DnsRecord { get; set; }
                    public class ListAppInstanceDomainsResponseBodyModuleDataResolutionDnsRecord : TeaModel {
                        /// <summary>
                        /// <para>Host record</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>portal-dev.bambulab.net</para>
                        /// </summary>
                        [NameInMap("Host")]
                        [Validation(Required=false)]
                        public string Host { get; set; }

                        /// <summary>
                        /// <para>Record type</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("RecordType")]
                        [Validation(Required=false)]
                        public string RecordType { get; set; }

                        /// <summary>
                        /// <para>Record value</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Maintenance</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>Error message</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>code: 400, invalid unionId request id: 09CC0F8B-49C2-7EFB-81E8-9AEF49068D02</para>
                    /// </summary>
                    [NameInMap("ErrorMsg")]
                    [Validation(Required=false)]
                    public string ErrorMsg { get; set; }

                    /// <summary>
                    /// <para>Domain resolution status</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SUCCESSFUL</para>
                    /// </summary>
                    [NameInMap("ResolutionStatus")]
                    [Validation(Required=false)]
                    public string ResolutionStatus { get; set; }

                }

                /// <summary>
                /// <para>Domain verification information</para>
                /// </summary>
                [NameInMap("Verification")]
                [Validation(Required=false)]
                public ListAppInstanceDomainsResponseBodyModuleDataVerification Verification { get; set; }
                public class ListAppInstanceDomainsResponseBodyModuleDataVerification : TeaModel {
                    /// <summary>
                    /// <para>DNS record guide that the user needs to configure.</para>
                    /// </summary>
                    [NameInMap("DnsRecord")]
                    [Validation(Required=false)]
                    public ListAppInstanceDomainsResponseBodyModuleDataVerificationDnsRecord DnsRecord { get; set; }
                    public class ListAppInstanceDomainsResponseBodyModuleDataVerificationDnsRecord : TeaModel {
                        /// <summary>
                        /// <para>Host record</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>${host}</para>
                        /// </summary>
                        [NameInMap("Host")]
                        [Validation(Required=false)]
                        public string Host { get; set; }

                        /// <summary>
                        /// <para>Record type</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("RecordType")]
                        [Validation(Required=false)]
                        public string RecordType { get; set; }

                        /// <summary>
                        /// <para>Record value</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>159.138.94.138</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>Error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>code: 400, invalid unionId request id: 2270AB0B-6FD0-7F72-9DC5-7A02B67CBB3B</para>
                    /// </summary>
                    [NameInMap("ErrorMsg")]
                    [Validation(Required=false)]
                    public string ErrorMsg { get; set; }

                    /// <summary>
                    /// <para>Ownership verification status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SUCCESSFUL</para>
                    /// </summary>
                    [NameInMap("VerificationStatus")]
                    [Validation(Required=false)]
                    public string VerificationStatus { get; set; }

                    /// <summary>
                    /// <para>Ownership verification status</para>
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
            /// <para>Decision weight</para>
            /// </summary>
            [NameInMap("Next")]
            [Validation(Required=false)]
            public ListAppInstanceDomainsResponseBodyModuleNext Next { get; set; }
            public class ListAppInstanceDomainsResponseBodyModuleNext : TeaModel {
                /// <summary>
                /// <para>Domain SSL certificate information</para>
                /// </summary>
                [NameInMap("Certificate")]
                [Validation(Required=false)]
                public ListAppInstanceDomainsResponseBodyModuleNextCertificate Certificate { get; set; }
                public class ListAppInstanceDomainsResponseBodyModuleNextCertificate : TeaModel {
                    /// <summary>
                    /// <para>Certificate name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>jfztkg202502</para>
                    /// </summary>
                    [NameInMap("CertificateName")]
                    [Validation(Required=false)]
                    public string CertificateName { get; set; }

                    /// <summary>
                    /// <para>Certificate status</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ACTIVE</para>
                    /// </summary>
                    [NameInMap("CertificateStatus")]
                    [Validation(Required=false)]
                    public string CertificateStatus { get; set; }

                    /// <summary>
                    /// <para>Certificate type</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Server</para>
                    /// </summary>
                    [NameInMap("CertificateType")]
                    [Validation(Required=false)]
                    public string CertificateType { get; set; }

                    /// <summary>
                    /// <para>证书的到期日期</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-01-15T02:04:00Z</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                }

                /// <summary>
                /// <para>Instance creation time (required, format: yyyy-MM-dd HH:mm:ss)</para>
                /// 
                /// <b>Example:</b>
                /// <para>1741572465000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Domain name</para>
                /// 
                /// <b>Example:</b>
                /// <para>usdcoin.xin</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>Binding overall status</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACTIVE</para>
                /// </summary>
                [NameInMap("OverallStatus")]
                [Validation(Required=false)]
                public string OverallStatus { get; set; }

                /// <summary>
                /// <para>Domain ownership information</para>
                /// </summary>
                [NameInMap("Ownership")]
                [Validation(Required=false)]
                public ListAppInstanceDomainsResponseBodyModuleNextOwnership Ownership { get; set; }
                public class ListAppInstanceDomainsResponseBodyModuleNextOwnership : TeaModel {
                    /// <summary>
                    /// <para>Account owner type: CURRENT OTHER</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>拾肆gavin</para>
                    /// </summary>
                    [NameInMap("Account")]
                    [Validation(Required=false)]
                    public string Account { get; set; }

                    /// <summary>
                    /// <para>Registrar type: ALIYUN OTHER</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pai</para>
                    /// </summary>
                    [NameInMap("Provider")]
                    [Validation(Required=false)]
                    public string Provider { get; set; }

                }

                /// <summary>
                /// <para>Domain resolution information</para>
                /// </summary>
                [NameInMap("Resolution")]
                [Validation(Required=false)]
                public ListAppInstanceDomainsResponseBodyModuleNextResolution Resolution { get; set; }
                public class ListAppInstanceDomainsResponseBodyModuleNextResolution : TeaModel {
                    /// <summary>
                    /// <para>DNS record information</para>
                    /// </summary>
                    [NameInMap("DnsRecord")]
                    [Validation(Required=false)]
                    public ListAppInstanceDomainsResponseBodyModuleNextResolutionDnsRecord DnsRecord { get; set; }
                    public class ListAppInstanceDomainsResponseBodyModuleNextResolutionDnsRecord : TeaModel {
                        /// <summary>
                        /// <para>Host record</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>172.16.6.1</para>
                        /// </summary>
                        [NameInMap("Host")]
                        [Validation(Required=false)]
                        public string Host { get; set; }

                        /// <summary>
                        /// <para>Record type</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>A</para>
                        /// </summary>
                        [NameInMap("RecordType")]
                        [Validation(Required=false)]
                        public string RecordType { get; set; }

                        /// <summary>
                        /// <para>Record value</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2025032000000054nuba0r0b0a79y70c1c983tsz09xw9hg3p04kqxmbt4g2p65h</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>Error message</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aliuid:1133664521498319 assumeOssRole not exist,serviceName:aliyunesarealtimelogpushossrole</para>
                    /// </summary>
                    [NameInMap("ErrorMsg")]
                    [Validation(Required=false)]
                    public string ErrorMsg { get; set; }

                    /// <summary>
                    /// <para>Domain resolution status</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SUCCESSFUL</para>
                    /// </summary>
                    [NameInMap("ResolutionStatus")]
                    [Validation(Required=false)]
                    public string ResolutionStatus { get; set; }

                }

                /// <summary>
                /// <para>Domain verification information</para>
                /// </summary>
                [NameInMap("Verification")]
                [Validation(Required=false)]
                public ListAppInstanceDomainsResponseBodyModuleNextVerification Verification { get; set; }
                public class ListAppInstanceDomainsResponseBodyModuleNextVerification : TeaModel {
                    /// <summary>
                    /// <para>Guide for DNS records that the user needs to configure.</para>
                    /// </summary>
                    [NameInMap("DnsRecord")]
                    [Validation(Required=false)]
                    public ListAppInstanceDomainsResponseBodyModuleNextVerificationDnsRecord DnsRecord { get; set; }
                    public class ListAppInstanceDomainsResponseBodyModuleNextVerificationDnsRecord : TeaModel {
                        /// <summary>
                        /// <para>Host record</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="http://www.abc.com">www.abc.com</a></para>
                        /// </summary>
                        [NameInMap("Host")]
                        [Validation(Required=false)]
                        public string Host { get; set; }

                        /// <summary>
                        /// <para>Record type</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("RecordType")]
                        [Validation(Required=false)]
                        public string RecordType { get; set; }

                        /// <summary>
                        /// <para>Record value</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>faHuBlyPcodSjBvBJYpm3-9W_cCSowLLQ4zAUyguEGM</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>Error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aliuid:1133664521498319 assumeOssRole not exist,serviceName:aliyunesarealtimelogpushossrole</para>
                    /// </summary>
                    [NameInMap("ErrorMsg")]
                    [Validation(Required=false)]
                    public string ErrorMsg { get; set; }

                    /// <summary>
                    /// <para>Ownership verification status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SUCCESSFUL</para>
                    /// </summary>
                    [NameInMap("VerificationStatus")]
                    [Validation(Required=false)]
                    public string VerificationStatus { get; set; }

                }

            }

            /// <summary>
            /// <para>Whether there is a next page.</para>
            /// </summary>
            [NameInMap("NextPage")]
            [Validation(Required=false)]
            public bool? NextPage { get; set; }

            /// <summary>
            /// <para>Page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Whether there is a previous page</para>
            /// </summary>
            [NameInMap("PrePage")]
            [Validation(Required=false)]
            public bool? PrePage { get; set; }

            /// <summary>
            /// <para>Apart from pagination limits, the server can process up to the most recent 1000 records. If the result exceeds 1000 records, <b>ResultLimit</b> will be <b>true</b>, please narrow down the time range and search again; otherwise, <b>ResultLimit</b> will be <b>false</b>.</para>
            /// </summary>
            [NameInMap("ResultLimit")]
            [Validation(Required=false)]
            public bool? ResultLimit { get; set; }

            /// <summary>
            /// <para>Total number of items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalItemNum")]
            [Validation(Required=false)]
            public int? TotalItemNum { get; set; }

            /// <summary>
            /// <para>Total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPageNum")]
            [Validation(Required=false)]
            public int? TotalPageNum { get; set; }

        }

        /// <summary>
        /// <para>下一个查询开始的Token。没有下一个查询时为空。</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw+qdTi1EjVSWX/INJdYNw==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C6B99AC-39EC-5350-874C-204128C905E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM.ERROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        /// <summary>
        /// <para>Exception message</para>
        /// 
        /// <b>Example:</b>
        /// <para>系统异常</para>
        /// </summary>
        [NameInMap("RootErrorMsg")]
        [Validation(Required=false)]
        public string RootErrorMsg { get; set; }

        /// <summary>
        /// <para>Reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
