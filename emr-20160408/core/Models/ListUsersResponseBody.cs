// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListUsersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserList")]
        [Validation(Required=false)]
        public ListUsersResponseBodyUserList UserList { get; set; }
        public class ListUsersResponseBodyUserList : TeaModel {
            [NameInMap("User")]
            [Validation(Required=false)]
            public List<ListUsersResponseBodyUserListUser> User { get; set; }
            public class ListUsersResponseBodyUserListUser : TeaModel {
                public string LinuxStatus { get; set; }
                public string K8sStatus { get; set; }
                public string KnoxStatus { get; set; }
                public string GroupName { get; set; }
                public string UserId { get; set; }
                public string KerberosStatus { get; set; }
                public string UserName { get; set; }
            }
        };

    }

}
