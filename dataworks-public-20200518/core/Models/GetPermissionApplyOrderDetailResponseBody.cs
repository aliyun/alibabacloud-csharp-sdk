// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetPermissionApplyOrderDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the permission request order.</para>
        /// </summary>
        [NameInMap("ApplyOrderDetail")]
        [Validation(Required=false)]
        public GetPermissionApplyOrderDetailResponseBodyApplyOrderDetail ApplyOrderDetail { get; set; }
        public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetail : TeaModel {
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
            /// <para>The time when the permission request order was submitted. The value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1615284086000</para>
            /// </summary>
            [NameInMap("ApplyTimestamp")]
            [Validation(Required=false)]
            public long? ApplyTimestamp { get; set; }

            /// <summary>
            /// <para>The list of Alibaba Cloud accounts that are used to process the permission request order.</para>
            /// </summary>
            [NameInMap("ApproveAccountList")]
            [Validation(Required=false)]
            public List<GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveAccountList> ApproveAccountList { get; set; }
            public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveAccountList : TeaModel {
                /// <summary>
                /// <para>The ID of the Alibaba Cloud account that is used to process the permission request order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>182293110403****</para>
                /// </summary>
                [NameInMap("BaseId")]
                [Validation(Required=false)]
                public string BaseId { get; set; }

            }

            /// <summary>
            /// <para>The content of the permission request.</para>
            /// </summary>
            [NameInMap("ApproveContent")]
            [Validation(Required=false)]
            public GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContent ApproveContent { get; set; }
            public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContent : TeaModel {
                /// <summary>
                /// <para>The reason of the permission request. The administrator processes the request based on the reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>I need to use this table</para>
                /// </summary>
                [NameInMap("ApplyReason")]
                [Validation(Required=false)]
                public string ApplyReason { get; set; }

                /// <summary>
                /// <para>The expiration time of the permissions that you request. The value is a UNIX timestamp. If LabelSecurity is disabled for the MaxCompute project in which you want to request permissions on the fields of a table, or the security level of the fields is 0 or is lower than or equal to the security level of the Alibaba Cloud account for which you want to request permissions, you can request only permanent permissions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1617115071885</para>
                /// </summary>
                [NameInMap("Deadline")]
                [Validation(Required=false)]
                public long? Deadline { get; set; }

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
                /// <para>The information about the project and workspace that are associated with the object on which you request permissions.</para>
                /// </summary>
                [NameInMap("ProjectMeta")]
                [Validation(Required=false)]
                public GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContentProjectMeta ProjectMeta { get; set; }
                public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContentProjectMeta : TeaModel {
                    /// <summary>
                    /// <para>The MaxCompute project to which the object on which you request permissions belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aMaxComputeProject</para>
                    /// </summary>
                    [NameInMap("MaxComputeProjectName")]
                    [Validation(Required=false)]
                    public string MaxComputeProjectName { get; set; }

                    /// <summary>
                    /// <para>The details about the object on which you request permissions.</para>
                    /// </summary>
                    [NameInMap("ObjectMetaList")]
                    [Validation(Required=false)]
                    public List<GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContentProjectMetaObjectMetaList> ObjectMetaList { get; set; }
                    public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContentProjectMetaObjectMetaList : TeaModel {
                        /// <summary>
                        /// <para>The information about the column fields in the object on which you request permissions.</para>
                        /// </summary>
                        [NameInMap("ColumnMetaList")]
                        [Validation(Required=false)]
                        public List<GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContentProjectMetaObjectMetaListColumnMetaList> ColumnMetaList { get; set; }
                        public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailApproveContentProjectMetaObjectMetaListColumnMetaList : TeaModel {
                            /// <summary>
                            /// <para>The description of the column on which you request permissions.</para>
                            /// </summary>
                            [NameInMap("ColumnComment")]
                            [Validation(Required=false)]
                            public string ColumnComment { get; set; }

                            /// <summary>
                            /// <para>The name of the column on which you request permissions.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>aColumnName</para>
                            /// </summary>
                            [NameInMap("ColumnName")]
                            [Validation(Required=false)]
                            public string ColumnName { get; set; }

                            /// <summary>
                            /// <para>The security level of the column on which you request permissions. Valid values: 0 to 9.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>9</para>
                            /// </summary>
                            [NameInMap("SecurityLevel")]
                            [Validation(Required=false)]
                            public string SecurityLevel { get; set; }

                        }

                        /// <summary>
                        /// <para>The name of the table on which you request permissions.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>aTableName</para>
                        /// </summary>
                        [NameInMap("ObjectName")]
                        [Validation(Required=false)]
                        public string ObjectName { get; set; }

                    }

                    /// <summary>
                    /// <para>The ID of the DataWorks workspace that is associated with the object on which you request permissions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12345</para>
                    /// </summary>
                    [NameInMap("WorkspaceId")]
                    [Validation(Required=false)]
                    public int? WorkspaceId { get; set; }

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

            /// <summary>
            /// <para>The information about the account that is used to request permissions.</para>
            /// </summary>
            [NameInMap("GranteeObjectList")]
            [Validation(Required=false)]
            public List<GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailGranteeObjectList> GranteeObjectList { get; set; }
            public class GetPermissionApplyOrderDetailResponseBodyApplyOrderDetailGranteeObjectList : TeaModel {
                /// <summary>
                /// <para>The ID of the account that is used to request permissions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>267842600408993176</para>
                /// </summary>
                [NameInMap("GranteeId")]
                [Validation(Required=false)]
                public string GranteeId { get; set; }

                /// <summary>
                /// <para>The name of the account that is used to request permissions. The name is in the same format as that of the account used to access the MaxCompute project.</para>
                /// <list type="bullet">
                /// <item><description>If the account is an Alibaba Cloud account, the value is in the ALIYUN$+Account name format.</description></item>
                /// <item><description>If the account is a RAM user, the value is in the RAM$+Account name format.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RAM$dataworks_3h1_1:StsRamUser(StsRamUser)</para>
                /// </summary>
                [NameInMap("GranteeName")]
                [Validation(Required=false)]
                public string GranteeName { get; set; }

                /// <summary>
                /// <para>The type of the subject that requests permissions. The value is fixed as 1, which indicates users.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("GranteeType")]
                [Validation(Required=false)]
                public int? GranteeType { get; set; }

                /// <summary>
                /// <para>The subtype of the subject that requests permissions. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>101: production account</description></item>
                /// <item><description>103: individual account</description></item>
                /// <item><description>105: account that requests permissions for others</description></item>
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
