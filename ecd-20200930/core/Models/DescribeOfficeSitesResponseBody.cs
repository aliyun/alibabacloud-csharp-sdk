// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeOfficeSitesResponseBody : TeaModel {
        /// <summary>
        /// <para>The token for the next query. If NextToken is empty, no more results exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The collection of office network information.</para>
        /// </summary>
        [NameInMap("OfficeSites")]
        [Validation(Required=false)]
        public List<DescribeOfficeSitesResponseBodyOfficeSites> OfficeSites { get; set; }
        public class DescribeOfficeSitesResponseBodyOfficeSites : TeaModel {
            /// <summary>
            /// <para>The collection of AD Connector information.</para>
            /// </summary>
            [NameInMap("ADConnectors")]
            [Validation(Required=false)]
            public List<DescribeOfficeSitesResponseBodyOfficeSitesADConnectors> ADConnectors { get; set; }
            public class DescribeOfficeSitesResponseBodyOfficeSitesADConnectors : TeaModel {
                /// <summary>
                /// <para>The endpoint of the AD Connector.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.24.<em>.</em></para>
                /// </summary>
                [NameInMap("ADConnectorAddress")]
                [Validation(Required=false)]
                public string ADConnectorAddress { get; set; }

                /// <summary>
                /// <para>The status of the AD Connector.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("ConnectorStatus")]
                [Validation(Required=false)]
                public string ConnectorStatus { get; set; }

                /// <summary>
                /// <para>The ID of the network interface controller (NIC) attached to the AD Connector.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eni-bp1i4wx78lgosrj6****</para>
                /// </summary>
                [NameInMap("NetworkInterfaceId")]
                [Validation(Required=false)]
                public string NetworkInterfaceId { get; set; }

                /// <summary>
                /// <para>The specification of the AD Connector.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Specification")]
                [Validation(Required=false)]
                public string Specification { get; set; }

                /// <summary>
                /// <para>The trust password configured when setting up the AD trust relationship.</para>
                /// 
                /// <b>Example:</b>
                /// <para>password123***</para>
                /// </summary>
                [NameInMap("TrustKey")]
                [Validation(Required=false)]
                public string TrustKey { get; set; }

                /// <summary>
                /// <para>The vSwitch ID of the network where the AD Connector resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp19ocz3erfx15uon****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

            /// <summary>
            /// <para>The Alibaba Cloud Global Accelerator (GA) instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ga-bp1astu3yrplkzoo2****</para>
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// <para>The access attribute of the office network (workspace).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Private</para>
            /// </summary>
            [NameInMap("AccessAttribute")]
            [Validation(Required=false)]
            public string AccessAttribute { get; set; }

            /// <summary>
            /// <para>The account type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SIMPLE</para>
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <para>The hostname of the domain controller. The hostname must comply with Windows hostname naming conventions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>beijing-ad01</para>
            /// </summary>
            [NameInMap("AdHostname")]
            [Validation(Required=false)]
            public string AdHostname { get; set; }

            /// <summary>
            /// <para>The authority URL of the identity authentication service.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://login.microsoftonline.com">https://login.microsoftonline.com</a></para>
            /// </summary>
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
            /// <para>The peak Internet bandwidth. Valid values: 0 to 1000. Unit: Mbit/s.<br>If the value is empty or 0, Internet access is not enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The basic bandwidth type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>basic_plus</para>
            /// </summary>
            [NameInMap("BasicInternetType")]
            [Validation(Required=false)]
            public string BasicInternetType { get; set; }

            /// <summary>
            /// <para>The status of the Cloud Enterprise Network (CEN) instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>attached</para>
            /// </summary>
            [NameInMap("CenAttachStatus")]
            [Validation(Required=false)]
            public string CenAttachStatus { get; set; }

            /// <summary>
            /// <para>The Cloud Enterprise Network (CEN) instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen-3gwy16dojz1m65****</para>
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// <para>The IPv4 CIDR block of the office network VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.100.XX.XX</para>
            /// </summary>
            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            /// <summary>
            /// <para>The client ID registered with the identity provider application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a2c8f7e4-1b3d-4c5e-9f0a-6d7b8c9e****</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <para>The client secret registered with the identity provider application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sct-9f3e2d1c****</para>
            /// </summary>
            [NameInMap("ClientSecret")]
            [Validation(Required=false)]
            public string ClientSecret { get; set; }

            /// <summary>
            /// <para>Indicates whether the office network is a CloudBox office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CloudBoxOfficeSite")]
            [Validation(Required=false)]
            public bool? CloudBoxOfficeSite { get; set; }

            /// <summary>
            /// <para>The time when the office network was created. The time is in the ISO 8601 standard (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-06T05:58Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The custom access gateway address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-****.com</para>
            /// </summary>
            [NameInMap("CustomAccessPoint")]
            [Validation(Required=false)]
            public string CustomAccessPoint { get; set; }

            /// <summary>
            /// <para>The array of custom DNS addresses.</para>
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
            /// <para>The access method allowed when connecting to cloud computers.</para>
            /// <remarks>
            /// <para>The VPC connection method depends on the Alibaba Cloud PrivateLink service, which is free of charge. When this parameter is set to <c>VPC</c> or <c>Any</c>, the system automatically activates the PrivateLink service for you.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>INTERNET</para>
            /// </summary>
            [NameInMap("DesktopAccessType")]
            [Validation(Required=false)]
            public string DesktopAccessType { get; set; }

            /// <summary>
            /// <para>The number of cloud computers that have been created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DesktopCount")]
            [Validation(Required=false)]
            public long? DesktopCount { get; set; }

            /// <summary>
            /// <para>The endpoint used for VPC connections to cloud computers.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://ep-bp1s2vmbj55r5rzc****.epsrv-bp1pcfhpwvlpny01****.cn-hangzhou.privatelink.aliyuncs.com">http://ep-bp1s2vmbj55r5rzc****.epsrv-bp1pcfhpwvlpny01****.cn-hangzhou.privatelink.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("DesktopVpcEndpoint")]
            [Validation(Required=false)]
            public string DesktopVpcEndpoint { get; set; }

            /// <summary>
            /// <para>The array of DNS addresses corresponding to the AD domain.</para>
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

            /// <summary>
            /// <para>The enterprise ID (EID).</para>
            /// 
            /// <b>Example:</b>
            /// <para>e-1234abcd****</para>
            /// </summary>
            [NameInMap("Eid")]
            [Validation(Required=false)]
            public string Eid { get; set; }

            /// <summary>
            /// <para>Indicates whether local administrator permissions are granted to users of cloud computers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableAdminAccess")]
            [Validation(Required=false)]
            public bool? EnableAdminAccess { get; set; }

            /// <summary>
            /// <para>Indicates whether cross-cloud computer access within the office network is enabled. If enabled, cloud computers within the same office network can access each other over the network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableCrossDesktopAccess")]
            [Validation(Required=false)]
            public bool? EnableCrossDesktopAccess { get; set; }

            /// <summary>
            /// <para>Indicates whether the public network access feature is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableInternetAccess")]
            [Validation(Required=false)]
            public bool? EnableInternetAccess { get; set; }

            /// <summary>
            /// <para>Indicates whether cloud service route access control is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableServiceRoute")]
            [Validation(Required=false)]
            public bool? EnableServiceRoute { get; set; }

            /// <summary>
            /// <para>The environment type. This parameter is not publicly available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Private</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>The array of NAS file system IDs.</para>
            /// </summary>
            [NameInMap("FileSystemIds")]
            [Validation(Required=false)]
            public List<string> FileSystemIds { get; set; }

            /// <summary>
            /// <para>Indicates whether the directory is an LDAP directory.</para>
            /// </summary>
            [NameInMap("IsLdap")]
            [Validation(Required=false)]
            public bool? IsLdap { get; set; }

            /// <summary>
            /// <para>The access URL of the LDAP service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ldap://192.168.0.10:389</para>
            /// </summary>
            [NameInMap("LdapUrl")]
            [Validation(Required=false)]
            public string LdapUrl { get; set; }

            /// <summary>
            /// <para>The registration log information.</para>
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
                /// <para>The detailed log information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>code:success | message:Create Connector complete</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The step that corresponds to the log entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CREATE_CONNECTOR</para>
                /// </summary>
                [NameInMap("Step")]
                [Validation(Required=false)]
                public string Step { get; set; }

                /// <summary>
                /// <para>The time when the log was printed. The time is in the ISO 8601 standard (UTC).</para>
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
            /// <para>The name of the office network. The name is unique within a region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>R&amp;D_Office_Network</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Applicable only to convenience account office networks. Indicates whether secondary authentication is required during logon. If logon secondary authentication is enabled, the system checks whether the logon account has security risks when a convenience user logs on to the client. If a risk is detected, the system sends a verification code to the email address associated with the account. The convenience user can log on to the client only after passing the verification code check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("NeedVerifyLoginRisk")]
            [Validation(Required=false)]
            public bool? NeedVerifyLoginRisk { get; set; }

            /// <summary>
            /// <para>Indicates whether trusted device verification is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NeedVerifyZeroDevice")]
            [Validation(Required=false)]
            public bool? NeedVerifyZeroDevice { get; set; }

            /// <summary>
            /// <para>The Internet access package ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>np-amtp8e8q1o9e4****</para>
            /// </summary>
            [NameInMap("NetworkPackageId")]
            [Validation(Required=false)]
            public string NetworkPackageId { get; set; }

            /// <summary>
            /// <para>The network version. The new version supports products such as WUYING Cloud Application.</para>
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
            /// <para>The account system type of the office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AD_CONNECTOR</para>
            /// </summary>
            [NameInMap("OfficeSiteType")]
            [Validation(Required=false)]
            public string OfficeSiteType { get; set; }

            /// <summary>
            /// <para>The organizational unit (OU) in the AD domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com/Domain Controllers</para>
            /// </summary>
            [NameInMap("OuName")]
            [Validation(Required=false)]
            public string OuName { get; set; }

            /// <summary>
            /// <para>The protocol type.</para>
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
            /// <para>The domain name where the RDS license resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("RdsLicenseDomainName")]
            [Validation(Required=false)]
            public string RdsLicenseDomainName { get; set; }

            /// <summary>
            /// <para>The status of the RDS license.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RdsLicenseStatus")]
            [Validation(Required=false)]
            public string RdsLicenseStatus { get; set; }

            /// <summary>
            /// <para>The resource count list.</para>
            /// </summary>
            [NameInMap("ResourceAmounts")]
            [Validation(Required=false)]
            public List<DescribeOfficeSitesResponseBodyOfficeSitesResourceAmounts> ResourceAmounts { get; set; }
            public class DescribeOfficeSitesResponseBodyOfficeSitesResourceAmounts : TeaModel {
                /// <summary>
                /// <para>The resource count.</para>
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
            /// <para>The Network Security Protection Settings of the office network.</para>
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
            /// <para>The array of DNS addresses of the AD subdomain.</para>
            /// </summary>
            [NameInMap("SubDnsAddress")]
            [Validation(Required=false)]
            public List<string> SubDnsAddress { get; set; }

            /// <summary>
            /// <para>The username of the AD subdomain DNS.</para>
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

            /// <summary>
            /// <para>The tenant ID of the identity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>72f988bf-86f1-41af-91ab-2d7cd011****</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>The number of cloud computers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalEdsCount")]
            [Validation(Required=false)]
            public long? TotalEdsCount { get; set; }

            /// <summary>
            /// <para>The number of cloud computers in shared cloud computer groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalEdsCountForGroup")]
            [Validation(Required=false)]
            public long? TotalEdsCountForGroup { get; set; }

            /// <summary>
            /// <para>The total number of network interface controllers (NICs).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalResourceAmount")]
            [Validation(Required=false)]
            public long? TotalResourceAmount { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not yet available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>To be hidden.</para>
            /// </summary>
            [NameInMap("TrustPassword")]
            [Validation(Required=false)]
            public string TrustPassword { get; set; }

            /// <summary>
            /// <para>The array of vSwitch IDs.</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            /// <summary>
            /// <para>The VPC ID of the secure office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-uf6tz5k67puge5jn8****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The usage mode of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Basic</para>
            /// </summary>
            [NameInMap("VpcType")]
            [Validation(Required=false)]
            public string VpcType { get; set; }

            /// <summary>
            /// <para>The version of the workspace network component (VPL).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0.0</para>
            /// </summary>
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
        /// <para>The total number of query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
