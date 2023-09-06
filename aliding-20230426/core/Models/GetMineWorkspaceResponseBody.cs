// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetMineWorkspaceResponseBody : TeaModel {
        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("workspace")]
        [Validation(Required=false)]
        public GetMineWorkspaceResponseBodyWorkspace Workspace { get; set; }
        public class GetMineWorkspaceResponseBodyWorkspace : TeaModel {
            [NameInMap("CorpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("Cover")]
            [Validation(Required=false)]
            public string Cover { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Icon")]
            [Validation(Required=false)]
            public GetMineWorkspaceResponseBodyWorkspaceIcon Icon { get; set; }
            public class GetMineWorkspaceResponseBodyWorkspaceIcon : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("ModifierId")]
            [Validation(Required=false)]
            public string ModifierId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PermissionRole")]
            [Validation(Required=false)]
            public string PermissionRole { get; set; }

            [NameInMap("RootNodeId")]
            [Validation(Required=false)]
            public string RootNodeId { get; set; }

            [NameInMap("TeamId")]
            [Validation(Required=false)]
            public string TeamId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

    }

}
