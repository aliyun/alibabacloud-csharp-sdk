// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdatePipelineBaseInfoRequest : TeaModel {
        [NameInMap("envId")]
        [Validation(Required=false)]
        public long? EnvId { get; set; }

        [NameInMap("pipelineName")]
        [Validation(Required=false)]
        public string PipelineName { get; set; }

        [NameInMap("tagList")]
        [Validation(Required=false)]
        public string TagList { get; set; }

    }

}
