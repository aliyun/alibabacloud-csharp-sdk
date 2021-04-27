// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryEdgeInstanceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryEdgeInstanceResponseBodyData Data { get; set; }
        public class QueryEdgeInstanceResponseBodyData : TeaModel {
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("InstanceList")]
            [Validation(Required=false)]
            public List<QueryEdgeInstanceResponseBodyDataInstanceList> InstanceList { get; set; }
            public class QueryEdgeInstanceResponseBodyDataInstanceList : TeaModel {
                public string InstanceId { get; set; }
                public string Name { get; set; }
                public string Tags { get; set; }
                public int? Type { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public string RoleArn { get; set; }
                public string RoleName { get; set; }
                public string RoleAttachTime { get; set; }
                public int? Spec { get; set; }
                public bool? BizEnable { get; set; }
                public int? LatestDeploymentStatus { get; set; }
                public string LatestDeploymentType { get; set; }
                public long? GmtCreateTimestamp { get; set; }
                public long? GmtModifiedTimestamp { get; set; }
                public long? RoleAttachTimestamp { get; set; }
            }
        };

    }

}
