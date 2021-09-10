// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetPermissionApplyOrderDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ApplyOrderDetail")]
        [Validation(Required=false)]
        public GetPermissionApplyOrderDetailResponseBodyApplyOrderDetail ApplyOrderDetail { get; set; }
        public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetail : TeaModel {
            [NameInMap("ApplyBaseId")]
            [Validation(Required=false)]
            public string ApplyBaseId { get; set; }
            [NameInMap("ApplyTimestamp")]
            [Validation(Required=false)]
            public long? ApplyTimestamp { get; set; }
            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }
            [NameInMap("FlowStatus")]
            [Validation(Required=false)]
            public int? FlowStatus { get; set; }
            [NameInMap("ApproveAccountList")]
            [Validation(Required=false)]
            public List<GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveAccountList> ApproveAccountList { get; set; }
            public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveAccountList : TeaModel {
                public string BaseId { get; set; }
            }
            [NameInMap("GranteeObjectList")]
            [Validation(Required=false)]
            public List<GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailGranteeObjectList> GranteeObjectList { get; set; }
            public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailGranteeObjectList : TeaModel {
                public int? GranteeType { get; set; }
                public int? GranteeTypeSub { get; set; }
                public string GranteeName { get; set; }
                public string GranteeId { get; set; }
            }
            [NameInMap("ApproveContent")]
            [Validation(Required=false)]
            public GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContent ApproveContent { get; set; }
            public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContent : TeaModel {
                [NameInMap("ApplyReason")]
                [Validation(Required=false)]
                public string ApplyReason { get; set; }

                [NameInMap("Deadline")]
                [Validation(Required=false)]
                public long? Deadline { get; set; }

                [NameInMap("OrderType")]
                [Validation(Required=false)]
                public int? OrderType { get; set; }

                [NameInMap("ProjectMeta")]
                [Validation(Required=false)]
                public GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContentProjectMeta ProjectMeta { get; set; }
                public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContentProjectMeta : TeaModel {
                    [NameInMap("MaxComputeProjectName")]
                    [Validation(Required=false)]
                    public string MaxComputeProjectName { get; set; }
                    [NameInMap("WorkspaceId")]
                    [Validation(Required=false)]
                    public int? WorkspaceId { get; set; }
                    [NameInMap("ObjectMetaList")]
                    [Validation(Required=false)]
                    public List<GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContentProjectMetaObjectMetaList> ObjectMetaList { get; set; }
                    public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContentProjectMetaObjectMetaList : TeaModel {
                        public string ObjectName { get; set; }
                        public List<GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContentProjectMetaObjectMetaListColumnMetaList> ColumnMetaList { get; set; }
                        public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContentProjectMetaObjectMetaListColumnMetaList : TeaModel {
                            public string ColumnName { get; set; }
                            public string ColumnComment { get; set; }
                        }
                    }
                };

            }
        };

    }

}
