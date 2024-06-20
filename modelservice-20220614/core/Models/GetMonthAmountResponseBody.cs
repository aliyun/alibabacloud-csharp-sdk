// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelService20220614.Models
{
    public class GetMonthAmountResponseBody : TeaModel {
        [NameInMap("BackgroundAmount")]
        [Validation(Required=false)]
        public int? BackgroundAmount { get; set; }

        [NameInMap("PostpayAmount")]
        [Validation(Required=false)]
        public int? PostpayAmount { get; set; }

        [NameInMap("PrepayAmount")]
        [Validation(Required=false)]
        public int? PrepayAmount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalAmount")]
        [Validation(Required=false)]
        public int? TotalAmount { get; set; }

    }

}
