// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypns20170620.Models
{
    public class ListSmsSignResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListSmsSignResponseBodyData> Data { get; set; }
        public class ListSmsSignResponseBodyData : TeaModel {
            [NameInMap("AuditResult")]
            [Validation(Required=false)]
            public string AuditResult { get; set; }

            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public long? CreateDate { get; set; }

            [NameInMap("DefaultFlag")]
            [Validation(Required=false)]
            public bool? DefaultFlag { get; set; }

            [NameInMap("SmsSignName")]
            [Validation(Required=false)]
            public string SmsSignName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TestFlag")]
            [Validation(Required=false)]
            public bool? TestFlag { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
