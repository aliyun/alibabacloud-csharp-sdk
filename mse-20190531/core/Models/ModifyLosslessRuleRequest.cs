// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ModifyLosslessRuleRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("Aligned")]
        [Validation(Required=false)]
        public bool? Aligned { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("DelayTime")]
        [Validation(Required=false)]
        public long? DelayTime { get; set; }

        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("FuncType")]
        [Validation(Required=false)]
        public long? FuncType { get; set; }

        [NameInMap("MseSessionId")]
        [Validation(Required=false)]
        public string MseSessionId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Related")]
        [Validation(Required=false)]
        public bool? Related { get; set; }

        [NameInMap("ShutdownWaitSeconds")]
        [Validation(Required=false)]
        public int? ShutdownWaitSeconds { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("WarmupTime")]
        [Validation(Required=false)]
        public long? WarmupTime { get; set; }

    }

}
