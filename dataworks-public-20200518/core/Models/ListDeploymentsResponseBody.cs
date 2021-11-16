// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDeploymentsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDeploymentsResponseBodyData Data { get; set; }
        public class ListDeploymentsResponseBodyData : TeaModel {
            [NameInMap("Deployments")]
            [Validation(Required=false)]
            public List<ListDeploymentsResponseBodyDataDeployments> Deployments { get; set; }
            public class ListDeploymentsResponseBodyDataDeployments : TeaModel {
                public long? CreateTime { get; set; }
                public string Creator { get; set; }
                public string ErrorMessage { get; set; }
                public long? ExecuteTime { get; set; }
                public string Executor { get; set; }
                public long? Id { get; set; }
                public string Name { get; set; }
                public int? Status { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
