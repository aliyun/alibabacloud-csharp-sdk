// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class ListFlowNodeSqlResultRequest : TeaModel {
        [NameInMap("Length")]
        [Validation(Required=false)]
        public int? Length { get; set; }

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

        [NameInMap("SqlIndex")]
        [Validation(Required=false)]
        public int? SqlIndex { get; set; }

    }

}
