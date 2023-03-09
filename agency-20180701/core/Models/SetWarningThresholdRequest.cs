// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180701.Models
{
    public class SetWarningThresholdRequest : TeaModel {
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

        [NameInMap("WarningValue")]
        [Validation(Required=false)]
        public string WarningValue { get; set; }

    }

}
