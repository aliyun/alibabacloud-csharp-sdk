// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class TaskInvocation : TeaModel {
        [NameInMap("instanceID")]
        [Validation(Required=false)]
        public string InstanceID { get; set; }

        [NameInMap("invocationID")]
        [Validation(Required=false)]
        public string InvocationID { get; set; }

        [NameInMap("invocationTarget")]
        [Validation(Required=false)]
        public string InvocationTarget { get; set; }

        [NameInMap("output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        [NameInMap("requestID")]
        [Validation(Required=false)]
        public string RequestID { get; set; }

        [NameInMap("slsLogStore")]
        [Validation(Required=false)]
        public string SlsLogStore { get; set; }

        [NameInMap("slsProject")]
        [Validation(Required=false)]
        public string SlsProject { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
