// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class SbrainServiceHasRunningTaskBatchQueryShrinkRequest : TeaModel {
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("ReferenceNos")]
        [Validation(Required=false)]
        public string ReferenceNosShrink { get; set; }

        [NameInMap("ReferenceType")]
        [Validation(Required=false)]
        public string ReferenceType { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
