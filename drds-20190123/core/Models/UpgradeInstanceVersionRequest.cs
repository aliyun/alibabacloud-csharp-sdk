// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class UpgradeInstanceVersionRequest : TeaModel {
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("DrdsPassword")]
        [Validation(Required=false)]
        public string DrdsPassword { get; set; }

        [NameInMap("Rpm")]
        [Validation(Required=false)]
        public string Rpm { get; set; }

    }

}
