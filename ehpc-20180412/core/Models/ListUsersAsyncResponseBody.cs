// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListUsersAsyncResponseBody : TeaModel {
        [NameInMap("AsyncId")]
        [Validation(Required=false)]
        public string AsyncId { get; set; }

        [NameInMap("AsyncStatus")]
        [Validation(Required=false)]
        public string AsyncStatus { get; set; }

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
        public ListUsersAsyncResponseBodyUsers Users { get; set; }
        public class ListUsersAsyncResponseBodyUsers : TeaModel {
            [NameInMap("UserInfo")]
            [Validation(Required=false)]
            public List<ListUsersAsyncResponseBodyUsersUserInfo> UserInfo { get; set; }
            public class ListUsersAsyncResponseBodyUsersUserInfo : TeaModel {
                [NameInMap("AddTime")]
                [Validation(Required=false)]
                public string AddTime { get; set; }

                [NameInMap("Group")]
                [Validation(Required=false)]
                public string Group { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
