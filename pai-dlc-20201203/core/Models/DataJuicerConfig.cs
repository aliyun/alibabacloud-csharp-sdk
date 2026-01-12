// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class DataJuicerConfig : TeaModel {
        [NameInMap("CommandType")]
        [Validation(Required=false)]
        public string CommandType { get; set; }

        [NameInMap("EnableResourceEstimation")]
        [Validation(Required=false)]
        public bool? EnableResourceEstimation { get; set; }

        [NameInMap("ExecutionMode")]
        [Validation(Required=false)]
        public string ExecutionMode { get; set; }

        [NameInMap("ResourceLimit")]
        [Validation(Required=false)]
        public ResourceLimit ResourceLimit { get; set; }

    }

}
