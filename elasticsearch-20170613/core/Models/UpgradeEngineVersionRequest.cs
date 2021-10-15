// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpgradeEngineVersionRequest : TeaModel {
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
