// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryAddressResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DivisionAddress")]
        [Validation(Required=false)]
        public QueryAddressResponseBodyDivisionAddress DivisionAddress { get; set; }
        public class QueryAddressResponseBodyDivisionAddress : TeaModel {
            [NameInMap("DivisionAddress")]
            [Validation(Required=false)]
            public List<QueryAddressResponseBodyDivisionAddressDivisionAddress> DivisionAddress { get; set; }
            public class QueryAddressResponseBodyDivisionAddressDivisionAddress : TeaModel {
                public long? ParentId { get; set; }
                public long? DivisionCode { get; set; }
                public int? DivisionLevel { get; set; }
                public string DivisionName { get; set; }
            }
        };

    }

}
