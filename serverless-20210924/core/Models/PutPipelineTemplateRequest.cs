// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Serverless20210924.Models
{
    public class PutPipelineTemplateRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public PipelineTemplate Body { get; set; }

        [NameInMap("force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

    }

}
