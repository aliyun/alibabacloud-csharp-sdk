// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CheckTrialFixCountResponseBody : TeaModel {
        [NameInMap("CanFix")]
        [Validation(Required=false)]
        public bool? CanFix { get; set; }

        [NameInMap("ExpendCount")]
        [Validation(Required=false)]
        public int? ExpendCount { get; set; }

        [NameInMap("RemainCount")]
        [Validation(Required=false)]
        public int? RemainCount { get; set; }

        [NameInMap("RepairedCount")]
        [Validation(Required=false)]
        public int? RepairedCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("isTrial")]
        [Validation(Required=false)]
        public bool? IsTrial { get; set; }

    }

}
