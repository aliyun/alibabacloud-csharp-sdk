// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qssj20220112.Models
{
    public class GetCrowdDataResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetCrowdDataResponseBodyData> Data { get; set; }
        public class GetCrowdDataResponseBodyData : TeaModel {
            [NameInMap("Age")]
            [Validation(Required=false)]
            public int? Age { get; set; }

            [NameInMap("BuyerId")]
            [Validation(Required=false)]
            public long? BuyerId { get; set; }

            [NameInMap("CateId")]
            [Validation(Required=false)]
            public long? CateId { get; set; }

            [NameInMap("CateName")]
            [Validation(Required=false)]
            public string CateName { get; set; }

            [NameInMap("Classification")]
            [Validation(Required=false)]
            public string Classification { get; set; }

            [NameInMap("ClassificationNew")]
            [Validation(Required=false)]
            public string ClassificationNew { get; set; }

            [NameInMap("Gender")]
            [Validation(Required=false)]
            public string Gender { get; set; }

            [NameInMap("OnlineDate")]
            [Validation(Required=false)]
            public string OnlineDate { get; set; }

            [NameInMap("OrderAmount")]
            [Validation(Required=false)]
            public double? OrderAmount { get; set; }

            [NameInMap("OrderQuantity")]
            [Validation(Required=false)]
            public long? OrderQuantity { get; set; }

            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            [NameInMap("SearchVolume")]
            [Validation(Required=false)]
            public long? SearchVolume { get; set; }

            [NameInMap("TrendLevel")]
            [Validation(Required=false)]
            public string TrendLevel { get; set; }

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
