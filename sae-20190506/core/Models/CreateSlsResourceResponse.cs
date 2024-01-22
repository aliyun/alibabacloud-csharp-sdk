// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateSlsResourceResponse : TeaModel {
        [NameInMap("logStore")]
        [Validation(Required=false)]
        public string LogStore { get; set; }

        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
