// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetUserResponseBody : TeaModel {
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

        [NameInMap("User")]
        [Validation(Required=false)]
        public GetUserResponseBodyUser User { get; set; }
        public class GetUserResponseBodyUser : TeaModel {
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
            public long? ParentUid { get; set; }

            [NameInMap("RoleIdList")]
            [Validation(Required=false)]
            public GetUserResponseBodyUserRoleIdList RoleIdList { get; set; }
            public class GetUserResponseBodyUserRoleIdList : TeaModel {
                [NameInMap("RoleIds")]
                [Validation(Required=false)]
                public List<int?> RoleIds { get; set; }

            }

            [NameInMap("RoleNameList")]
            [Validation(Required=false)]
            public GetUserResponseBodyUserRoleNameList RoleNameList { get; set; }
            public class GetUserResponseBodyUserRoleNameList : TeaModel {
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
