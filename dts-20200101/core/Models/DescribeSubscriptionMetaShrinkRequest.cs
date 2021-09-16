// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeSubscriptionMetaShrinkRequest : TeaModel {
        [NameInMap("Sid")]
        [Validation(Required=false)]
        public string Sid { get; set; }

        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        [NameInMap("SubMigrationJobIds")]
        [Validation(Required=false)]
        public string SubMigrationJobIdsShrink { get; set; }

        [NameInMap("Topics")]
        [Validation(Required=false)]
        public string TopicsShrink { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
