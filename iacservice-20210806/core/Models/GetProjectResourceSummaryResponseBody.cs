// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetProjectResourceSummaryResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resourceSummary")]
        [Validation(Required=false)]
        public GetProjectResourceSummaryResponseBodyResourceSummary ResourceSummary { get; set; }
        public class GetProjectResourceSummaryResponseBodyResourceSummary : TeaModel {
            [NameInMap("detail")]
            [Validation(Required=false)]
            public List<GetProjectResourceSummaryResponseBodyResourceSummaryDetail> Detail { get; set; }
            public class GetProjectResourceSummaryResponseBodyResourceSummaryDetail : TeaModel {
                [NameInMap("resourceCnt")]
                [Validation(Required=false)]
                public long? ResourceCnt { get; set; }

                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                [NameInMap("taskIds")]
                [Validation(Required=false)]
                public List<string> TaskIds { get; set; }

            }

            [NameInMap("resourceCnt")]
            [Validation(Required=false)]
            public long? ResourceCnt { get; set; }

            [NameInMap("resourceTypeCnt")]
            [Validation(Required=false)]
            public long? ResourceTypeCnt { get; set; }

        }

    }

}
