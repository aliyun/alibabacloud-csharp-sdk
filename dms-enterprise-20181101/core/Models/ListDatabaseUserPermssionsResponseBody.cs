// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDatabaseUserPermssionsResponseBody : TeaModel {
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
        /// <para>68075D06-7406-4887-83A7-F558A4D28C13</para>
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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The details of user permissions.</para>
        /// </summary>
        [NameInMap("UserPermissions")]
        [Validation(Required=false)]
        public ListDatabaseUserPermssionsResponseBodyUserPermissions UserPermissions { get; set; }
        public class ListDatabaseUserPermssionsResponseBodyUserPermissions : TeaModel {
            [NameInMap("UserPermission")]
            [Validation(Required=false)]
            public List<ListDatabaseUserPermssionsResponseBodyUserPermissionsUserPermission> UserPermission { get; set; }
            public class ListDatabaseUserPermssionsResponseBodyUserPermissionsUserPermission : TeaModel {
                /// <summary>
                /// <para>The alias of the database instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instance_alias</para>
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// <para>The name of a column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>column_name</para>
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// <para>The ID of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public string DbId { get; set; }

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
                /// <para>The type of resources on which the user has permissions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DATABASE</para>
                /// </summary>
                [NameInMap("DsType")]
                [Validation(Required=false)]
                public string DsType { get; set; }

                /// <summary>
                /// <para>The type of the environment to which the database belongs.</para>
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
                /// <para>1443</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Indicates whether the database is a logical database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// <para>The details of user permissions.</para>
                /// </summary>
                [NameInMap("PermDetails")]
                [Validation(Required=false)]
                public ListDatabaseUserPermssionsResponseBodyUserPermissionsUserPermissionPermDetails PermDetails { get; set; }
                public class ListDatabaseUserPermssionsResponseBodyUserPermissionsUserPermissionPermDetails : TeaModel {
                    [NameInMap("PermDetail")]
                    [Validation(Required=false)]
                    public List<ListDatabaseUserPermssionsResponseBodyUserPermissionsUserPermissionPermDetailsPermDetail> PermDetail { get; set; }
                    public class ListDatabaseUserPermssionsResponseBodyUserPermissionsUserPermissionPermDetailsPermDetail : TeaModel {
                        /// <summary>
                        /// <para>The time when the permission was created.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2019-12-12 00:00:00</para>
                        /// </summary>
                        [NameInMap("CreateDate")]
                        [Validation(Required=false)]
                        public string CreateDate { get; set; }

                        /// <summary>
                        /// <para>The time when the permissions expire.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2020-12-12 00:00:00</para>
                        /// </summary>
                        [NameInMap("ExpireDate")]
                        [Validation(Required=false)]
                        public string ExpireDate { get; set; }

                        /// <summary>
                        /// <para>The extra information. This parameter is reserved.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>DEFAULT</para>
                        /// </summary>
                        [NameInMap("ExtraData")]
                        [Validation(Required=false)]
                        public string ExtraData { get; set; }

                        /// <summary>
                        /// <para>The description of the entity that authorizes the permission.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xxx grant</para>
                        /// </summary>
                        [NameInMap("OriginFrom")]
                        [Validation(Required=false)]
                        public string OriginFrom { get; set; }

                        /// <summary>
                        /// <para>The type of the permission. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>QUERY: the query permissions</description></item>
                        /// <item><description>EXPORT: the export permissions</description></item>
                        /// <item><description>CORRECT: the change permissions</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>QUERY</para>
                        /// </summary>
                        [NameInMap("PermType")]
                        [Validation(Required=false)]
                        public string PermType { get; set; }

                        /// <summary>
                        /// <para>The ID of the authorization record.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>13434</para>
                        /// </summary>
                        [NameInMap("UserAccessId")]
                        [Validation(Required=false)]
                        public string UserAccessId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx@xxxx:3306</para>
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// <para>The name that is used to search for the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("SearchName")]
                [Validation(Required=false)]
                public string SearchName { get; set; }

                /// <summary>
                /// <para>The ID of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>42345</para>
                /// </summary>
                [NameInMap("TableId")]
                [Validation(Required=false)]
                public string TableId { get; set; }

                /// <summary>
                /// <para>The name of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table_name</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <para>The ID of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>14324</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The nickname of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user_nick_name</para>
                /// </summary>
                [NameInMap("UserNickName")]
                [Validation(Required=false)]
                public string UserNickName { get; set; }

            }

        }

    }

}
