// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListClusterChecksResponseBody : TeaModel {
        [NameInMap("checks")]
        [Validation(Required=false)]
        public List<ListClusterChecksResponseBodyChecks> Checks { get; set; }
        public class ListClusterChecksResponseBodyChecks : TeaModel {
            [NameInMap("check_id")]
            [Validation(Required=false)]
            public string CheckId { get; set; }

            [NameInMap("created_at")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("finished_at")]
            [Validation(Required=false)]
            public string FinishedAt { get; set; }

            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
