// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeAntChainSubnetMemberListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAntChainSubnetMemberListResponseBodyResult Result { get; set; }
        public class DescribeAntChainSubnetMemberListResponseBodyResult : TeaModel {
            [NameInMap("ConsortiumAdmin")]
            [Validation(Required=false)]
            public bool? ConsortiumAdmin { get; set; }

            [NameInMap("ConsortiumMemberInfoList")]
            [Validation(Required=false)]
            public List<DescribeAntChainSubnetMemberListResponseBodyResultConsortiumMemberInfoList> ConsortiumMemberInfoList { get; set; }
            public class DescribeAntChainSubnetMemberListResponseBodyResultConsortiumMemberInfoList : TeaModel {
                [NameInMap("JoinTime")]
                [Validation(Required=false)]
                public long? JoinTime { get; set; }

                [NameInMap("MemberId")]
                [Validation(Required=false)]
                public string MemberId { get; set; }

                [NameInMap("MemberName")]
                [Validation(Required=false)]
                public string MemberName { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public DescribeAntChainSubnetMemberListResponseBodyResultPagination Pagination { get; set; }
            public class DescribeAntChainSubnetMemberListResponseBodyResultPagination : TeaModel {
                [NameInMap("PageNumber")]
                [Validation(Required=false)]
                public long? PageNumber { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public long? PageSize { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

        }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
