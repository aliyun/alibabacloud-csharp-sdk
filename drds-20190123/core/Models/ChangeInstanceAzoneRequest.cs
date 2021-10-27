// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class ChangeInstanceAzoneRequest : TeaModel {
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("DrdsRegionId")]
        [Validation(Required=false)]
        public string DrdsRegionId { get; set; }

        [NameInMap("OriginAzoneId")]
        [Validation(Required=false)]
        public string OriginAzoneId { get; set; }

        [NameInMap("TargetAzoneId")]
        [Validation(Required=false)]
        public string TargetAzoneId { get; set; }

    }

}
