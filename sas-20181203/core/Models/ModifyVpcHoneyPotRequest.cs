// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyVpcHoneyPotRequest : TeaModel {
        [NameInMap("HoneyPotAction")]
        [Validation(Required=false)]
        public string HoneyPotAction { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
