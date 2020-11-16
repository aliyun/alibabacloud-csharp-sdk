// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201001.Models
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

            [NameInMap("CustomSecurityGroupId")]
            [Validation(Required=true)]
            public string CustomSecurityGroupId { get; set; }

            [NameInMap("DnsUserName")]
            [Validation(Required=true)]
            public string DnsUserName { get; set; }

            [NameInMap("EnableInternetAccess")]
            [Validation(Required=true)]
            public bool? EnableInternetAccess { get; set; }

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

            }

            [NameInMap("DnsAddress")]
            [Validation(Required=true)]
            public List<string> DnsAddress { get; set; }

        }

    }

}
