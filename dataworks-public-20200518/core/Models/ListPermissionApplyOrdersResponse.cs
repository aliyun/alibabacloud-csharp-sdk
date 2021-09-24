// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListPermissionApplyOrdersResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ApplyOrders")]
        [Validation(Required=true)]
        public ListPermissionApplyOrdersResponseApplyOrders ApplyOrders { get; set; }
        public class ListPermissionApplyOrdersResponseApplyOrders : TeaModel {
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
            [NameInMap("PageNumber")]
            [Validation(Required=true)]
            public int? PageNumber { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public int? TotalCount { get; set; }
            [NameInMap("ApplyOrder")]
            [Validation(Required=true)]
            public List<ListPermissionApplyOrdersResponseApplyOrdersApplyOrder> ApplyOrder { get; set; }
            public class ListPermissionApplyOrdersResponseApplyOrdersApplyOrder : TeaModel {
                public string FlowId { get; set; }
                public string ApplyBaseId { get; set; }
                public long? ApplyTimestamp { get; set; }
                public int? FlowStatus { get; set; }
                public ListPermissionApplyOrdersResponseApplyOrdersApplyOrderApproveContent ApproveContent { get; set; }
                public class ListPermissionApplyOrdersResponseApplyOrdersApplyOrderApproveContent : TeaModel {
                    [NameInMap("ApplyReason")]
                    [Validation(Required=true)]
                    public string ApplyReason { get; set; }

                    [NameInMap("OrderType")]
                    [Validation(Required=true)]
                    public int? OrderType { get; set; }

                    [NameInMap("ProjectMeta")]
                    [Validation(Required=true)]
                    public ListPermissionApplyOrdersResponseApplyOrdersApplyOrderApproveContentProjectMeta ProjectMeta { get; set; }
                    public class ListPermissionApplyOrdersResponseApplyOrdersApplyOrderApproveContentProjectMeta : TeaModel {
                        [NameInMap("WorkspaceName")]
                        [Validation(Required=true)]
                        public string WorkspaceName { get; set; }
                        [NameInMap("ObjectMetaList")]
                        [Validation(Required=true)]
                        public List<ListPermissionApplyOrdersResponseApplyOrdersApplyOrderApproveContentProjectMetaObjectMetaList> ObjectMetaList { get; set; }
                        public class ListPermissionApplyOrdersResponseApplyOrdersApplyOrderApproveContentProjectMetaObjectMetaList : TeaModel {
                            public string ObjectName { get; set; }
                            public List<string> Actions { get; set; }
                        }
                    };

                }
            }
        };

    }

}
