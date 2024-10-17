// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class SearchTableResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
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
        /// <para>1489257F-1B5D-4B5B-89EF-923C12CEEBD1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the tables.</para>
        /// </summary>
        [NameInMap("SearchTableList")]
        [Validation(Required=false)]
        public SearchTableResponseBodySearchTableList SearchTableList { get; set; }
        public class SearchTableResponseBodySearchTableList : TeaModel {
            [NameInMap("SearchTable")]
            [Validation(Required=false)]
            public List<SearchTableResponseBodySearchTableListSearchTable> SearchTable { get; set; }
            public class SearchTableResponseBodySearchTableListSearchTable : TeaModel {
                /// <summary>
                /// <para>The name that is used to search for the database to which the table belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("DBSearchName")]
                [Validation(Required=false)]
                public string DBSearchName { get; set; }

                /// <summary>
                /// <para>The ID of the database to which the table belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DatabaseId")]
                [Validation(Required=false)]
                public string DatabaseId { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("DbName")]
                [Validation(Required=false)]
                public string DbName { get; set; }

                /// <summary>
                /// <para>The type of the database. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>MySQL</b></description></item>
                /// <item><description><b>SQLServer</b></description></item>
                /// <item><description><b>PostgreSQL</b></description></item>
                /// <item><description><b>Oracle</b></description></item>
                /// <item><description><b>DRDS</b></description></item>
                /// <item><description><b>OceanBase</b></description></item>
                /// <item><description><b>Mongo</b></description></item>
                /// <item><description><b>Redis</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>mysql</para>
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

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
                /// <para>innodb</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The type of the environment to which the database belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// <para>Indicates whether the table is a logical table. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The table is a logical table.</description></item>
                /// <item><description><b>false</b>: The table is not a logical table.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// <para>The IDs of the table owners.</para>
                /// </summary>
                [NameInMap("OwnerIdList")]
                [Validation(Required=false)]
                public SearchTableResponseBodySearchTableListSearchTableOwnerIdList OwnerIdList { get; set; }
                public class SearchTableResponseBodySearchTableListSearchTableOwnerIdList : TeaModel {
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<string> OwnerIds { get; set; }

                }

                /// <summary>
                /// <para>The nicknames of the table owners.</para>
                /// </summary>
                [NameInMap("OwnerNameList")]
                [Validation(Required=false)]
                public SearchTableResponseBodySearchTableListSearchTableOwnerNameList OwnerNameList { get; set; }
                public class SearchTableResponseBodySearchTableListSearchTableOwnerNameList : TeaModel {
                    [NameInMap("OwnerNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNames { get; set; }

                }

                /// <summary>
                /// <para>The GUID of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IDB_L_9032.db-test.yuyang_test</para>
                /// </summary>
                [NameInMap("TableGuid")]
                [Validation(Required=false)]
                public string TableGuid { get; set; }

                /// <summary>
                /// <para>The ID of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TableId")]
                [Validation(Required=false)]
                public string TableId { get; set; }

                /// <summary>
                /// <para>The name of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_table</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <para>The name of the database to which the table belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:test@xxx.xxx.xxx.xxx">test@xxx.xxx.xxx.xxx</a>:3306</para>
                /// </summary>
                [NameInMap("TableSchemaName")]
                [Validation(Required=false)]
                public string TableSchemaName { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
