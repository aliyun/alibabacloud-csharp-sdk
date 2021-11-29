// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class DescribeDiskOpsActivityResponseBody : TeaModel {
        [NameInMap("ActivityState")]
        [Validation(Required=false)]
        public string ActivityState { get; set; }

        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        [NameInMap("CurrentActivity")]
        [Validation(Required=false)]
        public string CurrentActivity { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("NeedReboot")]
        [Validation(Required=false)]
        public bool? NeedReboot { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
