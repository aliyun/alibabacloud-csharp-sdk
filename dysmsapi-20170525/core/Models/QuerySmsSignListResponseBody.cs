// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySmsSignListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SmsSignList")]
        [Validation(Required=false)]
        public List<QuerySmsSignListResponseBodySmsSignList> SmsSignList { get; set; }
        public class QuerySmsSignListResponseBodySmsSignList : TeaModel {
            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public string AuditStatus { get; set; }

            [NameInMap("BusinessType")]
            [Validation(Required=false)]
            public string BusinessType { get; set; }

            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public QuerySmsSignListResponseBodySmsSignListReason Reason { get; set; }
            public class QuerySmsSignListResponseBodySmsSignListReason : TeaModel {
                [NameInMap("RejectDate")]
                [Validation(Required=false)]
                public string RejectDate { get; set; }
                [NameInMap("RejectInfo")]
                [Validation(Required=false)]
                public string RejectInfo { get; set; }
                [NameInMap("RejectSubInfo")]
                [Validation(Required=false)]
                public string RejectSubInfo { get; set; }
            };

            [NameInMap("SignName")]
            [Validation(Required=false)]
            public string SignName { get; set; }

        }

    }

}
