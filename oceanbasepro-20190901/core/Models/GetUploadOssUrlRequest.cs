// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class GetUploadOssUrlRequest : TeaModel {
        [NameInMap("EffectiveTimeMinutes")]
        [Validation(Required=false)]
        public int? EffectiveTimeMinutes { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
