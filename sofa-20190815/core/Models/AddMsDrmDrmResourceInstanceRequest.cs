// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddMsDrmDrmResourceInstanceRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        [NameInMap("TplId")]
        [Validation(Required=false)]
        public long? TplId { get; set; }

    }

}
