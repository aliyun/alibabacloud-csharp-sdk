// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20230630.Models
{
    public class GenerateDeviceRequest : TeaModel {
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public long? Amount { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

    }

}
