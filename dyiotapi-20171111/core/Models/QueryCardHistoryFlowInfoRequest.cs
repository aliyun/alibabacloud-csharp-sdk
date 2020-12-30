// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyiotapi20171111.Models
{
    public class QueryCardHistoryFlowInfoRequest : TeaModel {
        [NameInMap("Iccid")]
        [Validation(Required=false)]
        public string Iccid { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

    }

}
