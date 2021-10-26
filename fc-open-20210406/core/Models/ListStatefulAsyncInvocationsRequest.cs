// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListStatefulAsyncInvocationsRequest : TeaModel {
        [NameInMap("includePayload")]
        [Validation(Required=false)]
        public bool? IncludePayload { get; set; }

        [NameInMap("invocationIdPrefix")]
        [Validation(Required=false)]
        public string InvocationIdPrefix { get; set; }

        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        [NameInMap("sortOrderByTime")]
        [Validation(Required=false)]
        public string SortOrderByTime { get; set; }

        [NameInMap("startedTimeBegin")]
        [Validation(Required=false)]
        public long? StartedTimeBegin { get; set; }

        [NameInMap("startedTimeEnd")]
        [Validation(Required=false)]
        public long? StartedTimeEnd { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
