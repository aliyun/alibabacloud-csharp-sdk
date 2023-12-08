// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class CheckModifyConfigNeedRestartRequest : TeaModel {
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

    }

}
