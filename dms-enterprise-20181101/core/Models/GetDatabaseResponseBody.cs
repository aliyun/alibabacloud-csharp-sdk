// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDatabaseResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the database.</para>
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public GetDatabaseResponseBodyDatabase Database { get; set; }
        public class GetDatabaseResponseBodyDatabase : TeaModel {
            /// <summary>
            /// <para>The name of the catalog to which the database belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>def</para>
            /// </summary>
            [NameInMap("CatalogName")]
            [Validation(Required=false)]
            public string CatalogName { get; set; }

            /// <summary>
            /// <para>The ID of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>984****</para>
            /// </summary>
            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

            /// <summary>
            /// <para>The type of the database. For more information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/198106.html">DbType parameter</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// <para>The ID of the database administrator (DBA).</para>
            /// 
            /// <b>Example:</b>
            /// <para>27****</para>
            /// </summary>
            [NameInMap("DbaId")]
            [Validation(Required=false)]
            public string DbaId { get; set; }

            /// <summary>
            /// <para>The nickname of the DBA.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dba_name</para>
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
            /// <para>The type of the environment to which the database belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>product</b>: production environment</description></item>
            /// <item><description><b>dev</b>: development environment</description></item>
            /// <item><description><b>pre</b>: staging environment</description></item>
            /// <item><description><b>test</b>: test environment</description></item>
            /// <item><description><b>sit</b>: SIT environment</description></item>
            /// <item><description><b>uat</b>: user acceptance testing (UAT) environment</description></item>
            /// <item><description><b>pet</b>: stress testing environment</description></item>
            /// <item><description><b>stag</b>: STAG environment</description></item>
            /// </list>
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
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <para>The alias of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("InstanceAlias")]
            [Validation(Required=false)]
            public string InstanceAlias { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>149****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The IDs of the owners of the database.</para>
            /// </summary>
            [NameInMap("OwnerIdList")]
            [Validation(Required=false)]
            public GetDatabaseResponseBodyDatabaseOwnerIdList OwnerIdList { get; set; }
            public class GetDatabaseResponseBodyDatabaseOwnerIdList : TeaModel {
                [NameInMap("OwnerIds")]
                [Validation(Required=false)]
                public List<string> OwnerIds { get; set; }

            }

            /// <summary>
            /// <para>The names of the owners of the database.</para>
            /// </summary>
            [NameInMap("OwnerNameList")]
            [Validation(Required=false)]
            public GetDatabaseResponseBodyDatabaseOwnerNameList OwnerNameList { get; set; }
            public class GetDatabaseResponseBodyDatabaseOwnerNameList : TeaModel {
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
            /// 
            /// <b>Example:</b>
            /// <para>mysql</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <para>The keyword that is used to search for the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:mysql@192.168.XX.XX">mysql@192.168.XX.XX</a>:3306</para>
            /// </summary>
            [NameInMap("SearchName")]
            [Validation(Required=false)]
            public string SearchName { get; set; }

            /// <summary>
            /// <para>The SID of the database.</para>
            /// <remarks>
            /// <para> The value of the parameter is returned only for Oracle databases.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test_sid</para>
            /// </summary>
            [NameInMap("Sid")]
            [Validation(Required=false)]
            public string Sid { get; set; }

            /// <summary>
            /// <para>The status of the database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NORMAL</b>: The database is running as expected.</description></item>
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
        /// <para>An unknown error occurred.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3CDB8601-AD74-4A47-8114-08E08CD6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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

    }

}
