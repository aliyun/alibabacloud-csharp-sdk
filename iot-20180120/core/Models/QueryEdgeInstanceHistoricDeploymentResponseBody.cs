// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryEdgeInstanceHistoricDeploymentResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryEdgeInstanceHistoricDeploymentResponseBodyData Data { get; set; }
        public class QueryEdgeInstanceHistoricDeploymentResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("DeploymentList")]
            [Validation(Required=false)]
            public List<QueryEdgeInstanceHistoricDeploymentResponseBodyDataDeploymentList> DeploymentList { get; set; }
            public class QueryEdgeInstanceHistoricDeploymentResponseBodyDataDeploymentList : TeaModel {
                public string DeploymentId { get; set; }
                public string Description { get; set; }
                public string GmtCompleted { get; set; }
                public long? GmtCompletedTimestamp { get; set; }
                public string GmtCreate { get; set; }
                public long? GmtCreateTimestamp { get; set; }
                public string GmtModified { get; set; }
                public long? GmtModifiedTimestamp { get; set; }
                public int? Status { get; set; }
                public string Type { get; set; }
            }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
