// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class RenameSparkTemplateFileResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RenameSparkTemplateFileResponseBodyData Data { get; set; }
        public class RenameSparkTemplateFileResponseBodyData : TeaModel {
            [NameInMap("Succeeded")]
            [Validation(Required=false)]
            public bool? Succeeded { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
