// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreatePermissionApplyOrderRequest : TeaModel {
        [NameInMap("ApplyUserIds")]
        [Validation(Required=true)]
        public string ApplyUserIds { get; set; }

        [NameInMap("Deadline")]
        [Validation(Required=false)]
        public long? Deadline { get; set; }

        [NameInMap("ApplyReason")]
        [Validation(Required=true)]
        public string ApplyReason { get; set; }

        [NameInMap("MaxComputeProjectName")]
        [Validation(Required=true)]
        public string MaxComputeProjectName { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=true)]
        public int? WorkspaceId { get; set; }

        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public int? OrderType { get; set; }

        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        [NameInMap("ApplyObject")]
        [Validation(Required=true)]
        public List<CreatePermissionApplyOrderRequestApplyObject> ApplyObject { get; set; }
        public class CreatePermissionApplyOrderRequestApplyObject : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=true)]
            public string Name { get; set; }

            [NameInMap("ColumnMetaList")]
            [Validation(Required=true)]
            public List<CreatePermissionApplyOrderRequestApplyObjectColumnMetaList> ColumnMetaList { get; set; }
            public class CreatePermissionApplyOrderRequestApplyObjectColumnMetaList : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=true)]
                public string Name { get; set; }

            }

            [NameInMap("Actions")]
            [Validation(Required=true)]
            public string Actions { get; set; }

        }

    }

}
