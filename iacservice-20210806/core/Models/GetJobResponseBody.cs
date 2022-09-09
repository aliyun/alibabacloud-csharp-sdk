// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetJobResponseBody : TeaModel {
        [NameInMap("job")]
        [Validation(Required=false)]
        public GetJobResponseBodyJob Job { get; set; }
        public class GetJobResponseBodyJob : TeaModel {
            [NameInMap("config")]
            [Validation(Required=false)]
            public GetJobResponseBodyJobConfig Config { get; set; }
            public class GetJobResponseBodyJobConfig : TeaModel {
                [NameInMap("autoApply")]
                [Validation(Required=false)]
                public bool? AutoApply { get; set; }

                [NameInMap("isDestroy")]
                [Validation(Required=false)]
                public bool? IsDestroy { get; set; }

                [NameInMap("moduleVersion")]
                [Validation(Required=false)]
                public string ModuleVersion { get; set; }

                [NameInMap("resourcesChanged")]
                [Validation(Required=false)]
                public string ResourcesChanged { get; set; }

            }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("jobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            [NameInMap("parameters")]
            [Validation(Required=false)]
            public Dictionary<string, string> Parameters { get; set; }

            [NameInMap("runtimeType")]
            [Validation(Required=false)]
            public string RuntimeType { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("statusDetail")]
            [Validation(Required=false)]
            public Dictionary<string, JobStatusDetailValue> StatusDetail { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
