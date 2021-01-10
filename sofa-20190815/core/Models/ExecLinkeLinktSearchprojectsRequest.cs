// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ExecLinkeLinktSearchprojectsRequest : TeaModel {
        [NameInMap("IncludeArchived")]
        [Validation(Required=false)]
        public string IncludeArchived { get; set; }

        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("OnlyParticipated")]
        [Validation(Required=false)]
        public string OnlyParticipated { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public string Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("RoleControl")]
        [Validation(Required=false)]
        public string RoleControl { get; set; }

    }

}
