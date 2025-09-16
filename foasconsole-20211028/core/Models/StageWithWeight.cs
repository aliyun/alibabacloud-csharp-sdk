// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class StageWithWeight : TeaModel {
        [NameInMap("StepIndex")]
        [Validation(Required=false)]
        public int? StepIndex { get; set; }

        [NameInMap("StepName")]
        [Validation(Required=false)]
        public string StepName { get; set; }

        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

    }

}
