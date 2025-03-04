// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDirectoriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The hostname of the domain controller. The hostname must comply with the hostname naming convention of Windows. This parameter is returned only when the directory type is AD office network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cnshsv21hmc****</para>
        /// </summary>
        [NameInMap("AdHostname")]
        [Validation(Required=false)]
        public string AdHostname { get; set; }

        /// <summary>
        /// <para>The directories.</para>
        /// </summary>
        [NameInMap("Directories")]
        [Validation(Required=false)]
        public List<DescribeDirectoriesResponseBodyDirectories> Directories { get; set; }
        public class DescribeDirectoriesResponseBodyDirectories : TeaModel {
            /// <summary>
            /// <para>Details of the AD connector.</para>
            /// </summary>
            [NameInMap("ADConnectors")]
            [Validation(Required=false)]
            public List<DescribeDirectoriesResponseBodyDirectoriesADConnectors> ADConnectors { get; set; }
            public class DescribeDirectoriesResponseBodyDirectoriesADConnectors : TeaModel {
                /// <summary>
                /// <para>The connection address.</para>
                /// 
                /// <b>Example:</b>
                /// <para><c>172.17.**.**</c></para>
                /// </summary>
                [NameInMap("ADConnectorAddress")]
                [Validation(Required=false)]
                public string ADConnectorAddress { get; set; }

                /// <summary>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CONNECT_ERROR</description></item>
                /// <item><description>RUNNING</description></item>
                /// <item><description>CONNECTING: You must configure domain trust for your AD system.</description></item>
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
                /// <para>The ID of the NIC to which the AD connector is mounted.</para>
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
                /// <item><description><para>1: General</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- -->
                /// </description></item>
                /// <item><description><para>2: Advanced</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- --></description></item>
                /// </list>
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
                /// <para>The ID of the vSwitch with which the AD connector is associated.</para>
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
            /// <para>The time when the directory was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-02T01:44Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The security group ID. This parameter is returned only when the directory type is AD office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp1ce64o4g9mdf5u****</para>
            /// </summary>
            [NameInMap("CustomSecurityGroupId")]
            [Validation(Required=false)]
            public string CustomSecurityGroupId { get; set; }

            /// <summary>
            /// <para>The method in which the cloud computer is connected.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>VPC</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>Internet</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>Any</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Internet</para>
            /// </summary>
            [NameInMap("DesktopAccessType")]
            [Validation(Required=false)]
            public string DesktopAccessType { get; set; }

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
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>AD_CONNECTOR: AD directory</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>RAM: RAM directory</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RAM</para>
            /// </summary>
            [NameInMap("DirectoryType")]
            [Validation(Required=false)]
            public string DirectoryType { get; set; }

            /// <summary>
            /// <para>The DNS address of the directory.</para>
            /// </summary>
            [NameInMap("DnsAddress")]
            [Validation(Required=false)]
            public List<string> DnsAddress { get; set; }

            /// <summary>
            /// <para>The username of a DNS user.</para>
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
            /// <para>The password of the domain administrator. This parameter is returned only when the directory type is AD office network.</para>
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
            /// <para>Indicates whether the local administrator permissions are granted to users that use cloud computers in the office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableAdminAccess")]
            [Validation(Required=false)]
            public bool? EnableAdminAccess { get; set; }

            /// <summary>
            /// <para>Indicates whether cloud computers can communicate with each other in the directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableCrossDesktopAccess")]
            [Validation(Required=false)]
            public bool? EnableCrossDesktopAccess { get; set; }

            /// <summary>
            /// <para>Indicates whether access over the Internet is enabled.</para>
            /// <remarks>
            /// <para> This parameter is unavailable.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableInternetAccess")]
            [Validation(Required=false)]
            public bool? EnableInternetAccess { get; set; }

            /// <summary>
            /// <para>The IDs of File Storage NAS (NAS) file systems.</para>
            /// </summary>
            [NameInMap("FileSystemIds")]
            [Validation(Required=false)]
            public List<string> FileSystemIds { get; set; }

            /// <summary>
            /// <para>The registration logs. This parameter is returned only when the directory type is AD office network.</para>
            /// </summary>
            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<DescribeDirectoriesResponseBodyDirectoriesLogs> Logs { get; set; }
            public class DescribeDirectoriesResponseBodyDirectoriesLogs : TeaModel {
                /// <summary>
                /// <para>The level of the log entry.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>ERROR</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- -->
                /// </description></item>
                /// <item><description><para>INFO</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- -->
                /// </description></item>
                /// <item><description><para>WARN</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- --></description></item>
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
                /// <para>The time when the log entry was printed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-22T06:45Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether MFA is enabled.</para>
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
            /// <para>Indicates whether two-step verification for logons is enabled. This parameter is returned only for directories of convenience account type.\
            /// If two-factor verification is enabled, the system checks whether security risks exist within the logon account when a convenience user logs on to an Alibaba Cloud Workspace client. If risks are detected, the system sends a verification code to the email address that is associated with the account. Then, the convenience user can log on to the client only after the user enters the correct verification code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("NeedVerifyLoginRisk")]
            [Validation(Required=false)]
            public bool? NeedVerifyLoginRisk { get; set; }

            /// <summary>
            /// <para>The organization unit that you selected when you added the cloud computer to the domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com/Domain Controllers</para>
            /// </summary>
            [NameInMap("OuName")]
            [Validation(Required=false)]
            public string OuName { get; set; }

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
            /// <para>The status of the AD directory.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>REGISTERING</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>REGISTERED</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>REGISTERING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The DNS address of the enterprise AD subdomain.</para>
            /// </summary>
            [NameInMap("SubDnsAddress")]
            [Validation(Required=false)]
            public List<string> SubDnsAddress { get; set; }

            /// <summary>
            /// <para>The fully qualified domain name (FQDN) of the existing AD subdomain. The value contains both the host name and the domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>child.example.com</para>
            /// </summary>
            [NameInMap("SubDomainName")]
            [Validation(Required=false)]
            public string SubDomainName { get; set; }

            /// <summary>
            /// <para>The AD trust password. This parameter is returned only when the directory type is AD office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>82Tg****</para>
            /// </summary>
            [NameInMap("TrustPassword")]
            [Validation(Required=false)]
            public string TrustPassword { get; set; }

            /// <summary>
            /// <para>The IDs of the vSwitches specified when the directory was created.</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            /// <summary>
            /// <para>The ID of the VPC to which the vSwitch belongs. This parameter is returned only when the directory type is AD office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-uf6tz5k67puge5jn8****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The token that is used for the next query. If this parameter is empty, all results are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F369A091-002F-49C8-AD55-02A776297C7B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
