// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDirectoriesResponse : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=true)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Directories")]
        [Validation(Required=true)]
        public List<DescribeDirectoriesResponseDirectories> Directories { get; set; }
        public class DescribeDirectoriesResponseDirectories : TeaModel {
            [NameInMap("DirectoryId")]
            [Validation(Required=true)]
            public string DirectoryId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }

            [NameInMap("DirectoryType")]
            [Validation(Required=true)]
            public string DirectoryType { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=true)]
            public string CreationTime { get; set; }

            [NameInMap("Name")]
            [Validation(Required=true)]
            public string Name { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=true)]
            public string VpcId { get; set; }

            [NameInMap("CustomSecurityGroupId")]
            [Validation(Required=true)]
            public string CustomSecurityGroupId { get; set; }

            [NameInMap("DnsUserName")]
            [Validation(Required=true)]
            public string DnsUserName { get; set; }

            [NameInMap("EnableInternetAccess")]
            [Validation(Required=true)]
            public bool? EnableInternetAccess { get; set; }

            [NameInMap("EnableAdminAccess")]
            [Validation(Required=true)]
            public bool? EnableAdminAccess { get; set; }

            [NameInMap("DesktopAccessType")]
            [Validation(Required=true)]
            public string DesktopAccessType { get; set; }

            [NameInMap("DesktopVpcEndpoint")]
            [Validation(Required=true)]
            public string DesktopVpcEndpoint { get; set; }

            [NameInMap("TrustPassword")]
            [Validation(Required=true)]
            public string TrustPassword { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=true)]
            public string DomainName { get; set; }

            [NameInMap("DomainUserName")]
            [Validation(Required=true)]
            public string DomainUserName { get; set; }

            [NameInMap("DomainPassword")]
            [Validation(Required=true)]
            public string DomainPassword { get; set; }

            [NameInMap("SubDomainName")]
            [Validation(Required=true)]
            public string SubDomainName { get; set; }

            [NameInMap("MfaEnabled")]
            [Validation(Required=true)]
            public bool? MfaEnabled { get; set; }

            [NameInMap("SsoEnabled")]
            [Validation(Required=true)]
            public bool? SsoEnabled { get; set; }

            [NameInMap("ADConnectors")]
            [Validation(Required=true)]
            public List<DescribeDirectoriesResponseDirectoriesADConnectors> ADConnectors { get; set; }
            public class DescribeDirectoriesResponseDirectoriesADConnectors : TeaModel {
                [NameInMap("ADConnectorAddress")]
                [Validation(Required=true)]
                public string ADConnectorAddress { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=true)]
                public string VSwitchId { get; set; }

                [NameInMap("ConnectorStatus")]
                [Validation(Required=true)]
                public string ConnectorStatus { get; set; }

                [NameInMap("NetworkInterfaceId")]
                [Validation(Required=true)]
                public string NetworkInterfaceId { get; set; }

            }

            [NameInMap("Logs")]
            [Validation(Required=true)]
            public List<DescribeDirectoriesResponseDirectoriesLogs> Logs { get; set; }
            public class DescribeDirectoriesResponseDirectoriesLogs : TeaModel {
                [NameInMap("Level")]
                [Validation(Required=true)]
                public string Level { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=true)]
                public string TimeStamp { get; set; }

                [NameInMap("Step")]
                [Validation(Required=true)]
                public string Step { get; set; }

                [NameInMap("Message")]
                [Validation(Required=true)]
                public string Message { get; set; }

            }

            [NameInMap("DnsAddress")]
            [Validation(Required=true)]
            public List<string> DnsAddress { get; set; }

            [NameInMap("SubDnsAddress")]
            [Validation(Required=true)]
            public List<string> SubDnsAddress { get; set; }

            [NameInMap("VSwitchIds")]
            [Validation(Required=true)]
            public List<string> VSwitchIds { get; set; }

        }

    }

}
