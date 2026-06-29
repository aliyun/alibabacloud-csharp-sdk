// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListRowPermissionByUserIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of OK indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The paged query result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListRowPermissionByUserIdResponseBodyPageResult PageResult { get; set; }
        public class ListRowPermissionByUserIdResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The query result.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListRowPermissionByUserIdResponseBodyPageResultData> Data { get; set; }
            public class ListRowPermissionByUserIdResponseBodyPageResultData : TeaModel {
                /// <summary>
                /// <para>The creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30008888</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-03-30T21:37:23Z</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-03-03T10:14Z</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The modifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30008888</para>
                /// </summary>
                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                /// <summary>
                /// <para>The rules.</para>
                /// </summary>
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<ListRowPermissionByUserIdResponseBodyPageResultDataRules> Rules { get; set; }
                public class ListRowPermissionByUserIdResponseBodyPageResultDataRules : TeaModel {
                    /// <summary>
                    /// <para>The rule expressions.</para>
                    /// </summary>
                    [NameInMap("Expressions")]
                    [Validation(Required=false)]
                    public List<ListRowPermissionByUserIdResponseBodyPageResultDataRulesExpressions> Expressions { get; set; }
                    public class ListRowPermissionByUserIdResponseBodyPageResultDataRulesExpressions : TeaModel {
                        /// <summary>
                        /// <para>The mapping field name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>business_id</para>
                        /// </summary>
                        [NameInMap("MappingColumnName")]
                        [Validation(Required=false)]
                        public string MappingColumnName { get; set; }

                        /// <summary>
                        /// <para>The expression operator.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>EQUAL</para>
                        /// </summary>
                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        /// <summary>
                        /// <para>The sub-expressions.</para>
                        /// </summary>
                        [NameInMap("SubConditions")]
                        [Validation(Required=false)]
                        public List<object> SubConditions { get; set; }

                        /// <summary>
                        /// <para>The expression type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>EXPRESSION</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The expression operation values.</para>
                        /// </summary>
                        [NameInMap("Values")]
                        [Validation(Required=false)]
                        public List<string> Values { get; set; }

                    }

                    /// <summary>
                    /// <para>The rule ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the rule is deleted.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("IsDelete")]
                    [Validation(Required=false)]
                    public bool? IsDelete { get; set; }

                    /// <summary>
                    /// <para>The rule name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>业务管控</para>
                    /// </summary>
                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    /// <summary>
                    /// <para>The scope type of the rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SELECT_COLUMN</para>
                    /// </summary>
                    [NameInMap("ScopeType")]
                    [Validation(Required=false)]
                    public string ScopeType { get; set; }

                    /// <summary>
                    /// <para>The rule status.</para>
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
                    public List<ListRowPermissionByUserIdResponseBodyPageResultDataRulesUserMappingList> UserMappingList { get; set; }
                    public class ListRowPermissionByUserIdResponseBodyPageResultDataRulesUserMappingList : TeaModel {
                        /// <summary>
                        /// <para>The type of the account bound to the rule.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PERSONAL</para>
                        /// </summary>
                        [NameInMap("AccountType")]
                        [Validation(Required=false)]
                        public string AccountType { get; set; }

                        /// <summary>
                        /// <para>The accounts bound to the rule.</para>
                        /// </summary>
                        [NameInMap("Accounts")]
                        [Validation(Required=false)]
                        public List<ListRowPermissionByUserIdResponseBodyPageResultDataRulesUserMappingListAccounts> Accounts { get; set; }
                        public class ListRowPermissionByUserIdResponseBodyPageResultDataRulesUserMappingListAccounts : TeaModel {
                            /// <summary>
                            /// <para>The ID of the account bound to the rule.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>30008888</para>
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
                public List<ListRowPermissionByUserIdResponseBodyPageResultDataTables> Tables { get; set; }
                public class ListRowPermissionByUserIdResponseBodyPageResultDataTables : TeaModel {
                    /// <summary>
                    /// <para>The table field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>business_id</para>
                    /// </summary>
                    [NameInMap("ColumnName")]
                    [Validation(Required=false)]
                    public string ColumnName { get; set; }

                    /// <summary>
                    /// <para>The mapping field name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>拦截规则</para>
                    /// </summary>
                    [NameInMap("MappingColumnName")]
                    [Validation(Required=false)]
                    public string MappingColumnName { get; set; }

                    /// <summary>
                    /// <para>The table GUID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>odps.300199897.project_name.table_name</para>
                    /// </summary>
                    [NameInMap("ResourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                }

                /// <summary>
                /// <para>The tenant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30000001</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public long? TenantId { get; set; }

            }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>121</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
