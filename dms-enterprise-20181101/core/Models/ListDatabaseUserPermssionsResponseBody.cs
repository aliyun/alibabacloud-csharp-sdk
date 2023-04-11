// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDatabaseUserPermssionsResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// The details of user permissions.
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
                /// The alias of the database instance.
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// The name of a column.
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// The ID of the database.
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public string DbId { get; set; }

                /// <summary>
                /// The type of the database engine.
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// The type of resources on which the user has permissions.
                /// </summary>
                [NameInMap("DsType")]
                [Validation(Required=false)]
                public string DsType { get; set; }

                /// <summary>
                /// The type of the environment to which the database belongs.
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// Indicates whether the database is a logical database.
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// The details of user permissions.
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
                        /// The time when the permission was created.
                        /// </summary>
                        [NameInMap("CreateDate")]
                        [Validation(Required=false)]
                        public string CreateDate { get; set; }

                        /// <summary>
                        /// The time when the permissions expire.
                        /// </summary>
                        [NameInMap("ExpireDate")]
                        [Validation(Required=false)]
                        public string ExpireDate { get; set; }

                        /// <summary>
                        /// The extra information. This parameter is reserved.
                        /// </summary>
                        [NameInMap("ExtraData")]
                        [Validation(Required=false)]
                        public string ExtraData { get; set; }

                        /// <summary>
                        /// The description of the entity that authorizes the permission.
                        /// </summary>
                        [NameInMap("OriginFrom")]
                        [Validation(Required=false)]
                        public string OriginFrom { get; set; }

                        /// <summary>
                        /// The type of the permission. Valid values:
                        /// 
                        /// *   QUERY: the query permissions
                        /// *   EXPORT: the export permissions
                        /// *   CORRECT: the change permissions
                        /// </summary>
                        [NameInMap("PermType")]
                        [Validation(Required=false)]
                        public string PermType { get; set; }

                        /// <summary>
                        /// The ID of the authorization record.
                        /// </summary>
                        [NameInMap("UserAccessId")]
                        [Validation(Required=false)]
                        public string UserAccessId { get; set; }

                    }

                }

                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// The name that is used to search for the database.
                /// </summary>
                [NameInMap("SearchName")]
                [Validation(Required=false)]
                public string SearchName { get; set; }

                /// <summary>
                /// The ID of the table.
                /// </summary>
                [NameInMap("TableId")]
                [Validation(Required=false)]
                public string TableId { get; set; }

                /// <summary>
                /// The name of the table.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// The ID of the user.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// The nickname of the user.
                /// </summary>
                [NameInMap("UserNickName")]
                [Validation(Required=false)]
                public string UserNickName { get; set; }

            }

        }

    }

}
