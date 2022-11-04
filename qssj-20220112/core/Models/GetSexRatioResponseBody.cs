// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qssj20220112.Models
{
    public class GetSexRatioResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSexRatioResponseBodyData Data { get; set; }
        public class GetSexRatioResponseBodyData : TeaModel {
            [NameInMap("SaleNumbers")]
            [Validation(Required=false)]
            public List<GetSexRatioResponseBodyDataSaleNumbers> SaleNumbers { get; set; }
            public class GetSexRatioResponseBodyDataSaleNumbers : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public long? Value { get; set; }

            }

            [NameInMap("SearchNumbers")]
            [Validation(Required=false)]
            public List<GetSexRatioResponseBodyDataSearchNumbers> SearchNumbers { get; set; }
            public class GetSexRatioResponseBodyDataSearchNumbers : TeaModel {
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
        public string SuccessResponse { get; set; }

    }

}
