// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyDesktopPolicysResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Results")]
        [Validation(Required=true)]
        public List<ModifyDesktopPolicysResponseResults> Results { get; set; }
        public class ModifyDesktopPolicysResponseResults : TeaModel {
            [NameInMap("DesktopId")]
            [Validation(Required=true)]
            public string DesktopId { get; set; }

            [NameInMap("Success")]
            [Validation(Required=true)]
            public string Success { get; set; }

            [NameInMap("Code")]
            [Validation(Required=true)]
            public string Code { get; set; }

            [NameInMap("Message")]
            [Validation(Required=true)]
            public string Message { get; set; }

        }

    }

}
