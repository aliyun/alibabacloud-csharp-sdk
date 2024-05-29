// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class ListTextsRequest : TeaModel {
        [NameInMap("generationSource")]
        [Validation(Required=false)]
        public string GenerationSource { get; set; }

        [NameInMap("industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("publishStatus")]
        [Validation(Required=false)]
        public string PublishStatus { get; set; }

        [NameInMap("textStyleType")]
        [Validation(Required=false)]
        public string TextStyleType { get; set; }

        [NameInMap("textTheme")]
        [Validation(Required=false)]
        public string TextTheme { get; set; }

    }

}
