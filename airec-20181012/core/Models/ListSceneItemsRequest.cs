// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20181012.Models
{
    public class ListSceneItemsRequest : TeaModel {
        [NameInMap("OperationRuleId")]
        [Validation(Required=false)]
        public string OperationRuleId { get; set; }

        [NameInMap("SelectionRuleId")]
        [Validation(Required=false)]
        public string SelectionRuleId { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        [NameInMap("PreviewType")]
        [Validation(Required=false)]
        public string PreviewType { get; set; }

        [NameInMap("QueryCount")]
        [Validation(Required=false)]
        public int? QueryCount { get; set; }

    }

}
