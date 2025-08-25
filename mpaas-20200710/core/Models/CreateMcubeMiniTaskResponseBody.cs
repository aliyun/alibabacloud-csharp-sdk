// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20200710.Models
{
    public class CreateMcubeMiniTaskResponseBody : TeaModel {
        [NameInMap("CreateMiniTaskResult")]
        [Validation(Required=false)]
        public CreateMcubeMiniTaskResponseBodyCreateMiniTaskResult CreateMiniTaskResult { get; set; }
        public class CreateMcubeMiniTaskResponseBodyCreateMiniTaskResult : TeaModel {
            [NameInMap("MiniTaskId")]
            [Validation(Required=false)]
            public string MiniTaskId { get; set; }

            [NameInMap("ResultMsg")]
            [Validation(Required=false)]
            public string ResultMsg { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

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
