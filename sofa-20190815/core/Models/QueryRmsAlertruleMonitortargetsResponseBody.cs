// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsAlertruleMonitortargetsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Response")]
        [Validation(Required=false)]
        public QueryRmsAlertruleMonitortargetsResponseBodyResponse Response { get; set; }
        public class QueryRmsAlertruleMonitortargetsResponseBodyResponse : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryRmsAlertruleMonitortargetsResponseBodyResponseData> Data { get; set; }
            public class QueryRmsAlertruleMonitortargetsResponseBodyResponseData : TeaModel {
                public string MonitorTargetId { get; set; }
                public string MonitorTargetName { get; set; }
                public string MonitorTargetType { get; set; }
                public string TenantId { get; set; }
                public string WorkspaceId { get; set; }
            }
        };

    }

}
