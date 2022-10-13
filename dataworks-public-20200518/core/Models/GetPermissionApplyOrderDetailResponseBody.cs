// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetPermissionApplyOrderDetailResponseBody : TeaModel {
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

            [NameInMap("ApproveAccountList")]
            [Validation(Required=false)]
            public List<GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveAccountList> ApproveAccountList { get; set; }
            public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveAccountList : TeaModel {
                [NameInMap("BaseId")]
                [Validation(Required=false)]
                public string BaseId { get; set; }

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

                    [NameInMap("ObjectMetaList")]
                    [Validation(Required=false)]
                    public List<GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContentProjectMetaObjectMetaList> ObjectMetaList { get; set; }
                    public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContentProjectMetaObjectMetaList : TeaModel {
                        [NameInMap("ColumnMetaList")]
                        [Validation(Required=false)]
                        public List<GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContentProjectMetaObjectMetaListColumnMetaList> ColumnMetaList { get; set; }
                        public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContentProjectMetaObjectMetaListColumnMetaList : TeaModel {
                            [NameInMap("ColumnComment")]
                            [Validation(Required=false)]
                            public string ColumnComment { get; set; }

                            [NameInMap("ColumnName")]
                            [Validation(Required=false)]
                            public string ColumnName { get; set; }

                        }

                        [NameInMap("ObjectName")]
                        [Validation(Required=false)]
                        public string ObjectName { get; set; }

                    }

                    [NameInMap("WorkspaceId")]
                    [Validation(Required=false)]
                    public int? WorkspaceId { get; set; }

                }

            }

            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

            [NameInMap("FlowStatus")]
            [Validation(Required=false)]
            public int? FlowStatus { get; set; }

            [NameInMap("GranteeObjectList")]
            [Validation(Required=false)]
            public List<GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailGranteeObjectList> GranteeObjectList { get; set; }
            public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailGranteeObjectList : TeaModel {
                [NameInMap("GranteeId")]
                [Validation(Required=false)]
                public string GranteeId { get; set; }

                [NameInMap("GranteeName")]
                [Validation(Required=false)]
                public string GranteeName { get; set; }

                [NameInMap("GranteeType")]
                [Validation(Required=false)]
                public int? GranteeType { get; set; }

                [NameInMap("GranteeTypeSub")]
                [Validation(Required=false)]
                public int? GranteeTypeSub { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
