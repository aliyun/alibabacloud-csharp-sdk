// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain_intl20171218.Models
{
    public class QueryDSRecordResponseBody : TeaModel {
        [NameInMap("DSRecordList")]
        [Validation(Required=false)]
        public List<QueryDSRecordResponseBodyDSRecordList> DSRecordList { get; set; }
        public class QueryDSRecordResponseBodyDSRecordList : TeaModel {
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public int? Algorithm { get; set; }

            [NameInMap("Digest")]
            [Validation(Required=false)]
            public string Digest { get; set; }

            [NameInMap("DigestType")]
            [Validation(Required=false)]
            public int? DigestType { get; set; }

            [NameInMap("KeyTag")]
            [Validation(Required=false)]
            public int? KeyTag { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
