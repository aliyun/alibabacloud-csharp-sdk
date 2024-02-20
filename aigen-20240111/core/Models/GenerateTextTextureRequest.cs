// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aigen20240111.Models
{
    public class GenerateTextTextureRequest : TeaModel {
        [NameInMap("AlphaChannel")]
        [Validation(Required=false)]
        public bool? AlphaChannel { get; set; }

        [NameInMap("FontName")]
        [Validation(Required=false)]
        public string FontName { get; set; }

        [NameInMap("ImageShortSize")]
        [Validation(Required=false)]
        public long? ImageShortSize { get; set; }

        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("N")]
        [Validation(Required=false)]
        public long? N { get; set; }

        [NameInMap("OutputImageRatio")]
        [Validation(Required=false)]
        public string OutputImageRatio { get; set; }

        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        [NameInMap("TextContent")]
        [Validation(Required=false)]
        public string TextContent { get; set; }

        [NameInMap("TextureStyle")]
        [Validation(Required=false)]
        public string TextureStyle { get; set; }

        [NameInMap("TtfUrl")]
        [Validation(Required=false)]
        public string TtfUrl { get; set; }

    }

}
