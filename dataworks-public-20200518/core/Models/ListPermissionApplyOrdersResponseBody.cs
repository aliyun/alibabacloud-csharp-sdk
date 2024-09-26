// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListPermissionApplyOrdersResponseBody : TeaModel {
        /// <summary>
        /// <para>The query results returned by page.</para>
        /// </summary>
        [NameInMap("ApplyOrders")]
        [Validation(Required=false)]
        public ListPermissionApplyOrdersResponseBodyApplyOrders ApplyOrders { get; set; }
        public class ListPermissionApplyOrdersResponseBodyApplyOrders : TeaModel {
            /// <summary>
            /// <para>The list of the permission request orders.</para>
            /// </summary>
            [NameInMap("ApplyOrder")]
            [Validation(Required=false)]
            public List<ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrder> ApplyOrder { get; set; }
            public class ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrder : TeaModel {
                /// <summary>
                /// <para>The ID of the Alibaba Cloud account that was used to submit the permission request order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>267842600408993176</para>
                /// </summary>
                [NameInMap("ApplyBaseId")]
                [Validation(Required=false)]
                public string ApplyBaseId { get; set; }

                /// <summary>
                /// <para>The time when the permission request order was submitted. The parameter value is a UNIX timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1615284086000</para>
                /// </summary>
                [NameInMap("ApplyTimestamp")]
                [Validation(Required=false)]
                public long? ApplyTimestamp { get; set; }

                /// <summary>
                /// <para>The content of the permission request order.</para>
                /// </summary>
                [NameInMap("ApproveContent")]
                [Validation(Required=false)]
                public ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContent ApproveContent { get; set; }
                public class ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContent : TeaModel {
                    /// <summary>
                    /// <para>The reason for your request. The administrator determines whether to approve the request based on the reason.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>I need to use this table</para>
                    /// </summary>
                    [NameInMap("ApplyReason")]
                    [Validation(Required=false)]
                    public string ApplyReason { get; set; }

                    /// <summary>
                    /// <para>The type of the permission request order. The parameter value is 1 and cannot be changed. This value indicates ACL-based authorization.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("OrderType")]
                    [Validation(Required=false)]
                    public int? OrderType { get; set; }

                    /// <summary>
                    /// <para>The content of the object on which you requested permissions.</para>
                    /// </summary>
                    [NameInMap("ProjectMeta")]
                    [Validation(Required=false)]
                    public ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContentProjectMeta ProjectMeta { get; set; }
                    public class ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContentProjectMeta : TeaModel {
                        /// <summary>
                        /// <para>The information about the object on which you requested permissions.</para>
                        /// </summary>
                        [NameInMap("ObjectMetaList")]
                        [Validation(Required=false)]
                        public List<ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContentProjectMetaObjectMetaList> ObjectMetaList { get; set; }
                        public class ListPermissionApplyOrdersResponseBodyApplyOrdersApplyOrderApproveContentProjectMetaObjectMetaList : TeaModel {
                            [NameInMap("Actions")]
                            [Validation(Required=false)]
                            public List<string> Actions { get; set; }

                            /// <summary>
                            /// <para>The name of the table on which you requested permissions.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>aTableName</para>
                            /// </summary>
                            [NameInMap("ObjectName")]
                            [Validation(Required=false)]
                            public string ObjectName { get; set; }

                        }

                        /// <summary>
                        /// <para>The name of the DataWorks workspace that is associated with the MaxCompute project in which you requested permissions on a table.</para>
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
                /// <para>The ID of the permission request order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ad8da78d-8135-455e-9486-27cf213fc140</para>
                /// </summary>
                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }

                /// <summary>
                /// <para>The status of the permission request order. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: to be processed</description></item>
                /// <item><description>2: approved and authorized</description></item>
                /// <item><description>3: approved but authorization failed</description></item>
                /// <item><description>4: rejected</description></item>
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
            /// <para>The total number of entries returned.</para>
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
