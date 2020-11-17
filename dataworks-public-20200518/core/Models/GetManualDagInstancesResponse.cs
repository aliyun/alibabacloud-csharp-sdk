// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetManualDagInstancesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Instances")]
        [Validation(Required=true)]
        public List<GetManualDagInstancesResponseInstances> Instances { get; set; }
        public class GetManualDagInstancesResponseInstances : TeaModel {
            [NameInMap("NodeId")]
            [Validation(Required=true)]
            public long NodeId { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=true)]
            public long InstanceId { get; set; }

            [NameInMap("DagId")]
            [Validation(Required=true)]
            public long DagId { get; set; }

            [NameInMap("DagType")]
            [Validation(Required=true)]
            public string DagType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }

            [NameInMap("BizDate")]
            [Validation(Required=true)]
            public long BizDate { get; set; }

            [NameInMap("CycTime")]
            [Validation(Required=true)]
            public long CycTime { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=true)]
            public long CreateTime { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=true)]
            public long ModifyTime { get; set; }

            [NameInMap("NodeName")]
            [Validation(Required=true)]
            public string NodeName { get; set; }

            [NameInMap("BeginWaitTimeTime")]
            [Validation(Required=true)]
            public long BeginWaitTimeTime { get; set; }

            [NameInMap("BeginWaitResTime")]
            [Validation(Required=true)]
            public long BeginWaitResTime { get; set; }

            [NameInMap("BeginRunningTime")]
            [Validation(Required=true)]
            public long BeginRunningTime { get; set; }

            [NameInMap("ParamValues")]
            [Validation(Required=true)]
            public string ParamValues { get; set; }

            [NameInMap("FinishTime")]
            [Validation(Required=true)]
            public long FinishTime { get; set; }

        }

    }

}
