// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListAuthorizedDatabasesForUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The names of the databases on which the user has permissions.</para>
        /// </summary>
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<ListAuthorizedDatabasesForUserResponseBodyDatabases> Databases { get; set; }
        public class ListAuthorizedDatabasesForUserResponseBodyDatabases : TeaModel {
            /// <summary>
            /// <para>The database ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>254****</para>
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public string DbId { get; set; }

            /// <summary>
            /// <para>The engine of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MYSQL</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// <para>The type of the environment in which the database instance is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>product</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>235****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Indicates whether the database is a logical database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true.</b>: The database is a logical database</description></item>
            /// <item><description><b>false</b>: The database is a physical database.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Logic")]
            [Validation(Required=false)]
            public bool? Logic { get; set; }

            /// <summary>
            /// <para>The details of permissions. The format of the permission details varies with the permission source. For example, if the permission source is a normal permission, the following parameters are returned.</para>
            /// </summary>
            [NameInMap("PermissionDetail")]
            [Validation(Required=false)]
            public ListAuthorizedDatabasesForUserResponseBodyDatabasesPermissionDetail PermissionDetail { get; set; }
            public class ListAuthorizedDatabasesForUserResponseBodyDatabasesPermissionDetail : TeaModel {
                /// <summary>
                /// <para>The type of object on which the operation is performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DATABASE</para>
                /// </summary>
                [NameInMap("DsType")]
                [Validation(Required=false)]
                public string DsType { get; set; }

                /// <summary>
                /// <para>The time when the permissions expire.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-12-06 10:00:00</para>
                /// </summary>
                [NameInMap("ExpireDate")]
                [Validation(Required=false)]
                public string ExpireDate { get; set; }

                /// <summary>
                /// <para>If the permission source is a permission policy, the value of this parameter includes the policy name and the operations that are allowed for the user.</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The type of the permission. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>QUERY</b>: the query permission</description></item>
                /// <item><description><b>EXPORT</b>: the data export permission</description></item>
                /// <item><description><b>CORRECT</b>: the data change permission</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CORRECT</para>
                /// </summary>
                [NameInMap("PermType")]
                [Validation(Required=false)]
                public string PermType { get; set; }

            }

            /// <summary>
            /// <para>The database name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>poc_testdb</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <para>The name that is used to search for the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>poc</para>
            /// </summary>
            [NameInMap("SearchName")]
            [Validation(Required=false)]
            public string SearchName { get; set; }

            /// <summary>
            /// <para>The user IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>51****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use the ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>012AE0B5-4B52-532F-BD7C-1EE9F182089B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
