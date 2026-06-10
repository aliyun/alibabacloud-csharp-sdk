// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeOfficeSitesResponseBody : TeaModel {
        /// <summary>
        /// <para>The token used to retrieve the next page of results. If this parameter is empty, all results have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>A list of office networks.</para>
        /// </summary>
        [NameInMap("OfficeSites")]
        [Validation(Required=false)]
        public List<DescribeOfficeSitesResponseBodyOfficeSites> OfficeSites { get; set; }
        public class DescribeOfficeSitesResponseBodyOfficeSites : TeaModel {
            /// <summary>
            /// <para>A list of AD connectors.</para>
            /// </summary>
            [NameInMap("ADConnectors")]
            [Validation(Required=false)]
            public List<DescribeOfficeSitesResponseBodyOfficeSitesADConnectors> ADConnectors { get; set; }
            public class DescribeOfficeSitesResponseBodyOfficeSitesADConnectors : TeaModel {
                /// <summary>
                /// <para>The connection address of the AD connector.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.24.<em>.</em></para>
                /// </summary>
                [NameInMap("ADConnectorAddress")]
                [Validation(Required=false)]
                public string ADConnectorAddress { get; set; }

                /// <summary>
                /// <para>The status of the AD connector.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("ConnectorStatus")]
                [Validation(Required=false)]
                public string ConnectorStatus { get; set; }

                /// <summary>
                /// <para>The ID of the elastic network interface (ENI) to which the AD connector is attached.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eni-bp1i4wx78lgosrj6****</para>
                /// </summary>
                [NameInMap("NetworkInterfaceId")]
                [Validation(Required=false)]
                public string NetworkInterfaceId { get; set; }

                /// <summary>
                /// <para>The specification of the AD connector.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Specification")]
                [Validation(Required=false)]
                public string Specification { get; set; }

                /// <summary>
                /// <para>The trust password that is configured when you set up an AD trust relationship.</para>
                /// 
                /// <b>Example:</b>
                /// <para>password123***</para>
                /// </summary>
                [NameInMap("TrustKey")]
                [Validation(Required=false)]
                public string TrustKey { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch that corresponds to the network of the AD connector.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp19ocz3erfx15uon****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

            /// <summary>
            /// <para>The ID of the Global Accelerator (GA) instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ga-bp1astu3yrplkzoo2****</para>
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            [NameInMap("AccessAttribute")]
            [Validation(Required=false)]
            public string AccessAttribute { get; set; }

            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <para>The hostname of the domain controller.
            /// The hostname must comply with the Windows hostname naming conventions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>beijing-ad01</para>
            /// </summary>
            [NameInMap("AdHostname")]
            [Validation(Required=false)]
            public string AdHostname { get; set; }

            [NameInMap("AuthorityHost")]
            [Validation(Required=false)]
            public string AuthorityHost { get; set; }

            /// <summary>
            /// <para>The hostname of the backup domain controller.</para>
            /// 
            /// <b>Example:</b>
            /// <para>beijing-ad02</para>
            /// </summary>
            [NameInMap("BackupDCHostname")]
            [Validation(Required=false)]
            public string BackupDCHostname { get; set; }

            /// <summary>
            /// <para>The DNS address of the backup domain controller.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.24.XX.XX</para>
            /// </summary>
            [NameInMap("BackupDns")]
            [Validation(Required=false)]
            public string BackupDns { get; set; }

            /// <summary>
            /// <para>The peak public bandwidth, in Mbit/s. Valid values: 0 to 1000. <br>A value of 0 indicates that internet access is disabled.<br></para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The attachment status of the Cloud Enterprise Network (CEN) instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>attached</para>
            /// </summary>
            [NameInMap("CenAttachStatus")]
            [Validation(Required=false)]
            public string CenAttachStatus { get; set; }

            /// <summary>
            /// <para>The ID of the Cloud Enterprise Network (CEN) instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen-3gwy16dojz1m65****</para>
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// <para>The IPv4 CIDR block of the office network\&quot;s Virtual Private Cloud (VPC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.100.XX.XX</para>
            /// </summary>
            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            [NameInMap("ClientSecret")]
            [Validation(Required=false)]
            public string ClientSecret { get; set; }

            /// <summary>
            /// <para>Specifies whether the office network is a CloudBox-based office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CloudBoxOfficeSite")]
            [Validation(Required=false)]
            public bool? CloudBoxOfficeSite { get; set; }

            /// <summary>
            /// <para>The time when the office network was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-06T05:58Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The address of the custom access gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-****.com</para>
            /// </summary>
            [NameInMap("CustomAccessPoint")]
            [Validation(Required=false)]
            public string CustomAccessPoint { get; set; }

            /// <summary>
            /// <para>The custom DNS addresses.</para>
            /// </summary>
            [NameInMap("CustomDnsAddress")]
            [Validation(Required=false)]
            public List<string> CustomDnsAddress { get; set; }

            /// <summary>
            /// <para>The security group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp1ce64o4g9mdf5u****</para>
            /// </summary>
            [NameInMap("CustomSecurityGroupId")]
            [Validation(Required=false)]
            public string CustomSecurityGroupId { get; set; }

            /// <summary>
            /// <para>The method for connecting to cloud computers from an Elastic Desktop Service client.</para>
            /// <remarks>
            /// <para>Connections over a VPC use Alibaba Cloud PrivateLink, which is provided free of charge. The PrivateLink service is enabled when this parameter is returned as <c>VPC</c> or <c>Any</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>INTERNET</para>
            /// </summary>
            [NameInMap("DesktopAccessType")]
            [Validation(Required=false)]
            public string DesktopAccessType { get; set; }

            /// <summary>
            /// <para>The number of individually provisioned cloud computers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DesktopCount")]
            [Validation(Required=false)]
            public long? DesktopCount { get; set; }

            /// <summary>
            /// <para>The endpoint used to connect to cloud computers over a VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://ep-bp1s2vmbj55r5rzc****.epsrv-bp1pcfhpwvlpny01****.cn-hangzhou.privatelink.aliyuncs.com">http://ep-bp1s2vmbj55r5rzc****.epsrv-bp1pcfhpwvlpny01****.cn-hangzhou.privatelink.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("DesktopVpcEndpoint")]
            [Validation(Required=false)]
            public string DesktopVpcEndpoint { get; set; }

            /// <summary>
            /// <para>The DNS addresses of the AD domain.</para>
            /// </summary>
            [NameInMap("DnsAddress")]
            [Validation(Required=false)]
            public List<string> DnsAddress { get; set; }

            /// <summary>
            /// <para>The DNS username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testDnsUserName</para>
            /// </summary>
            [NameInMap("DnsUserName")]
            [Validation(Required=false)]
            public string DnsUserName { get; set; }

            /// <summary>
            /// <para>The domain name of the enterprise AD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The password of the domain administrator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testPassword</para>
            /// </summary>
            [NameInMap("DomainPassword")]
            [Validation(Required=false)]
            public string DomainPassword { get; set; }

            /// <summary>
            /// <para>The username of the domain administrator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Administrator</para>
            /// </summary>
            [NameInMap("DomainUserName")]
            [Validation(Required=false)]
            public string DomainUserName { get; set; }

            [NameInMap("Eid")]
            [Validation(Required=false)]
            public string Eid { get; set; }

            /// <summary>
            /// <para>Specifies whether to grant local administrator permissions to users of cloud computers in the office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableAdminAccess")]
            [Validation(Required=false)]
            public bool? EnableAdminAccess { get; set; }

            /// <summary>
            /// <para>Specifies whether cloud computers in the office network can access each other.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableCrossDesktopAccess")]
            [Validation(Required=false)]
            public bool? EnableCrossDesktopAccess { get; set; }

            /// <summary>
            /// <para>Indicates whether internet access is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableInternetAccess")]
            [Validation(Required=false)]
            public bool? EnableInternetAccess { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable access control for cloud service routing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableServiceRoute")]
            [Validation(Required=false)]
            public bool? EnableServiceRoute { get; set; }

            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>The IDs of Apsara File Storage for NAS file systems.</para>
            /// </summary>
            [NameInMap("FileSystemIds")]
            [Validation(Required=false)]
            public List<string> FileSystemIds { get; set; }

            [NameInMap("IsLdap")]
            [Validation(Required=false)]
            public bool? IsLdap { get; set; }

            [NameInMap("LdapUrl")]
            [Validation(Required=false)]
            public string LdapUrl { get; set; }

            /// <summary>
            /// <para>The registration logs.</para>
            /// </summary>
            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<DescribeOfficeSitesResponseBodyOfficeSitesLogs> Logs { get; set; }
            public class DescribeOfficeSitesResponseBodyOfficeSitesLogs : TeaModel {
                /// <summary>
                /// <para>The log level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>INFO</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>The log message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>code:success | message:Create Connector complete</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The registration step.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CREATE_CONNECTOR</para>
                /// </summary>
                [NameInMap("Step")]
                [Validation(Required=false)]
                public string Step { get; set; }

                /// <summary>
                /// <para>The timestamp of the log entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-05-12T09:42Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether multi-factor authentication (MFA) is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("MfaEnabled")]
            [Validation(Required=false)]
            public bool? MfaEnabled { get; set; }

            /// <summary>
            /// <para>The name of the office network. The name must be unique within the same region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Indicates whether risk-based verification is enabled for user logon. This feature applies only to office networks that use convenience accounts. If enabled, the system checks for security risks during logon. If a risk is detected, the user must enter a verification code sent to their email address to complete the logon process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("NeedVerifyLoginRisk")]
            [Validation(Required=false)]
            public bool? NeedVerifyLoginRisk { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable trusted device verification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NeedVerifyZeroDevice")]
            [Validation(Required=false)]
            public bool? NeedVerifyZeroDevice { get; set; }

            /// <summary>
            /// <para>The ID of the premium bandwidth plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>np-amtp8e8q1o9e4****</para>
            /// </summary>
            [NameInMap("NetworkPackageId")]
            [Validation(Required=false)]
            public string NetworkPackageId { get; set; }

            /// <summary>
            /// <para>The network version. The new version supports products such as App Streaming.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NM</para>
            /// </summary>
            [NameInMap("NmVersion")]
            [Validation(Required=false)]
            public string NmVersion { get; set; }

            /// <summary>
            /// <para>The office network ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-363353****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The account type of the office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AD_CONNECTOR</para>
            /// </summary>
            [NameInMap("OfficeSiteType")]
            [Validation(Required=false)]
            public string OfficeSiteType { get; set; }

            /// <summary>
            /// <para>The organizational unit (OU) in the Active Directory (AD) domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com/Domain Controllers</para>
            /// </summary>
            [NameInMap("OuName")]
            [Validation(Required=false)]
            public string OuName { get; set; }

            /// <summary>
            /// <para>The streaming protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ASP</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <para>The IP address of the RDS license server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.100.XX.XX</para>
            /// </summary>
            [NameInMap("RdsLicenseAddress")]
            [Validation(Required=false)]
            public string RdsLicenseAddress { get; set; }

            /// <summary>
            /// <para>The domain name of the RDS license server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("RdsLicenseDomainName")]
            [Validation(Required=false)]
            public string RdsLicenseDomainName { get; set; }

            /// <summary>
            /// <para>The status of the Remote Desktop Services (RDS) license.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RdsLicenseStatus")]
            [Validation(Required=false)]
            public string RdsLicenseStatus { get; set; }

            /// <summary>
            /// <para>A list of resource quantities.</para>
            /// </summary>
            [NameInMap("ResourceAmounts")]
            [Validation(Required=false)]
            public List<DescribeOfficeSitesResponseBodyOfficeSitesResourceAmounts> ResourceAmounts { get; set; }
            public class DescribeOfficeSitesResponseBodyOfficeSitesResourceAmounts : TeaModel {
                /// <summary>
                /// <para>The number of resources of this type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public long? Amount { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>desktop</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <para>The security protection configuration for the office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SASE</para>
            /// </summary>
            [NameInMap("SecurityProtection")]
            [Validation(Required=false)]
            public string SecurityProtection { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable single sign-on (SSO).</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SsoEnabled")]
            [Validation(Required=false)]
            public bool? SsoEnabled { get; set; }

            /// <summary>
            /// <para>The single sign-on (SSO) type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SAML</para>
            /// </summary>
            [NameInMap("SsoType")]
            [Validation(Required=false)]
            public string SsoType { get; set; }

            /// <summary>
            /// <para>The status of the office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>REGISTERED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The DNS addresses of the AD subdomains.</para>
            /// </summary>
            [NameInMap("SubDnsAddress")]
            [Validation(Required=false)]
            public List<string> SubDnsAddress { get; set; }

            /// <summary>
            /// <para>The name of the Active Directory (AD) subdomain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testSubDnsUserName</para>
            /// </summary>
            [NameInMap("SubDomainName")]
            [Validation(Required=false)]
            public string SubDomainName { get; set; }

            /// <summary>
            /// <para>The subnet mode of the office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SubnetMode")]
            [Validation(Required=false)]
            public string SubnetMode { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>The total number of cloud computers in the office network, including individual and shared computers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalEdsCount")]
            [Validation(Required=false)]
            public long? TotalEdsCount { get; set; }

            /// <summary>
            /// <para>The number of shared cloud computers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalEdsCountForGroup")]
            [Validation(Required=false)]
            public long? TotalEdsCountForGroup { get; set; }

            /// <summary>
            /// <para>The total number of resources, including cloud computers and shared cloud computers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalResourceAmount")]
            [Validation(Required=false)]
            public long? TotalResourceAmount { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>To be hidden.</para>
            /// </summary>
            [NameInMap("TrustPassword")]
            [Validation(Required=false)]
            public string TrustPassword { get; set; }

            /// <summary>
            /// <para>The vSwitch IDs.</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            /// <summary>
            /// <para>The ID of the office network\&quot;s Virtual Private Cloud (VPC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-uf6tz5k67puge5jn8****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The VPC type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Basic</para>
            /// </summary>
            [NameInMap("VpcType")]
            [Validation(Required=false)]
            public string VpcType { get; set; }

            [NameInMap("VplVersion")]
            [Validation(Required=false)]
            public string VplVersion { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
