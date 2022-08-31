// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateGadInstanceMemberResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreateGadInstanceMemberResponseBodyResult Result { get; set; }
        public class CreateGadInstanceMemberResponseBodyResult : TeaModel {
            [NameInMap("CreateCount")]
            [Validation(Required=false)]
            public string CreateCount { get; set; }
            [NameInMap("GadInstanceName")]
            [Validation(Required=false)]
            public string GadInstanceName { get; set; }
        };

    }

}
