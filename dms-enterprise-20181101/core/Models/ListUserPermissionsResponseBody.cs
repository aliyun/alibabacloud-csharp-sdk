// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListUserPermissionsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the user. You can call the [GetUser](~~147098~~) or [ListUsers](~~141938~~) operation to query the ID of the user.
        /// 
        /// >  The user ID is different from the ID of your Alibaba Cloud account.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The type of the environment to which the database belongs. Valid values:
        /// 
        /// *   product: production environment
        /// *   dev: development environment
        /// *   pre: staging environment
        /// *   test: test environment
        /// *   sit: SIT environment
        /// *   uat: user acceptance testing (UAT) environment
        /// *   pet: stress testing environment
        /// *   stag: STAG environment
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The details of the permissions that the user has.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The permissions on a specific type of resources that you want to query. Valid values:
        /// 
        /// *   DATABASE: permissions on databases
        /// *   TABLE: permissions on tables
        /// *   COLUMN: permissions on fields
        /// *   INSTANCE: permissions on instances
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// Indicates whether the database is a logical database. Valid values:
        /// 
        /// *   true: The database is a logical database.
        /// *   false: The database is a physical database.
        /// </summary>
        [NameInMap("UserPermissions")]
        [Validation(Required=false)]
        public ListUserPermissionsResponseBodyUserPermissions UserPermissions { get; set; }
        public class ListUserPermissionsResponseBodyUserPermissions : TeaModel {
            [NameInMap("UserPermission")]
            [Validation(Required=false)]
            public List<ListUserPermissionsResponseBodyUserPermissionsUserPermission> UserPermission { get; set; }
            public class ListUserPermissionsResponseBodyUserPermissionsUserPermission : TeaModel {
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// The user who grants the permissions.
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public string DbId { get; set; }

                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                [NameInMap("DsType")]
                [Validation(Required=false)]
                public string DsType { get; set; }

                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// The details of permissions.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The number of the page to return.
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("PermDetails")]
                [Validation(Required=false)]
                public ListUserPermissionsResponseBodyUserPermissionsUserPermissionPermDetails PermDetails { get; set; }
                public class ListUserPermissionsResponseBodyUserPermissionsUserPermissionPermDetails : TeaModel {
                    [NameInMap("PermDetail")]
                    [Validation(Required=false)]
                    public List<ListUserPermissionsResponseBodyUserPermissionsUserPermissionPermDetailsPermDetail> PermDetail { get; set; }
                    public class ListUserPermissionsResponseBodyUserPermissionsUserPermissionPermDetailsPermDetail : TeaModel {
                        [NameInMap("CreateDate")]
                        [Validation(Required=false)]
                        public string CreateDate { get; set; }

                        /// <summary>
                        /// Queries the permissions of a specific user on a database or a table.
                        /// </summary>
                        [NameInMap("ExpireDate")]
                        [Validation(Required=false)]
                        public string ExpireDate { get; set; }

                        [NameInMap("ExtraData")]
                        [Validation(Required=false)]
                        public string ExtraData { get; set; }

                        /// <summary>
                        /// The type of the permissions. Valid values:
                        /// 
                        /// *   QUERY: the query permissions
                        /// *   EXPORT: the export permissions
                        /// *   CORRECT: the change permissions
                        /// </summary>
                        [NameInMap("OriginFrom")]
                        [Validation(Required=false)]
                        public string OriginFrom { get; set; }

                        /// <summary>
                        /// The ID of the request.
                        /// </summary>
                        [NameInMap("PermType")]
                        [Validation(Required=false)]
                        public string PermType { get; set; }

                        [NameInMap("UserAccessId")]
                        [Validation(Required=false)]
                        public string UserAccessId { get; set; }

                    }

                }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public long? Port { get; set; }

                /// <summary>
                /// The error message.
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                [NameInMap("SearchName")]
                [Validation(Required=false)]
                public string SearchName { get; set; }

                [NameInMap("TableId")]
                [Validation(Required=false)]
                public string TableId { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// The ID of the user.
                /// </summary>
                [NameInMap("UserNickName")]
                [Validation(Required=false)]
                public string UserNickName { get; set; }

            }

        }

    }

}
