// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class HotUpdateJobParams : TeaModel {
        [NameInMap("rescaleJobParam")]
        [Validation(Required=false)]
        public RescaleJobParam RescaleJobParam { get; set; }

        [NameInMap("updateJobConfigParam")]
        [Validation(Required=false)]
        public UpdateJobConfigParam UpdateJobConfigParam { get; set; }

    }

}
