// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class IllustrationTaskCreateCmd : TeaModel {
        [NameInMap("backgroundType")]
        [Validation(Required=false)]
        public int? BackgroundType { get; set; }

        [NameInMap("dstHeight")]
        [Validation(Required=false)]
        public int? DstHeight { get; set; }

        [NameInMap("dstWidth")]
        [Validation(Required=false)]
        public int? DstWidth { get; set; }

        [NameInMap("idempotentId")]
        [Validation(Required=false)]
        public string IdempotentId { get; set; }

        [NameInMap("nums")]
        [Validation(Required=false)]
        public int? Nums { get; set; }

        [NameInMap("ossPaths")]
        [Validation(Required=false)]
        public List<string> OssPaths { get; set; }

        [NameInMap("stickerText")]
        [Validation(Required=false)]
        public string StickerText { get; set; }

    }

}
