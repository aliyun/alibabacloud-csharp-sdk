// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class GetWatermarkRequest : TeaModel {
        [NameInMap("ClientBaseParam")]
        [Validation(Required=false)]
        public string ClientBaseParam { get; set; }

        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        [NameInMap("WatermarkId")]
        [Validation(Required=false)]
        public string WatermarkId { get; set; }

    }

}
