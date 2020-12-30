// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListJobInstanceWorkersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("JobInstanceWorkers")]
        [Validation(Required=false)]
        public ListJobInstanceWorkersResponseBodyJobInstanceWorkers JobInstanceWorkers { get; set; }
        public class ListJobInstanceWorkersResponseBodyJobInstanceWorkers : TeaModel {
            [NameInMap("JobInstanceWorkerInfo")]
            [Validation(Required=false)]
            public List<ListJobInstanceWorkersResponseBodyJobInstanceWorkersJobInstanceWorkerInfo> JobInstanceWorkerInfo { get; set; }
            public class ListJobInstanceWorkersResponseBodyJobInstanceWorkersJobInstanceWorkerInfo : TeaModel {
                public string ContainerInfo { get; set; }
                public string InstanceInfo { get; set; }
                public string ApplicationId { get; set; }
            }
        };

    }

}
