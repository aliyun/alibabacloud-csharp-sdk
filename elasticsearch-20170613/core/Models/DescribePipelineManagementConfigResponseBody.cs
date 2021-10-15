// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribePipelineManagementConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribePipelineManagementConfigResponseBodyResult Result { get; set; }
        public class DescribePipelineManagementConfigResponseBodyResult : TeaModel {
            [NameInMap("endpoints")]
            [Validation(Required=false)]
            public string Endpoints { get; set; }
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }
            [NameInMap("pipelineManagementType")]
            [Validation(Required=false)]
            public string PipelineManagementType { get; set; }
            [NameInMap("esInstanceId")]
            [Validation(Required=false)]
            public string EsInstanceId { get; set; }
            [NameInMap("pipelineIds")]
            [Validation(Required=false)]
            public List<string> PipelineIds { get; set; }
        };

    }

}
