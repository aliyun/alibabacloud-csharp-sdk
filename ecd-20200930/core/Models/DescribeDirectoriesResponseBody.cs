// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDirectoriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The hostname of the domain controller. The hostname must comply with Windows hostname naming conventions. This parameter is returned only when the directory type is AD workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cnshsv21hmc****</para>
        /// </summary>
        [NameInMap("AdHostname")]
        [Validation(Required=false)]
        public string AdHostname { get; set; }

        /// <summary>
        /// <para>The list of directory information.</para>
        /// </summary>
        [NameInMap("Directories")]
        [Validation(Required=false)]
        public List<DescribeDirectoriesResponseBodyDirectories> Directories { get; set; }
        public class DescribeDirectoriesResponseBodyDirectories : TeaModel {
            /// <summary>
            /// <para>The information about AD connectors.</para>
            /// </summary>
            [NameInMap("ADConnectors")]
            [Validation(Required=false)]
            public List<DescribeDirectoriesResponseBodyDirectoriesADConnectors> ADConnectors { get; set; }
            public class DescribeDirectoriesResponseBodyDirectoriesADConnectors : TeaModel {
                /// <summary>
                /// <para>The endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.17.XX.XX</para>
                /// </summary>
                [NameInMap("ADConnectorAddress")]
                [Validation(Required=false)]
                public string ADConnectorAddress { get; set; }

                /// <summary>
                /// <para>The connection status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("ConnectorStatus")]
                [Validation(Required=false)]
                public string ConnectorStatus { get; set; }

                /// <summary>
                /// <para>The ID of the network interface controller (NIC) attached to the AD connector.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eni-bp1i4wx78lgosrj6****</para>
                /// </summary>
                [NameInMap("NetworkInterfaceId")]
                [Validation(Required=false)]
                public string NetworkInterfaceId { get; set; }

                /// <summary>
                /// <para>The AD connector specification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Specification")]
                [Validation(Required=false)]
                public string Specification { get; set; }

                /// <summary>
                /// <para>The trust password of the AD domain controller.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yfpoAD****</para>
                /// </summary>
                [NameInMap("TrustKey")]
                [Validation(Required=false)]
                public string TrustKey { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch where the AD connector resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp19ocz3erfx15uon****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

            /// <summary>
            /// <para>The hostname of the domain controller.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dc001</para>
            /// </summary>
            [NameInMap("AdHostname")]
            [Validation(Required=false)]
            public string AdHostname { get; set; }

            /// <summary>
            /// <para>The hostname of the backup domain controller.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dc002</para>
            /// </summary>
            [NameInMap("BackupDCHostname")]
            [Validation(Required=false)]
            public string BackupDCHostname { get; set; }

            /// <summary>
            /// <para>The DNS address of the backup domain controller.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.2.100</para>
            /// </summary>
            [NameInMap("BackupDns")]
            [Validation(Required=false)]
            public string BackupDns { get; set; }

            /// <summary>
            /// <para>The time when the directory was created. The time is in the ISO 8601 standard (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-02T01:44Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The security group ID. This parameter is returned only when the directory type is AD workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp1ce64o4g9mdf5u****</para>
            /// </summary>
            [NameInMap("CustomSecurityGroupId")]
            [Validation(Required=false)]
            public string CustomSecurityGroupId { get; set; }

            /// <summary>
            /// <para>The method allowed for connecting to cloud computers. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>VPC: VPC connection.</description></item>
            /// <item><description>Internet: Internet connection.</description></item>
            /// <item><description>Any: Both Internet and VPC connections.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Internet</para>
            /// </summary>
            [NameInMap("DesktopAccessType")]
            [Validation(Required=false)]
            public string DesktopAccessType { get; set; }

            /// <summary>
            /// <para>The endpoint used for connecting to cloud computers over a VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://ep-bp1s2vmbj55r5rzc****.epsrv-bp1pcfhpwvlpny01****.cn-hangzhou.privatelink.aliyuncs.com">http://ep-bp1s2vmbj55r5rzc****.epsrv-bp1pcfhpwvlpny01****.cn-hangzhou.privatelink.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("DesktopVpcEndpoint")]
            [Validation(Required=false)]
            public string DesktopVpcEndpoint { get; set; }

            /// <summary>
            /// <para>The directory ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-gx2x1dhsmu52rd****</para>
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// <para>The directory type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RAM</para>
            /// </summary>
            [NameInMap("DirectoryType")]
            [Validation(Required=false)]
            public string DirectoryType { get; set; }

            /// <summary>
            /// <para>The DNS addresses of the directory.</para>
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
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The password of the domain administrator. This parameter is returned only when the directory type is AD workspace.</para>
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
            /// <para>sAMAccountName</para>
            /// </summary>
            [NameInMap("DomainUserName")]
            [Validation(Required=false)]
            public string DomainUserName { get; set; }

            /// <summary>
            /// <para>Indicates whether local administrator permissions are granted to cloud computer users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableAdminAccess")]
            [Validation(Required=false)]
            public bool? EnableAdminAccess { get; set; }

            /// <summary>
            /// <para>Indicates whether the cross-cloud-computer access feature is enabled for the directory. After this feature is enabled, cloud computers within the same directory can access each other over the network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableCrossDesktopAccess")]
            [Validation(Required=false)]
            public bool? EnableCrossDesktopAccess { get; set; }

            /// <summary>
            /// <para>Indicates whether Internet access is enabled.    </para>
            /// <remarks>
            /// <para>This parameter is not yet available for use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableInternetAccess")]
            [Validation(Required=false)]
            public bool? EnableInternetAccess { get; set; }

            /// <summary>
            /// <para>The NAS file system IDs.</para>
            /// </summary>
            [NameInMap("FileSystemIds")]
            [Validation(Required=false)]
            public List<string> FileSystemIds { get; set; }

            /// <summary>
            /// <para>The list of registration log information. This parameter is returned only when the directory type is AD workspace.</para>
            /// </summary>
            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<DescribeDirectoriesResponseBodyDirectoriesLogs> Logs { get; set; }
            public class DescribeDirectoriesResponseBodyDirectoriesLogs : TeaModel {
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
                /// <para>code:success | message:Create Connector complete.</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The step that corresponds to the log entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DescribeDirectories</para>
                /// </summary>
                [NameInMap("Step")]
                [Validation(Required=false)]
                public string Step { get; set; }

                /// <summary>
                /// <para>The time when the log was printed. The time is in the ISO 8601 standard (UTC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-22T06:45Z</para>
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
            /// <para>The directory name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testDirectoryName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Indicates whether secondary authentication is required for logon. This parameter applies only to convenience directories. If secondary authentication is enabled, the system checks for security risks when a convenience user logs on to the client. If a risk is detected, the system sends a verification code to the email address associated with the account. The convenience user can log on to the client only after passing the verification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("NeedVerifyLoginRisk")]
            [Validation(Required=false)]
            public bool? NeedVerifyLoginRisk { get; set; }

            /// <summary>
            /// <para>The organizational unit (OU) selected when cloud computers join the domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com/Domain Controllers</para>
            /// </summary>
            [NameInMap("OuName")]
            [Validation(Required=false)]
            public string OuName { get; set; }

            /// <summary>
            /// <para>Indicates whether SSO is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SsoEnabled")]
            [Validation(Required=false)]
            public bool? SsoEnabled { get; set; }

            /// <summary>
            /// <para>The status of the AD directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>REGISTERING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The DNS addresses of the AD subdomain.</para>
            /// </summary>
            [NameInMap("SubDnsAddress")]
            [Validation(Required=false)]
            public List<string> SubDnsAddress { get; set; }

            /// <summary>
            /// <para>The fully qualified domain name (FQDN) of the existing AD subdomain, which includes both the hostname and the domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>child.example.com</para>
            /// </summary>
            [NameInMap("SubDomainName")]
            [Validation(Required=false)]
            public string SubDomainName { get; set; }

            /// <summary>
            /// <para>The AD trust password. This parameter is returned only when the directory type is AD workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>82Tg****</para>
            /// </summary>
            [NameInMap("TrustPassword")]
            [Validation(Required=false)]
            public string TrustPassword { get; set; }

            /// <summary>
            /// <para>The vSwitch IDs specified when the directory was created.</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            /// <summary>
            /// <para>The ID of the VPC to which the vSwitch belongs. This parameter is returned only when the directory type is AD workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-uf6tz5k67puge5jn8****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The pagination token for the next query. An empty value indicates that no more results exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F369A091-002F-49C8-AD55-02A776297C7B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
