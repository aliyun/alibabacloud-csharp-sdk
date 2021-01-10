// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CountLinkeBahamutGlobalsearchResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CountLinkeBahamutGlobalsearchResponseBodyResult Result { get; set; }
        public class CountLinkeBahamutGlobalsearchResponseBodyResult : TeaModel {
            [NameInMap("Apps")]
            [Validation(Required=false)]
            public long? Apps { get; set; }
            [NameInMap("Iterations")]
            [Validation(Required=false)]
            public long? Iterations { get; set; }
            [NameInMap("Releases")]
            [Validation(Required=false)]
            public long? Releases { get; set; }
            [NameInMap("IterationUnits")]
            [Validation(Required=false)]
            public long? IterationUnits { get; set; }
        };

    }

}
