// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class NextNodeSituations : TeaModel {
        [NameInMap("ConditionGroup")]
        [Validation(Required=false)]
        public List<NextNodeSituationsConditionGroup> ConditionGroup { get; set; }
        public class NextNodeSituationsConditionGroup : TeaModel {
            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public List<JudgeNodeMetaDesc> Conditions { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
