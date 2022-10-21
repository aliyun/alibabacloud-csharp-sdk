// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class TaskGraphFlow : TeaModel {
        [NameInMap("FlowRuleScoreType")]
        [Validation(Required=false)]
        public int? FlowRuleScoreType { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<GraphFlowNode> Nodes { get; set; }

        [NameInMap("Rid")]
        [Validation(Required=false)]
        public long? Rid { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        [NameInMap("ShowProperties")]
        [Validation(Required=false)]
        public string ShowProperties { get; set; }

        [NameInMap("SkipWhenFirstSessionNodeMiss")]
        [Validation(Required=false)]
        public bool? SkipWhenFirstSessionNodeMiss { get; set; }

    }

}
