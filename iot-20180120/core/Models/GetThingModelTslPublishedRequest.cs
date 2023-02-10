// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetThingModelTslPublishedRequest : TeaModel {
        [NameInMap("FunctionBlockId")]
        [Validation(Required=false)]
        public string FunctionBlockId { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ModelVersion")]
        [Validation(Required=false)]
        public string ModelVersion { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Simple")]
        [Validation(Required=false)]
        public bool? Simple { get; set; }

    }

}
