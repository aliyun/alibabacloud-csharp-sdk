// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateManualDagRequest : TeaModel {
        [NameInMap("ProjectEnv")]
        [Validation(Required=true)]
        public string ProjectEnv { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=true)]
        public string ProjectName { get; set; }

        [NameInMap("FlowName")]
        [Validation(Required=true)]
        public string FlowName { get; set; }

        [NameInMap("BizDate")]
        [Validation(Required=true)]
        public string BizDate { get; set; }

        [NameInMap("NodeParameters")]
        [Validation(Required=false)]
        public string NodeParameters { get; set; }

        [NameInMap("DagParameters")]
        [Validation(Required=false)]
        public string DagParameters { get; set; }

        [NameInMap("IncludeNodeIds")]
        [Validation(Required=false)]
        public string IncludeNodeIds { get; set; }

        [NameInMap("ExcludeNodeIds")]
        [Validation(Required=false)]
        public string ExcludeNodeIds { get; set; }

    }

}
