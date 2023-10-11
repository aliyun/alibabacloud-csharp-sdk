// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryOrgHonorsResponseBody : TeaModel {
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("openHonors")]
        [Validation(Required=false)]
        public List<QueryOrgHonorsResponseBodyOpenHonors> OpenHonors { get; set; }
        public class QueryOrgHonorsResponseBodyOpenHonors : TeaModel {
            [NameInMap("honorDesc")]
            [Validation(Required=false)]
            public string HonorDesc { get; set; }

            [NameInMap("honorId")]
            [Validation(Required=false)]
            public long? HonorId { get; set; }

            [NameInMap("honorImgUrl")]
            [Validation(Required=false)]
            public string HonorImgUrl { get; set; }

            [NameInMap("honorName")]
            [Validation(Required=false)]
            public string HonorName { get; set; }

            [NameInMap("honorPendantImgUrl")]
            [Validation(Required=false)]
            public string HonorPendantImgUrl { get; set; }

        }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
