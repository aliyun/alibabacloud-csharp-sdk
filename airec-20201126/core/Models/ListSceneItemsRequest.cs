// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ListSceneItemsRequest : TeaModel {
        [NameInMap("operationRuleId")]
        [Validation(Required=false)]
        public string OperationRuleId { get; set; }

        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("previewType")]
        [Validation(Required=false)]
        public string PreviewType { get; set; }

        [NameInMap("queryCount")]
        [Validation(Required=false)]
        public int? QueryCount { get; set; }

        [NameInMap("selectionRuleId")]
        [Validation(Required=false)]
        public string SelectionRuleId { get; set; }

        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
