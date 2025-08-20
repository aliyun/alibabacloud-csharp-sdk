// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ArtifactLifecyclePolicy : TeaModel {
        [NameInMap("Condition")]
        [Validation(Required=false)]
        public ArtifactLifecyclePolicyCondition Condition { get; set; }
        public class ArtifactLifecyclePolicyCondition : TeaModel {
            [NameInMap("LastPullOlderThanDays")]
            [Validation(Required=false)]
            public int? LastPullOlderThanDays { get; set; }

            [NameInMap("LastPushOlderThanDays")]
            [Validation(Required=false)]
            public int? LastPushOlderThanDays { get; set; }

            [NameInMap("LatestTagCount")]
            [Validation(Required=false)]
            public int? LatestTagCount { get; set; }

        }

        [NameInMap("Filter")]
        [Validation(Required=false)]
        public ArtifactLifecyclePolicyFilter Filter { get; set; }
        public class ArtifactLifecyclePolicyFilter : TeaModel {
            [NameInMap("TagWildcard")]
            [Validation(Required=false)]
            public string TagWildcard { get; set; }

        }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
