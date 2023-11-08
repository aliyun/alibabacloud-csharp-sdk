// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class BatchRemovalByFormInstanceIdListShrinkRequest : TeaModel {
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        [NameInMap("AsynchronousExecution")]
        [Validation(Required=false)]
        public bool? AsynchronousExecution { get; set; }

        [NameInMap("ExecuteExpression")]
        [Validation(Required=false)]
        public bool? ExecuteExpression { get; set; }

        [NameInMap("FormInstanceIdList")]
        [Validation(Required=false)]
        public string FormInstanceIdListShrink { get; set; }

        [NameInMap("FormUuid")]
        [Validation(Required=false)]
        public string FormUuid { get; set; }

        [NameInMap("SystemToken")]
        [Validation(Required=false)]
        public string SystemToken { get; set; }

    }

}
