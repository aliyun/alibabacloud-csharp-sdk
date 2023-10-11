// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryUserHonorsResponseBody : TeaModel {
        [NameInMap("honors")]
        [Validation(Required=false)]
        public List<QueryUserHonorsResponseBodyHonors> Honors { get; set; }
        public class QueryUserHonorsResponseBodyHonors : TeaModel {
            [NameInMap("expirationTime")]
            [Validation(Required=false)]
            public long? ExpirationTime { get; set; }

            [NameInMap("grantHistory")]
            [Validation(Required=false)]
            public List<QueryUserHonorsResponseBodyHonorsGrantHistory> GrantHistory { get; set; }
            public class QueryUserHonorsResponseBodyHonorsGrantHistory : TeaModel {
                [NameInMap("grantTime")]
                [Validation(Required=false)]
                public long? GrantTime { get; set; }

                [NameInMap("senderUserid")]
                [Validation(Required=false)]
                public string SenderUserid { get; set; }

            }

            [NameInMap("honorDesc")]
            [Validation(Required=false)]
            public string HonorDesc { get; set; }

            [NameInMap("honorId")]
            [Validation(Required=false)]
            public string HonorId { get; set; }

            [NameInMap("honorName")]
            [Validation(Required=false)]
            public string HonorName { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
