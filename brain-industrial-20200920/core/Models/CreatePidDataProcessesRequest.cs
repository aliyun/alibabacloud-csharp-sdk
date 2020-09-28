// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class CreatePidDataProcessesRequest : TeaModel {
        [NameInMap("PidProjectId")]
        [Validation(Required=true)]
        public string PidProjectId { get; set; }

        [NameInMap("PidLoopId")]
        [Validation(Required=true)]
        public string PidLoopId { get; set; }

        [NameInMap("DataProcessTime")]
        [Validation(Required=true)]
        public List<CreatePidDataProcessesRequestDataProcessTime> DataProcessTime { get; set; }
        public class CreatePidDataProcessesRequestDataProcessTime : TeaModel {
            [NameInMap("StartTime")]
            [Validation(Required=true)]
            public string StartTime { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=true)]
            public string EndTime { get; set; }

        }

        [NameInMap("ClientToken")]
        [Validation(Required=true)]
        public string ClientToken { get; set; }

    }

}
