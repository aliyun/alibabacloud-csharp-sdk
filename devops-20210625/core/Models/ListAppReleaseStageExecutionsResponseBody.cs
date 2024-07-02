// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListAppReleaseStageExecutionsResponseBody : TeaModel {
        [NameInMap("current")]
        [Validation(Required=false)]
        public long? Current { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListAppReleaseStageExecutionsResponseBodyData> Data { get; set; }
        public class ListAppReleaseStageExecutionsResponseBodyData : TeaModel {
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("number")]
            [Validation(Required=false)]
            public string Number { get; set; }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("triggerMode")]
            [Validation(Required=false)]
            public string TriggerMode { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("pages")]
        [Validation(Required=false)]
        public long? Pages { get; set; }

        [NameInMap("perPage")]
        [Validation(Required=false)]
        public long? PerPage { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
