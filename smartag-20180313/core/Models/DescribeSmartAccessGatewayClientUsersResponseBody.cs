// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSmartAccessGatewayClientUsersResponseBody : TeaModel {
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
        public DescribeSmartAccessGatewayClientUsersResponseBodyUsers Users { get; set; }
        public class DescribeSmartAccessGatewayClientUsersResponseBodyUsers : TeaModel {
            [NameInMap("User")]
            [Validation(Required=false)]
            public List<DescribeSmartAccessGatewayClientUsersResponseBodyUsersUser> User { get; set; }
            public class DescribeSmartAccessGatewayClientUsersResponseBodyUsersUser : TeaModel {
                [NameInMap("AccelerateBandwidth")]
                [Validation(Required=false)]
                public long? AccelerateBandwidth { get; set; }

                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }

                [NameInMap("ClientIp")]
                [Validation(Required=false)]
                public string ClientIp { get; set; }

                [NameInMap("IsStaticIp")]
                [Validation(Required=false)]
                public long? IsStaticIp { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public int? State { get; set; }

                [NameInMap("UserMail")]
                [Validation(Required=false)]
                public string UserMail { get; set; }

                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

    }

}
