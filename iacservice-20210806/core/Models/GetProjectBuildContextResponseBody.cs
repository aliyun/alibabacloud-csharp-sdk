// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetProjectBuildContextResponseBody : TeaModel {
        [NameInMap("ProjectBuild")]
        [Validation(Required=false)]
        public GetProjectBuildContextResponseBodyProjectBuild ProjectBuild { get; set; }
        public class GetProjectBuildContextResponseBodyProjectBuild : TeaModel {
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("failCnt")]
            [Validation(Required=false)]
            public long? FailCnt { get; set; }

            [NameInMap("jobList")]
            [Validation(Required=false)]
            public List<GetProjectBuildContextResponseBodyProjectBuildJobList> JobList { get; set; }
            public class GetProjectBuildContextResponseBodyProjectBuildJobList : TeaModel {
                [NameInMap("isDeleted")]
                [Validation(Required=false)]
                public long? IsDeleted { get; set; }

                [NameInMap("jobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("moduleId")]
                [Validation(Required=false)]
                public string ModuleId { get; set; }

                [NameInMap("moduleVersion")]
                [Validation(Required=false)]
                public string ModuleVersion { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("taskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

            [NameInMap("jobTotalCnt")]
            [Validation(Required=false)]
            public long? JobTotalCnt { get; set; }

            [NameInMap("projectBuildId")]
            [Validation(Required=false)]
            public string ProjectBuildId { get; set; }

            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("resourceCnt")]
            [Validation(Required=false)]
            public long? ResourceCnt { get; set; }

            [NameInMap("resourceList")]
            [Validation(Required=false)]
            public List<GetProjectBuildContextResponseBodyProjectBuildResourceList> ResourceList { get; set; }
            public class GetProjectBuildContextResponseBodyProjectBuildResourceList : TeaModel {
                [NameInMap("info")]
                [Validation(Required=false)]
                public Dictionary<string, string> Info { get; set; }

                [NameInMap("resourceCnt")]
                [Validation(Required=false)]
                public long? ResourceCnt { get; set; }

                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            [NameInMap("resourceTypeCnt")]
            [Validation(Required=false)]
            public long? ResourceTypeCnt { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("successCnt")]
            [Validation(Required=false)]
            public long? SuccessCnt { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
