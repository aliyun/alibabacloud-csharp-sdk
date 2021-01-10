// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeBahamutWorkitemsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryLinkeBahamutWorkitemsResponseBodyResult Result { get; set; }
        public class QueryLinkeBahamutWorkitemsResponseBodyResult : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("Datas")]
            [Validation(Required=false)]
            public List<QueryLinkeBahamutWorkitemsResponseBodyResultDatas> Datas { get; set; }
            public class QueryLinkeBahamutWorkitemsResponseBodyResultDatas : TeaModel {
                public string AcHour { get; set; }
                public string AssignedTo { get; set; }
                public string AssignedToStaffId { get; set; }
                public bool? CanSelect { get; set; }
                public string Creator { get; set; }
                public string CreatorId { get; set; }
                public string CreatorStaffId { get; set; }
                public string EsHour { get; set; }
                public string ExternalId { get; set; }
                public string Id { get; set; }
                public string Link { get; set; }
                public string NoSelectInfo { get; set; }
                public string NoSelectTag { get; set; }
                public string Priority { get; set; }
                public string PriorityId { get; set; }
                public string Progress { get; set; }
                public string ProjectId { get; set; }
                public string Stamp { get; set; }
                public string Status { get; set; }
                public string StatusId { get; set; }
                public string StatusStage { get; set; }
                public string Subject { get; set; }
                public string Url { get; set; }
            }
        };

    }

}
