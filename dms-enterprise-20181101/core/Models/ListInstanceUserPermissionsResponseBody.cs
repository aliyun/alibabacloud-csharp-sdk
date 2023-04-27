// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListInstanceUserPermissionsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the authorization record.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **ListInstanceUserPermissions**.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The nickname of the user.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("UserPermissions")]
        [Validation(Required=false)]
        public ListInstanceUserPermissionsResponseBodyUserPermissions UserPermissions { get; set; }
        public class ListInstanceUserPermissionsResponseBodyUserPermissions : TeaModel {
            [NameInMap("UserPermission")]
            [Validation(Required=false)]
            public List<ListInstanceUserPermissionsResponseBodyUserPermissionsUserPermission> UserPermission { get; set; }
            public class ListInstanceUserPermissionsResponseBodyUserPermissionsUserPermission : TeaModel {
                /// <summary>
                /// The details of permissions.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The number of the page to return.
                /// </summary>
                [NameInMap("PermDetails")]
                [Validation(Required=false)]
                public ListInstanceUserPermissionsResponseBodyUserPermissionsUserPermissionPermDetails PermDetails { get; set; }
                public class ListInstanceUserPermissionsResponseBodyUserPermissionsUserPermissionPermDetails : TeaModel {
                    [NameInMap("PermDetail")]
                    [Validation(Required=false)]
                    public List<ListInstanceUserPermissionsResponseBodyUserPermissionsUserPermissionPermDetailsPermDetail> PermDetail { get; set; }
                    public class ListInstanceUserPermissionsResponseBodyUserPermissionsUserPermissionPermDetailsPermDetail : TeaModel {
                        /// <summary>
                        /// Queries the permissions of a user on a specific instance.
                        /// </summary>
                        [NameInMap("CreateDate")]
                        [Validation(Required=false)]
                        public string CreateDate { get; set; }

                        /// <summary>
                        /// The ID of the request.
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
                        /// *   LOGIN: the logon permissions
                        /// *   PERF: the query permissions on the instance
                        /// </summary>
                        [NameInMap("OriginFrom")]
                        [Validation(Required=false)]
                        public string OriginFrom { get; set; }

                        /// <summary>
                        /// The time when the permissions were granted.
                        /// </summary>
                        [NameInMap("PermType")]
                        [Validation(Required=false)]
                        public string PermType { get; set; }

                        [NameInMap("UserAccessId")]
                        [Validation(Required=false)]
                        public string UserAccessId { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the tenant.
                /// 
                /// >  To view the ID of the tenant, move the pointer over the profile picture in the upper-right corner of the Data Management (DMS) console. For more information, see the "View information about the current tenant" section of the [Manage DMS tenants](~~181330~~) topic.
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
