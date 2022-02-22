// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class ScaleAppResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("ErrMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ScaleAppResponseBodyResult Result { get; set; }
        public class ScaleAppResponseBodyResult : TeaModel {
            [NameInMap("Admitted")]
            [Validation(Required=false)]
            public bool? Admitted { get; set; }
            [NameInMap("BusinessCode")]
            [Validation(Required=false)]
            public string BusinessCode { get; set; }
            [NameInMap("DeployOrderId")]
            [Validation(Required=false)]
            public long? DeployOrderId { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
