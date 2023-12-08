// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class ModifyDBClusterConfigInXMLRequest : TeaModel {
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
