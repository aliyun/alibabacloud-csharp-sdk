// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DeleteMonitorGroupDynamicRuleRequest : TeaModel {
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

    }

}
