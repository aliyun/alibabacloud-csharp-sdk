// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListPermissionApplyOrdersResponseBody : TeaModel {
        [NameInMap("ApplyOrders")]
        [Validation(Required=false)]
        public ListPermissionApplyOrdersResponseBodyApplyOrders ApplyOrders { get; set; }
        public class ListPermissionApplyOrdersResponseBodyApplyOrders : TeaModel {
            [NameInMap("ApplyOrder")]
            [Validation(Required=false)]
            public List<ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrder> ApplyOrder { get; set; }
            public class ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrder : TeaModel {
                public string ApplyBaseId { get; set; }
                public long? ApplyTimestamp { get; set; }
                public ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContent ApproveContent { get; set; }
                public class ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContent : TeaModel {
                    [NameInMap("ApplyReason")]
                    [Validation(Required=false)]
                    public string ApplyReason { get; set; }

                    [NameInMap("OrderType")]
                    [Validation(Required=false)]
                    public int? OrderType { get; set; }

                    [NameInMap("ProjectMeta")]
                    [Validation(Required=false)]
                    public ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContentProjectMeta ProjectMeta { get; set; }
                    public class ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContentProjectMeta : TeaModel {
                        [NameInMap("ObjectMetaList")]
                        [Validation(Required=false)]
                        public List<ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContentProjectMetaObjectMetaList> ObjectMetaList { get; set; }
                        public class ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContentProjectMetaObjectMetaList : TeaModel {
                            public List<string> Actions { get; set; }
                            public string ObjectName { get; set; }
                        }
                        [NameInMap("WorkspaceName")]
                        [Validation(Required=false)]
                        public string WorkspaceName { get; set; }
                    };

                }
                public string FlowId { get; set; }
                public int? FlowStatus { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
