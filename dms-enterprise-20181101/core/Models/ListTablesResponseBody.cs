// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTablesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B16FB618-5E96-4FFD-BB0D-490C890A4030</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The details of the tables.</para>
        /// </summary>
        [NameInMap("TableList")]
        [Validation(Required=false)]
        public ListTablesResponseBodyTableList TableList { get; set; }
        public class ListTablesResponseBodyTableList : TeaModel {
            [NameInMap("Table")]
            [Validation(Required=false)]
            public List<ListTablesResponseBodyTableListTable> Table { get; set; }
            public class ListTablesResponseBodyTableListTable : TeaModel {
                /// <summary>
                /// <para>The ID of the physical database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1860****</para>
                /// </summary>
                [NameInMap("DatabaseId")]
                [Validation(Required=false)]
                public string DatabaseId { get; set; }

                /// <summary>
                /// <para>The description of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The encoding format of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>utf8</para>
                /// </summary>
                [NameInMap("Encoding")]
                [Validation(Required=false)]
                public string Encoding { get; set; }

                /// <summary>
                /// <para>The engine of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InnoDB</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The number of rows in the table. This is a statistical value and does not indicate the actual number of rows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10085</para>
                /// </summary>
                [NameInMap("NumRows")]
                [Validation(Required=false)]
                public long? NumRows { get; set; }

                /// <summary>
                /// <para>The ID list of the table owners.</para>
                /// </summary>
                [NameInMap("OwnerIdList")]
                [Validation(Required=false)]
                public ListTablesResponseBodyTableListTableOwnerIdList OwnerIdList { get; set; }
                public class ListTablesResponseBodyTableListTableOwnerIdList : TeaModel {
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<string> OwnerIds { get; set; }

                }

                /// <summary>
                /// <para>The nickname list of the table owners.</para>
                /// </summary>
                [NameInMap("OwnerNameList")]
                [Validation(Required=false)]
                public ListTablesResponseBodyTableListTableOwnerNameList OwnerNameList { get; set; }
                public class ListTablesResponseBodyTableListTableOwnerNameList : TeaModel {
                    [NameInMap("OwnerNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNames { get; set; }

                }

                /// <summary>
                /// <para>The storage space that is occupied by the table. This is a statistical value and does not indicate the accurate storage space. Unit: MB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("StoreCapacity")]
                [Validation(Required=false)]
                public long? StoreCapacity { get; set; }

                /// <summary>
                /// <para>The GUID of the table in DMS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IDB_44743****.qntest.consumption_records</para>
                /// </summary>
                [NameInMap("TableGuid")]
                [Validation(Required=false)]
                public string TableGuid { get; set; }

                /// <summary>
                /// <para>The ID of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>44743****</para>
                /// </summary>
                [NameInMap("TableId")]
                [Validation(Required=false)]
                public string TableId { get; set; }

                /// <summary>
                /// <para>The table name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>consumption_records</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <para>The database in which the table resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qntest</para>
                /// </summary>
                [NameInMap("TableSchemaName")]
                [Validation(Required=false)]
                public string TableSchemaName { get; set; }

                /// <summary>
                /// <para>The type of the table. Default value: NORMAL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("TableType")]
                [Validation(Required=false)]
                public string TableType { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of tables that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
