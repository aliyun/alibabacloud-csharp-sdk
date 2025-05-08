// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class UnifiedSearchResponse : TeaModel {
        [NameInMap("costCredits")]
        [Validation(Required=false)]
        public UnifiedCostCredits CostCredits { get; set; }

        [NameInMap("pageItems")]
        [Validation(Required=false)]
        public List<UnifiedPageItem> PageItems { get; set; }

        [NameInMap("queryContext")]
        [Validation(Required=false)]
        public UnifiedQueryContext QueryContext { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("sceneItems")]
        [Validation(Required=false)]
        public List<UnifiedSceneItem> SceneItems { get; set; }

        [NameInMap("searchInformation")]
        [Validation(Required=false)]
        public UnifiedSearchInformation SearchInformation { get; set; }

    }

}
