// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListUsersResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

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
                public long? CurExecuteCount { get; set; }
                public long? CurResultCount { get; set; }
                public string DingRobot { get; set; }
                public string Email { get; set; }
                public string LastLoginTime { get; set; }
                public long? MaxExecuteCount { get; set; }
                public long? MaxResultCount { get; set; }
                public string Mobile { get; set; }
                public string NickName { get; set; }
                public string NotificationMode { get; set; }
                public string ParentUid { get; set; }
                public ListUsersResponseBodyUserListUserRoleIdList RoleIdList { get; set; }
                public class ListUsersResponseBodyUserListUserRoleIdList : TeaModel {
                    [NameInMap("RoleIds")]
                    [Validation(Required=false)]
                    public List<int?> RoleIds { get; set; }

                }
                public ListUsersResponseBodyUserListUserRoleNameList RoleNameList { get; set; }
                public class ListUsersResponseBodyUserListUserRoleNameList : TeaModel {
                    [NameInMap("RoleNames")]
                    [Validation(Required=false)]
                    public List<string> RoleNames { get; set; }

                }
                public string SignatureMethod { get; set; }
                public string State { get; set; }
                public string Uid { get; set; }
                public string UserId { get; set; }
                public string Webhook { get; set; }
            }
        };

    }

}
