// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpgradeClusterAddonsRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<UpgradeClusterAddonsRequestBody> Body { get; set; }
        public class UpgradeClusterAddonsRequestBody : TeaModel {
            [NameInMap("component_name")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            [NameInMap("config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            [NameInMap("next_version")]
            [Validation(Required=false)]
            public string NextVersion { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
