// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20170115.Models
{
    public class UpgradeMinorVersionResponseBody : TeaModel {
        [NameInMap("NewVersion")]
        [Validation(Required=false)]
        public string NewVersion { get; set; }

        [NameInMap("OldVersion")]
        [Validation(Required=false)]
        public string OldVersion { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
