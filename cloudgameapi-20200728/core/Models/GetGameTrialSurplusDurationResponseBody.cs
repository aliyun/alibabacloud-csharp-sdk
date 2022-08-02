// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class GetGameTrialSurplusDurationResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public float? Status { get; set; }

        [NameInMap("SurplusDuration")]
        [Validation(Required=false)]
        public double? SurplusDuration { get; set; }

    }

}
