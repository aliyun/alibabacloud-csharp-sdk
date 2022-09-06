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
                [NameInMap("DeploymentId")]
                [Validation(Required=false)]
                public string DeploymentId { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("GmtCompleted")]
                [Validation(Required=false)]
                public string GmtCompleted { get; set; }

                [NameInMap("GmtCompletedTimestamp")]
                [Validation(Required=false)]
                public long? GmtCompletedTimestamp { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtCreateTimestamp")]
                [Validation(Required=false)]
                public long? GmtCreateTimestamp { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("GmtModifiedTimestamp")]
                [Validation(Required=false)]
                public long? GmtModifiedTimestamp { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

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
