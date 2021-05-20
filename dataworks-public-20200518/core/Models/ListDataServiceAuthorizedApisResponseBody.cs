// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDataServiceAuthorizedApisResponseBody : TeaModel {
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDataServiceAuthorizedApisResponseBodyData Data { get; set; }
        public class ListDataServiceAuthorizedApisResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("ApiAuthorizedList")]
            [Validation(Required=false)]
            public List<ListDataServiceAuthorizedApisResponseBodyDataApiAuthorizedList> ApiAuthorizedList { get; set; }
            public class ListDataServiceAuthorizedApisResponseBodyDataApiAuthorizedList : TeaModel {
                public long? ApiId { get; set; }
                public int? ApiStatus { get; set; }
                public string GrantOperatorId { get; set; }
                public long? ProjectId { get; set; }
                public string CreatorId { get; set; }
                public string GrantEndTime { get; set; }
                public string ModifiedTime { get; set; }
                public string GroupId { get; set; }
                public string GrantCreatedTime { get; set; }
                public string CreatedTime { get; set; }
                public string ApiName { get; set; }
                public long? TenantId { get; set; }
                public string ApiPath { get; set; }
            }
        };

    }

}
