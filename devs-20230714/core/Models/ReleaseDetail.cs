// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class ReleaseDetail : TeaModel {
        [NameInMap("bizStatus")]
        [Validation(Required=false)]
        public string BizStatus { get; set; }

        [NameInMap("envName")]
        [Validation(Required=false)]
        public string EnvName { get; set; }

        [NameInMap("finishedTime")]
        [Validation(Required=false)]
        public string FinishedTime { get; set; }

        [NameInMap("gitEventSnapshot")]
        [Validation(Required=false)]
        public GitEventSnapshot GitEventSnapshot { get; set; }

        [NameInMap("latestTaskExecError")]
        [Validation(Required=false)]
        public TaskExecError LatestTaskExecError { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("pipelineName")]
        [Validation(Required=false)]
        public string PipelineName { get; set; }

        [NameInMap("pipelineTriggerEventName")]
        [Validation(Required=false)]
        public string PipelineTriggerEventName { get; set; }

        [NameInMap("releaseOutputs")]
        [Validation(Required=false)]
        public Dictionary<string, object> ReleaseOutputs { get; set; }

        [NameInMap("repositorySnapshot")]
        [Validation(Required=false)]
        public RepositorySpec RepositorySnapshot { get; set; }

        [NameInMap("templateConfigSnapshot")]
        [Validation(Required=false)]
        public TemplateConfig TemplateConfigSnapshot { get; set; }

    }

}
