// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class SearchOmsOpenAPIProjectsShrinkRequest : TeaModel {
        [NameInMap("DestDbTypes")]
        [Validation(Required=false)]
        public string DestDbTypesShrink { get; set; }

        [NameInMap("LabelIds")]
        [Validation(Required=false)]
        public string LabelIdsShrink { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        [NameInMap("SourceDbTypes")]
        [Validation(Required=false)]
        public string SourceDbTypesShrink { get; set; }

        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public string StatusListShrink { get; set; }

        [NameInMap("WorkerGradeId")]
        [Validation(Required=false)]
        public string WorkerGradeId { get; set; }

    }

}
