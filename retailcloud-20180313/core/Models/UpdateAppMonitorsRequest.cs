// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class UpdateAppMonitorsRequest : TeaModel {
        [NameInMap("MainUserId")]
        [Validation(Required=false)]
        public long? MainUserId { get; set; }

        [NameInMap("MonitorIds")]
        [Validation(Required=false)]
        public List<long?> MonitorIds { get; set; }

        [NameInMap("SilenceTime")]
        [Validation(Required=false)]
        public string SilenceTime { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}
