// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ApplyMetricRuleTemplateRequest : TeaModel {
        [NameInMap("ApplyMode")]
        [Validation(Required=false)]
        public string ApplyMode { get; set; }

        [NameInMap("EnableEndTime")]
        [Validation(Required=false)]
        public long? EnableEndTime { get; set; }

        [NameInMap("EnableStartTime")]
        [Validation(Required=false)]
        public long? EnableStartTime { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        [NameInMap("NotifyLevel")]
        [Validation(Required=false)]
        public long? NotifyLevel { get; set; }

        [NameInMap("SilenceTime")]
        [Validation(Required=false)]
        public long? SilenceTime { get; set; }

        [NameInMap("TemplateIds")]
        [Validation(Required=false)]
        public string TemplateIds { get; set; }

        [NameInMap("Webhook")]
        [Validation(Required=false)]
        public string Webhook { get; set; }

    }

}
