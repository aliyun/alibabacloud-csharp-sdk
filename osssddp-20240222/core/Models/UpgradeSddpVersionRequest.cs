// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OssSddp20240222.Models
{
    public class UpgradeSddpVersionRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OssVersion")]
        [Validation(Required=false)]
        public int? OssVersion { get; set; }

    }

}
