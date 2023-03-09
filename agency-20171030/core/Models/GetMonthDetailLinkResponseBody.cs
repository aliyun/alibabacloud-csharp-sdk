// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20171030.Models
{
    public class GetMonthDetailLinkResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMonthDetailLinkResponseBodyData Data { get; set; }
        public class GetMonthDetailLinkResponseBodyData : TeaModel {
            [NameInMap("BillDownloadDTO")]
            [Validation(Required=false)]
            public List<GetMonthDetailLinkResponseBodyDataBillDownloadDTO> BillDownloadDTO { get; set; }
            public class GetMonthDetailLinkResponseBodyDataBillDownloadDTO : TeaModel {
                [NameInMap("BillLink")]
                [Validation(Required=false)]
                public string BillLink { get; set; }

                [NameInMap("BillTime")]
                [Validation(Required=false)]
                public string BillTime { get; set; }

                [NameInMap("BillType")]
                [Validation(Required=false)]
                public string BillType { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Uid")]
                [Validation(Required=false)]
                public long? Uid { get; set; }

                [NameInMap("UserType")]
                [Validation(Required=false)]
                public string UserType { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
