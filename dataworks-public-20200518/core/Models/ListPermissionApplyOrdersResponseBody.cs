// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListPermissionApplyOrdersResponseBody : TeaModel {
        /// <summary>
        /// The query results returned by page.
        /// </summary>
        [NameInMap("ApplyOrders")]
        [Validation(Required=false)]
        public ListPermissionApplyOrdersResponseBodyApplyOrders ApplyOrders { get; set; }
        public class ListPermissionApplyOrdersResponseBodyApplyOrders : TeaModel {
            /// <summary>
            /// The list of the permission request orders.
            /// </summary>
            [NameInMap("ApplyOrder")]
            [Validation(Required=false)]
            public List<ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrder> ApplyOrder { get; set; }
            public class ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrder : TeaModel {
                /// <summary>
                /// The unique ID of the Alibaba Cloud account that was used to submit the permission request order.
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
                /// The content of the permission request order.
                /// </summary>
                [NameInMap("ApproveContent")]
                [Validation(Required=false)]
                public ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContent ApproveContent { get; set; }
                public class ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContent : TeaModel {
                    /// <summary>
                    /// The reason for your request. The administrator determines whether to approve the request based on the reason.
                    /// </summary>
                    [NameInMap("ApplyReason")]
                    [Validation(Required=false)]
                    public string ApplyReason { get; set; }

                    /// <summary>
                    /// The type of the permission request order. The parameter value is 1 and cannot be changed. This value indicates ACL-based authorization.
                    /// </summary>
                    [NameInMap("OrderType")]
                    [Validation(Required=false)]
                    public int? OrderType { get; set; }

                    /// <summary>
                    /// The content of the object on which you requested permissions.
                    /// </summary>
                    [NameInMap("ProjectMeta")]
                    [Validation(Required=false)]
                    public ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContentProjectMeta ProjectMeta { get; set; }
                    public class ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContentProjectMeta : TeaModel {
                        /// <summary>
                        /// The information about the object on which you requested permissions.
                        /// </summary>
                        [NameInMap("ObjectMetaList")]
                        [Validation(Required=false)]
                        public List<ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContentProjectMetaObjectMetaList> ObjectMetaList { get; set; }
                        public class ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContentProjectMetaObjectMetaList : TeaModel {
                            /// <summary>
                            /// The permission that you wanted to request. If you wanted to request multiple permissions at the same time, separate them with commas (,).
                            /// 
                            /// You can request only the following permissions: Select, Describe, Drop, Alter, Update, and Download.
                            /// </summary>
                            [NameInMap("Actions")]
                            [Validation(Required=false)]
                            public List<string> Actions { get; set; }

                            /// <summary>
                            /// The name of the table on which you requested permissions.
                            /// </summary>
                            [NameInMap("ObjectName")]
                            [Validation(Required=false)]
                            public string ObjectName { get; set; }

                        }

                        /// <summary>
                        /// The name of the DataWorks workspace that was associated with the MaxCompute project in which you requested permissions on a table.
                        /// </summary>
                        [NameInMap("WorkspaceName")]
                        [Validation(Required=false)]
                        public string WorkspaceName { get; set; }

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

            }

            /// <summary>
            /// The number of the returned page.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of permission request orders returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
