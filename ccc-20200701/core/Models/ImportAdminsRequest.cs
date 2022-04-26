// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ImportAdminsRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RamIdList")]
        [Validation(Required=false)]
        public string RamIdList { get; set; }

    }

}
