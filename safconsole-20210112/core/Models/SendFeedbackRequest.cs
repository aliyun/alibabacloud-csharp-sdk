// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safconsole20210112.Models
{
    public class SendFeedbackRequest : TeaModel {
        [NameInMap("RiskLabel")]
        [Validation(Required=false)]
        public string RiskLabel { get; set; }

        [NameInMap("SampleType")]
        [Validation(Required=false)]
        public string SampleType { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
