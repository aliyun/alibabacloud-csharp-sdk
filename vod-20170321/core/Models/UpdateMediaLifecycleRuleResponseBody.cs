// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateMediaLifecycleRuleResponseBody : TeaModel {
        [NameInMap("ForbiddenRuleIds")]
        [Validation(Required=false)]
        public List<string> ForbiddenRuleIds { get; set; }

        [NameInMap("NonExistRuleIds")]
        [Validation(Required=false)]
        public List<string> NonExistRuleIds { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
