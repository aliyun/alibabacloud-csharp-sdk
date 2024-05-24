// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class PipelineTriggerEventStatus : TeaModel {
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("firedPipelineName")]
        [Validation(Required=false)]
        public string FiredPipelineName { get; set; }

        [NameInMap("releaseDetail")]
        [Validation(Required=false)]
        public ReleaseDetail ReleaseDetail { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
