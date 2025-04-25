// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class DataStepPriceMapValue : TeaModel {
        [NameInMap("RightClose")]
        [Validation(Required=false)]
        public bool? RightClose { get; set; }

        [NameInMap("Min")]
        [Validation(Required=false)]
        public string Min { get; set; }

        [NameInMap("Max")]
        [Validation(Required=false)]
        public string Max { get; set; }

        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        [NameInMap("LeftClose")]
        [Validation(Required=false)]
        public bool? LeftClose { get; set; }

        [NameInMap("StepPriceValue")]
        [Validation(Required=false)]
        public string StepPriceValue { get; set; }

        [NameInMap("PriceValueType")]
        [Validation(Required=false)]
        public string PriceValueType { get; set; }

        [NameInMap("PriceValue")]
        [Validation(Required=false)]
        public string PriceValue { get; set; }

        [NameInMap("DeductCycleType")]
        [Validation(Required=false)]
        public string DeductCycleType { get; set; }

    }

}
