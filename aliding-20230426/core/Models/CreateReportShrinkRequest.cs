// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateReportShrinkRequest : TeaModel {
        [NameInMap("Contents")]
        [Validation(Required=false)]
        public string ContentsShrink { get; set; }

        [NameInMap("DdFrom")]
        [Validation(Required=false)]
        public string DdFrom { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

        [NameInMap("ToChat")]
        [Validation(Required=false)]
        public bool? ToChat { get; set; }

        [NameInMap("ToCids")]
        [Validation(Required=false)]
        public string ToCidsShrink { get; set; }

        [NameInMap("ToUserids")]
        [Validation(Required=false)]
        public string ToUseridsShrink { get; set; }

    }

}
