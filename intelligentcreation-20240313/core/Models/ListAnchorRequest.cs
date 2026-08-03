// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class ListAnchorRequest : TeaModel {
        [NameInMap("anchorCategory")]
        [Validation(Required=false)]
        public string AnchorCategory { get; set; }

        [NameInMap("anchorId")]
        [Validation(Required=false)]
        public string AnchorId { get; set; }

        [NameInMap("anchorType")]
        [Validation(Required=false)]
        public string AnchorType { get; set; }

        [NameInMap("coverRate")]
        [Validation(Required=false)]
        public string CoverRate { get; set; }

        [NameInMap("digitalHumanType")]
        [Validation(Required=false)]
        public string DigitalHumanType { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("resSpecType")]
        [Validation(Required=false)]
        public string ResSpecType { get; set; }

        [NameInMap("useScene")]
        [Validation(Required=false)]
        public string UseScene { get; set; }

    }

}
