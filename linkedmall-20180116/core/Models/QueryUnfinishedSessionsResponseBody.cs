// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryUnfinishedSessionsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("LmActivitySessionModelList")]
        [Validation(Required=false)]
        public QueryUnfinishedSessionsResponseBodyLmActivitySessionModelList LmActivitySessionModelList { get; set; }
        public class QueryUnfinishedSessionsResponseBodyLmActivitySessionModelList : TeaModel {
            [NameInMap("LmActivitySessionModel")]
            [Validation(Required=false)]
            public List<QueryUnfinishedSessionsResponseBodyLmActivitySessionModelListLmActivitySessionModel> LmActivitySessionModel { get; set; }
            public class QueryUnfinishedSessionsResponseBodyLmActivitySessionModelListLmActivitySessionModel : TeaModel {
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DisplayDate")]
                [Validation(Required=false)]
                public string DisplayDate { get; set; }

                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                [NameInMap("LmActivityId")]
                [Validation(Required=false)]
                public long? LmActivityId { get; set; }

                [NameInMap("LmSessionId")]
                [Validation(Required=false)]
                public long? LmSessionId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("StartDate")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

                [NameInMap("SubBizCode")]
                [Validation(Required=false)]
                public string SubBizCode { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
