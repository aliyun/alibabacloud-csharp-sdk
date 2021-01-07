// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class ListUsersForGroupResponseBody : TeaModel {
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
        public ListUsersForGroupResponseBodyUsers Users { get; set; }
        public class ListUsersForGroupResponseBodyUsers : TeaModel {
            [NameInMap("User")]
            [Validation(Required=false)]
            public List<ListUsersForGroupResponseBodyUsersUser> User { get; set; }
            public class ListUsersForGroupResponseBodyUsersUser : TeaModel {
                public string DisplayName { get; set; }
                public string JoinDate { get; set; }
                public string UserName { get; set; }
            }
        };

    }

}
