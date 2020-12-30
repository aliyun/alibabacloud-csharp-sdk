// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeUserOnlineClientsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Users")]
        [Validation(Required=false)]
        public DescribeUserOnlineClientsResponseBodyUsers Users { get; set; }
        public class DescribeUserOnlineClientsResponseBodyUsers : TeaModel {
            [NameInMap("User")]
            [Validation(Required=false)]
            public List<DescribeUserOnlineClientsResponseBodyUsersUser> User { get; set; }
            public class DescribeUserOnlineClientsResponseBodyUsersUser : TeaModel {
                public string ClientIp { get; set; }
                public string OnlineTime { get; set; }
            }
        };

    }

}
