// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListUserPermissionsResponseBody : TeaModel {
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
        /// <para>C51420E3-144A-4A94-B473-8662FCF4AD10</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The details of the permissions that the user has.</para>
        /// </summary>
        [NameInMap("UserPermissions")]
        [Validation(Required=false)]
        public ListUserPermissionsResponseBodyUserPermissions UserPermissions { get; set; }
        public class ListUserPermissionsResponseBodyUserPermissions : TeaModel {
            [NameInMap("UserPermission")]
            [Validation(Required=false)]
            public List<ListUserPermissionsResponseBodyUserPermissionsUserPermission> UserPermission { get; set; }
            public class ListUserPermissionsResponseBodyUserPermissionsUserPermission : TeaModel {
                /// <summary>
                /// <para>The alias of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instance_alias</para>
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// <para>The name of the field.</para>
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
                /// <para>1860****</para>
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public string DbId { get; set; }

                /// <summary>
                /// <para>The type of the database. For more information about the valid values of this parameter, see <a href="https://www.alibabacloud.com/help/en/data-management-service/latest/dbtype-parameter">DbType parameter</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>polardb</para>
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// <para>The permissions on a specific type of objects that are granted to the user. Valid values: </para>
                /// <list type="bullet">
                /// <item><description>DATABASE: permissions on physical databases</description></item>
                /// <item><description>LOGIC_DATABASE: permissions on logical databases</description></item>
                /// <item><description>TABLE: permissions on physical tables</description></item>
                /// <item><description>LOGIC_TABLE: permissions on logical tables</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DATABASE</para>
                /// </summary>
                [NameInMap("DsType")]
                [Validation(Required=false)]
                public string DsType { get; set; }

                /// <summary>
                /// <para>The type of the environment to which the database belongs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>product: production environment</description></item>
                /// <item><description>dev: development environment</description></item>
                /// <item><description>pre: staging environment</description></item>
                /// <item><description>test: test environment</description></item>
                /// <item><description>sit: SIT environment</description></item>
                /// <item><description>uat: UAT environment</description></item>
                /// <item><description>pet: stress testing environment</description></item>
                /// <item><description>stag: STAG environment</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>dev</para>
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// <para>The endpoint that is used to connect the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-bp144d5ky4l4r****</para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>174****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Indicates whether the database is a logical database. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The database is a logical database.</description></item>
                /// <item><description>false: The database is a physical database.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// <para>The details of permissions.</para>
                /// </summary>
                [NameInMap("PermDetails")]
                [Validation(Required=false)]
                public ListUserPermissionsResponseBodyUserPermissionsUserPermissionPermDetails PermDetails { get; set; }
                public class ListUserPermissionsResponseBodyUserPermissionsUserPermissionPermDetails : TeaModel {
                    [NameInMap("PermDetail")]
                    [Validation(Required=false)]
                    public List<ListUserPermissionsResponseBodyUserPermissionsUserPermissionPermDetailsPermDetail> PermDetail { get; set; }
                    public class ListUserPermissionsResponseBodyUserPermissionsUserPermissionPermDetailsPermDetail : TeaModel {
                        /// <summary>
                        /// <para>The time when the permissions were granted.</para>
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
                        /// <para>This parameter is reserved.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xxx</para>
                        /// </summary>
                        [NameInMap("ExtraData")]
                        [Validation(Required=false)]
                        public string ExtraData { get; set; }

                        /// <summary>
                        /// <para>The user who grants the permissions.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xxx authorization</para>
                        /// </summary>
                        [NameInMap("OriginFrom")]
                        [Validation(Required=false)]
                        public string OriginFrom { get; set; }

                        /// <summary>
                        /// <para>The type of the permissions. Valid values:</para>
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
                        /// <para>758****</para>
                        /// </summary>
                        [NameInMap("UserAccessId")]
                        [Validation(Required=false)]
                        public string UserAccessId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The port that is used to connect to the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public long? Port { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_db</para>
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// <para>The name that is used to search for the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_db@xxx:3306</para>
                /// </summary>
                [NameInMap("SearchName")]
                [Validation(Required=false)]
                public string SearchName { get; set; }

                /// <summary>
                /// <para>The ID of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13434</para>
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
                /// <para>The ID of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>51****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The nickname of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nick_name</para>
                /// </summary>
                [NameInMap("UserNickName")]
                [Validation(Required=false)]
                public string UserNickName { get; set; }

            }

        }

    }

}
