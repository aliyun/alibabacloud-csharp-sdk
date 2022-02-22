// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class ListPodsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListPodsResponseBodyData> Data { get; set; }
        public class ListPodsResponseBodyData : TeaModel {
            [NameInMap("AppInstanceId")]
            [Validation(Required=false)]
            public string AppInstanceId { get; set; }

            [NameInMap("DeployOrderId")]
            [Validation(Required=false)]
            public long? DeployOrderId { get; set; }

            [NameInMap("DeployPartitionNum")]
            [Validation(Required=false)]
            public int? DeployPartitionNum { get; set; }

            [NameInMap("DeploySteps")]
            [Validation(Required=false)]
            public List<ListPodsResponseBodyDataDeploySteps> DeploySteps { get; set; }
            public class ListPodsResponseBodyDataDeploySteps : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("StepCode")]
                [Validation(Required=false)]
                public string StepCode { get; set; }

                [NameInMap("StepName")]
                [Validation(Required=false)]
                public string StepName { get; set; }

            }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("HostIp")]
            [Validation(Required=false)]
            public string HostIp { get; set; }

            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            [NameInMap("PodIp")]
            [Validation(Required=false)]
            public string PodIp { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public int? Result { get; set; }

            [NameInMap("ResultName")]
            [Validation(Required=false)]
            public string ResultName { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("StatusName")]
            [Validation(Required=false)]
            public string StatusName { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
