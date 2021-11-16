// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetManualDagInstancesResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<GetManualDagInstancesResponseBodyInstances> Instances { get; set; }
        public class GetManualDagInstancesResponseBodyInstances : TeaModel {
            [NameInMap("BeginRunningTime")]
            [Validation(Required=false)]
            public long? BeginRunningTime { get; set; }

            [NameInMap("BeginWaitResTime")]
            [Validation(Required=false)]
            public long? BeginWaitResTime { get; set; }

            [NameInMap("BeginWaitTimeTime")]
            [Validation(Required=false)]
            public long? BeginWaitTimeTime { get; set; }

            [NameInMap("BizDate")]
            [Validation(Required=false)]
            public long? BizDate { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("CycTime")]
            [Validation(Required=false)]
            public long? CycTime { get; set; }

            [NameInMap("DagId")]
            [Validation(Required=false)]
            public long? DagId { get; set; }

            [NameInMap("DagType")]
            [Validation(Required=false)]
            public string DagType { get; set; }

            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public long? NodeId { get; set; }

            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            [NameInMap("ParamValues")]
            [Validation(Required=false)]
            public string ParamValues { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
