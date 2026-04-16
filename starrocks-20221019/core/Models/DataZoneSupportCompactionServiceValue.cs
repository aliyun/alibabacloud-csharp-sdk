// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class DataZoneSupportCompactionServiceValue : TeaModel {
        [NameInMap("zoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        [NameInMap("resourceLevel")]
        [Validation(Required=false)]
        public string ResourceLevel { get; set; }

        [NameInMap("recommended")]
        [Validation(Required=false)]
        public bool? Recommended { get; set; }

    }

}
