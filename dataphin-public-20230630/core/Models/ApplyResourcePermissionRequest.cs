// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ApplyResourcePermissionRequest : TeaModel {
        /// <summary>
        /// <para>The permission application request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApplyCommand")]
        [Validation(Required=false)]
        public ApplyResourcePermissionRequestApplyCommand ApplyCommand { get; set; }
        public class ApplyResourcePermissionRequestApplyCommand : TeaModel {
            /// <summary>
            /// <para>The list of users to whom permissions are granted.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("GrantToUsers")]
            [Validation(Required=false)]
            public List<ApplyResourcePermissionRequestApplyCommandGrantToUsers> GrantToUsers { get; set; }
            public class ApplyResourcePermissionRequestApplyCommandGrantToUsers : TeaModel {
                /// <summary>
                /// <para>The account type.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PERSONAL</para>
                /// </summary>
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                /// <summary>
                /// <para>The expiration date of the permission. Format: yyyy-MM-dd.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-12-31</para>
                /// </summary>
                [NameInMap("PeriodEnd")]
                [Validation(Required=false)]
                public string PeriodEnd { get; set; }

                /// <summary>
                /// <para>The type of the permission validity period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DAYS_30</para>
                /// </summary>
                [NameInMap("PeriodType")]
                [Validation(Required=false)]
                public string PeriodType { get; set; }

                /// <summary>
                /// <para>The project ID of the production account. This parameter is required when the account type is PRODUCE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7298904510790528</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300001186</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The permission granularity. Valid values: TABLE (table-level permissions) and COLUMN (column-level permissions).</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TABLE</para>
            /// </summary>
            [NameInMap("Granularity")]
            [Validation(Required=false)]
            public string Granularity { get; set; }

            /// <summary>
            /// <para>The list of operation types.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("OperateList")]
            [Validation(Required=false)]
            public List<string> OperateList { get; set; }

            /// <summary>
            /// <para>The reason for the application. This parameter is required and cannot be empty or contain only whitespace characters.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The list of resources for which permissions are applied.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ResourceList")]
            [Validation(Required=false)]
            public List<ApplyResourcePermissionRequestApplyCommandResourceList> ResourceList { get; set; }
            public class ApplyResourcePermissionRequestApplyCommandResourceList : TeaModel {
                /// <summary>
                /// <para>The list of column names specified for column-level permissions. This parameter is required when the granularity is COLUMN.</para>
                /// </summary>
                [NameInMap("ColumnList")]
                [Validation(Required=false)]
                public List<string> ColumnList { get; set; }

                /// <summary>
                /// <para>The resource ID, which is the GUID of the table metadata.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dp_ds_table_xxx</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

            }

            /// <summary>
            /// <para>The resource type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PHYSICAL_TABLE</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
