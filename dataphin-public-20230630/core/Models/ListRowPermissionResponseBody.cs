// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListRowPermissionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListRowPermissionResponseBodyPageResult PageResult { get; set; }
        public class ListRowPermissionResponseBodyPageResult : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListRowPermissionResponseBodyPageResultData> Data { get; set; }
            public class ListRowPermissionResponseBodyPageResultData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>30008888</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-08-23T08:01:44Z</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-02-12T02:16:45Z</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("MappingColumns")]
                [Validation(Required=false)]
                public List<ListRowPermissionResponseBodyPageResultDataMappingColumns> MappingColumns { get; set; }
                public class ListRowPermissionResponseBodyPageResultDataMappingColumns : TeaModel {
                    [NameInMap("ColumnDesc")]
                    [Validation(Required=false)]
                    public string ColumnDesc { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>business_id</para>
                    /// </summary>
                    [NameInMap("ColumnName")]
                    [Validation(Required=false)]
                    public string ColumnName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>string</para>
                    /// </summary>
                    [NameInMap("ColumnType")]
                    [Validation(Required=false)]
                    public string ColumnType { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30008888</para>
                /// </summary>
                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                [NameInMap("RowPermissionDesc")]
                [Validation(Required=false)]
                public string RowPermissionDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30008888</para>
                /// </summary>
                [NameInMap("RowPermissionId")]
                [Validation(Required=false)]
                public long? RowPermissionId { get; set; }

                [NameInMap("RowPermissionName")]
                [Validation(Required=false)]
                public string RowPermissionName { get; set; }

                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<ListRowPermissionResponseBodyPageResultDataRules> Rules { get; set; }
                public class ListRowPermissionResponseBodyPageResultDataRules : TeaModel {
                    [NameInMap("Expressions")]
                    [Validation(Required=false)]
                    public List<ListRowPermissionResponseBodyPageResultDataRulesExpressions> Expressions { get; set; }
                    public class ListRowPermissionResponseBodyPageResultDataRulesExpressions : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>business_id</para>
                        /// </summary>
                        [NameInMap("MappingColumnName")]
                        [Validation(Required=false)]
                        public string MappingColumnName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>30008888</para>
                        /// </summary>
                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        [NameInMap("SubConditions")]
                        [Validation(Required=false)]
                        public List<object> SubConditions { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>EXPRESSION</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("Values")]
                        [Validation(Required=false)]
                        public List<string> Values { get; set; }

                    }

                    [NameInMap("IsDelete")]
                    [Validation(Required=false)]
                    public bool? IsDelete { get; set; }

                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>SELECT_COLUMN</para>
                    /// </summary>
                    [NameInMap("ScopeType")]
                    [Validation(Required=false)]
                    public string ScopeType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    [NameInMap("UserMappingList")]
                    [Validation(Required=false)]
                    public List<ListRowPermissionResponseBodyPageResultDataRulesUserMappingList> UserMappingList { get; set; }
                    public class ListRowPermissionResponseBodyPageResultDataRulesUserMappingList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>PERSONAL</para>
                        /// </summary>
                        [NameInMap("AccountType")]
                        [Validation(Required=false)]
                        public string AccountType { get; set; }

                        [NameInMap("Accounts")]
                        [Validation(Required=false)]
                        public List<ListRowPermissionResponseBodyPageResultDataRulesUserMappingListAccounts> Accounts { get; set; }
                        public class ListRowPermissionResponseBodyPageResultDataRulesUserMappingListAccounts : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>30008888</para>
                            /// </summary>
                            [NameInMap("AccountId")]
                            [Validation(Required=false)]
                            public string AccountId { get; set; }

                        }

                    }

                }

                [NameInMap("Tables")]
                [Validation(Required=false)]
                public List<ListRowPermissionResponseBodyPageResultDataTables> Tables { get; set; }
                public class ListRowPermissionResponseBodyPageResultDataTables : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>business_id</para>
                    /// </summary>
                    [NameInMap("ColumnName")]
                    [Validation(Required=false)]
                    public string ColumnName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>business_id</para>
                    /// </summary>
                    [NameInMap("MappingColumnName")]
                    [Validation(Required=false)]
                    public string MappingColumnName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>odps.300199897.project_name.table_name</para>
                    /// </summary>
                    [NameInMap("ResourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30000001</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public long? TenantId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
