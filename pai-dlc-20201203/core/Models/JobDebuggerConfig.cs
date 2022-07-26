// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class JobDebuggerConfig : TeaModel {
        [NameInMap("DebuggerConfigContent")]
        [Validation(Required=false)]
        public string DebuggerConfigContent { get; set; }

        [NameInMap("DebuggerConfigId")]
        [Validation(Required=false)]
        public string DebuggerConfigId { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

    }

}
