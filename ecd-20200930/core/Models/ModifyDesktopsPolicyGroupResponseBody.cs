// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyDesktopsPolicyGroupResponseBody : TeaModel {
        [NameInMap("ModifyResults")]
        [Validation(Required=false)]
        public List<ModifyDesktopsPolicyGroupResponseBodyModifyResults> ModifyResults { get; set; }
        public class ModifyDesktopsPolicyGroupResponseBodyModifyResults : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
