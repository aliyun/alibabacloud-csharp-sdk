// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateProblemMeasureRequest : TeaModel {
        [NameInMap("checkStandard")]
        [Validation(Required=false)]
        public string CheckStandard { get; set; }

        [NameInMap("checkUserId")]
        [Validation(Required=false)]
        public long? CheckUserId { get; set; }

        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("directorId")]
        [Validation(Required=false)]
        public long? DirectorId { get; set; }

        [NameInMap("planFinishTime")]
        [Validation(Required=false)]
        public string PlanFinishTime { get; set; }

        [NameInMap("problemId")]
        [Validation(Required=false)]
        public long? ProblemId { get; set; }

        [NameInMap("stalkerId")]
        [Validation(Required=false)]
        public long? StalkerId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
