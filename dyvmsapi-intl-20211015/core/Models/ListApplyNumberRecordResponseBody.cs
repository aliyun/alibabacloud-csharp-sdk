// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi_intl20211015.Models
{
    public class ListApplyNumberRecordResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListApplyNumberRecordResponseBodyList> List { get; set; }
        public class ListApplyNumberRecordResponseBodyList : TeaModel {
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            [NameInMap("ApplyId")]
            [Validation(Required=false)]
            public string ApplyId { get; set; }

            [NameInMap("ApplyNote")]
            [Validation(Required=false)]
            public string ApplyNote { get; set; }

            [NameInMap("AuditNote")]
            [Validation(Required=false)]
            public string AuditNote { get; set; }

            [NameInMap("AuditTs")]
            [Validation(Required=false)]
            public string AuditTs { get; set; }

            [NameInMap("BatchIndex")]
            [Validation(Required=false)]
            public long? BatchIndex { get; set; }

            [NameInMap("CommitTs")]
            [Validation(Required=false)]
            public string CommitTs { get; set; }

            [NameInMap("CountryId")]
            [Validation(Required=false)]
            public string CountryId { get; set; }

            [NameInMap("InboundConcurrency")]
            [Validation(Required=false)]
            public long? InboundConcurrency { get; set; }

            [NameInMap("OutboundConcurrency")]
            [Validation(Required=false)]
            public long? OutboundConcurrency { get; set; }

            [NameInMap("PhoneType")]
            [Validation(Required=false)]
            public long? PhoneType { get; set; }

            [NameInMap("QualificationId")]
            [Validation(Required=false)]
            public string QualificationId { get; set; }

            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            [NameInMap("Support")]
            [Validation(Required=false)]
            public long? Support { get; set; }

            [NameInMap("UpdateTs")]
            [Validation(Required=false)]
            public string UpdateTs { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
