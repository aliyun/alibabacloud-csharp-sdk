// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidTid</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Specified parameter Tid is not valid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69161997-6030-53BA-A333-DBEC83B732FF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
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
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("UserList")]
        [Validation(Required=false)]
        public ListUsersResponseBodyUserList UserList { get; set; }
        public class ListUsersResponseBodyUserList : TeaModel {
            [NameInMap("User")]
            [Validation(Required=false)]
            public List<ListUsersResponseBodyUserListUser> User { get; set; }
            public class ListUsersResponseBodyUserListUser : TeaModel {
                [NameInMap("CurExecuteCount")]
                [Validation(Required=false)]
                public long? CurExecuteCount { get; set; }

                [NameInMap("CurResultCount")]
                [Validation(Required=false)]
                public long? CurResultCount { get; set; }

                [NameInMap("DingRobot")]
                [Validation(Required=false)]
                public string DingRobot { get; set; }

                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("LastLoginTime")]
                [Validation(Required=false)]
                public string LastLoginTime { get; set; }

                [NameInMap("MaxExecuteCount")]
                [Validation(Required=false)]
                public long? MaxExecuteCount { get; set; }

                [NameInMap("MaxResultCount")]
                [Validation(Required=false)]
                public long? MaxResultCount { get; set; }

                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                [NameInMap("NotificationMode")]
                [Validation(Required=false)]
                public string NotificationMode { get; set; }

                [NameInMap("ParentUid")]
                [Validation(Required=false)]
                public string ParentUid { get; set; }

                [NameInMap("RoleIdList")]
                [Validation(Required=false)]
                public ListUsersResponseBodyUserListUserRoleIdList RoleIdList { get; set; }
                public class ListUsersResponseBodyUserListUserRoleIdList : TeaModel {
                    [NameInMap("RoleIds")]
                    [Validation(Required=false)]
                    public List<int?> RoleIds { get; set; }

                }

                [NameInMap("RoleNameList")]
                [Validation(Required=false)]
                public ListUsersResponseBodyUserListUserRoleNameList RoleNameList { get; set; }
                public class ListUsersResponseBodyUserListUserRoleNameList : TeaModel {
                    [NameInMap("RoleNames")]
                    [Validation(Required=false)]
                    public List<string> RoleNames { get; set; }

                }

                [NameInMap("SignatureMethod")]
                [Validation(Required=false)]
                public string SignatureMethod { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("Webhook")]
                [Validation(Required=false)]
                public string Webhook { get; set; }

            }

        }

    }

}
