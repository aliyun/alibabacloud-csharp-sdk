// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class QueryEdsAgentReportConfigResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryEdsAgentReportConfigResponseBodyData Data { get; set; }
        public class QueryEdsAgentReportConfigResponseBodyData : TeaModel {
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
