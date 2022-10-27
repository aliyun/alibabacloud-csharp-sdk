// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListUsersResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Users")]
        [Validation(Required=false)]
        public ListUsersResponseBodyUsers Users { get; set; }
        public class ListUsersResponseBodyUsers : TeaModel {
            [NameInMap("UserInfo")]
            [Validation(Required=false)]
            public List<ListUsersResponseBodyUsersUserInfo> UserInfo { get; set; }
            public class ListUsersResponseBodyUsersUserInfo : TeaModel {
                [NameInMap("AddTime")]
                [Validation(Required=false)]
                public string AddTime { get; set; }

                [NameInMap("Group")]
                [Validation(Required=false)]
                public string Group { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

    }

}
