// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class WafBatchRuleShared : TeaModel {
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("Actions")]
        [Validation(Required=false)]
        public WafBatchRuleSharedActions Actions { get; set; }
        public class WafBatchRuleSharedActions : TeaModel {
            [NameInMap("Response")]
            [Validation(Required=false)]
            public WafBatchRuleSharedActionsResponse Response { get; set; }
            public class WafBatchRuleSharedActionsResponse : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

        }

        [NameInMap("CrossSiteId")]
        [Validation(Required=false)]
        public long? CrossSiteId { get; set; }

        [NameInMap("Expression")]
        [Validation(Required=false)]
        public string Expression { get; set; }

        [NameInMap("Match")]
        [Validation(Required=false)]
        public WafRuleMatch2 Match { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

    }

}
