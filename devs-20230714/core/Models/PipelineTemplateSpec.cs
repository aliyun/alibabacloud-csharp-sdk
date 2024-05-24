// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class PipelineTemplateSpec : TeaModel {
        [NameInMap("context")]
        [Validation(Required=false)]
        public Context Context { get; set; }

        [NameInMap("tasks")]
        [Validation(Required=false)]
        public List<TaskExec> Tasks { get; set; }

    }

}
