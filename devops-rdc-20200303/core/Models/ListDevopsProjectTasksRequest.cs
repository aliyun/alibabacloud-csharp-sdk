// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops_rdc20200303.Models
{
    public class ListDevopsProjectTasksRequest : TeaModel {
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        [NameInMap("ProjectIds")]
        [Validation(Required=false)]
        public string ProjectIds { get; set; }

    }

}
