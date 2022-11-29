// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Serverless20210924.Models
{
    public class TriggerConfig : TeaModel {
        [NameInMap("branch")]
        [Validation(Required=false)]
        public string Branch { get; set; }

        [NameInMap("commit")]
        [Validation(Required=false)]
        public string Commit { get; set; }

        [NameInMap("on")]
        [Validation(Required=false)]
        public string On { get; set; }

    }

}
