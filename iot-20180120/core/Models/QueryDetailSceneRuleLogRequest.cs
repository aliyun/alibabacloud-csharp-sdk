// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDetailSceneRuleLogRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("RuleId")]
        [Validation(Required=true)]
        public string RuleId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=true)]
        public int? StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=true)]
        public int? EndTime { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=true)]
        public string TraceId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=true)]
        public int? CurrentPage { get; set; }

    }

}
