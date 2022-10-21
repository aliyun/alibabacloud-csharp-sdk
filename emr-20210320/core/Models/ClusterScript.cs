// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ClusterScript : TeaModel {
        [NameInMap("ExecutionFailStrategy")]
        [Validation(Required=false)]
        public string ExecutionFailStrategy { get; set; }

        [NameInMap("ExecutionMoment")]
        [Validation(Required=false)]
        public string ExecutionMoment { get; set; }

        [NameInMap("NodeSelect")]
        [Validation(Required=false)]
        public NodeSelector NodeSelect { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("ScriptArgs")]
        [Validation(Required=false)]
        public string ScriptArgs { get; set; }

        [NameInMap("ScriptName")]
        [Validation(Required=false)]
        public string ScriptName { get; set; }

        [NameInMap("ScriptPath")]
        [Validation(Required=false)]
        public string ScriptPath { get; set; }

    }

}
