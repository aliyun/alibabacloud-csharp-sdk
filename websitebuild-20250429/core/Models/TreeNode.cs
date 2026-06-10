// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class TreeNode : TeaModel {
        [NameInMap("Children")]
        [Validation(Required=false)]
        public List<TreeNode> Children { get; set; }

        [NameInMap("FinalStepNo")]
        [Validation(Required=false)]
        public int? FinalStepNo { get; set; }

        [NameInMap("FinishTime")]
        [Validation(Required=false)]
        public long? FinishTime { get; set; }

        [NameInMap("IsContainerNode")]
        [Validation(Required=false)]
        public bool? IsContainerNode { get; set; }

        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        [NameInMap("NodeStatus")]
        [Validation(Required=false)]
        public string NodeStatus { get; set; }

        [NameInMap("OperatorRole")]
        [Validation(Required=false)]
        public string OperatorRole { get; set; }

        [NameInMap("ParentNodeId")]
        [Validation(Required=false)]
        public string ParentNodeId { get; set; }

        [NameInMap("StepNo")]
        [Validation(Required=false)]
        public int? StepNo { get; set; }

    }

}
