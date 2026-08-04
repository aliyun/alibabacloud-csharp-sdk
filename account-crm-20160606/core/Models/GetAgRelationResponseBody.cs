// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class GetAgRelationResponseBody : TeaModel {
        [NameInMap("AgRelationDto")]
        [Validation(Required=false)]
        public GetAgRelationResponseBodyAgRelationDto AgRelationDto { get; set; }
        public class GetAgRelationResponseBodyAgRelationDto : TeaModel {
            [NameInMap("Mpk")]
            [Validation(Required=false)]
            public string Mpk { get; set; }

            [NameInMap("Pk")]
            [Validation(Required=false)]
            public string Pk { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
