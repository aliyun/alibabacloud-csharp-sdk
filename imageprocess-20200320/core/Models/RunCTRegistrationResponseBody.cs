// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class RunCTRegistrationResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RunCTRegistrationResponseBodyData Data { get; set; }
        public class RunCTRegistrationResponseBodyData : TeaModel {
            [NameInMap("DUrl")]
            [Validation(Required=false)]
            public string DUrl { get; set; }
            [NameInMap("NUrl")]
            [Validation(Required=false)]
            public string NUrl { get; set; }
        };

    }

}
