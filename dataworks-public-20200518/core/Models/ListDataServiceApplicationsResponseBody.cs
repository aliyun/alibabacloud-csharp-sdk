// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDataServiceApplicationsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDataServiceApplicationsResponseBodyData Data { get; set; }
        public class ListDataServiceApplicationsResponseBodyData : TeaModel {
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public List<ListDataServiceApplicationsResponseBodyDataApplications> Applications { get; set; }
            public class ListDataServiceApplicationsResponseBodyDataApplications : TeaModel {
                public long? ApplicationId { get; set; }
                public string ApplicationName { get; set; }
                public long? ProjectId { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
