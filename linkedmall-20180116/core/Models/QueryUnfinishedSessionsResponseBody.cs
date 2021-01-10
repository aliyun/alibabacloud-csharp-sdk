// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryUnfinishedSessionsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("LmActivitySessionModelList")]
        [Validation(Required=false)]
        public QueryUnfinishedSessionsResponseBodyLmActivitySessionModelList LmActivitySessionModelList { get; set; }
        public class QueryUnfinishedSessionsResponseBodyLmActivitySessionModelList : TeaModel {
            [NameInMap("LmActivitySessionModel")]
            [Validation(Required=false)]
            public List<QueryUnfinishedSessionsResponseBodyLmActivitySessionModelListLmActivitySessionModel> LmActivitySessionModel { get; set; }
            public class QueryUnfinishedSessionsResponseBodyLmActivitySessionModelListLmActivitySessionModel : TeaModel {
                public string SubBizCode { get; set; }
                public string DisplayDate { get; set; }
                public string EndDate { get; set; }
                public string Description { get; set; }
                public long? LmSessionId { get; set; }
                public string BizId { get; set; }
                public long? LmActivityId { get; set; }
                public string StartDate { get; set; }
                public string Name { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
