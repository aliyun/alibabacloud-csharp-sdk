// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class UpdateRangeShrinkRequest : TeaModel {
        [NameInMap("BackgroundColors")]
        [Validation(Required=false)]
        public string BackgroundColorsShrink { get; set; }

        [NameInMap("Hyperlinks")]
        [Validation(Required=false)]
        public string HyperlinksShrink { get; set; }

        [NameInMap("NumberFormat")]
        [Validation(Required=false)]
        public string NumberFormat { get; set; }

        [NameInMap("RangeAddress")]
        [Validation(Required=false)]
        public string RangeAddress { get; set; }

        [NameInMap("SheetId")]
        [Validation(Required=false)]
        public string SheetId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

        [NameInMap("Values")]
        [Validation(Required=false)]
        public string ValuesShrink { get; set; }

        [NameInMap("WorkbookId")]
        [Validation(Required=false)]
        public string WorkbookId { get; set; }

    }

}
