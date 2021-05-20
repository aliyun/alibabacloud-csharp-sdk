// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateManualDagRequest : TeaModel {
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        [NameInMap("BizDate")]
        [Validation(Required=false)]
        public string BizDate { get; set; }

        [NameInMap("NodeParameters")]
        [Validation(Required=false)]
        public string NodeParameters { get; set; }

        [NameInMap("DagParameters")]
        [Validation(Required=false)]
        public string DagParameters { get; set; }

    }

}
