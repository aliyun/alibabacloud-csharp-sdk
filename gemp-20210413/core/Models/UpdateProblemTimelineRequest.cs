// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class UpdateProblemTimelineRequest : TeaModel {
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("keyNode")]
        [Validation(Required=false)]
        public string KeyNode { get; set; }

        [NameInMap("problemId")]
        [Validation(Required=false)]
        public long? ProblemId { get; set; }

        [NameInMap("problemTimelineId")]
        [Validation(Required=false)]
        public long? ProblemTimelineId { get; set; }

        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
