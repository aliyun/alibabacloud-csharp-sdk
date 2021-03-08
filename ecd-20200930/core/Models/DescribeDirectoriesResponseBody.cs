// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDirectoriesResponseBody : TeaModel {
        [NameInMap("Directories")]
        [Validation(Required=false)]
        public List<DescribeDirectoriesResponseBodyDirectories> Directories { get; set; }
        public class DescribeDirectoriesResponseBodyDirectories : TeaModel {
            [NameInMap("EnableInternetAccess")]
            [Validation(Required=false)]
            public bool? EnableInternetAccess { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("DomainPassword")]
            [Validation(Required=false)]
            public string DomainPassword { get; set; }

            [NameInMap("CustomSecurityGroupId")]
            [Validation(Required=false)]
            public string CustomSecurityGroupId { get; set; }

            [NameInMap("DomainUserName")]
            [Validation(Required=false)]
            public string DomainUserName { get; set; }

            [NameInMap("DesktopVpcEndpoint")]
            [Validation(Required=false)]
            public string DesktopVpcEndpoint { get; set; }

            [NameInMap("DesktopAccessType")]
            [Validation(Required=false)]
            public string DesktopAccessType { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            [NameInMap("DirectoryType")]
            [Validation(Required=false)]
            public string DirectoryType { get; set; }

            [NameInMap("DnsUserName")]
            [Validation(Required=false)]
            public string DnsUserName { get; set; }

            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<DescribeDirectoriesResponseBodyDirectoriesLogs> Logs { get; set; }
            public class DescribeDirectoriesResponseBodyDirectoriesLogs : TeaModel {
                [NameInMap("Step")]
                [Validation(Required=false)]
                public string Step { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

            }

            [NameInMap("TrustPassword")]
            [Validation(Required=false)]
            public string TrustPassword { get; set; }

            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ADConnectors")]
            [Validation(Required=false)]
            public List<DescribeDirectoriesResponseBodyDirectoriesADConnectors> ADConnectors { get; set; }
            public class DescribeDirectoriesResponseBodyDirectoriesADConnectors : TeaModel {
                [NameInMap("ConnectorStatus")]
                [Validation(Required=false)]
                public string ConnectorStatus { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("NetworkInterfaceId")]
                [Validation(Required=false)]
                public string NetworkInterfaceId { get; set; }

                [NameInMap("ADConnectorAddress")]
                [Validation(Required=false)]
                public string ADConnectorAddress { get; set; }

            }

            [NameInMap("DnsAddress")]
            [Validation(Required=false)]
            public List<string> DnsAddress { get; set; }

            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
