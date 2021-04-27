// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class UpdateProductFilterConfigRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("PropertyTimestampFilter")]
        [Validation(Required=false)]
        public bool? PropertyTimestampFilter { get; set; }

        [NameInMap("PropertyValueFilter")]
        [Validation(Required=false)]
        public bool? PropertyValueFilter { get; set; }

    }

}
