// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDirectoriesResponseBody : TeaModel {
        /// <summary>
        /// The hostname of the domain controller. The hostname must comply with the hostname naming convention of Windows. This parameter is returned only when the directory type is AD office network.
        /// </summary>
        [NameInMap("AdHostname")]
        [Validation(Required=false)]
        public string AdHostname { get; set; }

        /// <summary>
        /// The directories.
        /// </summary>
        [NameInMap("Directories")]
        [Validation(Required=false)]
        public List<DescribeDirectoriesResponseBodyDirectories> Directories { get; set; }
        public class DescribeDirectoriesResponseBodyDirectories : TeaModel {
            /// <summary>
            /// Details of the AD connector.
            /// </summary>
            [NameInMap("ADConnectors")]
            [Validation(Required=false)]
            public List<DescribeDirectoriesResponseBodyDirectoriesADConnectors> ADConnectors { get; set; }
            public class DescribeDirectoriesResponseBodyDirectoriesADConnectors : TeaModel {
                /// <summary>
                /// The connection address.
                /// </summary>
                [NameInMap("ADConnectorAddress")]
                [Validation(Required=false)]
                public string ADConnectorAddress { get; set; }

                /// <summary>
                /// Valid values:
                /// 
                /// *   CONNECT_ERROR
                /// *   RUNNING
                /// *   CONNECTING: You must configure domain trust for your AD system.
                /// *   EXPIRED
                /// *   CREATING
                /// </summary>
                [NameInMap("ConnectorStatus")]
                [Validation(Required=false)]
                public string ConnectorStatus { get; set; }

                /// <summary>
                /// The ID of the NIC to which the AD connector is mounted.
                /// </summary>
                [NameInMap("NetworkInterfaceId")]
                [Validation(Required=false)]
                public string NetworkInterfaceId { get; set; }

                /// <summary>
                /// The AD connector type.
                /// 
                /// Valid values:
                /// 
                /// *   1: General
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   2: Advanced
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// </summary>
                [NameInMap("Specification")]
                [Validation(Required=false)]
                public string Specification { get; set; }

                /// <summary>
                /// The trust password of the AD domain controller.
                /// </summary>
                [NameInMap("TrustKey")]
                [Validation(Required=false)]
                public string TrustKey { get; set; }

                /// <summary>
                /// The ID of the vSwitch with which the AD connector is associated.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

            /// <summary>
            /// The time when the directory was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The security group ID. This parameter is returned only when the directory type is AD office network.
            /// </summary>
            [NameInMap("CustomSecurityGroupId")]
            [Validation(Required=false)]
            public string CustomSecurityGroupId { get; set; }

            /// <summary>
            /// The method in which the cloud computer is connected.
            /// 
            /// Valid values:
            /// 
            /// *   VPC
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Internet
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Any
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("DesktopAccessType")]
            [Validation(Required=false)]
            public string DesktopAccessType { get; set; }

            /// <summary>
            /// The endpoint that is used to connect to cloud computers in the directory over a VPC.
            /// </summary>
            [NameInMap("DesktopVpcEndpoint")]
            [Validation(Required=false)]
            public string DesktopVpcEndpoint { get; set; }

            /// <summary>
            /// The directory ID.
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// The directory type.
            /// 
            /// Valid values:
            /// 
            /// *   AD_CONNECTOR: AD directory
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   RAM: RAM directory
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("DirectoryType")]
            [Validation(Required=false)]
            public string DirectoryType { get; set; }

            /// <summary>
            /// The DNS address of the directory.
            /// </summary>
            [NameInMap("DnsAddress")]
            [Validation(Required=false)]
            public List<string> DnsAddress { get; set; }

            /// <summary>
            /// The username of a DNS user.
            /// </summary>
            [NameInMap("DnsUserName")]
            [Validation(Required=false)]
            public string DnsUserName { get; set; }

            /// <summary>
            /// The domain name.
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// The password of the domain administrator. This parameter is returned only when the directory type is AD office network.
            /// </summary>
            [NameInMap("DomainPassword")]
            [Validation(Required=false)]
            public string DomainPassword { get; set; }

            /// <summary>
            /// The username of the domain administrator.
            /// </summary>
            [NameInMap("DomainUserName")]
            [Validation(Required=false)]
            public string DomainUserName { get; set; }

            /// <summary>
            /// Indicates whether the local administrator permissions are granted to users that use cloud computers in the office network.
            /// </summary>
            [NameInMap("EnableAdminAccess")]
            [Validation(Required=false)]
            public bool? EnableAdminAccess { get; set; }

            /// <summary>
            /// Indicates whether cloud computers can communicate with each other in the directory.
            /// </summary>
            [NameInMap("EnableCrossDesktopAccess")]
            [Validation(Required=false)]
            public bool? EnableCrossDesktopAccess { get; set; }

            /// <summary>
            /// Indicates whether access over the Internet is enabled.
            /// 
            /// >  This parameter is unavailable.
            /// </summary>
            [NameInMap("EnableInternetAccess")]
            [Validation(Required=false)]
            public bool? EnableInternetAccess { get; set; }

            /// <summary>
            /// The IDs of Apsara File Storage NAS (NAS) file systems.
            /// </summary>
            [NameInMap("FileSystemIds")]
            [Validation(Required=false)]
            public List<string> FileSystemIds { get; set; }

            /// <summary>
            /// The registration logs. This parameter is returned only when the directory type is AD office network.
            /// </summary>
            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<DescribeDirectoriesResponseBodyDirectoriesLogs> Logs { get; set; }
            public class DescribeDirectoriesResponseBodyDirectoriesLogs : TeaModel {
                /// <summary>
                /// The level of the log entry.
                /// 
                /// Valid values:
                /// 
                /// *   ERROR
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   INFO
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   WARN
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// Details of the log entry.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The step that corresponds to the log entry.
                /// </summary>
                [NameInMap("Step")]
                [Validation(Required=false)]
                public string Step { get; set; }

                /// <summary>
                /// The time when the log entry was printed.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

            /// <summary>
            /// Indicates whether MFA is enabled.
            /// </summary>
            [NameInMap("MfaEnabled")]
            [Validation(Required=false)]
            public bool? MfaEnabled { get; set; }

            /// <summary>
            /// The directory name.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Indicates whether two-step verification for logons is enabled. This parameter is returned only for directories of convenience account type.\
            /// If two-factor verification is enabled, the system checks whether security risks exist within the logon account when a convenience user logs on to an Alibaba Cloud Workspace client. If risks are detected, the system sends a verification code to the email address that is associated with the account. Then, the convenience user can log on to the client only after the user enters the correct verification code.
            /// </summary>
            [NameInMap("NeedVerifyLoginRisk")]
            [Validation(Required=false)]
            public bool? NeedVerifyLoginRisk { get; set; }

            /// <summary>
            /// The organization unit that you selected when you added the cloud computer to the domain.
            /// </summary>
            [NameInMap("OuName")]
            [Validation(Required=false)]
            public string OuName { get; set; }

            /// <summary>
            /// Indicates whether single sign-on (SSO) is enabled.
            /// </summary>
            [NameInMap("SsoEnabled")]
            [Validation(Required=false)]
            public bool? SsoEnabled { get; set; }

            /// <summary>
            /// The status of the AD directory.
            /// 
            /// Valid values:
            /// 
            /// *   REGISTERING
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   REGISTERED
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The DNS address of the enterprise AD subdomain.
            /// </summary>
            [NameInMap("SubDnsAddress")]
            [Validation(Required=false)]
            public List<string> SubDnsAddress { get; set; }

            /// <summary>
            /// The fully qualified domain name (FQDN) of the existing AD subdomain. The value contains both the host name and the domain name.
            /// </summary>
            [NameInMap("SubDomainName")]
            [Validation(Required=false)]
            public string SubDomainName { get; set; }

            /// <summary>
            /// The AD trust password. This parameter is returned only when the directory type is AD office network.
            /// </summary>
            [NameInMap("TrustPassword")]
            [Validation(Required=false)]
            public string TrustPassword { get; set; }

            /// <summary>
            /// The IDs of the vSwitches specified when the directory was created.
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            /// <summary>
            /// The ID of the VPC to which the vSwitch belongs. This parameter is returned only when the directory type is AD office network.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The token that is used for the next query. If this parameter is empty, all results are returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
