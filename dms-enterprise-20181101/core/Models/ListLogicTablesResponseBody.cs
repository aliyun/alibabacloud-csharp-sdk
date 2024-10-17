// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListLogicTablesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The details of the logical tables.</para>
        /// </summary>
        [NameInMap("LogicTableList")]
        [Validation(Required=false)]
        public ListLogicTablesResponseBodyLogicTableList LogicTableList { get; set; }
        public class ListLogicTablesResponseBodyLogicTableList : TeaModel {
            [NameInMap("LogicTable")]
            [Validation(Required=false)]
            public List<ListLogicTablesResponseBodyLogicTableListLogicTable> LogicTable { get; set; }
            public class ListLogicTablesResponseBodyLogicTableListLogicTable : TeaModel {
                /// <summary>
                /// <para>The ID of the logical database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DatabaseId")]
                [Validation(Required=false)]
                public string DatabaseId { get; set; }

                /// <summary>
                /// <para>Indicates whether the table is a logical table. The value is fixed to true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// <para>The IDs of the owners of the logical tables.</para>
                /// </summary>
                [NameInMap("OwnerIdList")]
                [Validation(Required=false)]
                public ListLogicTablesResponseBodyLogicTableListLogicTableOwnerIdList OwnerIdList { get; set; }
                public class ListLogicTablesResponseBodyLogicTableListLogicTableOwnerIdList : TeaModel {
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<string> OwnerIds { get; set; }

                }

                /// <summary>
                /// <para>The nicknames of the owners of the logical tables.</para>
                /// </summary>
                [NameInMap("OwnerNameList")]
                [Validation(Required=false)]
                public ListLogicTablesResponseBodyLogicTableListLogicTableOwnerNameList OwnerNameList { get; set; }
                public class ListLogicTablesResponseBodyLogicTableListLogicTableOwnerNameList : TeaModel {
                    [NameInMap("OwnerNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNames { get; set; }

                }

                /// <summary>
                /// <para>The logical database to which the logical table belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yuyang_test</para>
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// <para>The number of logical tables.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("TableCount")]
                [Validation(Required=false)]
                public string TableCount { get; set; }

                /// <summary>
                /// <para>The expression of the logical table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test[1-4]</para>
                /// </summary>
                [NameInMap("TableExpr")]
                [Validation(Required=false)]
                public string TableExpr { get; set; }

                /// <summary>
                /// <para>The GUID of the logical table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IDB_L_308302.yuyang_test.test_ch</para>
                /// </summary>
                [NameInMap("TableGuid")]
                [Validation(Required=false)]
                public string TableGuid { get; set; }

                /// <summary>
                /// <para>The ID of the logical table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TableId")]
                [Validation(Required=false)]
                public string TableId { get; set; }

                /// <summary>
                /// <para>The name of the logical table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F1E6484F-9DF1-4406-9BDE-0861C4629B69</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of logical tables that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
