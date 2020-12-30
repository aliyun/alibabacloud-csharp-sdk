// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class UpgradeMultiZoneClusterRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("RunMode")]
        [Validation(Required=false)]
        public string RunMode { get; set; }

        [NameInMap("UpgradeInsName")]
        [Validation(Required=false)]
        public string UpgradeInsName { get; set; }

        [NameInMap("Components")]
        [Validation(Required=false)]
        public string Components { get; set; }

        [NameInMap("Versions")]
        [Validation(Required=false)]
        public string Versions { get; set; }

        [NameInMap("RestartComponents")]
        [Validation(Required=false)]
        public string RestartComponents { get; set; }

    }

}
