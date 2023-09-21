// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateFileProtectEventStatusRequest : TeaModel {
        [NameInMap("Id")]
        [Validation(Required=false)]
        public List<long?> Id { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
