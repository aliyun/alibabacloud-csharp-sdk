// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeRdMemberListResponseBody : TeaModel {
        /// <summary>
        /// The list of the members.
        /// </summary>
        [NameInMap("MemberList")]
        [Validation(Required=false)]
        public List<DescribeRdMemberListResponseBodyMemberList> MemberList { get; set; }
        public class DescribeRdMemberListResponseBodyMemberList : TeaModel {
            /// <summary>
            /// The creation time.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// The name of the member.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The Alibaba Cloud account ID of the member.
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
