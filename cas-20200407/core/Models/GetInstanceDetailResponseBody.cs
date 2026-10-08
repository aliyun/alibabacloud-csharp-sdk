// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class GetInstanceDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Specifies whether automatic hosting is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>enable: Enabled.</description></item>
        /// <item><description>disable: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("AutoReissue")]
        [Validation(Required=false)]
        public string AutoReissue { get; set; }

        /// <summary>
        /// <para>Specifies whether the current version includes automatic hosting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Included.</description></item>
        /// <item><description>0: Not included.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoReissueFlag")]
        [Validation(Required=false)]
        public int? AutoReissueFlag { get; set; }

        /// <summary>
        /// <para>The average waiting time for issuing a certificate of this specification, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("AverageWaitingTime")]
        [Validation(Required=false)]
        public string AverageWaitingTime { get; set; }

        /// <summary>
        /// <para>The CA brand. Valid values: WoSign, CFCA, DigiCert, GeoTrust, GlobalSign, vTrus, and Alibaba.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DigiCert</para>
        /// </summary>
        [NameInMap("Brand")]
        [Validation(Required=false)]
        public string Brand { get; set; }

        /// <summary>
        /// <para>The global certificate ID. The format is Certificate ID + &quot;-&quot; + Site region ID. This ID is commonly used across Alibaba Cloud services.</para>
        /// <list type="bullet">
        /// <item><description>For the Chinese site, the format is Certificate ID + &quot;-cn-hangzhou&quot;.</description></item>
        /// <item><description>For the international site, the format is Certificate ID + &quot;-ap-southeast-1&quot;.
        /// For example, if the certificate ID is 123, the CertIdentifier for the Chinese site is &quot;123-cn-hangzhou&quot;, and for the international site, it is &quot;123-ap-southeast-1&quot;.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>22783111-cn-hangzhou</para>
        /// </summary>
        [NameInMap("CertIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        /// <summary>
        /// <para>The ID of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public int? CertificateId { get; set; }

        /// <summary>
        /// <para>The name of the instance. When a certificate is issued, this name is used as the default name of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("CertificateName")]
        [Validation(Required=false)]
        public string CertificateName { get; set; }

        /// <summary>
        /// <para>The expiration time of the latest certificate. The value is a UNIX timestamp accurate to seconds. If no certificate is issued, this parameter is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1801324800000</para>
        /// </summary>
        [NameInMap("CertificateNotAfter")]
        [Validation(Required=false)]
        public long? CertificateNotAfter { get; set; }

        /// <summary>
        /// <para>The start time of the latest certificate. The value is a UNIX timestamp accurate to seconds. If no certificate is issued, this parameter is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1781568000000</para>
        /// </summary>
        [NameInMap("CertificateNotBefore")]
        [Validation(Required=false)]
        public long? CertificateNotBefore { get; set; }

        /// <summary>
        /// <para>The revocation time of the latest certificate. The value is a UNIX timestamp accurate to seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1801324800000</para>
        /// </summary>
        [NameInMap("CertificateRevokeTime")]
        [Validation(Required=false)]
        public long? CertificateRevokeTime { get; set; }

        /// <summary>
        /// <para>The status of the certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>issued</b>: Issued.</description></item>
        /// <item><description><b>revoked</b>: Revoked.</description></item>
        /// <item><description><b>willExpire</b>: Expiring soon.</description></item>
        /// <item><description><b>expired</b>: Expired.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>issued</para>
        /// </summary>
        [NameInMap("CertificateStatus")]
        [Validation(Required=false)]
        public string CertificateStatus { get; set; }

        /// <summary>
        /// <para>The type of the certificate. Valid values: DV, OV, and EV.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DV</para>
        /// </summary>
        [NameInMap("CertificateType")]
        [Validation(Required=false)]
        public string CertificateType { get; set; }

        /// <summary>
        /// <para>The city where the company or organization of the user who purchased the certificate is located. This field is required when generating a CSR. Default value: Beijing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Beijing</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>The ID of the company information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47305</para>
        /// </summary>
        [NameInMap("CompanyId")]
        [Validation(Required=false)]
        public long? CompanyId { get; set; }

        /// <summary>
        /// <para>The list of contact IDs.</para>
        /// </summary>
        [NameInMap("ContactIdList")]
        [Validation(Required=false)]
        public List<long?> ContactIdList { get; set; }

        /// <summary>
        /// <para>The code of the country or region where the organization specified in the certificate is located. For example, CN indicates China, and US indicates the United States. This field is required when generating a CSR. Default value: CN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("CountryCode")]
        [Validation(Required=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// <para>The certificate signing request in PEM format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE REQUEST-----   ...... -----END CERTIFICATE REQUEST-----</para>
        /// </summary>
        [NameInMap("Csr")]
        [Validation(Required=false)]
        public string Csr { get; set; }

        /// <summary>
        /// <para>The number of deployed cloud service resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("DeploymentResourceCount")]
        [Validation(Required=false)]
        public int? DeploymentResourceCount { get; set; }

        /// <summary>
        /// <para>The used quota for deployment to cloud servers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("DeploymentUseCount")]
        [Validation(Required=false)]
        public int? DeploymentUseCount { get; set; }

        /// <summary>
        /// <para>The list of associated DingTalk groups for expert services.</para>
        /// </summary>
        [NameInMap("DingGroupList")]
        [Validation(Required=false)]
        public List<GetInstanceDetailResponseBodyDingGroupList> DingGroupList { get; set; }
        public class GetInstanceDetailResponseBodyDingGroupList : TeaModel {
            /// <summary>
            /// <para>The instance ID of the DingTalk group for expert services.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("DingGroupInstanceId")]
            [Validation(Required=false)]
            public string DingGroupInstanceId { get; set; }

            /// <summary>
            /// <para>The name of the DingTalk group for expert services.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("DingGroupName")]
            [Validation(Required=false)]
            public string DingGroupName { get; set; }

            /// <summary>
            /// <para>The type of the DingTalk group for expert services. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>expedite: Application assistance.</description></item>
            /// <item><description>remote: Offline deployment.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>remote</para>
            /// </summary>
            [NameInMap("DingGroupType")]
            [Validation(Required=false)]
            public string DingGroupType { get; set; }

            /// <summary>
            /// <para>The link to join the DingTalk group for expert services.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://123.com">https://123.com</a></para>
            /// </summary>
            [NameInMap("DingGroupUrl")]
            [Validation(Required=false)]
            public string DingGroupUrl { get; set; }

        }

        /// <summary>
        /// <para>The domain name bound to the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The list of domain names to be validated.</para>
        /// </summary>
        [NameInMap("DomainValidationList")]
        [Validation(Required=false)]
        public List<GetInstanceDetailResponseBodyDomainValidationList> DomainValidationList { get; set; }
        public class GetInstanceDetailResponseBodyDomainValidationList : TeaModel {
            /// <summary>
            /// <para>The CNAME record value for verification-free authorization. This parameter may be empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123.com</para>
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// <para>The prefix used for CNAME validation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("CnameKey")]
            [Validation(Required=false)]
            public string CnameKey { get; set; }

            /// <summary>
            /// <para>The domain name to be validated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The root domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("RootDomain")]
            [Validation(Required=false)]
            public string RootDomain { get; set; }

            /// <summary>
            /// <para>The host record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>@</para>
            /// </summary>
            [NameInMap("ValidationKey")]
            [Validation(Required=false)]
            public string ValidationKey { get; set; }

            /// <summary>
            /// <para>The validation type. Valid values: TXT, HTTP, and CNAME.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TXT</para>
            /// </summary>
            [NameInMap("ValidationType")]
            [Validation(Required=false)]
            public string ValidationType { get; set; }

            /// <summary>
            /// <para>The value of the host record for validation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("ValidationValue")]
            [Validation(Required=false)]
            public string ValidationValue { get; set; }

        }

        /// <summary>
        /// <para>The number of exact domain names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FullDomainCount")]
        [Validation(Required=false)]
        public int? FullDomainCount { get; set; }

        /// <summary>
        /// <para>The method used to generate the CSR. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>online: Generated by the system. The Csr field is ignored.</description></item>
        /// <item><description>upload: Uploaded by the user. The Csr field is required.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>online</para>
        /// </summary>
        [NameInMap("GenerateCsrMethod")]
        [Validation(Required=false)]
        public string GenerateCsrMethod { get; set; }

        /// <summary>
        /// <para>The expiration time of the instance. The value is a UNIX timestamp accurate to seconds. If no certificate has been issued, this parameter is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1801324800000</para>
        /// </summary>
        [NameInMap("InstanceEndTime")]
        [Validation(Required=false)]
        public long? InstanceEndTime { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cas_dv-cn-123</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The start time of the instance. The value is a UNIX timestamp accurate to seconds. If no certificate has been issued, this parameter is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1801324800000</para>
        /// </summary>
        [NameInMap("InstanceStartTime")]
        [Validation(Required=false)]
        public long? InstanceStartTime { get; set; }

        /// <summary>
        /// <para>The type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BUY: Official certificate.</description></item>
        /// <item><description>TEST: Test certificate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TEST</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The algorithm of the certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RSA_2048</b></description></item>
        /// <item><description><b>RSA_3072</b></description></item>
        /// <item><description><b>RSA_4096</b></description></item>
        /// <item><description><b>ECC_256</b></description></item>
        /// <item><description><b>SM2</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RSA_2048</para>
        /// </summary>
        [NameInMap("KeyAlgorithm")]
        [Validation(Required=false)]
        public string KeyAlgorithm { get; set; }

        /// <summary>
        /// <para>Specifies whether the quota for domain name monitoring can be expanded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Yes.</description></item>
        /// <item><description>0: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MonitorExpandFlag")]
        [Validation(Required=false)]
        public int? MonitorExpandFlag { get; set; }

        /// <summary>
        /// <para>The used quota for domain name monitoring.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MonitorUseCount")]
        [Validation(Required=false)]
        public int? MonitorUseCount { get; set; }

        /// <summary>
        /// <para>The end time of the instance purchase. The value is a UNIX timestamp used to determine the purchase duration of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1801324800000</para>
        /// </summary>
        [NameInMap("OrderEndTime")]
        [Validation(Required=false)]
        public long? OrderEndTime { get; set; }

        /// <summary>
        /// <para>The progress of the order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;orderProgress&quot;: [
        ///     {
        ///       &quot;certificateId&quot;: 12345,
        ///       &quot;certificateName&quot;: &quot;example.com&quot;,
        ///       &quot;notBefore&quot;: 1727000000000,
        ///       &quot;notAfter&quot;: 1735000000000,
        ///       &quot;stages&quot;: [
        ///         { &quot;name&quot;: &quot;apply&quot;, &quot;title&quot;: &quot;apply&quot;, &quot;status&quot;: &quot;completed&quot;, &quot;time&quot;: 1726990000000 },
        ///         { &quot;name&quot;: &quot;domainValidation&quot;, &quot;title&quot;: &quot;domainValidation&quot;, &quot;status&quot;: &quot;completed&quot;, &quot;time&quot;: 1727000000000 },
        ///         { &quot;name&quot;: &quot;issue&quot;, &quot;title&quot;: &quot;issue&quot;, &quot;status&quot;: &quot;completed&quot;, &quot;time&quot;: 1727000000000 }
        ///       ]
        ///     }
        ///   ]
        /// }</para>
        /// </summary>
        [NameInMap("OrderProgress")]
        [Validation(Required=false)]
        public string OrderProgress { get; set; }

        /// <summary>
        /// <para>The start time of the instance purchase. The value is a UNIX timestamp accurate to seconds, used to determine the time limit for refunds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1801324800000</para>
        /// </summary>
        [NameInMap("OrderStartTime")]
        [Validation(Required=false)]
        public long? OrderStartTime { get; set; }

        /// <summary>
        /// <para>The result returned by the CA during the last operation on the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pending</para>
        /// </summary>
        [NameInMap("PendingResult")]
        [Validation(Required=false)]
        public string PendingResult { get; set; }

        /// <summary>
        /// <para>The province or region where the company is located. This field is required when generating a CSR. Default value: Beijing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Beijing</para>
        /// </summary>
        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        /// <summary>
        /// <para>The ID of the request. It is a unique identifier generated by Alibaba Cloud for the request and can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B2CE1D02-6D5E-56E5-A9BD-EE288255C7F9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek****wia</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The specifications of the purchased instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ss.dv.t</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// <para>The instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>inactive</b>: Pending use.</description></item>
        /// <item><description><b>pending</b>: Under review. The latest certificate is committed for review.</description></item>
        /// <item><description><b>willExpire</b>: Expiring soon.</description></item>
        /// <item><description><b>expired</b>: Expired.</description></item>
        /// <item><description><b>refund</b>: Refunded.</description></item>
        /// <item><description><b>normal</b>: Normal.</description></item>
        /// <item><description><b>closed</b>: Shutdown and unavailable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>inactive</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetInstanceDetailResponseBodyTags> Tags { get; set; }
        public class GetInstanceDetailResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// <para>The total quota for deployment to cloud servers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("TotalDeploymentCount")]
        [Validation(Required=false)]
        public int? TotalDeploymentCount { get; set; }

        /// <summary>
        /// <para>The total quota for domain name monitoring.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("TotalMonitorCount")]
        [Validation(Required=false)]
        public int? TotalMonitorCount { get; set; }

        /// <summary>
        /// <para>The upgrade status of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>none: The instance is not upgraded.</description></item>
        /// <item><description>payed: The instance upgrade is paid.</description></item>
        /// <item><description>issued: The latest certificate is issued for the instance upgrade.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("UpgradeStatus")]
        [Validation(Required=false)]
        public string UpgradeStatus { get; set; }

        /// <summary>
        /// <para>The validation method for the certificate application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DNS: DNS validation, using TXT or CNAME records.</description></item>
        /// <item><description>HTTP: File validation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DNS</para>
        /// </summary>
        [NameInMap("ValidationMethod")]
        [Validation(Required=false)]
        public string ValidationMethod { get; set; }

        /// <summary>
        /// <para>The version type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FOTA: System upgrade.</description></item>
        /// <item><description>APP: Application upgrade.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("VersionType")]
        [Validation(Required=false)]
        public string VersionType { get; set; }

        /// <summary>
        /// <para>The number of wildcard domain names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("WildcardDomainCount")]
        [Validation(Required=false)]
        public int? WildcardDomainCount { get; set; }

    }

}
