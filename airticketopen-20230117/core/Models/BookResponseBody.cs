// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class BookResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public BookResponseBodyData Data { get; set; }
        public class BookResponseBodyData : TeaModel {
            [NameInMap("order_list")]
            [Validation(Required=false)]
            public List<BookResponseBodyDataOrderList> OrderList { get; set; }
            public class BookResponseBodyDataOrderList : TeaModel {
                [NameInMap("order_num")]
                [Validation(Required=false)]
                public long? OrderNum { get; set; }

            }

        }

        [NameInMap("error_code")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("error_data")]
        [Validation(Required=false)]
        public BookResponseBodyErrorData ErrorData { get; set; }
        public class BookResponseBodyErrorData : TeaModel {
            [NameInMap("order_list")]
            [Validation(Required=false)]
            public List<BookResponseBodyErrorDataOrderList> OrderList { get; set; }
            public class BookResponseBodyErrorDataOrderList : TeaModel {
                [NameInMap("order_num")]
                [Validation(Required=false)]
                public long? OrderNum { get; set; }

            }

        }

        [NameInMap("error_msg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
