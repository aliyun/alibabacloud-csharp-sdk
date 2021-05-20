// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetPermissionApplyOrderDetailResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ApplyOrderDetail")]
        [Validation(Required=true)]
        public GetPermissionApplyOrderDetailResponseApplyOrderDetail ApplyOrderDetail { get; set; }
        public class GetPermissionApplyOrderDetailResponseApplyOrderDetail : TeaModel {
            [NameInMap("ApplyBaseId")]
            [Validation(Required=true)]
            public string ApplyBaseId { get; set; }
            [NameInMap("ApplyTimestamp")]
            [Validation(Required=true)]
            public long? ApplyTimestamp { get; set; }
            [NameInMap("FlowId")]
            [Validation(Required=true)]
            public string FlowId { get; set; }
            [NameInMap("FlowStatus")]
            [Validation(Required=true)]
            public int? FlowStatus { get; set; }
            [NameInMap("ApproveAccountList")]
            [Validation(Required=true)]
            public List<GetPermissionApplyOrderDetailResponseApplyOrderDetailApproveAccountList> ApproveAccountList { get; set; }
            public class GetPermissionApplyOrderDetailResponseApplyOrderDetailApproveAccountList : TeaModel {
                public string BaseId { get; set; }
            }
            [NameInMap("GranteeObjectList")]
            [Validation(Required=true)]
            public List<GetPermissionApplyOrderDetailResponseApplyOrderDetailGranteeObjectList> GranteeObjectList { get; set; }
            public class GetPermissionApplyOrderDetailResponseApplyOrderDetailGranteeObjectList : TeaModel {
                public string GranteeId { get; set; }
                public string GranteeName { get; set; }
                public int? GranteeType { get; set; }
                public int? GranteeTypeSub { get; set; }
            }
            [NameInMap("ApproveContent")]
            [Validation(Required=true)]
            public GetPermissionApplyOrderDetailResponseApplyOrderDetailApproveContent ApproveContent { get; set; }
            public class GetPermissionApplyOrderDetailResponseApplyOrderDetailApproveContent : TeaModel {
                [NameInMap("ApplyReason")]
                [Validation(Required=true)]
                public string ApplyReason { get; set; }

                [NameInMap("Deadline")]
                [Validation(Required=true)]
                public long? Deadline { get; set; }

                [NameInMap("OrderType")]
                [Validation(Required=true)]
                public int? OrderType { get; set; }

                [NameInMap("ProjectMeta")]
                [Validation(Required=true)]
                public GetPermissionApplyOrderDetailResponseApplyOrderDetailApproveContentProjectMeta ProjectMeta { get; set; }
                public class GetPermissionApplyOrderDetailResponseApplyOrderDetailApproveContentProjectMeta : TeaModel {
                    [NameInMap("WorkspaceId")]
                    [Validation(Required=true)]
                    public int? WorkspaceId { get; set; }
                    [NameInMap("MaxComputeProjectName")]
                    [Validation(Required=true)]
                    public string MaxComputeProjectName { get; set; }
                    [NameInMap("ObjectMetaList")]
                    [Validation(Required=true)]
                    public List<GetPermissionApplyOrderDetailResponseApplyOrderDetailApproveContentProjectMetaObjectMetaList> ObjectMetaList { get; set; }
                    public class GetPermissionApplyOrderDetailResponseApplyOrderDetailApproveContentProjectMetaObjectMetaList : TeaModel {
                        public string ObjectName { get; set; }
                        public List<GetPermissionApplyOrderDetailResponseApplyOrderDetailApproveContentProjectMetaObjectMetaListColumnMetaList> ColumnMetaList { get; set; }
                        public class GetPermissionApplyOrderDetailResponseApplyOrderDetailApproveContentProjectMetaObjectMetaListColumnMetaList : TeaModel {
                            public string ColumnComment { get; set; }
                            public string ColumnName { get; set; }
                        }
                    }
                };

            }
        };

    }

}
