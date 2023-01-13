// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryEdgeInstanceHistoricDeploymentResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryEdgeInstanceHistoricDeploymentResponseData Data { get; set; }
        public class QueryEdgeInstanceHistoricDeploymentResponseData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=true)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=true)]
            public int? Total { get; set; }

            [NameInMap("DeploymentList")]
            [Validation(Required=true)]
            public List<QueryEdgeInstanceHistoricDeploymentResponseDataDeploymentList> DeploymentList { get; set; }
            public class QueryEdgeInstanceHistoricDeploymentResponseDataDeploymentList : TeaModel {
                [NameInMap("DeploymentId")]
                [Validation(Required=true)]
                public string DeploymentId { get; set; }

                [NameInMap("Description")]
                [Validation(Required=true)]
                public string Description { get; set; }

                [NameInMap("GmtCompleted")]
                [Validation(Required=true)]
                public string GmtCompleted { get; set; }

                [NameInMap("GmtCompletedTimestamp")]
                [Validation(Required=true)]
                public long? GmtCompletedTimestamp { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=true)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtCreateTimestamp")]
                [Validation(Required=true)]
                public long? GmtCreateTimestamp { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=true)]
                public string GmtModified { get; set; }

                [NameInMap("GmtModifiedTimestamp")]
                [Validation(Required=true)]
                public long? GmtModifiedTimestamp { get; set; }

                [NameInMap("Status")]
                [Validation(Required=true)]
                public int? Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=true)]
                public string Type { get; set; }

            }

        }

    }

}
