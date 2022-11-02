// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyResourceLogStatusRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public bool? Status { get; set; }

    }

}
