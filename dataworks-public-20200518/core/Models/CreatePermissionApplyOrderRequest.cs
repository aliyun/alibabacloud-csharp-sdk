// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreatePermissionApplyOrderRequest : TeaModel {
        [NameInMap("ApplyObject")]
        [Validation(Required=false)]
        public List<CreatePermissionApplyOrderRequestApplyObject> ApplyObject { get; set; }
        public class CreatePermissionApplyOrderRequestApplyObject : TeaModel {
            [NameInMap("Actions")]
            [Validation(Required=false)]
            public string Actions { get; set; }

            [NameInMap("ColumnMetaList")]
            [Validation(Required=false)]
            public List<CreatePermissionApplyOrderRequestApplyObjectColumnMetaList> ColumnMetaList { get; set; }
            public class CreatePermissionApplyOrderRequestApplyObjectColumnMetaList : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("ApplyReason")]
        [Validation(Required=false)]
        public string ApplyReason { get; set; }

        [NameInMap("ApplyUserIds")]
        [Validation(Required=false)]
        public string ApplyUserIds { get; set; }

        [NameInMap("Deadline")]
        [Validation(Required=false)]
        public long? Deadline { get; set; }

        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        [NameInMap("MaxComputeProjectName")]
        [Validation(Required=false)]
        public string MaxComputeProjectName { get; set; }

        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public int? OrderType { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public int? WorkspaceId { get; set; }

    }

}
