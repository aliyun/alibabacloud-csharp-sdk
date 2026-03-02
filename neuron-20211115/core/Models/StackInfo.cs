// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class StackInfo : TeaModel {
        [NameInMap("api")]
        [Validation(Required=false)]
        public string Api { get; set; }

        [NameInMap("duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        [NameInMap("exception")]
        [Validation(Required=false)]
        public string Exception { get; set; }

        [NameInMap("extInfo")]
        [Validation(Required=false)]
        public StackInfoExtInfo ExtInfo { get; set; }

        [NameInMap("line")]
        [Validation(Required=false)]
        public string Line { get; set; }

        [NameInMap("rpcId")]
        [Validation(Required=false)]
        public string RpcId { get; set; }

        [NameInMap("serviceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
