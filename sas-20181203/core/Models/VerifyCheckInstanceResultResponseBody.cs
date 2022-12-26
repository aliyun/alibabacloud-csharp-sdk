// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class VerifyCheckInstanceResultResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public VerifyCheckInstanceResultResponseBodyData Data { get; set; }
        public class VerifyCheckInstanceResultResponseBodyData : TeaModel {
            [NameInMap("FailInstances")]
            [Validation(Required=false)]
            public List<string> FailInstances { get; set; }

            [NameInMap("OperateCode")]
            [Validation(Required=false)]
            public string OperateCode { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
