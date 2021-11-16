// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateProblemEffectionServiceResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateProblemEffectionServiceResponseBodyData Data { get; set; }
        public class CreateProblemEffectionServiceResponseBodyData : TeaModel {
            [NameInMap("effectionServiceId")]
            [Validation(Required=false)]
            public long? EffectionServiceId { get; set; }
        };

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
