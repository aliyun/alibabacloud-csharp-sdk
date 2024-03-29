// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idaas_doraemon20210520.Models
{
    public class QuerySmsReportsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SmsReports")]
        [Validation(Required=false)]
        public List<QuerySmsReportsResponseBodySmsReports> SmsReports { get; set; }
        public class QuerySmsReportsResponseBodySmsReports : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("ChargedCount")]
            [Validation(Required=false)]
            public int? ChargedCount { get; set; }

            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            [NameInMap("Sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

            [NameInMap("Stat")]
            [Validation(Required=false)]
            public string Stat { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            [NameInMap("Tid")]
            [Validation(Required=false)]
            public string Tid { get; set; }

            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

        }

        [NameInMap("TotalElements")]
        [Validation(Required=false)]
        public long? TotalElements { get; set; }

    }

}
