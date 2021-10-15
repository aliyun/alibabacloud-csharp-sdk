// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeXpackMonitorConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeXpackMonitorConfigResponseBodyResult Result { get; set; }
        public class DescribeXpackMonitorConfigResponseBodyResult : TeaModel {
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }
            [NameInMap("esInstanceId")]
            [Validation(Required=false)]
            public string EsInstanceId { get; set; }
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }
            [NameInMap("endpoints")]
            [Validation(Required=false)]
            public List<string> Endpoints { get; set; }
            [NameInMap("pipelineIds")]
            [Validation(Required=false)]
            public List<string> PipelineIds { get; set; }
        };

    }

}
