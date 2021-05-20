// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTableOutputResponseBody : TeaModel {
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMetaTableOutputResponseBodyData Data { get; set; }
        public class GetMetaTableOutputResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
            [NameInMap("DataEntityList")]
            [Validation(Required=false)]
            public List<GetMetaTableOutputResponseBodyDataDataEntityList> DataEntityList { get; set; }
            public class GetMetaTableOutputResponseBodyDataDataEntityList : TeaModel {
                public string EndTime { get; set; }
                public long? TaskInstanceId { get; set; }
                public string StartTime { get; set; }
                public long? ProjectId { get; set; }
                public string WaitTime { get; set; }
                public string TableGuid { get; set; }
                public string TaskId { get; set; }
            }
        };

    }

}
