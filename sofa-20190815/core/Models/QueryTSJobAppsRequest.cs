// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryTSJobAppsRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InvokeType")]
        [Validation(Required=false)]
        public string InvokeType { get; set; }

        [NameInMap("TriggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

    }

}
