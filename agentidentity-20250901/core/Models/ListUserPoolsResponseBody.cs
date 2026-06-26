// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class ListUserPoolsResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("UserPools")]
        [Validation(Required=false)]
        public List<ListUserPoolsResponseBodyUserPools> UserPools { get; set; }
        public class ListUserPoolsResponseBodyUserPools : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("SourcePlatform")]
            [Validation(Required=false)]
            public string SourcePlatform { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("UserPoolId")]
            [Validation(Required=false)]
            public string UserPoolId { get; set; }

            [NameInMap("UserPoolName")]
            [Validation(Required=false)]
            public string UserPoolName { get; set; }

        }

    }

}
