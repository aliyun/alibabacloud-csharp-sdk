// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class SkipTSActivityInstanceRequest : TeaModel {
        [NameInMap("ActivityInstanceId")]
        [Validation(Required=false)]
        public long? ActivityInstanceId { get; set; }

        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("JobRequestId")]
        [Validation(Required=false)]
        public string JobRequestId { get; set; }

        [NameInMap("Zone")]
        [Validation(Required=false)]
        public string Zone { get; set; }

    }

}
