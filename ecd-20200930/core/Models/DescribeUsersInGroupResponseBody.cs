// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeUsersInGroupResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UsersCount")]
        [Validation(Required=false)]
        public int? UsersCount { get; set; }

        [NameInMap("OnlineUsersCount")]
        [Validation(Required=false)]
        public int? OnlineUsersCount { get; set; }

        [NameInMap("EndUsers")]
        [Validation(Required=false)]
        public List<DescribeUsersInGroupResponseBodyEndUsers> EndUsers { get; set; }
        public class DescribeUsersInGroupResponseBodyEndUsers : TeaModel {
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            [NameInMap("EndUserEmail")]
            [Validation(Required=false)]
            public string EndUserEmail { get; set; }

            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            [NameInMap("ConnectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            [NameInMap("EndUserType")]
            [Validation(Required=false)]
            public string EndUserType { get; set; }

            [NameInMap("EndUserPhone")]
            [Validation(Required=false)]
            public string EndUserPhone { get; set; }

            [NameInMap("EndUserName")]
            [Validation(Required=false)]
            public string EndUserName { get; set; }

        }

    }

}
