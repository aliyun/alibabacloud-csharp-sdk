// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi_intl20211015.Models
{
    public class ListNumberResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListNumberResponseBodyList> List { get; set; }
        public class ListNumberResponseBodyList : TeaModel {
            [NameInMap("ApplyId")]
            [Validation(Required=false)]
            public string ApplyId { get; set; }

            [NameInMap("CountryId")]
            [Validation(Required=false)]
            public string CountryId { get; set; }

            [NameInMap("DisableTs")]
            [Validation(Required=false)]
            public string DisableTs { get; set; }

            [NameInMap("InboundConcurrency")]
            [Validation(Required=false)]
            public long? InboundConcurrency { get; set; }

            [NameInMap("Number")]
            [Validation(Required=false)]
            public string Number { get; set; }

            [NameInMap("NumberName")]
            [Validation(Required=false)]
            public string NumberName { get; set; }

            [NameInMap("OutboundConcurrency")]
            [Validation(Required=false)]
            public long? OutboundConcurrency { get; set; }

            [NameInMap("PhoneType")]
            [Validation(Required=false)]
            public long? PhoneType { get; set; }

            [NameInMap("QualificationId")]
            [Validation(Required=false)]
            public string QualificationId { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            [NameInMap("SupplierId")]
            [Validation(Required=false)]
            public string SupplierId { get; set; }

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
