// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class CalcCACSResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public CalcCACSResponseData Data { get; set; }
        public class CalcCACSResponseData : TeaModel {
            [NameInMap("Score")]
            [Validation(Required=true)]
            public string Score { get; set; }
        };

    }

}
