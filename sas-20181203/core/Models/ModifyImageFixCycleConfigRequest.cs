// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyImageFixCycleConfigRequest : TeaModel {
        [NameInMap("ImageFixCycle")]
        [Validation(Required=false)]
        public int? ImageFixCycle { get; set; }

        [NameInMap("ImageFixSwitch")]
        [Validation(Required=false)]
        public string ImageFixSwitch { get; set; }

        [NameInMap("ImageFixTarget")]
        [Validation(Required=false)]
        public string ImageFixTarget { get; set; }

        [NameInMap("ImageTimeRange")]
        [Validation(Required=false)]
        public int? ImageTimeRange { get; set; }

    }

}
