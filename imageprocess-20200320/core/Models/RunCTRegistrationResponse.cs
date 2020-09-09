// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class RunCTRegistrationResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public RunCTRegistrationResponseData Data { get; set; }
        public class RunCTRegistrationResponseData : TeaModel {
            [NameInMap("DUrl")]
            [Validation(Required=true)]
            public string DUrl { get; set; }
            [NameInMap("NUrl")]
            [Validation(Required=true)]
            public string NUrl { get; set; }
        };

    }

}
