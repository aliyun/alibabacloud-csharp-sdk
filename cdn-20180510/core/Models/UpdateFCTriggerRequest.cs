// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class UpdateFCTriggerRequest : TeaModel {
        [NameInMap("FunctionARN")]
        [Validation(Required=false)]
        public string FunctionARN { get; set; }

        [NameInMap("Notes")]
        [Validation(Required=false)]
        public string Notes { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RoleARN")]
        [Validation(Required=false)]
        public string RoleARN { get; set; }

        [NameInMap("SourceARN")]
        [Validation(Required=false)]
        public string SourceARN { get; set; }

        [NameInMap("TriggerARN")]
        [Validation(Required=false)]
        public string TriggerARN { get; set; }

    }

}
