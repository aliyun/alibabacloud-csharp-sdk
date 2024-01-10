// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CopyThingModelAsyncRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("SourceModelVersion")]
        [Validation(Required=false)]
        public string SourceModelVersion { get; set; }

        [NameInMap("SourceProductKey")]
        [Validation(Required=false)]
        public string SourceProductKey { get; set; }

        [NameInMap("TargetProductKey")]
        [Validation(Required=false)]
        public string TargetProductKey { get; set; }

    }

}
