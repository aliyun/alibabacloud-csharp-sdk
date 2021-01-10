// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class UpdateTriggerRequest : TeaModel {
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Sandbox")]
        [Validation(Required=false)]
        public int? Sandbox { get; set; }

        [NameInMap("Production")]
        [Validation(Required=false)]
        public int? Production { get; set; }

    }

}
