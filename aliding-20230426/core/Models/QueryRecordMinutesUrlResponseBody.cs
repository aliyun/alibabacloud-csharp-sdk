// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryRecordMinutesUrlResponseBody : TeaModel {
        [NameInMap("recordMinutesUrls")]
        [Validation(Required=false)]
        public List<QueryRecordMinutesUrlResponseBodyRecordMinutesUrls> RecordMinutesUrls { get; set; }
        public class QueryRecordMinutesUrlResponseBodyRecordMinutesUrls : TeaModel {
            [NameInMap("RecordMinutesUrl")]
            [Validation(Required=false)]
            public string RecordMinutesUrl { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
