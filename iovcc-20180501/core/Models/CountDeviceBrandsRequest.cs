// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class CountDeviceBrandsRequest : TeaModel {
        [NameInMap("DeviceBrandId")]
        [Validation(Required=false)]
        public long? DeviceBrandId { get; set; }

        [NameInMap("DeviceBrand")]
        [Validation(Required=false)]
        public string DeviceBrand { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

    }

}
