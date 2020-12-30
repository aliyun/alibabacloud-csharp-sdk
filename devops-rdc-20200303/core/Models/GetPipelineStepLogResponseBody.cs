// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops_rdc20200303.Models
{
    public class GetPipelineStepLogResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Object")]
        [Validation(Required=false)]
        public GetPipelineStepLogResponseBodyObject Object { get; set; }
        public class GetPipelineStepLogResponseBodyObject : TeaModel {
            [NameInMap("Logs")]
            [Validation(Required=false)]
            public string Logs { get; set; }
            [NameInMap("Last")]
            [Validation(Required=false)]
            public int? Last { get; set; }
            [NameInMap("More")]
            [Validation(Required=false)]
            public bool? More { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
