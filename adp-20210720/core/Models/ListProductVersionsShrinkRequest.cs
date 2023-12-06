// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ListProductVersionsShrinkRequest : TeaModel {
        [NameInMap("fuzzy")]
        [Validation(Required=false)]
        public string Fuzzy { get; set; }

        [NameInMap("pageNum")]
        [Validation(Required=false)]
        public string PageNum { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("platforms")]
        [Validation(Required=false)]
        public string PlatformsShrink { get; set; }

        [NameInMap("productName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        [NameInMap("productUID")]
        [Validation(Required=false)]
        public string ProductUID { get; set; }

        [NameInMap("released")]
        [Validation(Required=false)]
        public bool? Released { get; set; }

        [NameInMap("supportedFoundationTypes")]
        [Validation(Required=false)]
        public string SupportedFoundationTypesShrink { get; set; }

        [NameInMap("tag")]
        [Validation(Required=false)]
        public string TagShrink { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
