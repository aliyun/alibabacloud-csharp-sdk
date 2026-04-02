// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class QueryAlertRulesInput : TeaModel {
        [NameInMap("filter")]
        [Validation(Required=false)]
        public QueryAlertRulesFilter Filter { get; set; }

        [NameInMap("pagination")]
        [Validation(Required=false)]
        public Pagination Pagination { get; set; }

        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
