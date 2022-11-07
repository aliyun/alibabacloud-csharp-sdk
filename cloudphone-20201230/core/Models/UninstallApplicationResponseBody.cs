// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudphone20201230.Models
{
    public class UninstallApplicationResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public UninstallApplicationResponseBodyTaskId TaskId { get; set; }
        public class UninstallApplicationResponseBodyTaskId : TeaModel {
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public List<string> TaskId { get; set; }

        }

    }

}
