// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetPermissionApplyOrderDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the request order.</para>
        /// </summary>
        [NameInMap("ApplyOrderDetail")]
        [Validation(Required=false)]
        public GetPermissionApplyOrderDetailResponseBodyApplyOrderDetail ApplyOrderDetail { get; set; }
        public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetail : TeaModel {
            /// <summary>
            /// <para>The UID of the Alibaba Cloud account that submitted the request order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26784260040899****</para>
            /// </summary>
            [NameInMap("ApplyBaseId")]
            [Validation(Required=false)]
            public string ApplyBaseId { get; set; }

            /// <summary>
            /// <para>The time when the request order was submitted, displayed as a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1615284086000</para>
            /// </summary>
            [NameInMap("ApplyTimestamp")]
            [Validation(Required=false)]
            public long? ApplyTimestamp { get; set; }

            /// <summary>
            /// <para>The list of Alibaba Cloud accounts that approved the request order.</para>
            /// </summary>
            [NameInMap("ApproveAccountList")]
            [Validation(Required=false)]
            public List<GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveAccountList> ApproveAccountList { get; set; }
            public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveAccountList : TeaModel {
                /// <summary>
                /// <para>The UID of the Alibaba Cloud account that approved the request order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>182293110403****</para>
                /// </summary>
                [NameInMap("BaseId")]
                [Validation(Required=false)]
                public string BaseId { get; set; }

            }

            /// <summary>
            /// <para>The specific content of the request.</para>
            /// </summary>
            [NameInMap("ApproveContent")]
            [Validation(Required=false)]
            public GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContent ApproveContent { get; set; }
            public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContent : TeaModel {
                /// <summary>
                /// <para>The reason for the request, used as a reference for the administrator during approval.</para>
                /// 
                /// <b>Example:</b>
                /// <para>I need to use this table</para>
                /// </summary>
                [NameInMap("ApplyReason")]
                [Validation(Required=false)]
                public string ApplyReason { get; set; }

                /// <summary>
                /// <para>The expiration time of the requested permissions, displayed as a UNIX timestamp.
                /// If the MaxCompute project does not have LabelSecurity enabled, or the security level of the requested table field is 0 or less than or equal to the security level of the requesting account, only permanent permissions can be requested.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1617115071885</para>
                /// </summary>
                [NameInMap("Deadline")]
                [Validation(Required=false)]
                public long? Deadline { get; set; }

                /// <summary>
                /// <para>The type of the request order. Currently, only the value 1 is supported, indicating an object ACL permission request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("OrderType")]
                [Validation(Required=false)]
                public int? OrderType { get; set; }

                /// <summary>
                /// <para>The information about the project and workspace to which the requested object belongs.</para>
                /// </summary>
                [NameInMap("ProjectMeta")]
                [Validation(Required=false)]
                public GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContentProjectMeta ProjectMeta { get; set; }
                public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContentProjectMeta : TeaModel {
                    /// <summary>
                    /// <para>The MaxCompute project in which the requested object resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aMaxComputeProject</para>
                    /// </summary>
                    [NameInMap("MaxComputeProjectName")]
                    [Validation(Required=false)]
                    public string MaxComputeProjectName { get; set; }

                    /// <summary>
                    /// <para>The detailed information about the requested objects.</para>
                    /// </summary>
                    [NameInMap("ObjectMetaList")]
                    [Validation(Required=false)]
                    public List<GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContentProjectMetaObjectMetaList> ObjectMetaList { get; set; }
                    public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContentProjectMetaObjectMetaList : TeaModel {
                        [NameInMap("Actions")]
                        [Validation(Required=false)]
                        public List<string> Actions { get; set; }

                        /// <summary>
                        /// <para>The column field information of the requested object.</para>
                        /// </summary>
                        [NameInMap("ColumnMetaList")]
                        [Validation(Required=false)]
                        public List<GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContentProjectMetaObjectMetaListColumnMetaList> ColumnMetaList { get; set; }
                        public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContentProjectMetaObjectMetaListColumnMetaList : TeaModel {
                            [NameInMap("ColumnActions")]
                            [Validation(Required=false)]
                            public List<string> ColumnActions { get; set; }

                            /// <summary>
                            /// <para>The description of the requested column.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Field description</para>
                            /// </summary>
                            [NameInMap("ColumnComment")]
                            [Validation(Required=false)]
                            public string ColumnComment { get; set; }

                            /// <summary>
                            /// <para>The name of the requested column.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>aColumnName</para>
                            /// </summary>
                            [NameInMap("ColumnName")]
                            [Validation(Required=false)]
                            public string ColumnName { get; set; }

                            /// <summary>
                            /// <para>The security level of the requested column. Valid values: 0 to 9.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>9</para>
                            /// </summary>
                            [NameInMap("SecurityLevel")]
                            [Validation(Required=false)]
                            public string SecurityLevel { get; set; }

                        }

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
                    /// <para>The ID of the DataWorks workspace in which the requested object resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123456</para>
                    /// </summary>
                    [NameInMap("WorkspaceId")]
                    [Validation(Required=false)]
                    public int? WorkspaceId { get; set; }

                }

            }

            /// <summary>
            /// <para>The time when the final approval was completed, displayed as a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1757496687000</para>
            /// </summary>
            [NameInMap("FinishAapprovalTimestamp")]
            [Validation(Required=false)]
            public long? FinishAapprovalTimestamp { get; set; }

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
            /// <para>The ID of the request order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ad8da78d-8135-455e-9486-27cf213f****</para>
            /// </summary>
            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

            /// <summary>
            /// <para>The status of the request order. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Pending approval.</description></item>
            /// <item><description>2: Approved and authorization succeeded.</description></item>
            /// <item><description>3: Approved but authorization failed.</description></item>
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

            /// <summary>
            /// <para>The information about the accounts that requested permissions.</para>
            /// </summary>
            [NameInMap("GranteeObjectList")]
            [Validation(Required=false)]
            public List<GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailGranteeObjectList> GranteeObjectList { get; set; }
            public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailGranteeObjectList : TeaModel {
                /// <summary>
                /// <para>The UID of the Alibaba Cloud account that requested permissions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>26784260040899****</para>
                /// </summary>
                [NameInMap("GranteeId")]
                [Validation(Required=false)]
                public string GranteeId { get; set; }

                /// <summary>
                /// <para>The name of the Alibaba Cloud account that requested permissions. The format is consistent with the MaxCompute account format.</para>
                /// <list type="bullet">
                /// <item><description>Primary account: ALIYUN$+account name.</description></item>
                /// <item><description>RAM user: RAM$+account name.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RAM$dataworks_3h1_1:StsRamUser(StsRamUser)</para>
                /// </summary>
                [NameInMap("GranteeName")]
                [Validation(Required=false)]
                public string GranteeName { get; set; }

                /// <summary>
                /// <para>The type of the entity that requested permissions. Currently, only 1 (user) is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("GranteeType")]
                [Validation(Required=false)]
                public int? GranteeType { get; set; }

                /// <summary>
                /// <para>The subtype of the entity that requested permissions. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>101: Production Alibaba Cloud account.</description></item>
                /// <item><description>103: Personal Alibaba Cloud account.</description></item>
                /// <item><description>105: Alibaba Cloud account applied on behalf of another user.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>103</para>
                /// </summary>
                [NameInMap("GranteeTypeSub")]
                [Validation(Required=false)]
                public int? GranteeTypeSub { get; set; }

            }

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
