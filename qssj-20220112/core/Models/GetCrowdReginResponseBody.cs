// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qssj20220112.Models
{
    public class GetCrowdReginResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCrowdReginResponseBodyData Data { get; set; }
        public class GetCrowdReginResponseBodyData : TeaModel {
            [NameInMap("SaleNumbers")]
            [Validation(Required=false)]
            public List<GetCrowdReginResponseBodyDataSaleNumbers> SaleNumbers { get; set; }
            public class GetCrowdReginResponseBodyDataSaleNumbers : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public long? Value { get; set; }

            }

            [NameInMap("SearchNumbers")]
            [Validation(Required=false)]
            public List<GetCrowdReginResponseBodyDataSearchNumbers> SearchNumbers { get; set; }
            public class GetCrowdReginResponseBodyDataSearchNumbers : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public long? Value { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuccessResponse")]
        [Validation(Required=false)]
        public bool? SuccessResponse { get; set; }

    }

}
