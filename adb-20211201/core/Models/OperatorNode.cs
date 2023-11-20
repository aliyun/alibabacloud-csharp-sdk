// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class OperatorNode : TeaModel {
        [NameInMap("children")]
        [Validation(Required=false)]
        public List<OperatorNode> Children { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public int? Id { get; set; }

        [NameInMap("levelWidth")]
        [Validation(Required=false)]
        public int? LevelWidth { get; set; }

        [NameInMap("nodeDepth")]
        [Validation(Required=false)]
        public int? NodeDepth { get; set; }

        [NameInMap("nodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        [NameInMap("nodeWidth")]
        [Validation(Required=false)]
        public int? NodeWidth { get; set; }

        [NameInMap("parentId")]
        [Validation(Required=false)]
        public int? ParentId { get; set; }

        [NameInMap("stats")]
        [Validation(Required=false)]
        public OperatorNodeStats Stats { get; set; }
        public class OperatorNodeStats : TeaModel {
            [NameInMap("bytes")]
            [Validation(Required=false)]
            public long? Bytes { get; set; }

            [NameInMap("outputRows")]
            [Validation(Required=false)]
            public long? OutputRows { get; set; }

            [NameInMap("parameters")]
            [Validation(Required=false)]
            public string Parameters { get; set; }

            [NameInMap("peakMemory")]
            [Validation(Required=false)]
            public long? PeakMemory { get; set; }

            [NameInMap("timeCost")]
            [Validation(Required=false)]
            public long? TimeCost { get; set; }

        }

    }

}
