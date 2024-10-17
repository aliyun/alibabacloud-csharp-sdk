// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetPhysicalDatabaseResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the physical database.</para>
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public GetPhysicalDatabaseResponseBodyDatabase Database { get; set; }
        public class GetPhysicalDatabaseResponseBodyDatabase : TeaModel {
            /// <summary>
            /// <para>The name of the catalog to which the database belongs.</para>
            /// <remarks>
            /// <para>: If the database is a PostgreSQL database, the name of the database is displayed.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>def</para>
            /// </summary>
            [NameInMap("CatalogName")]
            [Validation(Required=false)]
            public string CatalogName { get; set; }

            /// <summary>
            /// <para>The ID of the physical database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>43125312</para>
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
            /// <para>The user ID of the DBA in the destination database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>43253</para>
            /// </summary>
            [NameInMap("DbaId")]
            [Validation(Required=false)]
            public string DbaId { get; set; }

            /// <summary>
            /// <para>The nickname of the database administrator (DBA) in the destination database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dmstest</para>
            /// </summary>
            [NameInMap("DbaName")]
            [Validation(Required=false)]
            public string DbaName { get; set; }

            /// <summary>
            /// <para>The encoding format of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>utf8mb4</para>
            /// </summary>
            [NameInMap("Encoding")]
            [Validation(Required=false)]
            public string Encoding { get; set; }

            /// <summary>
            /// <para>The type of the environment to which the database belongs. For more information, see <a href="https://help.aliyun.com/document_detail/163309.html">Change the environment type of an instance</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>product</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>The endpoint that is used to connect to the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-xxxab3r272.mysql.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <para>The alias of the database instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("InstanceAlias")]
            [Validation(Required=false)]
            public string InstanceAlias { get; set; }

            /// <summary>
            /// <para>The instance ID of the destination database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>43215325</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The user IDs of the database owners.</para>
            /// </summary>
            [NameInMap("OwnerIdList")]
            [Validation(Required=false)]
            public GetPhysicalDatabaseResponseBodyDatabaseOwnerIdList OwnerIdList { get; set; }
            public class GetPhysicalDatabaseResponseBodyDatabaseOwnerIdList : TeaModel {
                [NameInMap("OwnerIds")]
                [Validation(Required=false)]
                public List<string> OwnerIds { get; set; }

            }

            /// <summary>
            /// <para>The nicknames of the database owners.</para>
            /// </summary>
            [NameInMap("OwnerNameList")]
            [Validation(Required=false)]
            public GetPhysicalDatabaseResponseBodyDatabaseOwnerNameList OwnerNameList { get; set; }
            public class GetPhysicalDatabaseResponseBodyDatabaseOwnerNameList : TeaModel {
                [NameInMap("OwnerNames")]
                [Validation(Required=false)]
                public List<string> OwnerNames { get; set; }

            }

            /// <summary>
            /// <para>The port that is used to connect to the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// <remarks>
            /// <para>: If the database is a PostgreSQL database, the name of the mode is displayed.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>dmstest</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <para>The name that is used for searching the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:dmstest@rm-xxxab3r272.mysql.rds.aliyuncs.com">dmstest@rm-xxxab3r272.mysql.rds.aliyuncs.com</a>:3306</para>
            /// </summary>
            [NameInMap("SearchName")]
            [Validation(Required=false)]
            public string SearchName { get; set; }

            /// <summary>
            /// <para>The system ID (SID) of the database.</para>
            /// <remarks>
            /// <para>: The value of the parameter is returned only for Oracle databases.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>def</para>
            /// </summary>
            [NameInMap("Sid")]
            [Validation(Required=false)]
            public string Sid { get; set; }

            /// <summary>
            /// <para>The state of the database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NORMAL</b>: The database is normal.</description></item>
            /// <item><description><b>DISABLE</b>: The database is disabled.</description></item>
            /// <item><description><b>OFFLINE</b>: The database is unpublished.</description></item>
            /// <item><description><b>NOT_EXIST</b>: The database does not exist.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

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
        /// <para>7FAD400F-7A5C-4193-8F9A-39D86C4F0231</para>
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

    }

}
