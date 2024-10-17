// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDatabasesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the databases.</para>
        /// </summary>
        [NameInMap("DatabaseList")]
        [Validation(Required=false)]
        public ListDatabasesResponseBodyDatabaseList DatabaseList { get; set; }
        public class ListDatabasesResponseBodyDatabaseList : TeaModel {
            [NameInMap("Database")]
            [Validation(Required=false)]
            public List<ListDatabasesResponseBodyDatabaseListDatabase> Database { get; set; }
            public class ListDatabasesResponseBodyDatabaseListDatabase : TeaModel {
                /// <summary>
                /// <para>The name of the catalog to which the database belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CatalogName")]
                [Validation(Required=false)]
                public string CatalogName { get; set; }

                /// <summary>
                /// <para>The ID of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DatabaseId")]
                [Validation(Required=false)]
                public string DatabaseId { get; set; }

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
                /// <para>The ID of the DBA.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DbaId")]
                [Validation(Required=false)]
                public string DbaId { get; set; }

                /// <summary>
                /// <para>The nickname of the Database administrator (DBA) to which the database belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dba_user</para>
                /// </summary>
                [NameInMap("DbaName")]
                [Validation(Required=false)]
                public string DbaName { get; set; }

                /// <summary>
                /// <para>The encoding format of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>utf-8</para>
                /// </summary>
                [NameInMap("Encoding")]
                [Validation(Required=false)]
                public string Encoding { get; set; }

                /// <summary>
                /// <para>The type of the environment to which the database belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dev</para>
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// <para>The endpoint of the instance to which the database belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx.xxx.xxx.xxx</para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The ID of the instance to which the database belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The IDs of the owners of the database.</para>
                /// </summary>
                [NameInMap("OwnerIdList")]
                [Validation(Required=false)]
                public ListDatabasesResponseBodyDatabaseListDatabaseOwnerIdList OwnerIdList { get; set; }
                public class ListDatabasesResponseBodyDatabaseListDatabaseOwnerIdList : TeaModel {
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<string> OwnerIds { get; set; }

                }

                /// <summary>
                /// <para>The nicknames of the database owners.</para>
                /// </summary>
                [NameInMap("OwnerNameList")]
                [Validation(Required=false)]
                public ListDatabasesResponseBodyDatabaseListDatabaseOwnerNameList OwnerNameList { get; set; }
                public class ListDatabasesResponseBodyDatabaseListDatabaseOwnerNameList : TeaModel {
                    [NameInMap("OwnerNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNames { get; set; }

                }

                /// <summary>
                /// <para>The connection port of the instance to which the database belongs.</para>
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
                /// <para>The name that is used for searching the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:test@xxx.xxx.xxx.xxx">test@xxx.xxx.xxx.xxx</a>:3306</para>
                /// </summary>
                [NameInMap("SearchName")]
                [Validation(Required=false)]
                public string SearchName { get; set; }

                /// <summary>
                /// <para>The system ID (SID) of the instance to which the database belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Sid")]
                [Validation(Required=false)]
                public string Sid { get; set; }

                /// <summary>
                /// <para>The state of the database. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NORMAL: The database is normal.</description></item>
                /// <item><description>DISABLE: The database is disabled.</description></item>
                /// <item><description>OFFLINE: The database is unpublished.</description></item>
                /// <item><description>NOT_EXIST: The database does not exist.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

        }

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
        /// <para>5541CDA6-F674-435C-81BD-40C2FB926CE3</para>
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
        /// <para>The number of databases that belong to an instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
