// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryAddressListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AddressList")]
        [Validation(Required=false)]
        public List<QueryAddressListResponseBodyAddressList> AddressList { get; set; }
        public class QueryAddressListResponseBodyAddressList : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("PostCode")]
            [Validation(Required=false)]
            public string PostCode { get; set; }

            [NameInMap("FullName")]
            [Validation(Required=false)]
            public string FullName { get; set; }

            [NameInMap("AddressDetail")]
            [Validation(Required=false)]
            public string AddressDetail { get; set; }

            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            [NameInMap("AddressId")]
            [Validation(Required=false)]
            public long? AddressId { get; set; }

            [NameInMap("DivisionCode")]
            [Validation(Required=false)]
            public string DivisionCode { get; set; }

            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            [NameInMap("Area")]
            [Validation(Required=false)]
            public string Area { get; set; }

            [NameInMap("TownDivisionCode")]
            [Validation(Required=false)]
            public string TownDivisionCode { get; set; }

            [NameInMap("Town")]
            [Validation(Required=false)]
            public string Town { get; set; }

            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

        }

    }

}
