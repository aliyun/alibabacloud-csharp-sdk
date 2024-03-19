/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20191211.Models
{
    public class ApplyTokenRequest : TeaModel {
        [NameInMap("Actions")]
        [Validation(Required=false)]
        public string Actions { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

    }

}
