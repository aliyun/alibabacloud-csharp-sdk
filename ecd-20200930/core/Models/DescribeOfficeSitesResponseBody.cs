// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeOfficeSitesResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("OfficeSites")]
        [Validation(Required=false)]
        public List<DescribeOfficeSitesResponseBodyOfficeSites> OfficeSites { get; set; }
        public class DescribeOfficeSitesResponseBodyOfficeSites : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("EnableAdminAccess")]
            [Validation(Required=false)]
            public bool? EnableAdminAccess { get; set; }

            [NameInMap("EnableCrossDesktopAccess")]
            [Validation(Required=false)]
            public bool? EnableCrossDesktopAccess { get; set; }

            [NameInMap("DesktopVpcEndpoint")]
            [Validation(Required=false)]
            public string DesktopVpcEndpoint { get; set; }

            [NameInMap("DesktopAccessType")]
            [Validation(Required=false)]
            public string DesktopAccessType { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            [NameInMap("SsoEnabled")]
            [Validation(Required=false)]
            public bool? SsoEnabled { get; set; }

            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            [NameInMap("TrustPassword")]
            [Validation(Required=false)]
            public string TrustPassword { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("EnableInternetAccess")]
            [Validation(Required=false)]
            public bool? EnableInternetAccess { get; set; }

            [NameInMap("DomainPassword")]
            [Validation(Required=false)]
            public string DomainPassword { get; set; }

            [NameInMap("CustomSecurityGroupId")]
            [Validation(Required=false)]
            public string CustomSecurityGroupId { get; set; }

            [NameInMap("DomainUserName")]
            [Validation(Required=false)]
            public string DomainUserName { get; set; }

            [NameInMap("SubDomainName")]
            [Validation(Required=false)]
            public string SubDomainName { get; set; }

            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            [NameInMap("MfaEnabled")]
            [Validation(Required=false)]
            public bool? MfaEnabled { get; set; }

            [NameInMap("NetworkPackageId")]
            [Validation(Required=false)]
            public string NetworkPackageId { get; set; }

            [NameInMap("DnsUserName")]
            [Validation(Required=false)]
            public string DnsUserName { get; set; }

            [NameInMap("OfficeSiteType")]
            [Validation(Required=false)]
            public string OfficeSiteType { get; set; }

            [NameInMap("ADConnectors")]
            [Validation(Required=false)]
            public List<DescribeOfficeSitesResponseBodyOfficeSitesADConnectors> ADConnectors { get; set; }
            public class DescribeOfficeSitesResponseBodyOfficeSitesADConnectors : TeaModel {
                [NameInMap("ConnectorStatus")]
                [Validation(Required=false)]
                public string ConnectorStatus { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("ADConnectorAddress")]
                [Validation(Required=false)]
                public string ADConnectorAddress { get; set; }

                [NameInMap("NetworkInterfaceId")]
                [Validation(Required=false)]
                public string NetworkInterfaceId { get; set; }

            }

            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<DescribeOfficeSitesResponseBodyOfficeSitesLogs> Logs { get; set; }
            public class DescribeOfficeSitesResponseBodyOfficeSitesLogs : TeaModel {
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

            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            [NameInMap("FileSystemIds")]
            [Validation(Required=false)]
            public List<string> FileSystemIds { get; set; }

            [NameInMap("SubDnsAddress")]
            [Validation(Required=false)]
            public List<string> SubDnsAddress { get; set; }

            [NameInMap("DnsAddress")]
            [Validation(Required=false)]
            public List<string> DnsAddress { get; set; }

        }

    }

}
