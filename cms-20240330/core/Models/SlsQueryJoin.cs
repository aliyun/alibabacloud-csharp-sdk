// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class SlsQueryJoin : TeaModel {
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public List<SlsJoinCondition> Conditions { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
