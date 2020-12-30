// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class GetNumberRegionInfoResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public GetNumberRegionInfoResponseBodyPhoneNumber PhoneNumber { get; set; }
        public class GetNumberRegionInfoResponseBodyPhoneNumber : TeaModel {
            [NameInMap("Number")]
            [Validation(Required=false)]
            public string Number { get; set; }
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }
            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
