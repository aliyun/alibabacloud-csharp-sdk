// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetNodesResponseBody : TeaModel {
        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<GetNodesResponseBodyNodes> Nodes { get; set; }
        public class GetNodesResponseBodyNodes : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            [NameInMap("HasChildren")]
            [Validation(Required=false)]
            public bool? HasChildren { get; set; }

            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("ModifierId")]
            [Validation(Required=false)]
            public string ModifierId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            [NameInMap("PermissionRole")]
            [Validation(Required=false)]
            public string PermissionRole { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("StatisticalInfo")]
            [Validation(Required=false)]
            public GetNodesResponseBodyNodesStatisticalInfo StatisticalInfo { get; set; }
            public class GetNodesResponseBodyNodesStatisticalInfo : TeaModel {
                [NameInMap("WordCount")]
                [Validation(Required=false)]
                public long? WordCount { get; set; }

            }

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

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
