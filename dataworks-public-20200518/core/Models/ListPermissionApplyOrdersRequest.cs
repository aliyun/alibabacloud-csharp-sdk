// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListPermissionApplyOrdersRequest : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        [NameInMap("FlowStatus")]
        [Validation(Required=false)]
        public int? FlowStatus { get; set; }

        [NameInMap("MaxComputeProjectName")]
        [Validation(Required=false)]
        public string MaxComputeProjectName { get; set; }

        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public int? OrderType { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public int? QueryType { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public int? WorkspaceId { get; set; }

    }

}
