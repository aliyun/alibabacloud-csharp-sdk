// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class LineageInfo : TeaModel {
        [NameInMap("edges")]
        [Validation(Required=false)]
        public Edge Edges { get; set; }

        [NameInMap("jobInfos")]
        [Validation(Required=false)]
        public List<JobInfo> JobInfos { get; set; }

        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<Node> Nodes { get; set; }

    }

}
