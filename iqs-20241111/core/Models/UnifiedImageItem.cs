// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class UnifiedImageItem : TeaModel {
        [NameInMap("height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        [NameInMap("hostPageUrl")]
        [Validation(Required=false)]
        public string HostPageUrl { get; set; }

        [NameInMap("imageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("publishedTime")]
        [Validation(Required=false)]
        public string PublishedTime { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

    }

}
