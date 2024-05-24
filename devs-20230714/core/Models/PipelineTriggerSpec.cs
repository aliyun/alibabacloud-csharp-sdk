// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class PipelineTriggerSpec : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("eventFilter")]
        [Validation(Required=false)]
        public EventFilterConfig EventFilter { get; set; }

        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        [NameInMap("runPipeline")]
        [Validation(Required=false)]
        public RunPipelineConfig RunPipeline { get; set; }

    }

}
