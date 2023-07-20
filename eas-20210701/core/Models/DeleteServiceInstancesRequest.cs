// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DeleteServiceInstancesRequest : TeaModel {
        [NameInMap("Container")]
        [Validation(Required=false)]
        public string Container { get; set; }

        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public string InstanceList { get; set; }

        [NameInMap("SoftRestart")]
        [Validation(Required=false)]
        public bool? SoftRestart { get; set; }

    }

}
