// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Serverless20210924.Models
{
    public class TaskStatus : TeaModel {
        [NameInMap("executionDetails")]
        [Validation(Required=false)]
        public List<string> ExecutionDetails { get; set; }

        [NameInMap("phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        [NameInMap("statusGeneration")]
        [Validation(Required=false)]
        public long? StatusGeneration { get; set; }

    }

}
