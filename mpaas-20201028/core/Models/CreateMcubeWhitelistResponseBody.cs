// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class CreateMcubeWhitelistResponseBody : TeaModel {
        [NameInMap("CreateWhitelistResult")]
        [Validation(Required=false)]
        public CreateMcubeWhitelistResponseBodyCreateWhitelistResult CreateWhitelistResult { get; set; }
        public class CreateMcubeWhitelistResponseBodyCreateWhitelistResult : TeaModel {
            [NameInMap("ResultMsg")]
            [Validation(Required=false)]
            public string ResultMsg { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            [NameInMap("WhitelistId")]
            [Validation(Required=false)]
            public string WhitelistId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}
