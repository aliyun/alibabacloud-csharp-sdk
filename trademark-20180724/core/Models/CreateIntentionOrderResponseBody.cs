// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class CreateIntentionOrderResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateIntentionOrderResponseBodyData Data { get; set; }
        public class CreateIntentionOrderResponseBodyData : TeaModel {
            [NameInMap("OrderIds")]
            [Validation(Required=false)]
            public List<string> OrderIds { get; set; }

        }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
