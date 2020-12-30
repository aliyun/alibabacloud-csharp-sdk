// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops_rdc20200303.Models
{
    public class ListCommonGroupRequest : TeaModel {
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("SmartGroupId")]
        [Validation(Required=false)]
        public string SmartGroupId { get; set; }

        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

    }

}
