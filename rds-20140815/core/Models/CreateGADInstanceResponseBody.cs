// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateGADInstanceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreateGADInstanceResponseBodyResult Result { get; set; }
        public class CreateGADInstanceResponseBodyResult : TeaModel {
            [NameInMap("CreateMemberCount")]
            [Validation(Required=false)]
            public string CreateMemberCount { get; set; }
            [NameInMap("GadInstanceName")]
            [Validation(Required=false)]
            public string GadInstanceName { get; set; }
            [NameInMap("TaskID")]
            [Validation(Required=false)]
            public string TaskID { get; set; }
        };

    }

}
