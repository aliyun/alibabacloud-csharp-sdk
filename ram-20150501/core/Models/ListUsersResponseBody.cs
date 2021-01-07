// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class ListUsersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        [NameInMap("Users")]
        [Validation(Required=false)]
        public ListUsersResponseBodyUsers Users { get; set; }
        public class ListUsersResponseBodyUsers : TeaModel {
            [NameInMap("User")]
            [Validation(Required=false)]
            public List<ListUsersResponseBodyUsersUser> User { get; set; }
            public class ListUsersResponseBodyUsersUser : TeaModel {
                public string DisplayName { get; set; }
                public string Email { get; set; }
                public string UpdateDate { get; set; }
                public string MobilePhone { get; set; }
                public string UserId { get; set; }
                public string Comments { get; set; }
                public string CreateDate { get; set; }
                public string UserName { get; set; }
            }
        };

    }

}
