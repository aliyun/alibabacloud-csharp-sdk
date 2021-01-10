// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListCoverPipelineResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PipelineList")]
        [Validation(Required=false)]
        public ListCoverPipelineResponseBodyPipelineList PipelineList { get; set; }
        public class ListCoverPipelineResponseBodyPipelineList : TeaModel {
            [NameInMap("Pipeline")]
            [Validation(Required=false)]
            public List<ListCoverPipelineResponseBodyPipelineListPipeline> Pipeline { get; set; }
            public class ListCoverPipelineResponseBodyPipelineListPipeline : TeaModel {
                public long? UserId { get; set; }
                public string PipelineId { get; set; }
                public string Name { get; set; }
                public string State { get; set; }
                public string Priority { get; set; }
                public int? QuotaNum { get; set; }
                public int? QuotaUsed { get; set; }
                public string NotifyConfig { get; set; }
                public string Role { get; set; }
                public string ExtendConfig { get; set; }
            }
        };

    }

}
