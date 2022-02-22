// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class CreateAppMonitorsRequest : TeaModel {
        [NameInMap("AlarmTemplateId")]
        [Validation(Required=false)]
        public long? AlarmTemplateId { get; set; }

        [NameInMap("AppIds")]
        [Validation(Required=false)]
        public List<long?> AppIds { get; set; }

        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public int? EnvType { get; set; }

        [NameInMap("MainUserId")]
        [Validation(Required=false)]
        public long? MainUserId { get; set; }

        [NameInMap("SilenceTime")]
        [Validation(Required=false)]
        public string SilenceTime { get; set; }

    }

}
