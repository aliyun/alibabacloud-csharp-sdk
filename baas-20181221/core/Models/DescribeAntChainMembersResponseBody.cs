// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeAntChainMembersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAntChainMembersResponseBodyResult Result { get; set; }
        public class DescribeAntChainMembersResponseBodyResult : TeaModel {
            [NameInMap("Members")]
            [Validation(Required=false)]
            public List<DescribeAntChainMembersResponseBodyResultMembers> Members { get; set; }
            public class DescribeAntChainMembersResponseBodyResultMembers : TeaModel {
                public string Status { get; set; }
                public string MemberName { get; set; }
                public long? JoinTime { get; set; }
                public string MemberId { get; set; }
                public string Role { get; set; }
            }
            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public DescribeAntChainMembersResponseBodyResultPagination Pagination { get; set; }
            public class DescribeAntChainMembersResponseBodyResultPagination : TeaModel {
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("PageNumber")]
                [Validation(Required=false)]
                public int? PageNumber { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }
        };

    }

}
