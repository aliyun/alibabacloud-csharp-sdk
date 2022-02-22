// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class SyncPodInfoRequest : TeaModel {
        [NameInMap("PodName")]
        [Validation(Required=false)]
        public string PodName { get; set; }

        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SideCarType")]
        [Validation(Required=false)]
        public string SideCarType { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public bool? Status { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
