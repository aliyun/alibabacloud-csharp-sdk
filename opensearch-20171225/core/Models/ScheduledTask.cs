// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ScheduledTask : TeaModel {
        [NameInMap("autoSwitch")]
        [Validation(Required=false)]
        public bool? AutoSwitch { get; set; }

        [NameInMap("cron")]
        [Validation(Required=false)]
        public string Cron { get; set; }

        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        [NameInMap("filter")]
        [Validation(Required=false)]
        public ScheduledTaskFilter Filter { get; set; }
        public class ScheduledTaskFilter : TeaModel {
            [NameInMap("days")]
            [Validation(Required=false)]
            public int? Days { get; set; }

            [NameInMap("expression")]
            [Validation(Required=false)]
            public string Expression { get; set; }

            [NameInMap("field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        [NameInMap("forkedAppId")]
        [Validation(Required=false)]
        public string ForkedAppId { get; set; }

        [NameInMap("permanent")]
        [Validation(Required=false)]
        public bool? Permanent { get; set; }

        [NameInMap("runNow")]
        [Validation(Required=false)]
        public bool? RunNow { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
