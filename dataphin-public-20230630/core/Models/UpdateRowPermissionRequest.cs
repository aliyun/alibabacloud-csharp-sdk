// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateRowPermissionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateRowPermissionCommand")]
        [Validation(Required=false)]
        public UpdateRowPermissionRequestUpdateRowPermissionCommand UpdateRowPermissionCommand { get; set; }
        public class UpdateRowPermissionRequestUpdateRowPermissionCommand : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("MappingColumns")]
            [Validation(Required=false)]
            public List<UpdateRowPermissionRequestUpdateRowPermissionCommandMappingColumns> MappingColumns { get; set; }
            public class UpdateRowPermissionRequestUpdateRowPermissionCommandMappingColumns : TeaModel {
                [NameInMap("ColumnDesc")]
                [Validation(Required=false)]
                public string ColumnDesc { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>business_id</para>
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("ColumnType")]
                [Validation(Required=false)]
                public string ColumnType { get; set; }

            }

            [NameInMap("RowPermissionDesc")]
            [Validation(Required=false)]
            public string RowPermissionDesc { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30009999</para>
            /// </summary>
            [NameInMap("RowPermissionId")]
            [Validation(Required=false)]
            public long? RowPermissionId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RowPermissionName")]
            [Validation(Required=false)]
            public string RowPermissionName { get; set; }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<UpdateRowPermissionRequestUpdateRowPermissionCommandRules> Rules { get; set; }
            public class UpdateRowPermissionRequestUpdateRowPermissionCommandRules : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Expressions")]
                [Validation(Required=false)]
                public List<UpdateRowPermissionRequestUpdateRowPermissionCommandRulesExpressions> Expressions { get; set; }
                public class UpdateRowPermissionRequestUpdateRowPermissionCommandRulesExpressions : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>business_id</para>
                    /// </summary>
                    [NameInMap("MappingColumnName")]
                    [Validation(Required=false)]
                    public string MappingColumnName { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OR</para>
                    /// </summary>
                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("SubConditions")]
                    [Validation(Required=false)]
                    public List<object> SubConditions { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>EXPRESSION</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IsDelete")]
                [Validation(Required=false)]
                public bool? IsDelete { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT_COLUMN</para>
                /// </summary>
                [NameInMap("ScopeType")]
                [Validation(Required=false)]
                public string ScopeType { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("UserMappingList")]
                [Validation(Required=false)]
                public List<UpdateRowPermissionRequestUpdateRowPermissionCommandRulesUserMappingList> UserMappingList { get; set; }
                public class UpdateRowPermissionRequestUpdateRowPermissionCommandRulesUserMappingList : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PERSONAL</para>
                    /// </summary>
                    [NameInMap("AccountType")]
                    [Validation(Required=false)]
                    public string AccountType { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("Accounts")]
                    [Validation(Required=false)]
                    public List<UpdateRowPermissionRequestUpdateRowPermissionCommandRulesUserMappingListAccounts> Accounts { get; set; }
                    public class UpdateRowPermissionRequestUpdateRowPermissionCommandRulesUserMappingListAccounts : TeaModel {
                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30001011</para>
                        /// </summary>
                        [NameInMap("AccountId")]
                        [Validation(Required=false)]
                        public string AccountId { get; set; }

                    }

                }

            }

            [NameInMap("Tables")]
            [Validation(Required=false)]
            public List<UpdateRowPermissionRequestUpdateRowPermissionCommandTables> Tables { get; set; }
            public class UpdateRowPermissionRequestUpdateRowPermissionCommandTables : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>business_id</para>
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>business_id</para>
                /// </summary>
                [NameInMap("MappingColumnName")]
                [Validation(Required=false)]
                public string MappingColumnName { get; set; }

                /// <summary>
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

    }

}
