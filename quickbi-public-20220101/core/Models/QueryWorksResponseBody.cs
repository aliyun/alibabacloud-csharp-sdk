// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryWorksResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// QueryWorksModel
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryWorksResponseBodyResult Result { get; set; }
        public class QueryWorksResponseBodyResult : TeaModel {
            [NameInMap("Auth3rdFlag")]
            [Validation(Required=false)]
            public int? Auth3rdFlag { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public QueryWorksResponseBodyResultDirectory Directory { get; set; }
            public class QueryWorksResponseBodyResultDirectory : TeaModel {
                /// <summary>
                /// 目录ID
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// 目录名称
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 目录ID的路径，例如：aa/bb/cc/dd
                /// </summary>
                [NameInMap("PathId")]
                [Validation(Required=false)]
                public string PathId { get; set; }

                /// <summary>
                /// 目录ID的路径名称，例如：一层目录/二层目录
                /// </summary>
                [NameInMap("PathName")]
                [Validation(Required=false)]
                public string PathName { get; set; }

            }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }
            [NameInMap("GmtModify")]
            [Validation(Required=false)]
            public string GmtModify { get; set; }
            [NameInMap("ModifyName")]
            [Validation(Required=false)]
            public string ModifyName { get; set; }
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }
            [NameInMap("OwnerName")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }
            [NameInMap("SecurityLevel")]
            [Validation(Required=false)]
            public string SecurityLevel { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("WorkName")]
            [Validation(Required=false)]
            public string WorkName { get; set; }
            [NameInMap("WorkType")]
            [Validation(Required=false)]
            public string WorkType { get; set; }
            [NameInMap("WorksId")]
            [Validation(Required=false)]
            public string WorksId { get; set; }
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }
            [NameInMap("WorkspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
