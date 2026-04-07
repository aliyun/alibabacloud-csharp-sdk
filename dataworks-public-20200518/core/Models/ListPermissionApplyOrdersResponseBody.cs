// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListPermissionApplyOrdersResponseBody : TeaModel {
        /// <summary>
        /// <para>The paginated query results of permission requests.</para>
        /// </summary>
        [NameInMap("ApplyOrders")]
        [Validation(Required=false)]
        public ListPermissionApplyOrdersResponseBodyApplyOrders ApplyOrders { get; set; }
        public class ListPermissionApplyOrdersResponseBodyApplyOrders : TeaModel {
            /// <summary>
            /// <para>The list of permission requests.</para>
            /// </summary>
            [NameInMap("ApplyOrder")]
            [Validation(Required=false)]
            public List<ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrder> ApplyOrder { get; set; }
            public class ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrder : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud account ID of the user who submitted the permission request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>267842600408993176</para>
                /// </summary>
                [NameInMap("ApplyBaseId")]
                [Validation(Required=false)]
                public string ApplyBaseId { get; set; }

                /// <summary>
                /// <para>The time when the permission request was submitted, in Unix timestamp format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1615284086000</para>
                /// </summary>
                [NameInMap("ApplyTimestamp")]
                [Validation(Required=false)]
                public long? ApplyTimestamp { get; set; }

                /// <summary>
                /// <para>The content of the permission request.</para>
                /// </summary>
                [NameInMap("ApproveContent")]
                [Validation(Required=false)]
                public ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContent ApproveContent { get; set; }
                public class ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContent : TeaModel {
                    /// <summary>
                    /// <para>The reason for the permission request, which is used by administrators for evaluation and approval.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>I need to use this table</para>
                    /// </summary>
                    [NameInMap("ApplyReason")]
                    [Validation(Required=false)]
                    public string ApplyReason { get; set; }

                    /// <summary>
                    /// <para>The type of permission request. Only the value 1 is supported, which indicates an ACL permission request for objects.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("OrderType")]
                    [Validation(Required=false)]
                    public int? OrderType { get; set; }

                    /// <summary>
                    /// <para>The content of the requested object.</para>
                    /// </summary>
                    [NameInMap("ProjectMeta")]
                    [Validation(Required=false)]
                    public ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContentProjectMeta ProjectMeta { get; set; }
                    public class ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContentProjectMeta : TeaModel {
                        /// <summary>
                        /// <para>The information about the requested object.</para>
                        /// </summary>
                        [NameInMap("ObjectMetaList")]
                        [Validation(Required=false)]
                        public List<ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContentProjectMetaObjectMetaList> ObjectMetaList { get; set; }
                        public class ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContentProjectMetaObjectMetaList : TeaModel {
                            /// <summary>
                            /// <para>The operation type.</para>
                            /// </summary>
                            [NameInMap("Actions")]
                            [Validation(Required=false)]
                            public List<string> Actions { get; set; }

                            /// <summary>
                            /// <para>The name of the requested table.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>aTableName</para>
                            /// </summary>
                            [NameInMap("ObjectName")]
                            [Validation(Required=false)]
                            public string ObjectName { get; set; }

                        }

                        /// <summary>
                        /// <para>The name of the DataWorks workspace that contains the MaxCompute project for which permissions are requested.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>aWorkspaceName</para>
                        /// </summary>
                        [NameInMap("WorkspaceName")]
                        [Validation(Required=false)]
                        public string WorkspaceName { get; set; }

                    }

                }

                /// <summary>
                /// <para>The final approval comment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agree</para>
                /// </summary>
                [NameInMap("FinishApprovalComment")]
                [Validation(Required=false)]
                public string FinishApprovalComment { get; set; }

                /// <summary>
                /// <para>The final approval timestamp. Displayed as a Unix timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1757496687000</para>
                /// </summary>
                [NameInMap("FinishApprovalTimestamp")]
                [Validation(Required=false)]
                public long? FinishApprovalTimestamp { get; set; }

                /// <summary>
                /// <para>The permission request ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ad8da78d-8135-455e-9486-27cf213fc140</para>
                /// </summary>
                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }

                /// <summary>
                /// <para>The status of the permission request. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: Pending approval</description></item>
                /// <item><description>2: Approved and authorization succeeded</description></item>
                /// <item><description>3: Approved but authorization failed</description></item>
                /// <item><description>4: Rejected</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("FlowStatus")]
                [Validation(Required=false)]
                public int? FlowStatus { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of permission requests returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>150</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc1ec92159376****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
