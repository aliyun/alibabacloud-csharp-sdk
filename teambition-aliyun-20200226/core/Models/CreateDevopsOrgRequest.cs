// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Teambition_aliyun20200226.Models
{
    public class CreateDevopsOrgRequest : TeaModel {
        [NameInMap("OrgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("RealPk")]
        [Validation(Required=false)]
        public string RealPk { get; set; }

        [NameInMap("DesiredMemberCount")]
        [Validation(Required=false)]
        public int? DesiredMemberCount { get; set; }

    }

}
