// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetCurrentModeResponseBody : TeaModel {
        [NameInMap("ModeCode")]
        [Validation(Required=false)]
        public int? ModeCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PaddingModeCode")]
        [Validation(Required=false)]
        public int? PaddingModeCode { get; set; }

        [NameInMap("EffectiveAt")]
        [Validation(Required=false)]
        public int? EffectiveAt { get; set; }

        [NameInMap("EstimateBandwidth")]
        [Validation(Required=false)]
        public int? EstimateBandwidth { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
