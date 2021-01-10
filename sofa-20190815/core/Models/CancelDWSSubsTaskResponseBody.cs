// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CancelDWSSubsTaskResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CancelDWSSubsTaskResponseBodyData Data { get; set; }
        public class CancelDWSSubsTaskResponseBodyData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("GmtModify")]
            [Validation(Required=false)]
            public long? GmtModify { get; set; }
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }
            [NameInMap("ConnectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }
            [NameInMap("Consumer")]
            [Validation(Required=false)]
            public string Consumer { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("TableId")]
            [Validation(Required=false)]
            public string TableId { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }
            [NameInMap("ClusterUrl")]
            [Validation(Required=false)]
            public string ClusterUrl { get; set; }
        };

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
