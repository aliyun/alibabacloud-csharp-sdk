// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class RemoveClusterNodeResponseBody : TeaModel {
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
        public RemoveClusterNodeResponseBodyResult Result { get; set; }
        public class RemoveClusterNodeResponseBodyResult : TeaModel {
            [NameInMap("Nonsense")]
            [Validation(Required=false)]
            public int? Nonsense { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
