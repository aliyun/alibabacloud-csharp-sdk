// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryEdgeInstanceHistoricDeploymentResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryEdgeInstanceHistoricDeploymentResponseData Data { get; set; }
        public class QueryEdgeInstanceHistoricDeploymentResponseData : TeaModel {
            [NameInMap("Total")]
            [Validation(Required=true)]
            public int? Total { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
            [NameInMap("CurrentPage")]
            [Validation(Required=true)]
            public int? CurrentPage { get; set; }
            [NameInMap("DeploymentList")]
            [Validation(Required=true)]
            public List<QueryEdgeInstanceHistoricDeploymentResponseDataDeploymentList> DeploymentList { get; set; }
            public class QueryEdgeInstanceHistoricDeploymentResponseDataDeploymentList : TeaModel {
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public string GmtCompleted { get; set; }
                public string DeploymentId { get; set; }
                public string Description { get; set; }
                public int? Status { get; set; }
                public string Type { get; set; }
                public long? GmtCreateTimestamp { get; set; }
                public long? GmtModifiedTimestamp { get; set; }
                public long? GmtCompletedTimestamp { get; set; }
            }
        };

    }

}
