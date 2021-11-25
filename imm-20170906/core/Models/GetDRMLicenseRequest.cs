// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class GetDRMLicenseRequest : TeaModel {
        [NameInMap("DRMLicense")]
        [Validation(Required=false)]
        public string DRMLicense { get; set; }

        [NameInMap("DRMType")]
        [Validation(Required=false)]
        public string DRMType { get; set; }

        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

    }

}
