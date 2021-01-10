// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DescribeWorkspaceGroupsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WorkspaceGroups")]
        [Validation(Required=false)]
        public List<DescribeWorkspaceGroupsResponseBodyWorkspaceGroups> WorkspaceGroups { get; set; }
        public class DescribeWorkspaceGroupsResponseBodyWorkspaceGroups : TeaModel {
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("Workspaces")]
            [Validation(Required=false)]
            public List<DescribeWorkspaceGroupsResponseBodyWorkspaceGroupsWorkspaces> Workspaces { get; set; }
            public class DescribeWorkspaceGroupsResponseBodyWorkspaceGroupsWorkspaces : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("Zones")]
                [Validation(Required=false)]
                public List<string> Zones { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("Identity")]
                [Validation(Required=false)]
                public string Identity { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Tenant")]
                [Validation(Required=false)]
                public string Tenant { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

            [NameInMap("MasterWorkspaceId")]
            [Validation(Required=false)]
            public string MasterWorkspaceId { get; set; }

            [NameInMap("Identity")]
            [Validation(Required=false)]
            public string Identity { get; set; }

            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

            [NameInMap("DomainSuffix")]
            [Validation(Required=false)]
            public string DomainSuffix { get; set; }

            [NameInMap("MasterWorkspaceIdentity")]
            [Validation(Required=false)]
            public string MasterWorkspaceIdentity { get; set; }

            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("ReleaseMode")]
            [Validation(Required=false)]
            public string ReleaseMode { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
