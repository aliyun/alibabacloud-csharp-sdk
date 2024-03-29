// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idaas_doraemon20210520.Models
{
    public class QuerySmsUpsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SmsUps")]
        [Validation(Required=false)]
        public List<QuerySmsUpsResponseBodySmsUps> SmsUps { get; set; }
        public class QuerySmsUpsResponseBodySmsUps : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("DestCode")]
            [Validation(Required=false)]
            public string DestCode { get; set; }

            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            [NameInMap("SendTime")]
            [Validation(Required=false)]
            public string SendTime { get; set; }

            [NameInMap("SequenceId")]
            [Validation(Required=false)]
            public string SequenceId { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        [NameInMap("TotalElements")]
        [Validation(Required=false)]
        public long? TotalElements { get; set; }

    }

}
