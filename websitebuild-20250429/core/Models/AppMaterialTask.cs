// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class AppMaterialTask : TeaModel {
        [NameInMap("CompleteTime")]
        [Validation(Required=false)]
        public string CompleteTime { get; set; }

        [NameInMap("CompleteTimeFormat")]
        [Validation(Required=false)]
        public string CompleteTimeFormat { get; set; }

        [NameInMap("FailReason")]
        [Validation(Required=false)]
        public string FailReason { get; set; }

        [NameInMap("FinalFileUrls")]
        [Validation(Required=false)]
        public List<string> FinalFileUrls { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SubStatus")]
        [Validation(Required=false)]
        public string SubStatus { get; set; }

        [NameInMap("SubmitTime")]
        [Validation(Required=false)]
        public string SubmitTime { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TaskParam")]
        [Validation(Required=false)]
        public string TaskParam { get; set; }

        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
