// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetJobInfoResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetJobInfoResponseBodyData Data { get; set; }
        public class GetJobInfoResponseBodyData : TeaModel {
            [NameInMap("cuUsage")]
            [Validation(Required=false)]
            public long? CuUsage { get; set; }

            [NameInMap("endAtTime")]
            [Validation(Required=false)]
            public long? EndAtTime { get; set; }

            [NameInMap("extNodeId")]
            [Validation(Required=false)]
            public string ExtNodeId { get; set; }

            [NameInMap("extNodeOnDuty")]
            [Validation(Required=false)]
            public string ExtNodeOnDuty { get; set; }

            [NameInMap("extPlantFrom")]
            [Validation(Required=false)]
            public string ExtPlantFrom { get; set; }

            [NameInMap("inputBytes")]
            [Validation(Required=false)]
            public double? InputBytes { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("jobOwner")]
            [Validation(Required=false)]
            public string JobOwner { get; set; }

            [NameInMap("jobSubStatusList")]
            [Validation(Required=false)]
            public List<GetJobInfoResponseBodyDataJobSubStatusList> JobSubStatusList { get; set; }
            public class GetJobInfoResponseBodyDataJobSubStatusList : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            [NameInMap("jobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            [NameInMap("memoryUsage")]
            [Validation(Required=false)]
            public long? MemoryUsage { get; set; }

            [NameInMap("priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            [NameInMap("project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            [NameInMap("quotaNickname")]
            [Validation(Required=false)]
            public string QuotaNickname { get; set; }

            [NameInMap("quotaType")]
            [Validation(Required=false)]
            public string QuotaType { get; set; }

            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("runningAtTime")]
            [Validation(Required=false)]
            public long? RunningAtTime { get; set; }

            [NameInMap("runningTime")]
            [Validation(Required=false)]
            public long? RunningTime { get; set; }

            [NameInMap("sceneResults")]
            [Validation(Required=false)]
            public List<GetJobInfoResponseBodyDataSceneResults> SceneResults { get; set; }
            public class GetJobInfoResponseBodyDataSceneResults : TeaModel {
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("params")]
                [Validation(Required=false)]
                public Dictionary<string, string> Params { get; set; }

                [NameInMap("scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                [NameInMap("sceneTag")]
                [Validation(Required=false)]
                public string SceneTag { get; set; }

                [NameInMap("summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("submittedAtTime")]
            [Validation(Required=false)]
            public long? SubmittedAtTime { get; set; }

            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            [NameInMap("totalTime")]
            [Validation(Required=false)]
            public long? TotalTime { get; set; }

            [NameInMap("waitingTime")]
            [Validation(Required=false)]
            public long? WaitingTime { get; set; }

        }

        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
