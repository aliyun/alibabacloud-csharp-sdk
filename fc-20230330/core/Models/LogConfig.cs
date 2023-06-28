// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class LogConfig : TeaModel {
        [NameInMap("enableInstanceMetrics")]
        [Validation(Required=false)]
        public bool? EnableInstanceMetrics { get; set; }

        [NameInMap("enableRequestMetrics")]
        [Validation(Required=false)]
        public bool? EnableRequestMetrics { get; set; }

        [NameInMap("logBeginRule")]
        [Validation(Required=false)]
        public string LogBeginRule { get; set; }

        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

    }

}
