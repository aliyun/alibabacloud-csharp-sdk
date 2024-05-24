// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class RunPipelineConfig : TeaModel {
        [NameInMap("pipelineSpec")]
        [Validation(Required=false)]
        public PipelineSpec PipelineSpec { get; set; }

        [NameInMap("variables")]
        [Validation(Required=false)]
        public List<Variable> Variables { get; set; }

        [NameInMap("yamlFileContent")]
        [Validation(Required=false)]
        public string YamlFileContent { get; set; }

        [NameInMap("yamlFilePath")]
        [Validation(Required=false)]
        public string YamlFilePath { get; set; }

    }

}
