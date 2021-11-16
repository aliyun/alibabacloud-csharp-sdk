// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class RunManualDagNodesRequest : TeaModel {
        [NameInMap("BizDate")]
        [Validation(Required=false)]
        public string BizDate { get; set; }

        [NameInMap("DagParameters")]
        [Validation(Required=false)]
        public string DagParameters { get; set; }

        [NameInMap("ExcludeNodeIds")]
        [Validation(Required=false)]
        public string ExcludeNodeIds { get; set; }

        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        [NameInMap("IncludeNodeIds")]
        [Validation(Required=false)]
        public string IncludeNodeIds { get; set; }

        [NameInMap("NodeParameters")]
        [Validation(Required=false)]
        public string NodeParameters { get; set; }

        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

    }

}
