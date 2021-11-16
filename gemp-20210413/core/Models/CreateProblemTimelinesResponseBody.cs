// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateProblemTimelinesResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateProblemTimelinesResponseBodyData Data { get; set; }
        public class CreateProblemTimelinesResponseBodyData : TeaModel {
            [NameInMap("problemTimelineIds")]
            [Validation(Required=false)]
            public List<string> ProblemTimelineIds { get; set; }
        };

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
