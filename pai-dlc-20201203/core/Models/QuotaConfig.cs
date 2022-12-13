// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class QuotaConfig : TeaModel {
        [NameInMap("AllowedMaxPriority")]
        [Validation(Required=false)]
        public int? AllowedMaxPriority { get; set; }

        [NameInMap("EnableDLC")]
        [Validation(Required=false)]
        public bool? EnableDLC { get; set; }

        [NameInMap("EnableDSW")]
        [Validation(Required=false)]
        public bool? EnableDSW { get; set; }

        [NameInMap("EnableTideResource")]
        [Validation(Required=false)]
        public bool? EnableTideResource { get; set; }

        [NameInMap("ResourceLevel")]
        [Validation(Required=false)]
        public string ResourceLevel { get; set; }

    }

}
