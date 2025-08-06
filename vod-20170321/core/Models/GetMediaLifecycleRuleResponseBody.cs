// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaLifecycleRuleResponseBody : TeaModel {
        [NameInMap("ForbiddenRuleIds")]
        [Validation(Required=false)]
        public List<string> ForbiddenRuleIds { get; set; }

        [NameInMap("NonExistRuleIds")]
        [Validation(Required=false)]
        public List<string> NonExistRuleIds { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RuleList")]
        [Validation(Required=false)]
        public List<GetMediaLifecycleRuleResponseBodyRuleList> RuleList { get; set; }
        public class GetMediaLifecycleRuleResponseBodyRuleList : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            [NameInMap("RuleContent")]
            [Validation(Required=false)]
            public string RuleContent { get; set; }

            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
