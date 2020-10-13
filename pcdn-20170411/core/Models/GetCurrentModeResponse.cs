// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetCurrentModeResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("ModeCode")]
        [Validation(Required=true)]
        public int? ModeCode { get; set; }

        [NameInMap("PaddingModeCode")]
        [Validation(Required=true)]
        public int? PaddingModeCode { get; set; }

        [NameInMap("EffectiveAt")]
        [Validation(Required=true)]
        public int? EffectiveAt { get; set; }

        [NameInMap("EstimateBandwidth")]
        [Validation(Required=true)]
        public int? EstimateBandwidth { get; set; }

    }

}
