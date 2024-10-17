// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListInstanceUserPermissionsResponseBody : TeaModel {
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
        /// <para>7D162AAE-6501-5691-BF14-D7018F662895</para>
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
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The permissions of the user on the instance.</para>
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
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>174****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The details of permissions.</para>
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
                        /// <para>XXX</para>
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
                        /// <item><description>LOGIN: the logon permissions</description></item>
                        /// <item><description>PERF: the query permissions on the instance</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>LOGIN</para>
                        /// </summary>
                        [NameInMap("PermType")]
                        [Validation(Required=false)]
                        public string PermType { get; set; }

                        /// <summary>
                        /// <para>The ID of the authorization record.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>773****</para>
                        /// </summary>
                        [NameInMap("UserAccessId")]
                        [Validation(Required=false)]
                        public string UserAccessId { get; set; }

                    }

                }

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
                /// <para>test_nick_name</para>
                /// </summary>
                [NameInMap("UserNickName")]
                [Validation(Required=false)]
                public string UserNickName { get; set; }

            }

        }

    }

}
