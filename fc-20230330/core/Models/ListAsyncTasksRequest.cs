// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListAsyncTasksRequest : TeaModel {
        [NameInMap("includePayload")]
        [Validation(Required=false)]
        public bool? IncludePayload { get; set; }

        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

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
