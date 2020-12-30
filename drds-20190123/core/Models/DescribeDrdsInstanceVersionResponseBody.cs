// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsInstanceVersionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDrdsInstanceVersionResponseBodyData Data { get; set; }
        public class DescribeDrdsInstanceVersionResponseBodyData : TeaModel {
            [NameInMap("InstanceVersion")]
            [Validation(Required=false)]
            public string InstanceVersion { get; set; }
            [NameInMap("NewestVersion")]
            [Validation(Required=false)]
            public string NewestVersion { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
