// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class PauseChangeResponseBody : TeaModel {
        [NameInMap("EnvChange")]
        [Validation(Required=false)]
        public PauseChangeResponseBodyEnvChange EnvChange { get; set; }
        public class PauseChangeResponseBodyEnvChange : TeaModel {
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }
            [NameInMap("ChangeId")]
            [Validation(Required=false)]
            public string ChangeId { get; set; }
            [NameInMap("EnvId")]
            [Validation(Required=false)]
            public string EnvId { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
