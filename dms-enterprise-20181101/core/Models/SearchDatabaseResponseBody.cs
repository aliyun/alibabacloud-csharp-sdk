// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class SearchDatabaseResponseBody : TeaModel {
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E0D21075-CD3E-4D98-8264-FD8AD04A63B6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the databases.</para>
        /// </summary>
        [NameInMap("SearchDatabaseList")]
        [Validation(Required=false)]
        public SearchDatabaseResponseBodySearchDatabaseList SearchDatabaseList { get; set; }
        public class SearchDatabaseResponseBodySearchDatabaseList : TeaModel {
            [NameInMap("SearchDatabase")]
            [Validation(Required=false)]
            public List<SearchDatabaseResponseBodySearchDatabaseListSearchDatabase> SearchDatabase { get; set; }
            public class SearchDatabaseResponseBodySearchDatabaseListSearchDatabase : TeaModel {
                /// <summary>
                /// <para>The alias of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_rds</para>
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// <para>The name of the catalog to which the database belongs.</para>
                /// <remarks>
                /// <para>If the type of the database engine is PostgreSQL, the name of the database is displayed.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>dmstest</para>
                /// </summary>
                [NameInMap("CatalogName")]
                [Validation(Required=false)]
                public string CatalogName { get; set; }

                /// <summary>
                /// <para>The ID of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2528****</para>
                /// </summary>
                [NameInMap("DatabaseId")]
                [Validation(Required=false)]
                public string DatabaseId { get; set; }

                /// <summary>
                /// <para>The name of the data link for cross-database queries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>datalink_name</para>
                /// </summary>
                [NameInMap("DatalinkName")]
                [Validation(Required=false)]
                public string DatalinkName { get; set; }

                /// <summary>
                /// <para>The type of the database engine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql</para>
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// <para>The ID of the user who assumes the database administrator (DBA) role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10****</para>
                /// </summary>
                [NameInMap("DbaId")]
                [Validation(Required=false)]
                public string DbaId { get; set; }

                /// <summary>
                /// <para>The encoding method of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>utf8</para>
                /// </summary>
                [NameInMap("Encoding")]
                [Validation(Required=false)]
                public string Encoding { get; set; }

                /// <summary>
                /// <para>The environment type of the database. For more information, see <a href="https://help.aliyun.com/document_detail/163309.html">Change the environment type of an instance</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// <para>The endpoint of the instance in which the database resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-xxxx.mysql.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>Indicates whether the database is a logical database. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The database is a logical database.</description></item>
                /// <item><description><b>false</b>: The database is not a logical database.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// <para>The IDs of the owners of the databases.</para>
                /// </summary>
                [NameInMap("OwnerIdList")]
                [Validation(Required=false)]
                public SearchDatabaseResponseBodySearchDatabaseListSearchDatabaseOwnerIdList OwnerIdList { get; set; }
                public class SearchDatabaseResponseBodySearchDatabaseListSearchDatabaseOwnerIdList : TeaModel {
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<string> OwnerIds { get; set; }

                }

                /// <summary>
                /// <para>The nicknames of the database owners.</para>
                /// </summary>
                [NameInMap("OwnerNameList")]
                [Validation(Required=false)]
                public SearchDatabaseResponseBodySearchDatabaseListSearchDatabaseOwnerNameList OwnerNameList { get; set; }
                public class SearchDatabaseResponseBodySearchDatabaseListSearchDatabaseOwnerNameList : TeaModel {
                    [NameInMap("OwnerNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNames { get; set; }

                }

                /// <summary>
                /// <para>The port of the instance in which the database resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// <para>The name that is used to search for the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:test@xxx.xxx.xxx.xxx">test@xxx.xxx.xxx.xxx</a>:3306</para>
                /// </summary>
                [NameInMap("SearchName")]
                [Validation(Required=false)]
                public string SearchName { get; set; }

                /// <summary>
                /// <para>The system ID (SID) of the instance in which the database resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testSid</para>
                /// </summary>
                [NameInMap("Sid")]
                [Validation(Required=false)]
                public string Sid { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
