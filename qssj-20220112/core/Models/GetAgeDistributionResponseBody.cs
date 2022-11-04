// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qssj20220112.Models
{
    public class GetAgeDistributionResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetAgeDistributionResponseBodyData> Data { get; set; }
        public class GetAgeDistributionResponseBodyData : TeaModel {
            [NameInMap("AgeRange")]
            [Validation(Required=false)]
            public string AgeRange { get; set; }

            [NameInMap("SaleNumbers")]
            [Validation(Required=false)]
            public long? SaleNumbers { get; set; }

            [NameInMap("SearchNumbers")]
            [Validation(Required=false)]
            public long? SearchNumbers { get; set; }

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
