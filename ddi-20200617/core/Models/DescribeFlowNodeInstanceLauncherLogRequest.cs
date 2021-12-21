// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class DescribeFlowNodeInstanceLauncherLogRequest : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("Length")]
        [Validation(Required=false)]
        public int? Length { get; set; }

        [NameInMap("Lines")]
        [Validation(Required=false)]
        public int? Lines { get; set; }

        [NameInMap("NodeInstanceId")]
        [Validation(Required=false)]
        public string NodeInstanceId { get; set; }

        [NameInMap("Offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

        [NameInMap("Start")]
        [Validation(Required=false)]
        public int? Start { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
