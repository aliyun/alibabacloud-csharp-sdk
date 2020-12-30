// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDatabaseUserPermssionsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("UserPermissions")]
        [Validation(Required=false)]
        public ListDatabaseUserPermssionsResponseBodyUserPermissions UserPermissions { get; set; }
        public class ListDatabaseUserPermssionsResponseBodyUserPermissions : TeaModel {
            [NameInMap("UserPermission")]
            [Validation(Required=false)]
            public List<ListDatabaseUserPermssionsResponseBodyUserPermissionsUserPermission> UserPermission { get; set; }
            public class ListDatabaseUserPermssionsResponseBodyUserPermissionsUserPermission : TeaModel {
                public string DbId { get; set; }
                public string TableName { get; set; }
                public string UserId { get; set; }
                public string SchemaName { get; set; }
                public bool? Logic { get; set; }
                public string UserNickName { get; set; }
                public string InstanceId { get; set; }
                public ListDatabaseUserPermssionsResponseBodyUserPermissionsUserPermissionPermDetails PermDetails { get; set; }
                public class ListDatabaseUserPermssionsResponseBodyUserPermissionsUserPermissionPermDetails : TeaModel {
                    [NameInMap("PermDetail")]
                    [Validation(Required=false)]
                    public List<ListDatabaseUserPermssionsResponseBodyUserPermissionsUserPermissionPermDetailsPermDetail> PermDetail { get; set; }
                    public class ListDatabaseUserPermssionsResponseBodyUserPermissionsUserPermissionPermDetailsPermDetail : TeaModel {
                        [NameInMap("OriginFrom")]
                        [Validation(Required=false)]
                        public string OriginFrom { get; set; }

                        [NameInMap("PermType")]
                        [Validation(Required=false)]
                        public string PermType { get; set; }

                        [NameInMap("ExpireDate")]
                        [Validation(Required=false)]
                        public string ExpireDate { get; set; }

                        [NameInMap("CreateDate")]
                        [Validation(Required=false)]
                        public string CreateDate { get; set; }

                        [NameInMap("UserAccessId")]
                        [Validation(Required=false)]
                        public string UserAccessId { get; set; }

                        [NameInMap("ExtraData")]
                        [Validation(Required=false)]
                        public string ExtraData { get; set; }

                    }

                }
                public string EnvType { get; set; }
                public string ColumnName { get; set; }
                public string DbType { get; set; }
                public string DsType { get; set; }
                public string TableId { get; set; }
                public string SearchName { get; set; }
                public string Alias { get; set; }
            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
