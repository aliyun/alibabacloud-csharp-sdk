// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class LimitRule : TeaModel {
        [NameInMap("beginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        [NameInMap("condcase")]
        [Validation(Required=false)]
        public string Condcase { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("limitNum")]
        [Validation(Required=false)]
        public int? LimitNum { get; set; }

        [NameInMap("ruleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

    }

}
