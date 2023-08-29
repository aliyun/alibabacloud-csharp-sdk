// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class ListMappCenterWorkspacesResponseBody : TeaModel {
        [NameInMap("ListMappCenterWorkspaceResult")]
        [Validation(Required=false)]
        public ListMappCenterWorkspacesResponseBodyListMappCenterWorkspaceResult ListMappCenterWorkspaceResult { get; set; }
        public class ListMappCenterWorkspacesResponseBodyListMappCenterWorkspaceResult : TeaModel {
            [NameInMap("MappCenterWorkspaceList")]
            [Validation(Required=false)]
            public List<ListMappCenterWorkspacesResponseBodyListMappCenterWorkspaceResultMappCenterWorkspaceList> MappCenterWorkspaceList { get; set; }
            public class ListMappCenterWorkspacesResponseBodyListMappCenterWorkspaceResultMappCenterWorkspaceList : TeaModel {
                [NameInMap("CompatibleId")]
                [Validation(Required=false)]
                public string CompatibleId { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Uid")]
                [Validation(Required=false)]
                public long? Uid { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

                [NameInMap("Zones")]
                [Validation(Required=false)]
                public string Zones { get; set; }

            }

            [NameInMap("ResultMsg")]
            [Validation(Required=false)]
            public string ResultMsg { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}
