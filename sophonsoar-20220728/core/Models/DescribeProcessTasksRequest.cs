// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeProcessTasksRequest : TeaModel {
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        [NameInMap("EntityName")]
        [Validation(Required=false)]
        public string EntityName { get; set; }

        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        [NameInMap("OrderField")]
        [Validation(Required=false)]
        public string OrderField { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ParamContent")]
        [Validation(Required=false)]
        public string ParamContent { get; set; }

        [NameInMap("ProcessActionEnd")]
        [Validation(Required=false)]
        public long? ProcessActionEnd { get; set; }

        [NameInMap("ProcessActionStart")]
        [Validation(Required=false)]
        public long? ProcessActionStart { get; set; }

        [NameInMap("ProcessRemoveEnd")]
        [Validation(Required=false)]
        public long? ProcessRemoveEnd { get; set; }

        [NameInMap("ProcessRemoveStart")]
        [Validation(Required=false)]
        public long? ProcessRemoveStart { get; set; }

        [NameInMap("ProcessStrategyUuid")]
        [Validation(Required=false)]
        public string ProcessStrategyUuid { get; set; }

        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        [NameInMap("YunCode")]
        [Validation(Required=false)]
        public string YunCode { get; set; }

    }

}
