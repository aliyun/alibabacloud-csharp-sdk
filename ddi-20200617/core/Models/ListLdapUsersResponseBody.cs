// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class ListLdapUsersResponseBody : TeaModel {
        [NameInMap("IsAdmin")]
        [Validation(Required=false)]
        public bool? IsAdmin { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserList")]
        [Validation(Required=false)]
        public ListLdapUsersResponseBodyUserList UserList { get; set; }
        public class ListLdapUsersResponseBodyUserList : TeaModel {
            [NameInMap("User")]
            [Validation(Required=false)]
            public List<ListLdapUsersResponseBodyUserListUser> User { get; set; }
            public class ListLdapUsersResponseBodyUserListUser : TeaModel {
                public long? UserCreateTime { get; set; }
                public string GroupName { get; set; }
                public string UserId { get; set; }
                public string Note { get; set; }
                public string KeytabHex { get; set; }
                public string UserName { get; set; }
            }
        };

    }

}
