// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class CreateAutoSnapshotPolicyShrinkRequest : TeaModel {
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RepeatWeekdays")]
        [Validation(Required=false)]
        public string RepeatWeekdaysShrink { get; set; }

        [NameInMap("RetentionDays")]
        [Validation(Required=false)]
        public int? RetentionDays { get; set; }

        [NameInMap("TimePoints")]
        [Validation(Required=false)]
        public string TimePointsShrink { get; set; }

    }

}
