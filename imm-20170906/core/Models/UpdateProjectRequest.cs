// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class UpdateProjectRequest : TeaModel {
        [NameInMap("NewCU")]
        [Validation(Required=false)]
        public int? NewCU { get; set; }

        [NameInMap("NewServiceRole")]
        [Validation(Required=false)]
        public string NewServiceRole { get; set; }

        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

    }

}
