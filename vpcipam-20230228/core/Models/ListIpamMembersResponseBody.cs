// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class ListIpamMembersResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("MemberInfos")]
        [Validation(Required=false)]
        public List<ListIpamMembersResponseBodyMemberInfos> MemberInfos { get; set; }
        public class ListIpamMembersResponseBodyMemberInfos : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("MemberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            [NameInMap("MemberType")]
            [Validation(Required=false)]
            public string MemberType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
