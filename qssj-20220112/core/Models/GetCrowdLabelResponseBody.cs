// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qssj20220112.Models
{
    public class GetCrowdLabelResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetCrowdLabelResponseBodyData> Data { get; set; }
        public class GetCrowdLabelResponseBodyData : TeaModel {
            [NameInMap("ClosingDate")]
            [Validation(Required=false)]
            public string ClosingDate { get; set; }

            [NameInMap("LabelName")]
            [Validation(Required=false)]
            public string LabelName { get; set; }

            [NameInMap("OrderAmount")]
            [Validation(Required=false)]
            public double? OrderAmount { get; set; }

            [NameInMap("PurchaseAmount")]
            [Validation(Required=false)]
            public double? PurchaseAmount { get; set; }

            [NameInMap("SearchVolume")]
            [Validation(Required=false)]
            public double? SearchVolume { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuccessResponse")]
        [Validation(Required=false)]
        public string SuccessResponse { get; set; }

    }

}
