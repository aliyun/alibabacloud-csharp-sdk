// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetPermissionApplyOrderDetailResponseBody : TeaModel {
        /// <summary>
        /// Details about the permission request order.
        /// </summary>
        [NameInMap("ApplyOrderDetail")]
        [Validation(Required=false)]
        public GetPermissionApplyOrderDetailResponseBodyApplyOrderDetail ApplyOrderDetail { get; set; }
        public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetail : TeaModel {
            /// <summary>
            /// The unique ID of the Alibaba Cloud account that is used to submit the permission request order.
            /// </summary>
            [NameInMap("ApplyBaseId")]
            [Validation(Required=false)]
            public string ApplyBaseId { get; set; }

            /// <summary>
            /// The time when the permission request order was submitted. The parameter value is a UNIX timestamp.
            /// </summary>
            [NameInMap("ApplyTimestamp")]
            [Validation(Required=false)]
            public long? ApplyTimestamp { get; set; }

            /// <summary>
            /// The list of Alibaba Cloud accounts that are used to approve the permission request order.
            /// </summary>
            [NameInMap("ApproveAccountList")]
            [Validation(Required=false)]
            public List<GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveAccountList> ApproveAccountList { get; set; }
            public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveAccountList : TeaModel {
                /// <summary>
                /// The unique ID of the Alibaba Cloud account that is used to approve the permission request order.
                /// </summary>
                [NameInMap("BaseId")]
                [Validation(Required=false)]
                public string BaseId { get; set; }

            }

            /// <summary>
            /// The content of the permission request.
            /// </summary>
            [NameInMap("ApproveContent")]
            [Validation(Required=false)]
            public GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContent ApproveContent { get; set; }
            public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContent : TeaModel {
                /// <summary>
                /// The reason for your request. The administrator decides whether to approve the request based on the request reason.
                /// </summary>
                [NameInMap("ApplyReason")]
                [Validation(Required=false)]
                public string ApplyReason { get; set; }

                /// <summary>
                /// The expiration time of the permissions that you requested. The parameter value is a UNIX timestamp.
                /// 
                /// If LabelSecurity is disabled in the MaxCompute project, or the security level of fields in the MaxCompute table on which you request permissions is 0 or is less than or equal to the security level of the Alibaba Cloud account for which you request permissions, you can request only permanent permissions.
                /// </summary>
                [NameInMap("Deadline")]
                [Validation(Required=false)]
                public long? Deadline { get; set; }

                /// <summary>
                /// The type of the permission request order. The parameter value is 1 and cannot be changed. 1 indicates that ACL-based authorization is requested.
                /// </summary>
                [NameInMap("OrderType")]
                [Validation(Required=false)]
                public int? OrderType { get; set; }

                /// <summary>
                /// The information about the project and workspace that are associated with the object on which you requested permissions.
                /// </summary>
                [NameInMap("ProjectMeta")]
                [Validation(Required=false)]
                public GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContentProjectMeta ProjectMeta { get; set; }
                public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContentProjectMeta : TeaModel {
                    /// <summary>
                    /// The MaxCompute project to which the object on which you request permissions belongs.
                    /// </summary>
                    [NameInMap("MaxComputeProjectName")]
                    [Validation(Required=false)]
                    public string MaxComputeProjectName { get; set; }

                    /// <summary>
                    /// Details about the object on which you request permissions.
                    /// </summary>
                    [NameInMap("ObjectMetaList")]
                    [Validation(Required=false)]
                    public List<GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContentProjectMetaObjectMetaList> ObjectMetaList { get; set; }
                    public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContentProjectMetaObjectMetaList : TeaModel {
                        /// <summary>
                        /// The information about the column fields in the object on which you request permissions.
                        /// </summary>
                        [NameInMap("ColumnMetaList")]
                        [Validation(Required=false)]
                        public List<GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContentProjectMetaObjectMetaListColumnMetaList> ColumnMetaList { get; set; }
                        public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContentProjectMetaObjectMetaListColumnMetaList : TeaModel {
                            /// <summary>
                            /// The description of the column on which you request permissions.
                            /// </summary>
                            [NameInMap("ColumnComment")]
                            [Validation(Required=false)]
                            public string ColumnComment { get; set; }

                            /// <summary>
                            /// The name of the column on which you request permissions.
                            /// </summary>
                            [NameInMap("ColumnName")]
                            [Validation(Required=false)]
                            public string ColumnName { get; set; }

                            [NameInMap("SecurityLevel")]
                            [Validation(Required=false)]
                            public string SecurityLevel { get; set; }

                        }

                        /// <summary>
                        /// The name of the table on which you request permissions.
                        /// </summary>
                        [NameInMap("ObjectName")]
                        [Validation(Required=false)]
                        public string ObjectName { get; set; }

                    }

                    /// <summary>
                    /// The ID of the DataWorks workspace that is associated with the object on which you request permissions.
                    /// </summary>
                    [NameInMap("WorkspaceId")]
                    [Validation(Required=false)]
                    public int? WorkspaceId { get; set; }

                }

            }

            /// <summary>
            /// The ID of the permission request order.
            /// </summary>
            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

            /// <summary>
            /// The status of the permission request order. Valid values:
            /// 
            /// *   1: pending approval
            /// *   2: approved and authorized
            /// *   3: approved but authorization failed
            /// *   4: rejected
            /// </summary>
            [NameInMap("FlowStatus")]
            [Validation(Required=false)]
            public int? FlowStatus { get; set; }

            /// <summary>
            /// Information about the account that is used to request permissions.
            /// </summary>
            [NameInMap("GranteeObjectList")]
            [Validation(Required=false)]
            public List<GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailGranteeObjectList> GranteeObjectList { get; set; }
            public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailGranteeObjectList : TeaModel {
                /// <summary>
                /// The unique ID of the account that is used to request permissions.
                /// </summary>
                [NameInMap("GranteeId")]
                [Validation(Required=false)]
                public string GranteeId { get; set; }

                /// <summary>
                /// The name of the account that is used to request permissions. The name is in the same format as that of the account used to access the MaxCompute project.
                /// 
                /// *   An Alibaba Cloud account is in the format of ALIYUN$+Account name.
                /// *   A RAM user is in the format of RAM$+Account name.
                /// </summary>
                [NameInMap("GranteeName")]
                [Validation(Required=false)]
                public string GranteeName { get; set; }

                /// <summary>
                /// The type of the subject that requests permissions. The parameter value is 1 and cannot be changed. It indicates user.
                /// </summary>
                [NameInMap("GranteeType")]
                [Validation(Required=false)]
                public int? GranteeType { get; set; }

                /// <summary>
                /// The subtype of the subject that requests permissions. Valid values:
                /// 
                /// *   101: production account
                /// *   103: individual account
                /// *   105: account that requests permissions for others
                /// </summary>
                [NameInMap("GranteeTypeSub")]
                [Validation(Required=false)]
                public int? GranteeTypeSub { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
