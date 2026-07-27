// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListPermissionApplyOrdersResponseBody : TeaModel {
        /// <summary>
        /// <para>The paginated query results of permission application orders.</para>
        /// </summary>
        [NameInMap("ApplyOrders")]
        [Validation(Required=false)]
        public ListPermissionApplyOrdersResponseBodyApplyOrders ApplyOrders { get; set; }
        public class ListPermissionApplyOrdersResponseBodyApplyOrders : TeaModel {
            /// <summary>
            /// <para>The list of permission application orders.</para>
            /// </summary>
            [NameInMap("ApplyOrder")]
            [Validation(Required=false)]
            public List<ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrder> ApplyOrder { get; set; }
            public class ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrder : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud user UID that submitted the application order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>267842600408993176</para>
                /// </summary>
                [NameInMap("ApplyBaseId")]
                [Validation(Required=false)]
                public string ApplyBaseId { get; set; }

                /// <summary>
                /// <para>The submission time of the application order, displayed as a UNIX timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1615284086000</para>
                /// </summary>
                [NameInMap("ApplyTimestamp")]
                [Validation(Required=false)]
                public long? ApplyTimestamp { get; set; }

                /// <summary>
                /// <para>The content of the application order.</para>
                /// </summary>
                [NameInMap("ApproveContent")]
                [Validation(Required=false)]
                public ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContent ApproveContent { get; set; }
                public class ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContent : TeaModel {
                    /// <summary>
                    /// <para>The reason for the application, used by the administrator for evaluation and approval.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>I need to use this table</para>
                    /// </summary>
                    [NameInMap("ApplyReason")]
                    [Validation(Required=false)]
                    public string ApplyReason { get; set; }

                    /// <summary>
                    /// <para>The application order type. Currently, only the value 1 is supported, indicating an object ACL permission application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("OrderType")]
                    [Validation(Required=false)]
                    public int? OrderType { get; set; }

                    /// <summary>
                    /// <para>The content of the applied object.</para>
                    /// </summary>
                    [NameInMap("ProjectMeta")]
                    [Validation(Required=false)]
                    public ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContentProjectMeta ProjectMeta { get; set; }
                    public class ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContentProjectMeta : TeaModel {
                        /// <summary>
                        /// <para>The information about the applied objects.</para>
                        /// </summary>
                        [NameInMap("ObjectMetaList")]
                        [Validation(Required=false)]
                        public List<ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContentProjectMetaObjectMetaList> ObjectMetaList { get; set; }
                        public class ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContentProjectMetaObjectMetaList : TeaModel {
                            /// <summary>
                            /// <para>The action types.</para>
                            /// </summary>
                            [NameInMap("Actions")]
                            [Validation(Required=false)]
                            public List<string> Actions { get; set; }

                            /// <summary>
                            /// <para>The name of the applied table.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>aTableName</para>
                            /// </summary>
                            [NameInMap("ObjectName")]
                            [Validation(Required=false)]
                            public string ObjectName { get; set; }

                        }

                        /// <summary>
                        /// <para>The name of the DataWorks workspace to which the MaxCompute project with the requested permissions belongs.</para>
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
                /// <para>The final approval completion time, displayed as a UNIX timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1757496687000</para>
                /// </summary>
                [NameInMap("FinishApprovalTimestamp")]
                [Validation(Required=false)]
                public long? FinishApprovalTimestamp { get; set; }

                /// <summary>
                /// <para>The application order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ad8da78d-8135-455e-9486-27cf213fc140</para>
                /// </summary>
                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }

                /// <summary>
                /// <para>The status of the application order. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: Pending approval.</description></item>
                /// <item><description>2: Approved, authorization succeeded.</description></item>
                /// <item><description>3: Approved, authorization failed.</description></item>
                /// <item><description>4: Rejected.</description></item>
                /// <item><description>5: Withdrawn.</description></item>
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
            /// <para>The total number of permission application orders returned.</para>
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
