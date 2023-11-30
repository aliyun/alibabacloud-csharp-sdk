// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ExternalMultiFileRevisionConfig : TeaModel {
        [NameInMap("revision_count")]
        [Validation(Required=false)]
        public long? RevisionCount { get; set; }

        [NameInMap("revision_merge_enabled")]
        [Validation(Required=false)]
        public bool? RevisionMergeEnabled { get; set; }

        [NameInMap("revision_recycle_period")]
        [Validation(Required=false)]
        public long? RevisionRecyclePeriod { get; set; }

    }

}
