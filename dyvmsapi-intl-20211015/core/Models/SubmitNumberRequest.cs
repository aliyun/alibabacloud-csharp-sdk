// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi_intl20211015.Models
{
    public class SubmitNumberRequest : TeaModel {
        [NameInMap("ApplyNote")]
        [Validation(Required=false)]
        public string ApplyNote { get; set; }

        [NameInMap("CountryId")]
        [Validation(Required=false)]
        public string CountryId { get; set; }

        [NameInMap("NumberList")]
        [Validation(Required=false)]
        public List<SubmitNumberRequestNumberList> NumberList { get; set; }
        public class SubmitNumberRequestNumberList : TeaModel {
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public long? Amount { get; set; }

            [NameInMap("InboundConcurrency")]
            [Validation(Required=false)]
            public long? InboundConcurrency { get; set; }

            [NameInMap("OutboundConcurrency")]
            [Validation(Required=false)]
            public long? OutboundConcurrency { get; set; }

            [NameInMap("PhoneType")]
            [Validation(Required=false)]
            public long? PhoneType { get; set; }

            [NameInMap("Support")]
            [Validation(Required=false)]
            public long? Support { get; set; }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("QualificationId")]
        [Validation(Required=false)]
        public string QualificationId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

    }

}
