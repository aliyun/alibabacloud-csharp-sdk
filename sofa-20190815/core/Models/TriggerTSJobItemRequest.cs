// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class TriggerTSJobItemRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        [NameInMap("ParamMap")]
        [Validation(Required=false)]
        public string ParamMap { get; set; }

        [NameInMap("Zone")]
        [Validation(Required=false)]
        public string Zone { get; set; }

    }

}
