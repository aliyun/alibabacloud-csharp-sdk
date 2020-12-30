// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSmartAccessGatewayClientUsersResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Users")]
        [Validation(Required=false)]
        public DescribeSmartAccessGatewayClientUsersResponseBodyUsers Users { get; set; }
        public class DescribeSmartAccessGatewayClientUsersResponseBodyUsers : TeaModel {
            [NameInMap("User")]
            [Validation(Required=false)]
            public List<DescribeSmartAccessGatewayClientUsersResponseBodyUsersUser> User { get; set; }
            public class DescribeSmartAccessGatewayClientUsersResponseBodyUsersUser : TeaModel {
                public int? Bandwidth { get; set; }
                public int? State { get; set; }
                public string ClientIp { get; set; }
                public string UserName { get; set; }
                public string UserMail { get; set; }
            }
        };

    }

}
