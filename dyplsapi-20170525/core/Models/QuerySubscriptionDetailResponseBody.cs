// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QuerySubscriptionDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecretBindDetailDTO")]
        [Validation(Required=false)]
        public QuerySubscriptionDetailResponseBodySecretBindDetailDTO SecretBindDetailDTO { get; set; }
        public class QuerySubscriptionDetailResponseBodySecretBindDetailDTO : TeaModel {
            [NameInMap("ASRModelId")]
            [Validation(Required=false)]
            public string ASRModelId { get; set; }

            [NameInMap("ASRStatus")]
            [Validation(Required=false)]
            public bool? ASRStatus { get; set; }

            [NameInMap("CallRestrict")]
            [Validation(Required=false)]
            public string CallRestrict { get; set; }

            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public string ExpireDate { get; set; }

            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            [NameInMap("NeedRecord")]
            [Validation(Required=false)]
            public bool? NeedRecord { get; set; }

            [NameInMap("PhoneNoA")]
            [Validation(Required=false)]
            public string PhoneNoA { get; set; }

            [NameInMap("PhoneNoB")]
            [Validation(Required=false)]
            public string PhoneNoB { get; set; }

            [NameInMap("PhoneNoX")]
            [Validation(Required=false)]
            public string PhoneNoX { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            [NameInMap("SubsId")]
            [Validation(Required=false)]
            public string SubsId { get; set; }

        }

    }

}
