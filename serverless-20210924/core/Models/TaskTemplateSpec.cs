// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Serverless20210924.Models
{
    public class TaskTemplateSpec : TeaModel {
        [NameInMap("context")]
        [Validation(Required=false)]
        public Context Context { get; set; }

        [NameInMap("contextSchema")]
        [Validation(Required=false)]
        public Dictionary<string, object> ContextSchema { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("executeCondition")]
        [Validation(Required=false)]
        public Condition ExecuteCondition { get; set; }

        [NameInMap("worker")]
        [Validation(Required=false)]
        public TaskWorker Worker { get; set; }

    }

}
