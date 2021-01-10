// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ImportDSTSlsTokenRequest : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
