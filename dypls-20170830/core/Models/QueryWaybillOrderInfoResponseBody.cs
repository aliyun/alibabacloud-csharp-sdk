// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypls20170830.Models
{
    public class QueryWaybillOrderInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryWaybillOrderInfoResponseBodyData Data { get; set; }
        public class QueryWaybillOrderInfoResponseBodyData : TeaModel {
            [NameInMap("Aliyunprice")]
            [Validation(Required=false)]
            public string Aliyunprice { get; set; }

            [NameInMap("AppointGotEndTime")]
            [Validation(Required=false)]
            public string AppointGotEndTime { get; set; }

            [NameInMap("AppointGotStartTime")]
            [Validation(Required=false)]
            public string AppointGotStartTime { get; set; }

            [NameInMap("BizType")]
            [Validation(Required=false)]
            public int? BizType { get; set; }

            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            [NameInMap("CpCode")]
            [Validation(Required=false)]
            public string CpCode { get; set; }

            [NameInMap("GotCode")]
            [Validation(Required=false)]
            public string GotCode { get; set; }

            [NameInMap("LastLogisticDetail")]
            [Validation(Required=false)]
            public string LastLogisticDetail { get; set; }

            [NameInMap("LogisticsGmtModified")]
            [Validation(Required=false)]
            public string LogisticsGmtModified { get; set; }

            [NameInMap("LogisticsStatus")]
            [Validation(Required=false)]
            public string LogisticsStatus { get; set; }

            [NameInMap("LogisticsStatusDesc")]
            [Validation(Required=false)]
            public string LogisticsStatusDesc { get; set; }

            [NameInMap("MailNo")]
            [Validation(Required=false)]
            public string MailNo { get; set; }

            [NameInMap("OuterOrderCode")]
            [Validation(Required=false)]
            public string OuterOrderCode { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
