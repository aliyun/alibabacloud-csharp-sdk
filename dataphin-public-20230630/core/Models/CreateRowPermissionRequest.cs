// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateRowPermissionRequest : TeaModel {
        /// <summary>
        /// <para>Request command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateRowPermissionCommand")]
        [Validation(Required=false)]
        public CreateRowPermissionRequestCreateRowPermissionCommand CreateRowPermissionCommand { get; set; }
        public class CreateRowPermissionRequestCreateRowPermissionCommand : TeaModel {
            /// <summary>
            /// <para>The mapping columns.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("MappingColumns")]
            [Validation(Required=false)]
            public List<CreateRowPermissionRequestCreateRowPermissionCommandMappingColumns> MappingColumns { get; set; }
            public class CreateRowPermissionRequestCreateRowPermissionCommandMappingColumns : TeaModel {
                /// <summary>
                /// <para>The description of the mapping column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>控制业务ID字段</para>
                /// </summary>
                [NameInMap("ColumnDesc")]
                [Validation(Required=false)]
                public string ColumnDesc { get; set; }

                /// <summary>
                /// <para>The name of the mapping column.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>business_id</para>
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// <para>The type of the mapping column.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("ColumnType")]
                [Validation(Required=false)]
                public string ColumnType { get; set; }

            }

            /// <summary>
            /// <para>The description of the row-level permission.</para>
            /// 
            /// <b>Example:</b>
            /// <para>管控业务数据</para>
            /// </summary>
            [NameInMap("RowPermissionDesc")]
            [Validation(Required=false)]
            public string RowPermissionDesc { get; set; }

            /// <summary>
            /// <para>The name of the row-level permission.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>业务管控</para>
            /// </summary>
            [NameInMap("RowPermissionName")]
            [Validation(Required=false)]
            public string RowPermissionName { get; set; }

            /// <summary>
            /// <para>The rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<CreateRowPermissionRequestCreateRowPermissionCommandRules> Rules { get; set; }
            public class CreateRowPermissionRequestCreateRowPermissionCommandRules : TeaModel {
                /// <summary>
                /// <para>The rule expressions.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Expressions")]
                [Validation(Required=false)]
                public List<CreateRowPermissionRequestCreateRowPermissionCommandRulesExpressions> Expressions { get; set; }
                public class CreateRowPermissionRequestCreateRowPermissionCommandRulesExpressions : TeaModel {
                    /// <summary>
                    /// <para>The name of the mapping column.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>id</para>
                    /// </summary>
                    [NameInMap("MappingColumnName")]
                    [Validation(Required=false)]
                    public string MappingColumnName { get; set; }

                    /// <summary>
                    /// <para>The operator of the expression.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>EQUAL</para>
                    /// </summary>
                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <para>The sub-expressions.</para>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("SubConditions")]
                    [Validation(Required=false)]
                    public List<object> SubConditions { get; set; }

                    /// <summary>
                    /// <para>The type of the expression.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>RELATION</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The expression operation values.</para>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>Specifies whether to delete the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsDelete")]
                [Validation(Required=false)]
                public bool? IsDelete { get; set; }

                /// <summary>
                /// <para>The name of the rule.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>中台</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The scope type of the rule.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT_COLUMN</para>
                /// </summary>
                [NameInMap("ScopeType")]
                [Validation(Required=false)]
                public string ScopeType { get; set; }

                /// <summary>
                /// <para>The status of the rule.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The accounts bound to the rule.</para>
                /// </summary>
                [NameInMap("UserMappingList")]
                [Validation(Required=false)]
                public List<CreateRowPermissionRequestCreateRowPermissionCommandRulesUserMappingList> UserMappingList { get; set; }
                public class CreateRowPermissionRequestCreateRowPermissionCommandRulesUserMappingList : TeaModel {
                    /// <summary>
                    /// <para>The type of the account bound to the rule.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PERSONAL</para>
                    /// </summary>
                    [NameInMap("AccountType")]
                    [Validation(Required=false)]
                    public string AccountType { get; set; }

                    /// <summary>
                    /// <para>The accounts bound to the rule.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PERSONAL</para>
                    /// </summary>
                    [NameInMap("Accounts")]
                    [Validation(Required=false)]
                    public List<CreateRowPermissionRequestCreateRowPermissionCommandRulesUserMappingListAccounts> Accounts { get; set; }
                    public class CreateRowPermissionRequestCreateRowPermissionCommandRulesUserMappingListAccounts : TeaModel {
                        /// <summary>
                        /// <para>The ID of the account bound to the rule.</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>300001111</para>
                        /// </summary>
                        [NameInMap("AccountId")]
                        [Validation(Required=false)]
                        public string AccountId { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>The related tables.</para>
            /// </summary>
            [NameInMap("Tables")]
            [Validation(Required=false)]
            public List<CreateRowPermissionRequestCreateRowPermissionCommandTables> Tables { get; set; }
            public class CreateRowPermissionRequestCreateRowPermissionCommandTables : TeaModel {
                /// <summary>
                /// <para>The column of the table.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>business_id</para>
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// <para>The name of the mapping column.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>business_id</para>
                /// </summary>
                [NameInMap("MappingColumnName")]
                [Validation(Required=false)]
                public string MappingColumnName { get; set; }

                /// <summary>
                /// <para>The GUID of the table.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps.300199897.project_name.table_name</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

            }

        }

        /// <summary>
        /// <para>Tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

    }

}
