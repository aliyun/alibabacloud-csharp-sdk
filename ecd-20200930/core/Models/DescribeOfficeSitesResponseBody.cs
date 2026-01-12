// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeOfficeSitesResponseBody : TeaModel {
        /// <summary>
        /// <para>The token that determines the start point of the next query. If this parameter is empty, all results are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The office networks.</para>
        /// </summary>
        [NameInMap("OfficeSites")]
        [Validation(Required=false)]
        public List<DescribeOfficeSitesResponseBodyOfficeSites> OfficeSites { get; set; }
        public class DescribeOfficeSitesResponseBodyOfficeSites : TeaModel {
            /// <summary>
            /// <para>Details of AD connectors.</para>
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
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CONNECT_ERROR</description></item>
                /// <item><description>RUNNING</description></item>
                /// <item><description>CONNECTING (You must configure the AD domain in which the AD connector is used.)</description></item>
                /// <item><description>EXPIRED</description></item>
                /// <item><description>CREATING</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("ConnectorStatus")]
                [Validation(Required=false)]
                public string ConnectorStatus { get; set; }

                /// <summary>
                /// <para>The ID of an elastic network interface (ENI) to which the AD connector is mounted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eni-bp1i4wx78lgosrj6****</para>
                /// </summary>
                [NameInMap("NetworkInterfaceId")]
                [Validation(Required=false)]
                public string NetworkInterfaceId { get; set; }

                /// <summary>
                /// <para>The AD connector type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: General</description></item>
                /// <item><description>2: Advanced</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Specification")]
                [Validation(Required=false)]
                public string Specification { get; set; }

                /// <summary>
                /// <para>The trust password that is specified when you configure the AD trust relationship.</para>
                /// 
                /// <b>Example:</b>
                /// <para>password123***</para>
                /// </summary>
                [NameInMap("TrustKey")]
                [Validation(Required=false)]
                public string TrustKey { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch that resides in the network of the AD connector.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp19ocz3erfx15uon****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

            /// <summary>
            /// <para>The ID of the GA instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ga-bp1astu3yrplkzoo2****</para>
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <para>The hostname of the domain controller. The hostname must comply with the hostname naming convention of Windows.</para>
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
            /// <para>The hostname of the secondary domain controller.</para>
            /// 
            /// <b>Example:</b>
            /// <para>beijing-ad02</para>
            /// </summary>
            [NameInMap("BackupDCHostname")]
            [Validation(Required=false)]
            public string BackupDCHostname { get; set; }

            /// <summary>
            /// <para>The DNS address of the secondary domain controller.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.24.XX.XX</para>
            /// </summary>
            [NameInMap("BackupDns")]
            [Validation(Required=false)]
            public string BackupDns { get; set; }

            /// <summary>
            /// <para>The maximum public bandwidth value. Valid values: 0 to 1000.\
            /// If you leave this parameter empty or set this parameter to 0, Internet access is not enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The CEN instance status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>attached</para>
            /// </summary>
            [NameInMap("CenAttachStatus")]
            [Validation(Required=false)]
            public string CenAttachStatus { get; set; }

            /// <summary>
            /// <para>The CEN instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen-3gwy16dojz1m65****</para>
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// <para>The IPv4 CIDR block of the VPC that the office network uses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.0.0/16</para>
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
            /// <para>Indicates whether the CloudBox-based office network is created.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
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
            /// <para>The custom endpoint of the access gateway.</para>
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
            /// <para>The ID of the security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp1ce64o4g9mdf5u****</para>
            /// </summary>
            [NameInMap("CustomSecurityGroupId")]
            [Validation(Required=false)]
            public string CustomSecurityGroupId { get; set; }

            /// <summary>
            /// <para>The method that is used to connect cloud computers that reside in the office network from Alibaba Cloud Workspace clients.</para>
            /// <remarks>
            /// <para> The VPC connection depends on Alibaba Cloud PrivateLink. You can use Alibaba Cloud PrivateLink for free. When you set this parameter to <c>VPC</c> or <c>Any</c>, PrivateLink is automatically activated.</para>
            /// </remarks>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>INTERNET (default): Cloud computers are connected from Alibaba Cloud Workspace clients over the Internet.</description></item>
            /// <item><description>VPC: Cloud computers are connected from Alibaba Cloud Workspace clients over the VPC.</description></item>
            /// <item><description>ANY: Cloud computers are connected from Alibaba Cloud Workspace clients over the Internet or the VPC. When end users connect to cloud computers from Alibaba Cloud Workspace clients, you can choose a connection method based on your business requirements.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INTERNET</para>
            /// </summary>
            [NameInMap("DesktopAccessType")]
            [Validation(Required=false)]
            public string DesktopAccessType { get; set; }

            /// <summary>
            /// <para>The number of cloud computers that are created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DesktopCount")]
            [Validation(Required=false)]
            public long? DesktopCount { get; set; }

            /// <summary>
            /// <para>The endpoint that is used to connect to cloud computers in the directory over a VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://ep-bp1s2vmbj55r5rzc****.epsrv-bp1pcfhpwvlpny01****.cn-hangzhou.privatelink.aliyuncs.com">http://ep-bp1s2vmbj55r5rzc****.epsrv-bp1pcfhpwvlpny01****.cn-hangzhou.privatelink.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("DesktopVpcEndpoint")]
            [Validation(Required=false)]
            public string DesktopVpcEndpoint { get; set; }

            /// <summary>
            /// <para>The DNS addresses for the AD domains.</para>
            /// </summary>
            [NameInMap("DnsAddress")]
            [Validation(Required=false)]
            public List<string> DnsAddress { get; set; }

            /// <summary>
            /// <para>The username of a Domain Name System (DNS) user.</para>
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
            /// <para>Indicates whether the local administrator permissions are granted to users that are authorized to use cloud computers in the office network.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true (default)</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableAdminAccess")]
            [Validation(Required=false)]
            public bool? EnableAdminAccess { get; set; }

            /// <summary>
            /// <para>Indicates whether the connection between cloud computers in the office network is enabled. After you enable the connection between cloud computers in the office network, cloud computers in the office network can access each other.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableCrossDesktopAccess")]
            [Validation(Required=false)]
            public bool? EnableCrossDesktopAccess { get; set; }

            /// <summary>
            /// <para>Indicates whether Internet access is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableInternetAccess")]
            [Validation(Required=false)]
            public bool? EnableInternetAccess { get; set; }

            /// <summary>
            /// <para>Indicates whether route access control is enabled for cloud services.</para>
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
            /// <para>An array of File Storage NAS (NAS) file system IDs.</para>
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
            /// <para>Details about registration logs.</para>
            /// </summary>
            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<DescribeOfficeSitesResponseBodyOfficeSitesLogs> Logs { get; set; }
            public class DescribeOfficeSitesResponseBodyOfficeSitesLogs : TeaModel {
                /// <summary>
                /// <para>The log severity.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ERROR</description></item>
                /// <item><description>INFO</description></item>
                /// <item><description>WARN</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>INFO</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>Details of the log entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>code:success | message:Create Connector complete</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The step in the log entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CREATE_CONNECTOR</para>
                /// </summary>
                [NameInMap("Step")]
                [Validation(Required=false)]
                public string Step { get; set; }

                /// <summary>
                /// <para>The time when the log entry was printed.</para>
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
            /// <para>The name of the office network. The name is unique in a region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Indicates whether two-factor verification is enabled when an end user logs on to an Alibaba Cloud Workspace client. This parameter is required only for convenience office networks. If two-factor verification is enabled, the system checks whether security risks exist within the logon account when a convenience user logs on to the client. If risks are detected, the system sends a verification code to the email address that is associated with the account. Then, the convenience user can log on to the client only after the user enters the correct verification code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("NeedVerifyLoginRisk")]
            [Validation(Required=false)]
            public bool? NeedVerifyLoginRisk { get; set; }

            /// <summary>
            /// <para>Indicates whether the trusted device verification is enabled.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NeedVerifyZeroDevice")]
            [Validation(Required=false)]
            public bool? NeedVerifyZeroDevice { get; set; }

            /// <summary>
            /// <para>The premium bandwidth plan ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>np-amtp8e8q1o9e4****</para>
            /// </summary>
            [NameInMap("NetworkPackageId")]
            [Validation(Required=false)]
            public string NetworkPackageId { get; set; }

            /// <summary>
            /// <para>The network version. The new version supports App Streaming.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DEFAULT: the old version.</description></item>
            /// <item><description>NM: the new version.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NM</para>
            /// </summary>
            [NameInMap("NmVersion")]
            [Validation(Required=false)]
            public string NmVersion { get; set; }

            /// <summary>
            /// <para>The IDs of the office networks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-363353****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The account type of the office network.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SIMPLE: the convenience account</description></item>
            /// <item><description>AD_CONNECTOR: the enterprise AD account</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AD_CONNECTOR</para>
            /// </summary>
            [NameInMap("OfficeSiteType")]
            [Validation(Required=false)]
            public string OfficeSiteType { get; set; }

            /// <summary>
            /// <para>The organizational unit (OU) in the AD domain to which the office network is connected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com/Domain Controllers</para>
            /// </summary>
            [NameInMap("OuName")]
            [Validation(Required=false)]
            public string OuName { get; set; }

            /// <summary>
            /// <para>The protocol type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>HDX</description></item>
            /// <item><description>ASP</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ASP</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <para>The IP address of the RDS license.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.100.XX.XX</para>
            /// </summary>
            [NameInMap("RdsLicenseAddress")]
            [Validation(Required=false)]
            public string RdsLicenseAddress { get; set; }

            /// <summary>
            /// <para>The domain name of the RDS license.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.com</para>
            /// </summary>
            [NameInMap("RdsLicenseDomainName")]
            [Validation(Required=false)]
            public string RdsLicenseDomainName { get; set; }

            /// <summary>
            /// <para>The remote desktop service (RDS) license status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RdsLicenseStatus")]
            [Validation(Required=false)]
            public string RdsLicenseStatus { get; set; }

            /// <summary>
            /// <para>The number of resources.</para>
            /// </summary>
            [NameInMap("ResourceAmounts")]
            [Validation(Required=false)]
            public List<DescribeOfficeSitesResponseBodyOfficeSitesResourceAmounts> ResourceAmounts { get; set; }
            public class DescribeOfficeSitesResponseBodyOfficeSitesResourceAmounts : TeaModel {
                /// <summary>
                /// <para>The number of resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public long? Amount { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>desktop: the cloud computer.</description></item>
                /// <item><description>DesktopGroup: the cloud computer share.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>desktop</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <para>The security protection setting of the office network.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SASE: SASE is configured.</description></item>
            /// <item><description>OFF: No security protection setting is configured.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SASE</para>
            /// </summary>
            [NameInMap("SecurityProtection")]
            [Validation(Required=false)]
            public string SecurityProtection { get; set; }

            /// <summary>
            /// <para>Indicates whether single sign-on (SSO) is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SsoEnabled")]
            [Validation(Required=false)]
            public bool? SsoEnabled { get; set; }

            /// <summary>
            /// <para>The SSO type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SAML.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("SsoType")]
            [Validation(Required=false)]
            public string SsoType { get; set; }

            /// <summary>
            /// <para>The office network status.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>REGISTERING: The office network is being registered.</description></item>
            /// <item><description>DEREGISTERING: The office network is being deregistered.</description></item>
            /// <item><description>REGISTERED: The office network is registered.</description></item>
            /// <item><description>NEEDCONFIGTRUST: A trust relationship is required for the office network.</description></item>
            /// <item><description>CONFIGTRUSTFAILED: A trust relationship fails to be configured for the office network.</description></item>
            /// <item><description>DEREGISTERED: The office network is deregistered.</description></item>
            /// <item><description>ERROR: One or more configurations of the office network are invalid.</description></item>
            /// <item><description>CONFIGTRUSTING: A trust relationship is being configured for the office network.</description></item>
            /// <item><description>NEEDCONFIGUSER: Users are required for the office network.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>REGISTERED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The DNS addresses for the AD subdomains.</para>
            /// </summary>
            [NameInMap("SubDnsAddress")]
            [Validation(Required=false)]
            public List<string> SubDnsAddress { get; set; }

            /// <summary>
            /// <para>The username of enterprise AD subdomain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testSubDnsUserName</para>
            /// </summary>
            [NameInMap("SubDomainName")]
            [Validation(Required=false)]
            public string SubDomainName { get; set; }

            /// <summary>
            /// <para>The subnet mode of the office network.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: disabled.</description></item>
            /// <item><description>1: enabled.</description></item>
            /// </list>
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
            /// <para>The total number of cloud computers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalEdsCount")]
            [Validation(Required=false)]
            public long? TotalEdsCount { get; set; }

            /// <summary>
            /// <para>The number of cloud computers in the cloud computer share.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalEdsCountForGroup")]
            [Validation(Required=false)]
            public long? TotalEdsCountForGroup { get; set; }

            /// <summary>
            /// <para>The number of network interface controllers (NICs).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalResourceAmount")]
            [Validation(Required=false)]
            public long? TotalResourceAmount { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is unavailable.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("TrustPassword")]
            [Validation(Required=false)]
            public string TrustPassword { get; set; }

            /// <summary>
            /// <para>An array of VSwitch IDs.</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-uf6tz5k67puge5jn8****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The VPC type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Basic</description></item>
            /// <item><description>Customized</description></item>
            /// <item><description>Standard</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Basic</para>
            /// </summary>
            [NameInMap("VpcType")]
            [Validation(Required=false)]
            public string VpcType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
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
