// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetDWSSubsTasksResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDWSSubsTasksResponseBodyData Data { get; set; }
        public class GetDWSSubsTasksResponseBodyData : TeaModel {
            [NameInMap("CurrentPageCount")]
            [Validation(Required=false)]
            public long? CurrentPageCount { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
            [NameInMap("Tasks")]
            [Validation(Required=false)]
            public List<GetDWSSubsTasksResponseBodyDataTasks> Tasks { get; set; }
            public class GetDWSSubsTasksResponseBodyDataTasks : TeaModel {
                public string ClusterUrl { get; set; }
                public string Comment { get; set; }
                public string ConnectionString { get; set; }
                public string Consumer { get; set; }
                public long? GmtCreate { get; set; }
                public long? GmtModify { get; set; }
                public string Group { get; set; }
                public long? Id { get; set; }
                public string Name { get; set; }
                public string Status { get; set; }
                public string TableId { get; set; }
            }
        };

    }

}
