// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class SLSTriggerLogConfig : TeaModel {
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

    }

}
