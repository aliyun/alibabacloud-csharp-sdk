// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class HyperNodeSchedulingConfig : TeaModel {
        [NameInMap("MinAvailable")]
        [Validation(Required=false)]
        public int? MinAvailable { get; set; }

        [NameInMap("QualityPolicy")]
        [Validation(Required=false)]
        public string QualityPolicy { get; set; }

    }

}
