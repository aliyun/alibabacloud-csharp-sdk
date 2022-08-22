// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class QueryHotelProductResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryHotelProductResponseBodyResult Result { get; set; }
        public class QueryHotelProductResponseBodyResult : TeaModel {
            [NameInMap("HotelId")]
            [Validation(Required=false)]
            public string HotelId { get; set; }
            [NameInMap("HotelName")]
            [Validation(Required=false)]
            public string HotelName { get; set; }
            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }
        };

    }

}
