// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class MultimodalSearchOutput : TeaModel {
        [NameInMap("imageItems")]
        [Validation(Required=false)]
        public List<UnifiedImageItem> ImageItems { get; set; }

        [NameInMap("queryContext")]
        [Validation(Required=false)]
        public MultimodalQueryContext QueryContext { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("searchInformation")]
        [Validation(Required=false)]
        public SearchInformation SearchInformation { get; set; }

    }

}
