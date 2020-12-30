// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class SaveWebRTCStatsRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RecordTime")]
        [Validation(Required=false)]
        public long? RecordTime { get; set; }

        [NameInMap("CallId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        [NameInMap("CallerNumber")]
        [Validation(Required=false)]
        public string CallerNumber { get; set; }

        [NameInMap("CalleeNumber")]
        [Validation(Required=false)]
        public string CalleeNumber { get; set; }

        [NameInMap("CallStartTime")]
        [Validation(Required=false)]
        public long? CallStartTime { get; set; }

        [NameInMap("Stats")]
        [Validation(Required=false)]
        public string Stats { get; set; }

        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
